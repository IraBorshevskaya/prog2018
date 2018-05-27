using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SushiDelivery;


namespace SushiDelivery.LicenceGenerator
{
    class Program
    {
        private static void GenerateNewKeyPair()

        {

            string withSecret;
            string woSecret;
            using (var rsaCsp = new RSACryptoServiceProvider())

            {

                withSecret = rsaCsp.ToXmlString(true);
                woSecret = rsaCsp.ToXmlString(false);

            }



            File.WriteAllText("private.xml", withSecret);
            File.WriteAllText("public.xml", woSecret);
            //
            Console.WriteLine(withSecret);
            Console.WriteLine();
            Console.WriteLine(woSecret);
            //
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            if (args.Any(a => a == "--generate"))
            {
                GenerateNewKeyPair();
            }

            var dto = new LicenceDto()
            {
                ValidUntil = DateTime.Now.AddDays(7)
            };

            var fileName = string.Join("", DateTime.Now.ToString().Where(c => char.IsDigit(c)));
            new LicenceGenerator().CreateLicenseFile(dto, fileName + ".gh_licence");
        }
    }

    class LicenceGenerator
    {
        private static string PrivateKey = @"<RSAKeyValue>
<Modulus>vi6smTFPxDTyU4qDlgXzlipDBYbe+qTsgyyTIlip6GQylgdrbyaO9W/PSKkh7CY0LlUTX7+2hq8z038gR4HL06iss7BywYQFynCpIGnWVAdKH7DIF2f8CBxhugNHIxZ7F31lXKs2zCh+/qbR9ODihxr48NiJT9rbgQjWCZW2t5E=</Modulus>
<Exponent>AQAB</Exponent>
<P>3KvhOJASGWXOS/L4q+auJa2i6dLYPmHZ44Inj5v8wnEwWHM4YX3gF0HFKhpGMGvTg+Do0UOSwXCjW/kAOjOZnw==</P>
<Q>3KE2eEjqD9N4wGj2dRzs3ZcJqKHnCKqatxDMk4NzGm6njP3JOZNAC2y5YOSVzEXKKAy7Gu0jtOoYOiiwlBKAzw==</Q>
<DP>h5POjxrtE8+ZvM3t/GeBLUMOKczR8Rnbbc1EkxYKaEh0pJM926AjswZEpcZ4wz0sOgVP5Wo320NiCprkid20Dw==</DP>
<DQ>1iLCM0zRoDqn4Ff/nPtOCmQlw74f9pFfSH7Nj/7tIKJ1jKplO7RnXK9R3XD+0xyJcQWqNCAln9n1Wb1UZOLwkQ==</DQ>
<InverseQ>1xKYLTYF25RDcfynBUoTdY7cqz1uIyw/QCDSlpNTyXhGkWZCA+19x9d8vXwCDauyOkRX2KuHw0mDnyS5sna6VQ==</InverseQ>
<D>HI4FfDrbLyqD9+ckOrJKEJHn3jyR3jBFEqzuqomFeU8SCVSz3Mx9SnyvMsmyPjK+QvajIg026qIDtg2wWwwx/iNix5lpDSjE7DVzIaM9gGoKJ262NNU9I3iqAyvUyiQsGzBFkCasgVeeJp4G5AXfEi2KFNKnuuBMNVkzmuDXF8E=</D>
</RSAKeyValue>

";
        public void CreateLicenseFile(LicenceDto dto, string fileName)

        {

            var ms = new MemoryStream();

            new XmlSerializer(typeof(LicenceDto)).Serialize(ms, dto);



            // Create a new CspParameters object to specify

            // a key container.



            // Create a new RSA signing key and save it in the container.

            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();

            rsaKey.FromXmlString(PrivateKey);



            // Create a new XML document.

            XmlDocument xmlDoc = new XmlDocument();



            // Load an XML file into the XmlDocument object.

            xmlDoc.PreserveWhitespace = true;

            ms.Seek(0, SeekOrigin.Begin);

            xmlDoc.Load(ms);



            // Sign the XML document.

            SignXml(xmlDoc, rsaKey);



            // Save the document.

            xmlDoc.Save(fileName);



        }



        // Sign an XML file.

        // This document cannot be verified unless the verifying

        // code has the key with which it was signed.

        public static void SignXml(XmlDocument xmlDoc, RSA Key)

        {

            // Check arguments.

            if (xmlDoc == null)

                throw new ArgumentException("xmlDoc");

            if (Key == null)

                throw new ArgumentException("Key");



            // Create a SignedXml object.

            SignedXml signedXml = new SignedXml(xmlDoc);



            // Add the key to the SignedXml document.

            signedXml.SigningKey = Key;



            // Create a reference to be signed.

            Reference reference = new Reference();

            reference.Uri = "";



            // Add an enveloped transformation to the reference.

            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();

            reference.AddTransform(env);



            // Add the reference to the SignedXml object.

            signedXml.AddReference(reference);



            // Compute the signature.

            signedXml.ComputeSignature();



            // Get the XML representation of the signature and save

            // it to an XmlElement object.

            XmlElement xmlDigitalSignature = signedXml.GetXml();



            // Append the element to the XML document.

            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));



        }
    }
}

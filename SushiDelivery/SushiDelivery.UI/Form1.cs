using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace SushiDelivery.UI
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        
        
        public Form1()
        {
            InitializeComponent();
            Sushi.DataSource = Enum.GetValues(typeof(NameSushi));
            addition.DataSource = Enum.GetValues(typeof(Addition));
            drink.DataSource = Enum.GetValues(typeof(NameDrinks));
        }

        OrderInformation GetModelFromUI()
        {
            return new OrderInformation
            {
                FullName = FullName.Text,
                Address = address.Text,
                Filled = dateTimePicker1.Value,
                Price = Priсe.Value,
                NumberСutlery = (int)numericUpDown3.Value,
                Orders = orders,

            };
        }
        private void SetModelToUI(OrderInformation dto)
        {
            FullName.Text = dto.FullName;
            address.Text = dto.Address;
            dateTimePicker1.Value = dto.Filled;
            Priсe.Value = dto.Price;
            numericUpDown3.Value = (decimal)dto.NumberСutlery;
            orders = dto.Orders;
            for (int i = 0; i < orders.Count; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["Column1"].Value = orders[i].Sushi.NameSushi;
                dataGridView1.Rows[i].Cells["Column2"].Value = orders[i].Sushi.NumberSushi;
                dataGridView1.Rows[i].Cells["Column3"].Value = orders[i].Sushi.Addition;
                dataGridView1.Rows[i].Cells["Column4"].Value = orders[i].Sushi.NumberAddition;
                dataGridView1.Rows[i].Cells["Column5"].Value = orders[i].Drinks.NameDrinks;
                dataGridView1.Rows[i].Cells["Column6"].Value = orders[i].Drinks.NumberDrinks;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Файлы заказов|*.sushi" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();             
                OrderDto.WriteToFile(sfd.FileName, dto);
            }
        }
        

        private void button_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells["Column1"].Value = Sushi.SelectedValue;
            dataGridView1.Rows[rowNumber].Cells["Column2"].Value = NumberSushi.Value;
            dataGridView1.Rows[rowNumber].Cells["Column3"].Value = addition.SelectedValue;
            dataGridView1.Rows[rowNumber].Cells["Column4"].Value = NumberAddition.Value;
            dataGridView1.Rows[rowNumber].Cells["Column5"].Value = drink.SelectedValue;
            dataGridView1.Rows[rowNumber].Cells["Column6"].Value = NumerDrink.Value;

            Order tempOrder = new Order { Drinks = new Drinks(), Sushi = new Sushi() };
            tempOrder.Sushi.NameSushi = (SushiDelivery.NameSushi)Sushi.SelectedValue;
            tempOrder.Sushi.NumberSushi = (int)NumberSushi.Value;
            tempOrder.Sushi.Addition = (SushiDelivery.Addition)addition.SelectedValue;
            tempOrder.Sushi.NumberAddition = (int)NumberAddition.Value;
            tempOrder.Drinks.NumberDrinks = (int)NumerDrink.Value;
            tempOrder.Drinks.NameDrinks = (SushiDelivery.NameDrinks)drink.SelectedValue;
            
            orders.Add(tempOrder);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void Open_Click_1(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл заказа|*.sushi" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = OrderDto.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }
        private void Sushi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }        
    }
}

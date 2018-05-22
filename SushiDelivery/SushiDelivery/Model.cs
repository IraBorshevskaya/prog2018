using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SushiDelivery
{
     public class Model
     {
         static void Main()
         { }
     }
    /// <summary>
    /// Информация о заказе
    /// </summary>
    public class OrderInformation
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>
        /// Заказ
        /// </summary>
        public List<Order> Orders { get; set; }
        /// <summary>
        /// ФИО заказчика
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        /// <summary>
        ///Количество столовых приборов
        /// </summary>
        public int NumberСutlery { get; set; }

    }
    public class Order
    {
        public Sushi Sushi { get; set; }
        public Drinks Drinks { get; set; }
    }
    public class Sushi
    {
        /// <summary>
        /// Вид суши
        /// </summary>
        public NameSushi NameSushi { get; set; }
        /// <summary>
        /// Дополнение к суши
        /// </summary>
        public Addition Addition { get; set; }      
        /// <summary>
        ///Количество суши
        /// </summary>
        public double NumberSushi { get; set; }
        public double NumberAddition { get; set; }
    }

    public class Drinks
    {
        /// <summary>
        /// Напитки
        /// </summary>
        public NameDrinks NameDrinks { get; set; }
        /// <summary>
        ///Количество напитков
        /// </summary>
        public double NumberDrinks { get; set; }
    }
    /// <summary>
    /// Названия суши
    /// </summary>
    public enum NameSushi
    {
        Philadelphia,
        Tortilla,
        Cheese,
        Greek,
        Bonito,
        California
    }
    /// <summary>
    /// Дополнение к суши
    /// </summary>
    public enum Addition
    {
        SoySauce,
        Ginger,
        Wasabi
    }
    /// <summary>
    /// Название напитков
    /// </summary>
    public enum NameDrinks
    {
        Morse,
        CocaCola,
        Sprite,
        Fanta,
        Juice
    }
    public enum Currency
    {
        Rubles
    }
}

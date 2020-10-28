using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    /// <summary>
    /// Жилая площадь, которая сдаётся в аренду.
    /// </summary>
    class Houseroom
    {
        public uint Id;         // идентификатор квартиры
        public string City;     // город, в котором расположена кв
        public string Street;   // улица
        public string Description; // описание
        public decimal Price;    // стоимость квартиры в месяц
        //public uint NumberOfRooms; // количество комнат
        //public string Type; // тип, квартира или дом

        public Houseroom()
        {
            Id = 0;
            City = Street = Description = "";
            Price = 0.0M;
            //NumberOfRooms = 0;
        }

        public Houseroom(uint id, string city, string street, decimal price, string description /*uint numberOfRooms*/)
        {
            Id = id;
            City = city;
            Street = street;
            Price = price;
            Description = description;
            //NumberOfRooms = numberOfRooms;
        }
    }
}

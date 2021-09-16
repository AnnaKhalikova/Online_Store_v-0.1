using System;
using System.Collections.Generic;

namespace Online_Store_v_0._1
{
    public class Online_Store
    {
        // [Required] // Атрибут (Почитать!!!)
        public string Name;
        public string TimeWorking;
        public string PhoneNumber;
        public AdresOnlineStore AdresStore;
        public List<Phone> ListOfPhones;

        public Online_Store()
        {
        }

        public Online_Store(string _Name, string _TimeWorking, string _PhoneNumber,
            AdresOnlineStore _AdresStore, List<Phone> _ListOfPhones)
        {
            Name = _Name;
            TimeWorking = _TimeWorking;
            PhoneNumber = _PhoneNumber;
            AdresStore = _AdresStore;
            ListOfPhones = _ListOfPhones;
        }

        public void Online_StoreDisplayInfo()
        {
            Console.WriteLine("Название магазина: \n\t" + Name +
                "/ Режим работы: " + TimeWorking +
                "/ Телефон: " + PhoneNumber);
        }

        public void AdresOnlineStoreDisplayInfo()
        {
            Console.WriteLine("Адрес магазина: \n\t" + "Страна: " +
                AdresStore.Country + "/ Город: " + AdresStore.City + "/ Улица: " +
                AdresStore.Street + "/ Почтовый адрес: " + AdresStore.PostalCode);
        }

        public void PhoneDisplayInfo(Phone phone) // Для одного телефона
        {
            Console.WriteLine($"Модель телефона: " + phone.Model +
                " / Память : " + phone.PhoneMemory + " ГБ" +
                " / Цвет: " + phone.Color +
                " / Артикул: " + phone.PhoneVendorCode +
                " / Цена: " + phone.Price + " BYN");
        }

        public void DisplayInfoAboutAllPhones() // Для всех телефонов
        {
            foreach (Phone phone in ListOfPhones)
            {
                PhoneDisplayInfo(phone);
            }
        }
    }
}

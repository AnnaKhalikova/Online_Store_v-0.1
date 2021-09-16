using System;
using System.Collections;

namespace Online_Store_v_0._1
{
    public class Buyer
    {
        public string BuyerName;
        public string BuyerPhoneNumber;
        public bool СardCurrency;
        public ArrayList BuyerСart;

        public Buyer()
        {
        }

        public Buyer(string _BuyerName, string _BuyerPhoneNumber, bool _СardCurrency, ArrayList _BuyerСart)
        {
            BuyerName = _BuyerName;
            BuyerPhoneNumber = _BuyerPhoneNumber;
            СardCurrency = _СardCurrency;
            BuyerСart = _BuyerСart;
        }

        public void BuyerDisplayInfo()
        {
            Console.WriteLine($"Имя покупателя: {BuyerName} \nНомер телефона: {BuyerPhoneNumber}");
        }

        // информация о одном товаре в корзине
        public void BuyerСartDisplayInfo()
        {
            Console.WriteLine("Корзина покупателя: ");
            Console.WriteLine(((Phone)BuyerСart[0]).ToString());
        }

        // информация о всех товарах в корзине
        public void DisplayInfoAboutAllBuyerCart()
        {
            Console.WriteLine("Корзина покупателя: ");

            foreach (Phone phone in BuyerСart)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}


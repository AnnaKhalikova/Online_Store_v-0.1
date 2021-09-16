using System;

namespace Online_Store_v_0._1
{
    public class Phone
    {
        public PhoneModel Model;
        public int PhoneMemory;
        public PhoneСolor Color;
        public string PhoneVendorCode;
        public double Price;

        public Phone()
        {
        }

        public Phone(PhoneModel _Model, int _PhoneMemory, PhoneСolor _Color, string _PhoneVendorCode, double _Price)
        {
            Model = _Model;
            PhoneMemory = _PhoneMemory;
            Color = _Color;
            PhoneVendorCode = _PhoneVendorCode;
            Price = _Price;
        }

        public override string ToString()
        {
            return "Модель телефона: " + Model +
                " / Память : " + PhoneMemory + " ГБ" +
                " / Цвет: " + Color +
                " / Артикул: " + PhoneVendorCode +
                " / Цена: " + Price + " BYN";
        }
    }
}

using System;
namespace Online_Store_v_0._1
{
    public class IPhone_12_mini : Phone
    {
        public IPhone_12_mini()
        {
        }

        public IPhone_12_mini(PhoneModel _Model, int _PhoneMemory, PhoneСolor _Color, string _PhoneVendorCode, double _Price)
            : base(_Model, _PhoneMemory, _Color, _PhoneVendorCode, _Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

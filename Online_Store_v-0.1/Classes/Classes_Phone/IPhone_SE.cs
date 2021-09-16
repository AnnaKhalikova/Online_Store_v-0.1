using System;
namespace Online_Store_v_0._1
{
    public class IPhone_SE : Phone
    {
        public IPhone_SE()
        {
        }

        public IPhone_SE(PhoneModel _Model, int _PhoneMemory, PhoneСolor _Color, string _PhoneVendorCode, double _Price)
            : base(_Model, _PhoneMemory, _Color, _PhoneVendorCode, _Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

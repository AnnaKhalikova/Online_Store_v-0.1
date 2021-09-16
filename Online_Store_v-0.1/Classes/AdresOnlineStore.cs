using System;
namespace Online_Store_v_0._1
{
    public class AdresOnlineStore
    {
        public string Country;
        public string City;
        public string Street;
        public string PostalCode;

        public AdresOnlineStore()
        {
        }

        public AdresOnlineStore(string _Country, string _City, string _Street, string _PostalCode)
        {
            Country = _Country;
            City = _City;
            Street = _Street;
            PostalCode = _PostalCode;
        }
    }
}

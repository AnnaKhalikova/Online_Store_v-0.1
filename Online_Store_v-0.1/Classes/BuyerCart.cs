using System;
using System.Collections;

namespace Online_Store_v_0._1
{
    public class BuyerСart
    {
        public ArrayList buyerCart;

        public BuyerСart()
        {
        }

        public BuyerСart(ArrayList _buyerCart)
        {
            buyerCart = _buyerCart;
        }

        public void BuyerCartDisplayInfo()
        {
            Console.WriteLine("Корзина покупателя: " + buyerCart);
        }
    }
}

using System;
using System.Collections.Generic;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class OrderFixed // this could be an abstract class to be overriden by other order type class
    {
        public int OrderId { get; set; }

        public Basket Basket { get; set; }

        public OrderFixed(Basket basket)
        {
            Basket = basket;
        }

        public void ProcessOrder(Basket basket)
        {
            throw new NotImplementedException();
        }
    }

    public class Basket
    {
        public IEnumerable<int> Products { get; set; }
        public int BasketTotal { get; set; }
    }
}

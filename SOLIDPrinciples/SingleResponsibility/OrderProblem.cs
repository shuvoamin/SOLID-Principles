using System;
using System.Collections.Generic;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class OrderProblem
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public IEnumerable<int> Products { get; set; }
        public int CreditCardId { get; set; }

        public void ChargeCard()
        {
            throw new NotImplementedException();
        }

        public void ProcessOrder()
        {
            throw new NotImplementedException();
        }

        public void CheckStock()
        {
            throw new NotImplementedException();
        }
    }
}

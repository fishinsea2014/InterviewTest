using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    public class Redemption
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public string RedeemCode { get; set; }
        public int ConsumerId { get; set; }
        public int OfferId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    public class Offer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CouponId { get; set; }
        public virtual ICollection<Redemption> Redemptions { get; set; }

    }
}

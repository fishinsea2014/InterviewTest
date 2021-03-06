﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxNumberPerUser { get; set; }
        public int MaxNumberAll { get; set; }
        public int Status { get; set; } //"active" or "inactive"


        public virtual ICollection<Redemption> Redemptions { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Solution
{
    public class Consumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Redemption lists
        public virtual ICollection<Redemption> Redemptions { get; set; }



    }
}

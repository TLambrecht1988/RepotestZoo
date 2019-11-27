using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Lib
{
    public class Zoo
    {
        public decimal EntranceFee { get; set; } = 50.0M;
        public LionCage lionCage { get; set; }

        public Zoo (decimal entrancefee)
        {
            EntranceFee = entrancefee;

        }



    }
}

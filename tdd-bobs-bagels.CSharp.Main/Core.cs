﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> Bagels { get; set; } = new List<string>();
        public int BagelsMax { get; set; } = 5;
        public bool FullBasket
        {
            get
            {
                return this.BagelsMax >= this.Bagels.Count ? true : false;
            }
        }

        public void AddBagel(string bagel)
        {
            this.Bagels.Add(bagel);
        }

        public void ChangeBasketCapacity(int newCapacity)
        {
            this.BagelsMax = newCapacity;
        }

        public bool RemoveFromBasket(string bagel)
        {
            return this.Bagels.Remove(bagel);
        }
    }


}

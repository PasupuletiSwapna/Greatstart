﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittestEX.cs
{
   /// <summary>
   /// products
   /// </summary>
    public class product
    {
        private string prname;

        public string Prname
        {
            get { return prname; }
            set { prname = value; }
        }

        private string desc;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private int prodid;

        public int ProdId
        {
            get { return prodid; }
            set { prodid = value; }
        }
        public string Sayhello()

       {
            return "Hello"  + Prname + "(" + ProdId + "):" + desc;

        }

    }
}

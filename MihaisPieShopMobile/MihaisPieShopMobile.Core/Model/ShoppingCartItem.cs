﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MihaisPieShopMobile.Core.Model
{
    public class ShoppingCartItem
    {
        public Pie Pie
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy
{
    internal interface IOrderable
    {
        public void PlacingOrder();
        public void ProcessingPayment();
        public void DeliveringProduct();

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Persistence.MongoDB.Tests.Model
{
    public class OutgoingInvoice : Invoice
    {
        public string CustomerName { get; set; }
    }
}
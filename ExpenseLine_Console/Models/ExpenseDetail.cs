﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseLine_Console.Models
{
    public class ExpenseDetail
    {
        public int Id { get; set; }
        public GLAccount Account { get; set; }
        public Department Department { get; set; }
        [Precision(18, 2)]
        public Decimal Hst {  get; set; }
        [Precision(18, 2)]
        public Decimal Amount { get; set; }
    }
}

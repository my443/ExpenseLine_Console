﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseLine_Console.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalHst { get; set; }
        public Vendor Vendor { get; set; }
        public Employee SubmittedBy { get; set; }
        public List<Approval> Approvals { get; set; } = new List<Approval>();
        public List<Note> Notes { get; set; } = new List<Note>();
        public List<ExpenseDetail> ExpenseDetails { get; set; } = new List<ExpenseDetail>();
        public List<Image> Images { get; set; } = new List<Image>();
        public ExpenseStatus ExpenseStatus { get; set; }
    }
}
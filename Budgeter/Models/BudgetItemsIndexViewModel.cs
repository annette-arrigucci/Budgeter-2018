﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgeter.Models
{
    public class BudgetItemsIndexViewModel
    {
        public List<BudgetItemViewModel> ExpenseItems { get; set; }
        public List<BudgetItemViewModel> IncomeItems { get; set; }
    }
}
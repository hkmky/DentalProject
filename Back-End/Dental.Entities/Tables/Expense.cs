using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Enums;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class Expense : EntityBase
    {
        public ExpensesType ExpensesType { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
    }
}

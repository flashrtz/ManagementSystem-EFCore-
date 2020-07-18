using System;
using System.Collections.Generic;
using System.Text;

namespace Empit.Core.Models
{
    public class ReportModel
    {

        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}

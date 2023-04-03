using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilldownFunctions.Data.Models
{
    public class NationalIncome
    {
        public string year_month { get; set; }
        public ushort age { get; set; }
        public string gender { get; set; }
        public string location { get; set; }
        public string occupation { get; set; }
        public uint income { get; set; }
    }
}

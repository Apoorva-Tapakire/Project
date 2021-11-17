using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalLibrary
{
    
        public class PaymentBAL
        {

            public string BankName { get; set; }
            public string IFSC { get; set; }
            public string UPI { get; set; }
            public long CardNos { get; set; }
            public long CVV { get; set; }
        }
    }


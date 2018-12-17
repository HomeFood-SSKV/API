using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.ComplexModel
{
    
    public class SupportedPayment
    {
        public string PaymentID { get; set; }
        public string PaymentName { get; set; }
    }

    public class PaymentSelectionResponse
    {
        public List<SupportedPayment> supportedPayment { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo.Models
{
    internal class DeliveryProof
    {
        private string signatureFilePath = "";
        private string packagesPictureFilePath = "";
        private string customerId = "";

        public string SignatureFilePath { get; set; }
        public string PackagesPictureFilePath { get; set; }
        public string CustomerId { get; set; }
    }
}

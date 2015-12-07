using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class MyCustomErrorDetail
    {

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string ErrorInfo { get; set; }

        [DataMember]
        public string ErrorDetails { get; set; }
    }
}

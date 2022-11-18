using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Akopyants
{
    public class My_attribute : Attribute
    {
        public My_attribute(string message) => Comment = message;
        public string Comment { get; set; }
    }
}

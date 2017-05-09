using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Class2 : Class1
    {
        private string _e;
        public string E
        {
            get { return _e; }
            set { this._e = value; }
        }

        public Class2(string a, int b, string e):base(a,b)
        {
            this.E = e;
        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());
            Bloque.AppendLine("DNI: " + this.E);
            return Bloque.ToString();
        }


    }
}

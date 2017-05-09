using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Class3 : Class1
    {
        private string _f;
        public string F
        {
            set { this._f = value;  }
            get { return this._f; }
        }

        public Class3(string a, int b, string f):base(a,b)
        {
            this.F = f;
        }
        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());
            Bloque.AppendLine("DNI: " + this.F);
            return Bloque.ToString();
        }
    }
}

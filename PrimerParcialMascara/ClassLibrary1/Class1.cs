using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Class1
    {
        private string _a;
        public string A
        {
            get { return _a; }
            set { this._a = value; }
        }

        private int _b;
        public int B
        {
            get { return _b; }
            set { this._b = value; }
        }
        private string _c;
        public string C
        {
            get { return _c; }
            set { this._c = value; }
        }

        public Class1(string a, int b)
        {
            this.A = a;
            this._b = b;
        }

        public Class1(string a, int b, string c):this(a,b)
        {
            this._c = c;
        }


        public void Mostrar()
        {
            System.Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine("DNI: " + this.A);
            Bloque.AppendLine("Nombre: " + this.B);
            Bloque.AppendLine("Apellido: " + this.C);
            return Bloque.ToString();
        }
    }
}

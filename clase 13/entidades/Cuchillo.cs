using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Cuchillo : Item
    {
        public int durabilidad;

        public Cuchillo(int durabilidad,string nombre):base(nombre)
        {
            this.durabilidad = durabilidad;
        }

        public override string Usar()
        {
            this.durabilidad--;
            return $"Se utilizo el {base.nombre}";
        }
    }
}

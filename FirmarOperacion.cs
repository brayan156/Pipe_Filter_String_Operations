using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigacion5
{
    class FirmarOperacion: IStringOperacion
    {
        public string ejecutarOperacion(string mensaje)
        {
            return mensaje+ "\nBy TB Company";
        }
    }
}

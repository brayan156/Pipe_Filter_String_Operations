using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigacion5
{
    class Pipeline
    {
        private readonly List<IStringOperacion> operaciones = new List<IStringOperacion>();

        public Pipeline AgregarOperacion(IStringOperacion operation)
        {
            this.operaciones.Add(operation);
            return this;
        }

        public String RealizarPipeline(String mensaje)
        {
            return this.operaciones.Aggregate(mensaje, (current, operacion) => operacion.ejecutarOperacion(current));
        }
    }

}

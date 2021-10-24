using System;

namespace Investigacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pipeline pipeline1 = new Pipeline();
            pipeline1.AgregarOperacion(new UpperOperacion());
            pipeline1.AgregarOperacion(new FirmarOperacion());


            Pipeline pipeline2 = new Pipeline();
            pipeline2.AgregarOperacion(new FirmarOperacion());
            pipeline2.AgregarOperacion(new UpperOperacion());


            Pipeline pipeline3 = new Pipeline();
            pipeline3.AgregarOperacion(new UpperOperacion());

            Pipeline pipeline4 = new Pipeline();
            pipeline4.AgregarOperacion(new FirmarOperacion());


            Console.WriteLine("mensaje 1:");
            Console.WriteLine(pipeline1.RealizarPipeline("mensaje del pipeline 1"));
            Console.WriteLine("mensaje 2:");
            Console.WriteLine(pipeline2.RealizarPipeline("mensaje del pipeline 2"));
            Console.WriteLine("mensaje 3:");
            Console.WriteLine(pipeline3.RealizarPipeline("mensaje del pipeline 3"));
            Console.WriteLine("mensaje 4:");
            Console.WriteLine(pipeline4.RealizarPipeline("mensaje del pipeline 4"));

        }
    }
}

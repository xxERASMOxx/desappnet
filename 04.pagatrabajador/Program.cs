using System;

namespace _04.pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int horas ,horasextra;
            float paga,tasa=0.3f;
            float bruta=0, extra=0 ,impuesto=0, neta=0 ;
            
            Console.Clear();
            Console.WriteLine("programa que calcula la paga de un trabajador");

            Console.WriteLine("Nombre ");nombre=Console.ReadLine();
            Console.WriteLine("Horas ");horas=int.Parse(Console.ReadLine());
            Console.WriteLine("Paga ");paga=float.Parse(Console.ReadLine());

            horasextra=(horas>40 ? horas-40 :0);
            extra =horasextra * (paga * 2);
            bruta = (horas-horasextra) * paga + extra;
            impuesto = bruta * tasa;
            neta = bruta - impuesto;

            Console.WriteLine($"{nombre} trabajo {horas} a una paga {paga} ");
            Console.WriteLine($"Paga Bruta {bruta}");
             Console.WriteLine($"Impuesto {impuesto}");
              Console.WriteLine($"Paga Neta {neta}");
            
        }
    }
}

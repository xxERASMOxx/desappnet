using System;

namespace _07.tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, op2;

            menu();
            op = Int32.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("NUMERO DE LA TABLA DE MULTIPLICAR QUE DESEA VER ");
                op2 = Int32.Parse(Console.ReadLine());
                imprimirTabla(op2);
            }
            else if (op == 2)
            {
                Console.WriteLine("NUMERO DE LAS TABLAS DE MULTIPLICAR QUE DESEA VER ");
                op2 = Int32.Parse(Console.ReadLine());
                imprimirTablas(op2);
            }else{
                Console.WriteLine("OPCION INCORRECTA !");
            }
        }

        static void imprimirTablas(int numero){

            Console.WriteLine("TABLAS: ");
            for (int i = 1; i <= numero; i++)
            {
                
                imprimirTabla(i);
            }
        }

        static void imprimirTabla(int numero){

            Console.WriteLine("TABLA NUMERO: " + numero);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
            Console.WriteLine("\n");
        }

         static void menu()
        {
            Console.WriteLine("OPCIONES: ");
            Console.WriteLine("INGRESE '1' PARA IMPRIMIR SOLO UNA EN ESPECIFICO");
            Console.WriteLine("INGRESE '2' PARA IMPRIMIR HASTA EL NUMERO INGRESADOD");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CreandoHojaGuardado
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] Apellido=new string[5];
           string[] Nombre = new string[5];
           string[] Edad = new string[5];
           string path = @"C:\Users\Ariel\Desktop/Nombre.xls";
           for (int i = 0; i < 3; i++) 
           {
               Console.WriteLine("Ingrese un Apellido Porfavor"+" "+i);
               Apellido[i] = Console.ReadLine();



               Console.WriteLine("Ingrese un Nombre Porfavor" + " " + i);
               Nombre[i] = Console.ReadLine();

               Console.WriteLine("Ingrese un Edad Porfavor" + " " + i);
               Edad[i] = Console.ReadLine();

               if (File.Exists("Nombre.xls"))
               {
                   File.WriteAllText(@"C:\Users\Ariel\Desktop/Nombre.xls", Apellido[i]);
                   File.WriteAllText(@"C:\Users\Ariel\Desktop/Nombre.xls", Nombre[i]);
                   File.WriteAllText(@"C:\Users\Ariel\Desktop/Nombre.xls", Edad[i] + " \n");
                   Console.WriteLine(" \n");
               }

               else 
               {
                   File.AppendAllText(@"C:\Users\Ariel\Desktop/Nombre.xls", Apellido[i] + " \n");
                   File.AppendAllText(@"C:\Users\Ariel\Desktop/Nombre.xls", Nombre[i] + " \n");
                   File.AppendAllText(@"C:\Users\Ariel\Desktop/Nombre.xls", Edad[i]+" \n");

                   
               }



           }

        }
    }
}

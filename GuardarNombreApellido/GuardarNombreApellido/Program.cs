using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuardarNombreApellido
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombre = new string[3];
            string[] Apellido = new string[3];
            var NombreArchivo = "NombreApellido.xls";
            for (int i = 0; i <3;i++)
            {
                Console.WriteLine("Carga Un nombre al vector" + i);
                Nombre[i] = Console.ReadLine();

                Console.WriteLine("Carga Un Apellido al vector" + i);
                Apellido[i] = Console.ReadLine();

                if (!File.Exists(NombreArchivo))
                {
                    File.WriteAllText(NombreArchivo, Nombre[i] + " \n");
                    File.WriteAllText(NombreArchivo, Apellido[i] + "\n");
                }

                else 
                {
                    File.AppendAllText(NombreArchivo, Nombre[i] + " \n");
                    File.AppendAllText(NombreArchivo, Apellido[i] + " \n");
                }

                
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExpecificaBorrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la ruta del archivo o carpeta que desea eliminar:");
            string ruta = Console.ReadLine();

            if (File.Exists(ruta))
            {
                File.Delete(ruta);
                Console.WriteLine("Archivo eliminado exitosamente.");
            }
            else if (Directory.Exists(ruta))
            {
                Directory.Delete(ruta, true);
              
                Console.WriteLine("Carpeta eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("La ruta especificada no existe o es incorrecta.");
            }

            Console.ReadKey();
        }
    }
}

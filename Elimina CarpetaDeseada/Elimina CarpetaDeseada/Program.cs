using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Elimina_CarpetaDeseada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indica la ruta de la carpeta que deseas eliminar

            string rutaCarpeta = @"C:\Users\Ariel\Desktop/eze";
            
            Console.WriteLine(" La carpeta que se borrara es "+rutaCarpeta);

           

            Console.WriteLine("Deseas realmente borrar esa carpeta s para si");
            char s=char.Parse(Console.ReadLine());

            if (s == 's')
            {
                // Elimina la carpeta y su contenido
                Directory.Delete(rutaCarpeta);

                Console.WriteLine("La carpeta ha sido eliminada.");
            }

            else 
            {
                Console.WriteLine("La carpeta no se borrara");
            }

            
            Console.ReadKey();
        }
       
    }
}

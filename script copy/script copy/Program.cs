using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace script_copy
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            // Ruta de la carpeta del escritorio
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            // Ruta de la carpeta destino en la unidad USB
            string destPath = @"D:\";
           

            // Obtener las carpetas del escritorio
            DirectoryInfo desktopDir = new DirectoryInfo(desktopPath);
            DirectoryInfo[] folders = desktopDir.GetDirectories();

            // Copiar las carpetas encontradas a la carpeta destino
            foreach (DirectoryInfo folder in folders)
            {
                string destFolder = Path.Combine(destPath, folder.Name); // Combinar las rutas de la carpeta destino y la carpeta actual del escritorio
                CopyDirectory(folder.FullName, destFolder); // Llamar a la función CopyDirectory para copiar la carpeta actual
            }

            Console.WriteLine("Carpetas copiadas con éxito a la unidad USB."); // Mostrar mensaje de éxito en la consola
            Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
        }

        static void CopyDirectory(string sourceDir, string destDir)
        {
            // Obtener la información de la carpeta origen
            DirectoryInfo sourceInfo = new DirectoryInfo(sourceDir);

            // Crear la carpeta destino
            Directory.CreateDirectory(destDir);

            // Copiar los archivos de la carpeta origen a la carpeta destino
            foreach (FileInfo file in sourceInfo.GetFiles())
            {
                string tempPath = Path.Combine(destDir, file.Name); // Combinar las rutas de la carpeta destino y el archivo actual
                file.CopyTo(tempPath, true); // Copiar el archivo actual a la carpeta destino
            }

            // Copiar las subcarpetas de la carpeta origen a la carpeta destino
            foreach (DirectoryInfo subDir in sourceInfo.GetDirectories())
            {
                string tempPath = Path.Combine(destDir, subDir.Name); // Combinar las rutas de la carpeta destino y la subcarpeta actual
                CopyDirectory(subDir.FullName, tempPath); // Llamar a la función CopyDirectory para copiar la actual
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriteAll
{
    class Program
    {
        static void Main(string[] args)
        {

          
          
                Console.WriteLine("Carga nombres");//Cargamos elemento de 10 posiciones
                string Identidad = Console.ReadLine();
                
                if (!File.Exists("newfile.txt"))//si el archivo new file no existe
                {

                    File.WriteAllText("newfile.txt", Identidad + " \n");//lo creara
                 
                }
                else
                {

                    File.AppendAllText("newfile.txt", Identidad + " \n");// si existe agregara el siguiente texto ingresado
                    
                }
            


               
           
        }
    }
}

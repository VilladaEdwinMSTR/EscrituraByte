using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraByte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nbytes = 0, car;

            try
            {
                //crear el flujo del archivo
                //Append agrega en el mismo renglon
                //Create sobre escribe
                fs = new FileStream("text.txt", FileMode.Append, FileAccess.Write); 
                Console.WriteLine("Escriba el texto que deasea almacenar en el archivo: ");

                //Ciclo
                while((car=Console.Read()) != '\r' && (nbytes < buffer.Length))
                {
                    buffer[nbytes] = (byte)car;
                    nbytes++;
                }
                fs.Write(buffer, 0, nbytes);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
    }
}

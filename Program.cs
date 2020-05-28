using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cesaretti.elia._3j.mediapesata
{
    class Program
    {
        static void Main(string[] args)
        {
            float sommap = 0, prodottivp = 0, campi0, campi1;
            string riga;
            double media;
            string[] campi = new string[10];
            StreamReader File = new StreamReader("voti.txt");
            Console.WriteLine("Programma Media pesata di Elia Cesaretti");
            while (!File.EndOfStream)
            {
                Console.WriteLine();
                riga = File.ReadLine();
                campi = riga.Split(':');
                Console.WriteLine("Voto: " + campi[0]);
                Console.WriteLine("Peso: " + campi[1]);
                campi0 = Convert.ToSingle(campi[0]);
                campi1 = Convert.ToSingle(campi[1]);
                sommap = sommap + campi1;
                prodottivp = prodottivp + (campi0 * campi1);
            }
            media = prodottivp / sommap;
            Console.WriteLine();
           media=Math.Round(media,2);
            Console.WriteLine("La media pesata dei tuoi voti è " + media);
            Console.ReadLine();
            File.Close();
        }
    }
}
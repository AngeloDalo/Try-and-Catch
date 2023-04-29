using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            string inputUtente = Console.ReadLine();
            Console.WriteLine("Inserisci un altro numero");
            string inputUtente2 = Console.ReadLine();
            int num1 = 0;
            try
            {
                //prova a fare questo
                num1 = int.Parse(inputUtente);
            }
            catch (Exception)
            {
                Console.WriteLine("errore di formato del nuemro 1");
                //trow serve a lanciare l'errore
                //throw; //con trow il programma si ferma e ci dice l'errore
            } finally
            {
                num1 = 3;
            }
            int num2 = int.Parse(inputUtente2);
            int risultato = num1 + num2;
            Console.WriteLine("risultato: " + risultato);
        }
    }
}

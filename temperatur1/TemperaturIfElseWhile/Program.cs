using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oppgave 1 lag et program som leser inn et tall, en temperatur, fra en bruker 
            //programmet ditt skal så skrive ut om det er pluss, minus eller null 
            string tekst;
            int temperatur = 0;
            bool parseOk = false;
            while (!parseOk)
            {
                Console.WriteLine("tast en temp, heltall");//Oppgave 3 - bruk av en loop - while
              //Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet, som i oppgave 2.
              //Brukeren skal så få mulighet til å taste inn en verdi, helt til at en gyldig verdi er inntastet.

                //vi leser inn fra bruker
                tekst = Console.ReadLine();
                //må gjøre om til en int - heltall
                //sjekke at input faktisk er et tall
                parseOk = int.TryParse(tekst, out temperatur);//For å parse fra string til en int må det parses.
                //Når vi leser fra Console. Console.ReadLine()). Om man bruker int.Parse(), vi programmet krasje om det ikke er en numerisk verdi inntastet
                                                         

            }
            if (parseOk == true)
            {
                if (temperatur < 0)
                {
                    Console.WriteLine("minus");
                }
                else if (temperatur == 0)
                {
                    Console.WriteLine("null grader");
                }
                else
                {
                    Console.WriteLine("pluss");
                }
            }
            else
            {
                Console.WriteLine("feil verdi skriv inn ett siffer");//Oppgave 2
                //Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet.

            }

            Console.ReadLine();
        }
    }
    
    
    
}
    


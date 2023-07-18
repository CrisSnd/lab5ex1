using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura.*/


            Console.WriteLine("Introduceti stringul: ");
            string string1= (Console.ReadLine());


           if (string.IsNullOrWhiteSpace(string1))
            {
                Console.WriteLine("Nu s-a introdus primul string.Introduceti stringul:");
                return;
            }



            Console.WriteLine("Introduceti substringul:");
             string substring= (Console.ReadLine());
            if (string.IsNullOrWhiteSpace(substring))
            {
                Console.WriteLine("Nu s-a introdus substringul.Introduceti substringul: ");
            }


            int pozitieSubstring=string1.IndexOf(substring);

            if (pozitieSubstring == -1)
            {
                Console.WriteLine("\n" + $"Substringul {substring} nu se afla in stringul {string1}");
            }
            else
            { 
                Console.WriteLine("\n"+$" Substringul {substring}  incepe de la pozitia {pozitieSubstring} in stringul {string1}. ");
            }

        }

     }

 }









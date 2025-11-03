
using System;

class Programm
{


    static void Main (string[] args)
    {



int n = 10;

int somma =0;

for (int i = 0; i <= n; i++)
{
    somma += i;
}

Console.WriteLine($"La somma dei numeri da 1 a {n} è {somma}");



        int counter = 1;

        while (counter <= 100)
        {

            if (counter%2 == 0)
            {
                Console.WriteLine("Numero pari:" + counter);
            }

            counter++;
        }


        Random ran = new Random();

        int randomNumber= ran.Next(1,10);

       

        Console.WriteLine("numero random:" + randomNumber );

        int numberSelected = 0;

        do
        {
            Console.Write("Indovina il numero random, inserisci un numbero intero:");
            numberSelected = int.Parse(Console.ReadLine());
            if (numberSelected == randomNumber)
            {
                Console.WriteLine("Hai indovinato!");
            } else
            {
                Console.WriteLine("Non hai indovinato, Riprova");
            }
         }
        while (!(numberSelected == randomNumber));





    }
}
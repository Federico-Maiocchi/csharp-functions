﻿using System.Security.Principal;
using System.Xml.Linq;
using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
            //-**void StampaArray(int[] array) * *: che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. 
            //Potete prendere quella fatta in classe questa mattina

            //Funzione per inserire vigola e spazio dentro COnsole.Write
            void StampaVirgolaESpazio()
            {
                Console.Write(", ");
            }

            //Funzione per stampare a video l'array
            void StampaArray(int[] array)
            {

                Console.Write("(");

                //ciclo for per ciclare l'array
                for (int i = 0; i < array.Length; i++)
                {

                    Console.Write(array[i]);

                    //Controllo per eliminare lo spazio finale della stampa
                    if (i < array.Length - 1)
                        StampaVirgolaESpazio();
                }
                Console.Write(")");
            }

            int[] numeri = { 1, 2, 3, 4 };
            StampaArray(numeri);

            //- **int Quadrato(int numero) * *: che vi restituisca il quadrato del numero passato come parametro.

            //Funzione per calcolare il quadrato di un numero
            int Quadrato(int numero)
            {
                int quadrato = numero * numero;
                return quadrato;
            }

            int num = 3;
            int risultato = Quadrato(num);

            Console.WriteLine($"Il quadrato di {num} è {risultato}");

            //-**int[] ElevaArrayAlQuadrato(int[] array) * *: che preso un array di numeri interi, 
            //restituisca un nuovo array con tutti gli elementi elevati quadrato. 
            //Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!
            //Vi ricordate perchè? Pensateci(vedi slide)

            int[] ClonaArray(int[] array)
            {
                int[] nuovoArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    nuovoArray[i] = array[i];

                return nuovoArray;
            }

            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] arrayclonato = ClonaArray(array);

                for (int i = 0; i < arrayclonato.Length; i++)
                {
                    Console.WriteLine(arrayclonato[i]);



                    arrayclonato[i] = Quadrato(arrayclonato[i]);
                }

                return arrayclonato;
            }

            int[] arraynumeri = { 2, 3, 4, 5 };

            int[] arrayelevato = ElevaArrayAlQuadrato(arraynumeri);


            StampaArray(arrayelevato);




            //-**int sommaElementiArray(int[] array) * *: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
            int[] arrayNumeri2 = { 1, 2, 3, 4, 5 };

            int sommaElementiArray(int[] array)
            {
                int somma = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    somma += array[i];
                }

                return somma;
            }

            int sommaArray = sommaElementiArray(arrayNumeri2);
            Console.WriteLine(sommaArray);



            //Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri[2, 6, 7, 5, 3, 9] 
            //già dichiarato nel vostro codice,
            //si vogliono utilizzare le funzioni per:
            int[] arrayNumeri3 = { 2, 6, 7, 5, 3, 9 };

            //-Stampare l’array di numeri fornito a video
            StampaArray(arrayNumeri3);

            //-Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato(Verificare che l’array
            //originale non sia stato modificato quindi ristampare nuovamente l’array originale e 
            //verificare che sia rimasto[2, 6, 7, 5, 3, 9])
            int[] arrayNUmeri3Elevato = ElevaArrayAlQuadrato(arrayNumeri3);
            StampaArray(arrayNUmeri3Elevato);


            //-Stampare la somma di tutti i numeri
            int sommaArrayNUmeri3 = sommaElementiArray(arrayNumeri3);
            Console.WriteLine(sommaArrayNUmeri3);

            //-Stampare la somma di tutti i numeri elevati al quadrati
            int sommaArrayNUmeri3Elevato = sommaElementiArray(arrayNUmeri3Elevato);
            Console.WriteLine(sommaArrayNUmeri3Elevato);

            //** BONUS:**Convertire le funzioni appena dichiarate in funzioni generiche, ossia 
            //    funzioni che possono lavorare con array di numeri interi** di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di... e così via.
            //A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, 
            //    e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.

            
            Console.WriteLine("Quanti numeri vuoi inserire?");

            int N;
            
            N = Convert.ToInt32(Console.ReadLine());


            int[] arrayNumeriUtente = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° numero:");

                arrayNumeriUtente[i] = Convert.ToInt32(Console.ReadLine());

            }

            StampaArray(arrayNumeriUtente);

            int[] arrayNumeriUtenteElevati = ElevaArrayAlQuadrato(arrayNumeriUtente);
            StampaArray(arrayNumeriUtenteElevati);

            int sommaArrayNumeriUtente = sommaElementiArray(arrayNumeriUtente);
            Console.WriteLine(sommaArrayNumeriUtente);

            int sommaArrayNumeriUtenteElevati = sommaElementiArray(arrayNumeriUtenteElevati);
            Console.WriteLine(sommaArrayNumeriUtenteElevati);




        }
    }
}

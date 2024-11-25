using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AS2425._3F.INF.Prof.IndovinaNumero
{
    internal class Program
    {
        // Griglia Valutazione
        //2 voto di partenza
        //1 scrittura codice corretta(indentazione, intestazione, buon codice (nomi variabili, ecc), ...)
        //5 Indovina un numero inventato dal calcolatore fra 1 e 20 in un massimo possibile di 15 tentativi; alla fine indicare se il numero è stato indovinato o meno e in quanti tentativi
        //1,5 Indica per ognuno dei tentativi dell'utente se il numero indicato dall'utente è entro il 20% del numero da indovinare come "fuochino" o altrimenti "acqua"
        //0,5 Se indovina il numero in 2 tentativi assegna 5 punti, in 3 tentativi 4 punti, 5 tentativi 3 punti o altrimenti 0 punti e alla fine indicare il numero di punti vinti
        
        static void Main(string[] args)
        {
            Console.WriteLine("Prof; 3F; 13/11/24; Indovina il numero");

            const int nTentativiMax = 15; 

            int numeroUtente; 
            Random r = new Random();
            
            bool numeroIndovinato = false; 
            int numeroTentativi = 0;

            int numeroCasuale = r.Next(1, 20+1); 

            // TODO: remove
            Console.WriteLine($"Numero generato {numeroCasuale}");

            Console.WriteLine("Il calcolatore ha generato un numero casuale che va da 1 a 20, hai 15 tentativi per provare a indovinarlo.");

            for (int i = 0; i < nTentativiMax; i++)
            {

                Console.WriteLine("Inserisci un numero fra 1 e 20");
                numeroUtente = Convert.ToInt32(Console.ReadLine());

                numeroTentativi++;

                if (numeroUtente == numeroCasuale) // se il numero viene indovinato esce dal ciclo
                {
                    numeroIndovinato = true;
                    break;
                }

                Console.WriteLine("Ritenta\n");
            }

            if (numeroIndovinato == true)
            {
                Console.WriteLine($"Hai indovinato il numero:{numeroCasuale} in {numeroTentativi} tentativi.");
            }
            else
            {
                Console.WriteLine($"Non hai indovinato il numero:{numeroCasuale} in {numeroTentativi} tentativi.");
            }

        }
    }
}

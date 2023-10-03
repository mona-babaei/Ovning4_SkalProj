
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {


            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    Console.WriteLine("\n5. Reverse a text string");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;

                    /* case '5':
                         ReverseText();
                         break;

                     /*
                      * Extend the menu to include the recursive 
                      * and iterative exercises.
                      */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }







            /// <summary>
            /// Examines the datastructure List
            /// </summary>

            static void ExamineList()
            {

                List<string> theList = new List<string>();
                string input;

                do
                {
                    Console.WriteLine("Ange +Namn för att lägga till eller " +
                    "-Namn för att ta bort. Skriv 'exit' för att avsluta.");
                    input = Console.ReadLine();
                    char nav = input[0];
                    string value = input.Substring(1);

                    switch (nav)
                    {
                        case '+':
                            theList.Add(value);
                            Console.WriteLine($"Lade till {value}. Antal element:" +
                            $" {theList.Count}, Kapacitet: {theList.Capacity}");
                            break;
                        case '-':
                            if (theList.Contains(value))
                            {
                                theList.Remove(value);
                                Console.WriteLine($"Tog bort {value}. Antal element:" +
                                $" {theList.Count}, Kapacitet: {theList.Capacity}");
                            }
                            else
                            {
                                Console.WriteLine($"{value} fanns inte i listan.");
                            }
                            break;
                        default:
                            if (input != "exit")
                                Console.WriteLine("Använd endast + eller - följt av värdet.");
                            break;
                    }
                } while (input != "exit");
            }

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}


            /// <summary>
            /// Examines the datastructure Queue
            /// </summary>
            static void ExamineQueue()
            {


                Queue<string> myQueue = new Queue<string>();

                {
                    // Simulera ICA kösekvens
                    Console.WriteLine("ICA kösekvens simulering startar...");
                    Console.WriteLine("a. ICA öppnar och kön till kassan är tom.");
                    myQueue.Enqueue("Kalle");
                    Console.WriteLine("b. Kalle ställer sig i kön.");
                    myQueue.Enqueue("Greta");
                    Console.WriteLine("c. Greta ställer sig i kön.");
                    Console.WriteLine($"d. {myQueue.Dequeue()} blir expedierad och lämnar kön.");
                    myQueue.Enqueue("Stina");
                    Console.WriteLine("e. Stina ställer sig i kön.");
                    Console.WriteLine($"f. {myQueue.Dequeue()} blir expedierad och lämnar kön.");
                    myQueue.Enqueue("Olle");
                    Console.WriteLine("g. Olle ställer sig i kön.");
                    Console.WriteLine("\nICA kösekvens simulering avslutas.\n");

                    // Manuell hantering av kön
                    string input = "";
                    Console.WriteLine("Välkommen till Queue simulator!");

                    while (true)
                    {
                        Console.WriteLine("\nMeny:");
                        Console.WriteLine("1. Lägg till en person i kön (Enqueue).");
                        Console.WriteLine("2. Ta bort nästa person i kön (Dequeue).");
                        Console.WriteLine("3. Visa nuvarande kön.");
                        Console.WriteLine("4. Återgå till huvudmenyn.");
                        Console.Write("Ange ditt val: ");

                        input = Console.ReadLine();

                        switch (input)
                        {
                            case "1":
                                Console.Write("Ange namnet på personen som ska läggas till i kön: ");
                                string name = Console.ReadLine();
                                myQueue.Enqueue(name);
                                Console.WriteLine($"{name} har lagts till i kön.");
                                break;
                            case "2":
                                if (myQueue.Count > 0)
                                {
                                    string removedPerson = myQueue.Dequeue();
                                    Console.WriteLine($"{removedPerson} har tagits bort från kön.");
                                }
                                else
                                {
                                    Console.WriteLine("Kön är tom.");
                                }
                                break;
                            case "3":
                                Console.WriteLine("Nuvarande kön:");
                                foreach (var person in myQueue)
                                {
                                    Console.WriteLine(person);
                                }
                                break;
                            case "4":
                                return;
                            default:
                                Console.WriteLine("Ogiltigt val. Försök igen.");
                                break;
                        }

                    }

                }
            }

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */


            /// <summary>
            /// Examines the datastructure Stack
            /// </summary>
            static void ExamineStack()
            {

                Stack<string> theStack = new Stack<string>();

                string input;


                do
                {
                    Console.WriteLine("Ange +Namn för att lägga till eller - för att ta bort det översta elementet. Skriv 'exit' för att avsluta.");
                    input = Console.ReadLine();

                    if (input.StartsWith("+"))
                    {
                        string value = input.Substring(1);
                        theStack.Push(value);
                        Console.WriteLine($"Lade till {value}. Stackstorlek: {theStack.Count}");
                    }
                    else if (input == "-")
                    {
                        if (theStack.Count > 0)
                        {
                            string removedValue = theStack.Pop();
                            Console.WriteLine($"Tog bort {removedValue}. Stackstorlek: {theStack.Count}");
                        }
                        else
                        {
                            Console.WriteLine("Stacken är tom.");
                        }
                    }
                    else if (input != "exit")
                    {
                        Console.WriteLine("Använd +Namn för att lägga till eller - för att ta bort det översta elementet.");
                    }
                } while (input != "exit");


            }



            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            static void CheckParanthesis()
            {
                Console.WriteLine("Please enter a string to check for well-formed parentheses:");
                string input = Console.ReadLine();

                if (IsWellFormed(input))
                    Console.WriteLine("The string is well-formed.");
                else
                    Console.WriteLine("The string is NOT well-formed.");
            }

            static bool IsWellFormed(string input)
            {
                Stack<char> stack = new Stack<char>();

                foreach (char ch in input)
                {
                    switch (ch)
                    {
                        case '(':
                        case '[':
                        case '{':
                            stack.Push(ch);
                            break;
                        case ')':
                            if (!stack.TryPop(out char top) || top != '(')
                                return false;
                            break;
                        case ']':
                            if (!stack.TryPop(out top) || top != '[')
                                return false;
                            break;
                        case '}':
                            if (!stack.TryPop(out top) || top != '{')
                                return false;
                            break;
                    }
                }

                return stack.Count == 0;
            }

        }
    }
}


/*
 * Use this method to check if the paranthesis in a string is Correct or incorrect.
 * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
 * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
 */



/* Frågor:
 * 1. Stacken och heapen är minnesområden i en dator. Stacken har en LIFO-struktur och lagrar lokala variabler samt 
 * hanterar minnet automatiskt, men har begränsad storlek. Heapen tillåter dynamisk minnesallokering, 
 * vilket betyder att data med okänd storlek vid kompileringstid kan lagras där, men kräver manuell hantering och kan 
 * leda till minnesläckor om inte hanterad korrekt. Den största skillnaden är att stacken hanterar minnet automatiskt
 * medan heapen kräver manuell hantering.

Stacken:

	•	Organiserad som LIFO (sist in, först ut).
	•	Används för lokala variabler och returadresser.
	•	Minne allokeras/deallokeras automatiskt vid funktionsanrop/retur.

Exempel: När en funktion kallas skapas en “stack frame” med dess lokala variabler. Vid retur tas denna bort.

Heapen:

	•	För dynamisk minnesallokering.
	•	Programmeraren bestämmer när minne allokeras/deallokeras.
	•	Risk för minnesläckor om inte hanterad korrekt.

Exempel: Vid skapande av en dynamisk lista allokeras minne från heapen.

Kort skiss:

---------------------
| Heap (Dynamisk)   |
| ...               |
---------------------
|                   |
---------------------
| Stack (LIFO)      |
| ...               |
---------------------
| Programkod        |
---------------------

Huvudskillnaden: Stacken sköter minnet automatiskt, medan heapen kräver manuell hantering.

 * 2.**Värdestyper (Value Types)**:
- Innehåller direkt data.
- Vid tilldelning kopieras det underliggande värdet.
- Ändringar av en kopia har ingen inverkan på originalet.
- Typexempel: `int`, `float`, `struct` i många programmeringsspråk.

**Referenstyper (Reference Types)**:
- Innehåller en pekare till ett värde.
- Vid tilldelning kopieras endast pekaren, inte själva datat.
- Ändringar reflekteras över alla variabler som delar samma pekare.
- Typexempel: `class`-instanser, `arrays` i många språk.

**Skillnad**: Value types lagrar själva datat medan reference types lagrar en adress till data
 * 
 * 3.När du ändrar värdet av y till 4 påverkas inte x, x och y är två skilda värdestyper i minnet. 
 * Så när du returnerar x, är dess värde fortfarande .

Däremot, när du ändrar MyValue-egenskapen hos y till 4, påverkas även x. Detta beror på att x och y,
som båda är referenstyper av MyInt, pekar på samma objekt i minnet. Därför returnerar x.MyValue värdet 4.
*****************
 * övning1 (4-1)
 * 
 2.När ökar listans kapacitet?
Kapaciteten ökar när antalet element överstiger nuvarande kapacitet.

3. Med hur mycket ökar kapaciteten?

I början kan en lista ha en liten kapacitet, till exempel 4. När den blir full,
dubbleras dess storlek (så den går från 4 till 8, sedan 16, 32, och så vidare).

4. Varför ökar inte listans kapacitet i samma takt som element läggs till?

Att öka varje gång skulle ta mycket minne. Därför ökar den ibland, som att dubbla,
för att spara på minnet.

5. Minskar kapaciteten när element tas bort ur listan? 
Nej, när element tas bort ur en lista minskar inte dess kapacitet.
Kapaciteten förblir densamma tills vi explicit minskar den, t.ex. med TrimExcess()-metoden.

6. 	När är det fördelaktigt att använda en array istället för en lista?
Använd en array istället för en lista när vi vet antalet element i förväg,
vill optimera minnesanvändningen, och inte behöver listans dynamiska funktioner.
Listans kapacitet (storlek på underliggande array) kan ses via `Capacity`-egenskapen i List-klassen.
 * 
 * 
 */










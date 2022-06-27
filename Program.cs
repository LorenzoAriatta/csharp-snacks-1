// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Snack - Il software deve chiedere per 10 volte all’utente di inserire un numero
Il programma stampa la somma di tutti i numeri inseriti.
 */

//dichiarazione array
int numbers = 0;

//richiesta all'user
for(int i = 0; i<10;i++)
{
    Console.Write("Insert a number: ");
    numbers += Int32.Parse(Console.ReadLine());

}

Console.WriteLine("The sum of your numbers is: {0}",numbers);
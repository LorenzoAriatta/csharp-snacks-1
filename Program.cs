// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Snack 10
Fai inserire un numero, che chiameremo N all'utente.
Genera N, array ognuno formato da 10 num casuali tra 1 e 100.
Ogni volta che ne crei uno stampalo a schermo.
*/

Console.Write("Insert a number: ");

int N = Int32.Parse(Console.ReadLine());

int[] arrayNumbers;

Random rng = new Random();

for (int nArrays = 0; nArrays < N; nArrays++)
{
    arrayNumbers = new int[10];

    for(int i = 0; i < arrayNumbers.Length; i++)
    {
        arrayNumbers[i] = rng.Next(1, 100);
    }
    
    for(int i = 0; i < arrayNumbers.Length; i++)
    {
        Console.Write(arrayNumbers[i] + ",");
    }
    Console.WriteLine();
}



return;

/*
Snack 5
Il software chiede di inserire un numero all'utente
Se il numero è pari, stampa il numero, se è dispari, stampa il successivo
 */

//user input
Console.WriteLine("Insert a number");
int userNum = Int32.Parse(Console.ReadLine());

//logica controllo input
if (userNum % 2 == 0) {
    Console.Write($"Your number: {userNum}, is EVEN! ");
}else
{
    Console.Write($"Sorry, your number: {userNum}, is ODD, the next EVEN is: {userNum + 1}");
}




/*
Snack 4
Calcola la somma e la media dei numeri da 2 a 10
 */


double average;
int sum = 0;

for(int i = 2; i <= 10; i++)
{
    sum += i;
}

average = sum / (10 - 2);

Console.WriteLine("Sum of number is: " + sum);
Console.WriteLine("the average is: " + average);



/*
Snack 3
Il software deve chiedere per 10 volte all’utente di inserire un numero
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



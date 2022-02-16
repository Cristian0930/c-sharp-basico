/*
    for, while, do-while
    Grosso modo
    for
    Se utilizará cuando se conozca la cantidad de veces
    que se va a repetir nuestro bloque de código.

    while
    Es conveniente utilizarlo cuando
    la cantidad de veces a repetir el ciclo
    dependa de un factor difícil de controlar
    o que llegará en un momento inesperado.

    do-while
    Lo emplearemos para asegurar que
    nuestro ciclo se ejecute al menos una vez
    y que además las condiciones del problema
    sean similares a las de los problemas en las que
    se emplea while
 */

// Ciclo for

for (int i = 0; i <= 50; i= i + 10) {
    Console.WriteLine("#" + i);
}

// Ciclo while
/*
bool continueSoftwareExecution = true;
while (continueSoftwareExecution == true)
{
    Console.WriteLine("Do you wish to keep the software running? write 1 if yes, 0 if no");
    int keepGoing = Convert.ToInt16(Console.ReadLine());
    if (keepGoing == 1)
    {
        Console.WriteLine("Hello! the software will keep running");
        continueSoftwareExecution = true;
    } 
    else if (keepGoing == 0)
    {
        Console.WriteLine("This is the last time the software is running");
        continueSoftwareExecution = false;
    } 
    else
    {
        Console.WriteLine("Invalid input, try again");
    }
    Console.WriteLine("Hello");
}
*/

// Ciclo do-while
bool continueSoftwareExecution = false;

do
{
    Console.WriteLine("Do you wish to keep the software running? write 1 if yes, 0 if no");
    int keepGoing = Convert.ToInt16(Console.ReadLine());
    if (keepGoing == 1)
    {
        Console.WriteLine("Hello! the software will keep running");
        continueSoftwareExecution = true;
    }
    else if (keepGoing == 0)
    {
        Console.WriteLine("This is the last time the software is running");
        continueSoftwareExecution = false;
    }
    else
    {
        Console.WriteLine("Invalid input, try again");
    }
    Console.WriteLine("Hello");
} while (continueSoftwareExecution == true);
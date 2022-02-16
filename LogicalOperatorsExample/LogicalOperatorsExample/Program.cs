// &&, ||, !

/* 
bool value1 = true;
bool value2 = true;
bool value3 = false;

bool result = value1 && value2 && value3;
Console.WriteLine("The result of the logical AND is: " + result);

bool result2 = value1 || value2 || value3;
Console.WriteLine("The result of the logical OR is: " + result2);

bool result3 = !value1;
Console.WriteLine("The result of the logical NOT is: " + result3);
*/

int value1 = 3;
int value2 = 18;

bool result = value1 == value2;
bool result1 = value1 != value2;
bool result2 = value1 > value2;
bool result3 = value1 < value2;
bool result4 = value1 >= value2;
bool result5 = value1 <= value2;

Console.WriteLine($"The result of value1 == value2 is: {result}");
Console.WriteLine($"The result of value1 != value2 is: {result1}");
Console.WriteLine($"The result of value1 > value2 is: {result2}");
Console.WriteLine($"The result of value1 < value2 is: {result3}");
Console.WriteLine($"The result of value1 >= value2 is: {result4}");
Console.WriteLine($"The result of value1 <= value2 is: {result5}");


int anyValue = 14;
String message = "";

if (anyValue == 8)
{
    message = "OMG, it's a miracle any Value is 7";
} else if (anyValue == 14)
{
    message = "OMG, it's a miracle any Value is 14";
}
else 
{
    message = "puff, the value wasn't 7";
}

Console.WriteLine($"The answer is: { message }");

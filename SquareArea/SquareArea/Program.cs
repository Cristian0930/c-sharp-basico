// calculate area of a rectangle

try
{
    Console.WriteLine("Please enter the side A of the rectangle: ");
    float sideA = float.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the side B of the rectangle: ");
    float sideB = float.Parse(Console.ReadLine());

    float area = sideA * sideB;

    Console.WriteLine("The area of the rectangle is: " + area);
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


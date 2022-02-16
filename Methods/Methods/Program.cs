using Methods;

Random random = new Random();
Console.WriteLine(random.Next(1, 10)); // Obtener un número random de 1 a 10

string ClassTopic = "Métodos de strings";
string School = "Platzi";
Console.WriteLine("Estoy aprendiendo de " + ClassTopic + " en " + School + ".");

string SchoolClone = School.Clone().ToString();
Console.WriteLine(SchoolClone);

Console.WriteLine(ClassTopic.CompareTo(School)); // -1
Console.WriteLine(School.CompareTo(SchoolClone)); // 0

MyMethod myMethod = new MyMethod();

myMethod.IntegerAddition(3,6);

int result = myMethod.IntegerMultiplication(12, 2);
Console.WriteLine("El resultado de la multiplicación es " + result);

float result2 = myMethod.FloatDivision(21, 2);
Console.WriteLine("El resultado de la división es " + result2);

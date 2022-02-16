


string[] coffeTypes;
float[] coffeePrices;

coffeTypes = new string[] { "Expresso", "Largo", "Filtrado", "Latte" };
coffeePrices = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

coffeTypes[1] = "Lungo";
for (int i = 0; i < coffeTypes.Length; i++)
{
    Console.WriteLine(coffeTypes[i] + " coffee - $" + coffeePrices[i]);
}
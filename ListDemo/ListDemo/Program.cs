

List<string> tacoShoppingList = new List<string>();

tacoShoppingList.Add("Cinco tacos de suadero");
tacoShoppingList.Add("Cuatro tacos de tripa");
tacoShoppingList.Add("Cinco tacos de pastor");
tacoShoppingList.Add("Cuatro Coca colas");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

//tacoShoppingList.Remove("Cinco tacos de suadero");
tacoShoppingList.RemoveAt(0);

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}
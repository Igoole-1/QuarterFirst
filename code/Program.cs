string [] InitialArray = {"Sunday", "Ski", "Kazan", "2", "Love", "31","USA" };
string [] FinalArray = new string [InitialArray.Length];

void PrintNums(string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintNums (InitialArray);

void ThreeSymbols (string[] InitialArray) 
{
    Console.WriteLine ();
    string[] arr = new string [InitialArray.Length];
    int j = 0;
    for (int i = 0; i < InitialArray.Length; i++)
    {
        if (InitialArray[i].Length <= 3)
        {
            arr[j] = InitialArray[i];
            j=j++;
            Console.Write($"{arr[j]} ");
        }
    }
}
Console.WriteLine ();
ThreeSymbols (InitialArray);
PrintNums (FinalArray);

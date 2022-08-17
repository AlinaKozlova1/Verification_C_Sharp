Console.WriteLine("Enter your array size: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array =  new string[n];

void FillArray (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Enter " + (i+1) + " array valye: ");
        arr[i] = Console.ReadLine();
    }
    
}

FillArray(array);
Console.WriteLine("Initial array: [" + string.Join(", ", array) + "]");

string[] SelectionArray(string[] arr2)
{
    int k = 0;
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr2[j].Length <= 3) k++;
    }
    string[] moveArray = new string[k];
    int l = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i].Length <= 3)
            {
                moveArray[l] = arr2[i];
                l++;
            }
        }
    return moveArray;
}

Console.WriteLine("Output array: [" + string.Join(", ", SelectionArray(array)) + "]");



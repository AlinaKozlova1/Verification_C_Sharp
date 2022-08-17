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

string[] RefillArray(string[] arr2)
{
    int k = 0;
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr2[j].Length <= 3) k++;
    }
    string[] removeArr = new string[k];
    int l = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i].Length <= 3)
            {
                removeArr[l] = arr2[i];
                l++;
            }
        }
    return removeArr;
}

Console.WriteLine("Output array: [" + string.Join(", ", RefillArray(array)) + "]");



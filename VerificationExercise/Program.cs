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


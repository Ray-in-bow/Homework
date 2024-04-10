string[] arr = Console.ReadLine()!.Split(' ').ToArray();
string[] new_arr = new string[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        Array.Resize(ref new_arr, new_arr.Length + 1);
        new_arr[new_arr.Length - 1] = arr[i];
    }
}

if (new_arr.Length > 0)
{
    for (int i = 0; i < new_arr.Length; i++)
    {
        Console.Write(new_arr[i] + " ");
    }
}
else
{
    Console.WriteLine("");
}
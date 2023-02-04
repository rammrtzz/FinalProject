string[] arr = { "adasdad", "ads", "123rf", "234" };
string[] arr1 = { };
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 4)
    {
        arr1.Append(arr[i]);
        Console.WriteLine(arr[i]);
    }
}
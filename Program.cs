// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a series of integers separated by spaces.");
String stringOfNumbers = Console.ReadLine();
String[] numbersSplit = stringOfNumbers.Split(' ');
//Converting to an int array
int[] values = new int[numbersSplit.Length];
for (int i = 0; i < numbersSplit.Length; i++) {
values[i] = Int32.Parse(numbersSplit[i]);
}
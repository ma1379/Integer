// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a series of integers separated by spaces. Do not end with a space.");
String stringOfNumbers = Console.ReadLine();
String[] numbersSplit = stringOfNumbers.Split(' ');
//Converting to an int array
int[] values = new int[numbersSplit.Length];
for (int i = 0; i < numbersSplit.Length; i++) {
values[i] = Int32.Parse(numbersSplit[i]);
}
bool quit = false;
while(!quit) {
    Console.WriteLine("Please input the appropriate number.");
    Console.WriteLine("1 - Display the whole list of input.");
    Console.WriteLine("2 - Display every even number.");
    Console.WriteLine("3 - Display every odd number");
    Console.WriteLine("4 - Display every fifth number");
    Console.WriteLine("5 - Display the sum of the integers");
    Console.WriteLine("6 - Display every number divisible by 3");
    Console.WriteLine("7 - Quit");
    String choice = Console.ReadLine();
    if(choice == "1") {
        //step 1 goes here
        for ( int i = 0 ; i < values.Length ; i++ ){
        Console.WriteLine( values[i]);
        }
    } else if(choice == "2") {
        //step 2 goes here
    } else if(choice == "3") {
        //step 3 goes here
    } else if(choice == "4") {
        for (int i = 0; i < values.length;i++) {
            Console.WriteLine(values[i*5])
        }
    } else if(choice == "5") {
        //step 5 goes here
    } else if(choice == "6") {
        //step 6 goes here
    } else if(choice == "7") { 
        quit = true;
    } else {
        Console.WriteLine("Invalid Input");
    }

}


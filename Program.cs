

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello\nWorld"); //Adding \n to the end of the string will create a new line

        Console.WriteLine("Hello\tWorld"); // adding \t will create a tab

        Console.WriteLine("Hello\" World\"!"); //Adding \" will create a quotation mark 

        Console.WriteLine("c:\\windows\\repos");//Adding \\ will create a backslash

        Console.WriteLine("Generating invoices for customers ");
        Console.WriteLine("Invoice 1021\t\tComplete!");
        Console.WriteLine("Invoice 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
        Console.Write(@"c:\invoices");
        Console.WriteLine();

        Console.WriteLine("\u3053\u3093\u3068\u3061\u306F World!");

        // To generate Japanese invoices:
        // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        // User command to run an application
        Console.WriteLine(@"c:\invoices\app.exe -j");


        string Projectname = ("ACME");
        string russianmessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434 :";
        Console.WriteLine(russianmessage);
        string Russian = $@"c\{Projectname}\data.txt";//This is how you can use $ to create a string with variables in it.
        Console.WriteLine(Russian);




        Console.WriteLine(@"    c:\source\repos
      (This is Where you code goes)");
        Console.WriteLine("Testing 123");
        String hi = "Hello World"; //This is how to declare a variable in c#
        Console.WriteLine(hi);
        Console.WriteLine("Enter your name: ");
        String userName = Console.ReadLine();
        Console.WriteLine("So your name is " + userName);//This is how take user input and replay it back to them
        Console.WriteLine("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is " + userAge); //This is how to take a user input of a number i.e an integer and print it back to them


    }
}
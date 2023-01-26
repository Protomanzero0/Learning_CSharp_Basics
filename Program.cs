// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
// Variables
int score = 1000;
Console.WriteLine(score);
string message = "This is a new message! :D";
Console.WriteLine(message);
char letter = 'c';
Console.WriteLine(letter);

// Expressions
int a = 3 + 5;
Console.WriteLine(a);
a += 5;
int b = 10 + 13;
int c = a + b;
int d = a * b;
float e = c / d;
int f = b % a;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine();
float sum = a + b + c + d + e + f;
Console.WriteLine(sum);
Console.Write("Write your message here: ");
string userMessage = Console.ReadLine();
Console.WriteLine("Your message: " + userMessage);
Console.WriteLine();

// Conditionals and Functions
string ConditionalSwitcher(string conditional_type)
{

    if (conditional_type == "1")
    {
        Console.Write("Enter your option number (1 - 3): ");
        string option = Console.ReadLine();
        int numOption = Int32.Parse(option);
        if (numOption == 1)
        {
            return "You entered option 1!";
        }
        else if (numOption == 2)
        {
            return "You entered option 2!";
        }
        else if (numOption == 3)
        {
            return "You entered option 3!";
        }
        else
        {
            return "Error: Invalid option.";
        }
    }
    else if (conditional_type == "2")
    {
        Console.Write("Enter your option number (1 - 3): ");
        string option = Console.ReadLine();
        int numOption = Int32.Parse(option);
        switch (numOption)
        {
            case 1:
                return "You entered option 1!";
                break;
            case 2:
                return "You entered option 3!";
                break;
            case 3:
                return "You entered option 3!";
                break;
            default:
                return "Error: Invalid input";
        }
    }
    else
    {
        return "Error: Invalid Input";
    }


}
Console.Write("Enter the condition type you'd like to use (1-2) : ");
string conditional_type = Console.ReadLine();
Console.WriteLine(ConditionalSwitcher(conditional_type));
Console.WriteLine();

// Loops
short i = 0;
List<Int16> list = new List<Int16>();

while (i < 10)
{
    list.Add(i);
    i++;
}
foreach (short item in list)
{
    Console.WriteLine(item);
}
for (short j = 0; j <= 15; j++)
{
    Console.WriteLine("j = " + j);
}
Console.WriteLine();
// Classes 
// This class won't do much for now, but I'd like to create a Tron Lightcycle's style game and this will be a rough 
// draft of sorts for the bike's class. This is just to show I can create and access class variables and methods. 

// Classes Test
Bike bike1 = new Bike("Player 1");

Console.WriteLine("Bike 1's name: " + bike1.GetName());
Console.WriteLine("Bike 1's lives: " + bike1.GetLivesLeft());
bike1.Kill();
Console.WriteLine("Bike 1's lives: " + bike1.GetLivesLeft());
bike1.AddPoints();
Console.WriteLine("Bike 1's points: " + bike1.GetPoints());
Console.WriteLine();

// Structure Tests
Players newPlayer = new Players();
newPlayer.GetValues("ASDF", 5, 2);
newPlayer.Display();
Console.WriteLine();

// Reading Tests
readFile("C:\\Users\\proto\\Documents\\Personal Programming Projects\\C# Projects\\LearningCSharb\\Reader.txt");

// Writing Tests
writeFile("C:\\Users\\proto\\Documents\\Personal Programming Projects\\C# Projects\\LearningCSharb\\Writer.txt");
readFile("C:\\Users\\proto\\Documents\\Personal Programming Projects\\C# Projects\\LearningCSharb\\Writer.txt");

// Reading and Writing to a file
void readFile(string path)
{
    string line;
    try
    {
        StreamReader sr = new StreamReader(path);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);   
    }
    finally
    {
        Console.WriteLine();
    }
}

void writeFile(string path)
{
    try
    {
        StreamWriter sw = new StreamWriter(path);
        sw.WriteLine("This is a writing test!");
        sw.WriteLine("Testing testing 123");
        sw.Close();
    }
    catch(Exception e) { Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine();   
    }
}
class Bike
{
    private string _name;
    private int _livesLeft;
    private int _points;

    public Bike(string name)
    {
        _name = name;
        _points = 0;
        _livesLeft = 3;

    }
    public void Kill()
    {
        Console.WriteLine("Killing " + _name + "... ");
        _livesLeft--;
        if (_livesLeft == 0)
        {
            _points = 0;
        }
    }

    public void AddPoints() 
    {
        Console.WriteLine(_name + " scored a kill!"); 
        _points++; 
    }
        

    public string GetName() { return _name; }
    public int GetPoints() { return _points; }
    public int GetLivesLeft() { return _livesLeft; }
}

// Structures
// Another sort of throwaway example, but could be used to track player data maybe?

struct Players
{
    public string name;
    public int score;
    public int times_played;

    public void GetValues(string n, int s, int t)
    {
        name = n;
        score = s;  
        times_played = t;
    }

    public void Display()
    {
        Console.WriteLine("Player Name: {0}", name);
        Console.WriteLine("Score: {0}", score);
        Console.WriteLine("Times Played {0}", times_played);
    }
}

// Unions
// I don't understand Unions at all, there's no operator for them in C# and I don't understand the point of them




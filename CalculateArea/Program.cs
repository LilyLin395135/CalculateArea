//-Open a Class to make the method
//    - Method：length*width
//    - and turn “square feet” into “square meters” 
//    square meters=0.09290304 square feet
//- Program：use Console.ReadLine()
//-Challenges
//    - [X]  確認input的值為數字。並例外處理input值為文字者。
//    - [X]  讓user可以選擇input feet或是meters
//    - [ ] 做成GUI介面。
//    "GUI" stands for Graphical User Interface.A GUI program is a type of computer program that allows users to interact with the computer using graphical elements such as icons, buttons, and windows, rather than using text commands. GUI programs are commonly used for applications such as word processors, image editors, and web browsers, among others.

double resultLength = 0;
double resultWidth = 0;

Console.WriteLine("Enter \"feet\" or \"meters\" you want to use in calculating area.");
string unitOfArea = Console.ReadLine();
if (unitOfArea == "feet")
{
    Console.WriteLine("What is the length of the room in feet?");
    string length = Console.ReadLine();
    if (double.TryParse(length, out resultLength))
    {
        Console.WriteLine("What is the width of the room in feet?");
        string width = Console.ReadLine();

        if (double.TryParse(width, out resultWidth))
        {
            Console.WriteLine($"You entered dimensions of {length} feet by {width} feet.");
            double squareFeet = resultLength * resultWidth;
            double squareMeters = squareFeet * 0.09290304;
            Console.WriteLine($"The area is \n{squareFeet} square feet \n{squareMeters} square meters");
        }
        else
        {
            Console.WriteLine("You must input numbers! You bad bad!>A<");
        }
    }
    else
    {
        Console.WriteLine("You must input numbers! You bad bad!>A<");
    }
}

if (unitOfArea == "meters")
{
    Console.WriteLine("What is the length of the room in meters?");
    string length = Console.ReadLine();
    if (double.TryParse(length, out resultLength))
    {
        Console.WriteLine("What is the width of the room in meters?");
        string width = Console.ReadLine();

        if (double.TryParse(width, out resultWidth))
        {
            Console.WriteLine($"You entered dimensions of {length} meters by {width} meters.");
            double squareMeters = resultLength * resultWidth;
            double squareFeet = squareMeters / 0.09290304;
            Console.WriteLine($"The area is \n{squareMeters} square meters\n{squareFeet} square feet");
        }
        else
        {
            Console.WriteLine("You must input numbers! You bad bad!>A<");
        }
    }
    else
    {
        Console.WriteLine("You must input numbers! You bad bad!>A<");
    }
}

else
{
    Console.WriteLine("You must input \"feet\" or \"meters\" ! You bad bad!>A<");
}
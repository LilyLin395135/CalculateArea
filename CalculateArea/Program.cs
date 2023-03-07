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

// double resultLength = 0;
// double resultWidth = 0;
//
// // GUI
// Console.WriteLine("Enter \"feet\" or \"meters\" you want to use in calculating area.");
// string unitOfArea = Console.ReadLine();
// if (unitOfArea == "feet")
// {
//     // GUI
//     Console.WriteLine("What is the length of the room in feet?");
//     string length = Console.ReadLine();
//     if (double.TryParse(length, out resultLength))
//     {
//         // GUI
//         Console.WriteLine("What is the width of the room in feet?");
//         string width = Console.ReadLine();
//
//         if (double.TryParse(width, out resultWidth))
//         {
//             // GUI
//             Console.WriteLine($"You entered dimensions of {length} feet by {width} feet.");
//             // Logic
//             double squareFeet = resultLength * resultWidth;
//             double squareMeters = squareFeet * 0.09290304;
//             // GUI
//             Console.WriteLine($"The area is \n{squareFeet} square feet \n{squareMeters} square meters");
//         }
//         else
//         {
//             // GUI
//             Console.WriteLine("You must input numbers! You bad bad!>A<");
//         }
//     }
//     else
//     {
//         // GUI
//         Console.WriteLine("You must input numbers! You bad bad!>A<");
//     }
// }
//
// // 以下 87% 重複
// if (unitOfArea == "meters")
// {
//     Console.WriteLine("What is the length of the room in meters?");
//     string length = Console.ReadLine();
//     if (double.TryParse(length, out resultLength))
//     {
//         Console.WriteLine("What is the width of the room in meters?");
//         string width = Console.ReadLine();
//
//         if (double.TryParse(width, out resultWidth))
//         {
//             Console.WriteLine($"You entered dimensions of {length} meters by {width} meters.");
//             double squareMeters = resultLength * resultWidth;
//             double squareFeet = squareMeters / 0.09290304;
//             Console.WriteLine($"The area is \n{squareMeters} square meters\n{squareFeet} square feet");
//         }
//         else
//         {
//             Console.WriteLine("You must input numbers! You bad bad!>A<");
//         }
//     }
//     else
//     {
//         Console.WriteLine("You must input numbers! You bad bad!>A<");
//     }
// }
//
// else
// {
//     Console.WriteLine("You must input \"feet\" or \"meters\" ! You bad bad!>A<");
// }

using CalculateArea;

Console.WriteLine("Enter \"feet\" or \"meters\" you want to use in calculating area.");
var unitOfArea = Console.ReadLine()?.ToLower();
if (unitOfArea != UnitOfArea.Feet.ToString().ToLower() && unitOfArea != UnitOfArea.Meters.ToString().ToLower())
{
    Console.WriteLine("""You must input "feet" or "meters" ! You bad bad!>A<""");
    return;
}

Console.WriteLine($"""What is the length of the room in "{unitOfArea}"?""");
var length = Console.ReadLine();
if (double.TryParse(length, out var resultLength) == false)
{
    Console.WriteLine("You must input numbers! You bad bad!>A<");
    return;
}

Console.WriteLine($"What is the width of the room in {unitOfArea}?");
var width = Console.ReadLine();
if (double.TryParse(width, out var resultWidth) == false)
{
    Console.WriteLine("You must input numbers! You bad bad!>A<");
    return;
}

var room = new Room(resultLength, resultWidth, unitOfArea);

var template = $"""
    You entered dimensions of {resultLength} {unitOfArea} by {resultWidth} {unitOfArea}.
    The area is
    {Math.Round(room.GetMeter, 3)} square meters
    {Math.Round(room.GetFeet, 3)} square feet
    """;

Console.WriteLine(template);
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Assignment
{
class DistanceCalculator
{
/// <summary>
/// This class calculates the distance between two points and the angle of the slope.
/// </summary>

static void Main(string[] args)
{
float point1X = 0;
float point1Y = 0;
float point2X = 0;
float point2Y = 0;

float deltaX = 0;
float deltaY = 0;

double distance = 0;
double angle;

Console.WriteLine("Welcome. This program calculates the distance \nbetween two points as well as their angle.\nPlease type the prompted values.");

//GetPoints() defines all the point coordinates via user input and
//returns true if the data entered was invalid.
NewPoints : while (GetPoints(ref point1X, ref point1Y, ref point2X, ref point2Y))
{
Console.WriteLine("Invalid data has been entered. Try again.");
}

//Getting the change in x and y from point 1 to 2.
deltaX = point2X - point1X;
deltaY = point2Y - point1Y;

//Calc() uses the Pythagorean Theorem to calculate and return
//distance, and calculates angle in degrees by multiplying the
//tangent of deltaX and deltaY.
distance = Calc(deltaX, deltaY, out angle);

//Displaying calculations
Console.WriteLine("\nDistance: {0:N3}\nAngle: {1:N3} degrees\nWould you like to calculate new points? (y,n)", distance, angle);

//User decides whether or not to do new calculations.
string newCalc = Console.ReadLine().ToLower();

if (newCalc.Equals("y") || newCalc.Equals("yes"))
{
goto NewPoints;
}
else return;
}

static bool GetPoints(ref float newPoint1X, ref float newPoint1Y, ref float newPoint2X, ref float newPoint2Y)
{

bool invalid = false;

//Prompts user for coordinates and sets the cursor in front of the
//prompt for neatness, then checks validity of user input
Console.WriteLine("\nPoint 1\nX Coordinate: ");
Console.SetCursorPosition(14, Console.CursorTop - 1);
if (!float.TryParse(Console.ReadLine(), out newPoint1X))
{
invalid = true;
return invalid;
}
Console.WriteLine("Y Coordinate: ");
Console.SetCursorPosition(14, Console.CursorTop - 1);
if (!float.TryParse(Console.ReadLine(), out newPoint1Y))
{
invalid = true;
return invalid;
}

Console.WriteLine("Point 2\nX Coordinate: ");
Console.SetCursorPosition(14, Console.CursorTop - 1);
if (!float.TryParse(Console.ReadLine(), out newPoint2X))
{
invalid = true;
return invalid;
}
Console.WriteLine("Y Coordinate: ");
Console.SetCursorPosition(14, Console.CursorTop - 1);
if (!float.TryParse(Console.ReadLine(), out newPoint2Y))
{
invalid = true;
return invalid;
}

return invalid;
}

static double Calc(float deltaX, float deltaY, out double angle)
{
double newDistance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
angle = (Math.Atan2(deltaY, deltaX)) * (180 / Math.PI);
return newDistance;
}
}
}
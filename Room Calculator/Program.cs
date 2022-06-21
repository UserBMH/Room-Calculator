//Prompts user to enter L X W X H
Console.WriteLine("Enter the length of the room in feet.");
double length = double.Parse(Console.ReadLine());


Console.WriteLine("Enter the width of the room in feet.");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the height of the room in feet.");
double height = double.Parse(Console.ReadLine());


//variables
double area = length * width;
double perimeter = ((length * 2) +(width * 2));
double volume = length * width * height;
double surfaceArea = (2 * (width * height)) + (2 * (length * height)) + (2 * (width * length));



//Console returns
Console.WriteLine("The area of the room is " + area + " feet.");
Console.WriteLine("The perimeter of the room is " + perimeter + " feet.");
Console.WriteLine("The volume of the room is " + volume + " feet.");
Console.WriteLine("The surface area of the room is " + surfaceArea + " feet.");



//If else room size check
if (area >= 650)
{
    Console.WriteLine("woooow thats a LARGE ROOM!");
}

else if (area >= 250)
{
    Console.WriteLine("woooow thats a MEDIUM ROOM!");
}


else if (250 >= area)
{
    Console.WriteLine("woooow thats a SMALL ROOM!");
}






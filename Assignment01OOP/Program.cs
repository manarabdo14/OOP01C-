namespace Assignment01OOP
{
    internal class Program
    {
        static string GetMonthRange(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    return "March to May";
                case Season.Summer:
                    return "June to August";
                case Season.Autumn:
                    return "September to November";
                case Season.Winter:
                    return "December to February";
                default:
                    return "Out oF Range"; ;
            }
        }
        static bool IsPrimaryColor(Colors color)
        {
            switch (color)
            {
                case Colors.Red:
                case Colors.Green:
                case Colors.Blue:
                    return true;
                default:
                    return false;
            }
        }
        static void Main(string[] args)
        {

            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //Console.WriteLine("Days of the week:");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    string monthRange = GetMonthRange(season);
            //    Console.WriteLine($"{season} includes the months: {monthRange}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season. Please enter one of the following: Spring, Summer, Autumn, Winter.");
            //}
            #endregion
            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Employee eMP = new Employee();
            //eMP.Name = "Manar";
            //eMP.Age = 24;
            //eMP.Permissions = (Permissions)3;
            //Console.WriteLine($"{eMP.Permissions}");
            ////ADD Read
            //eMP.Permissions ^= Permissions.Read;
            //Console.WriteLine($"{eMP.Permissions}");
            ////DENY Read
            //eMP.Permissions ^= Permissions.Read;
            //Console.WriteLine($"{eMP.Permissions}");

            //if ((eMP.Permissions & Permissions.Excute) == Permissions.Excute)
            //{
            //    Console.WriteLine("Excute permission is granted.");

            //}
            //else
            //{
            //    eMP.Permissions ^= Permissions.Excute;
            //    Console.WriteLine($"{eMP.Permissions}");
            //}
            #endregion
            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not

            //Console.WriteLine("Enter a color (Red, Green, Blue):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{

            //    bool isPrimaryColor = IsPrimaryColor(color);
            //    if (isPrimaryColor)
            //    {
            //        Console.WriteLine($"{color} is a primary color.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{color} is not a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color. Please enter one of the following: Red, Green, Blue.");
            //}
            #endregion
            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them
            //Console.WriteLine("Enter the X coordinate of the first point:");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the first point:");
            //double y1 = double.Parse(Console.ReadLine());
            //Point point1 = new Point(x1, y1);

            //Console.WriteLine("Enter the X coordinate of the second point:");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the second point:");
            //double y2 = double.Parse(Console.ReadLine());
            //Point point2 = new Point(x2, y2);

            //double distance = point1.DistanceTo(point2);
            //Console.WriteLine($"The distance between the points ({point1.X}, {point1.Y}) and ({point2.X}, {point2.Y}) is {distance}");
            #endregion


        }
    }
}

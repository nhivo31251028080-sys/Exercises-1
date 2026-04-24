namespace Exercises_1
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                // 1. Sum Two Numbers
                double a = 5, b = 3;
                Console.WriteLine("1. Sum: " + (a + b));

                // 2. Swap Values
                int x = 10, y = 20;
                Console.WriteLine($"\n2. Before swap: x = {x}, y = {y}");
                int temp = x;
                x = y;
                y = temp;
                Console.WriteLine($"   After swap: x = {x}, y = {y}");

                // 3. Multiply Floating Numbers
                float f1 = 2.5f, f2 = 4.2f;
                Console.WriteLine("\n3. Multiply: " + (f1 * f2));

                // 4. Feet to Meter
                double feet = 10;
                double meter = feet * 0.3048;
                Console.WriteLine("\n4. Feet to Meter: " + meter);

                // 5. Celsius ↔ Fahrenheit
                double c = 25;
                double f = (c * 9.0 / 5) + 32;
                Console.WriteLine("\n5. Celsius to Fahrenheit: " + f);

                double f_input = 77;
                double c_result = (f_input - 32) * 5.0 / 9;
                Console.WriteLine("   Fahrenheit to Celsius: " + c_result);

                // 6. Size of Data Types
                Console.WriteLine("\n6. Size of Data Types:");
                Console.WriteLine("   int: " + sizeof(int));
                Console.WriteLine("   float: " + sizeof(float));
                Console.WriteLine("   double: " + sizeof(double));
                Console.WriteLine("   char: " + sizeof(char));
                Console.WriteLine("   bool: " + sizeof(bool));

                // 7. ASCII Value
                char ch = 'A';
                int ascii = (int)ch;
                Console.WriteLine("\n7. ASCII of 'A': " + ascii);

                // 8. Area of Circle
                double r = 5;
                double circleArea = Math.PI * r * r;
                Console.WriteLine("\n8. Area of Circle: " + circleArea);

                // 9. Area of Square
                double side = 4;
                double squareArea = side * side;
                Console.WriteLine("\n9. Area of Square: " + squareArea);

                // 10. Days to Years, Weeks, Days
                int days = 500;
                int years = days / 365;
                int weeks = (days % 365) / 7;
                int remainingDays = (days % 365) % 7;
                Console.WriteLine($"\n10. {days} days = {years} years, {weeks} weeks, {remainingDays} days");

                Console.ReadLine();
            }
        }
    }


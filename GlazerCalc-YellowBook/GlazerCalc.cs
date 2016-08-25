using System;
using System.IO;

namespace GlazerCalc_YellowBook
{
    class GlazerCalc
    {
        static void Main()
        {
            // Initialize variables needed to calculate and store the amount of wood
            double width, height, woodLength, glassArea; // descriptive enough in the name?
            string widthString, heightString;

            // Constants - measurements in feet
            const double MAXWIDTH = 5.0;
            const double MINWIDTH = 0.5;
            const double MAXHEIGHT = 3.0;
            const double MINHEIGHT = 0.75;

            // INPUT width and height

            do {
                Console.WriteLine("Enter the width in feet of the window between " + MINWIDTH + " and " + MAXWIDTH + " :");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
                
            } while (width < MINWIDTH || width > MAXWIDTH);

            do {
                Console.Write("Enter the height in feet of the window between " + MINHEIGHT + " and " + MAXHEIGHT + " :");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            } while (height < MINHEIGHT || height > MAXHEIGHT);

            // PROCESSING - calculate the woodLength and glassArea (give equations)
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            // OUTPUT  to screen
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square feet");

            // OUTPUT to file
            StreamWriter writer = new StreamWriter("glazerCalc.txt");
            string woodLengthString = Convert.ToString(woodLength);
            string glassAreaString = Convert.ToString(glassArea);
            writer.WriteLine(woodLengthString + ", " + glassAreaString);
            writer.Close();

        }
    }
}

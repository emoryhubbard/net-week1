using System;

class WindowCalculator {
    static void Main() {
        string name = "Emory Hubbard";
        string location = "Maryland";

        Console.WriteLine("My name is " + name
            + ", and I'm from " + location + ".");
        Console.WriteLine("Today's date is " +
            DateTime.Now.ToShortDateString() + ".");

        DateTime today = DateTime.Now;
        DateTime xmas = new DateTime(today.Year, 12, 25);
        int tilXmas = xmas.DayOfYear - today.DayOfYear;

        Console.WriteLine("That means there are " + tilXmas
            + " days until Christmas!");

        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.WriteLine("OK enough of that. Now onto "
            + " the exciting field of window calculation. "
            + "\nWhat is the width of your window in feet? ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("What is the height of your window "
            + " in feet? ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " +
        woodLength + " feet.");
        Console.WriteLine("The area of the glass is " +
        glassArea + " square meters.");

        Console.ReadKey();
    }
}

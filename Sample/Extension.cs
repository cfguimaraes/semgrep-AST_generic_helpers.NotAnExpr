using System;
public static class Extension
{
    // The extension method does a simple proccessing in the input
    public static (int propA, int propB )? ManipulateInput(this string input) {
        string[] splited = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
        int propA = int.Parse(splited[0]);
        int propB = int.Parse(splited[1]);

        // It returns a tuple
        return (propA, propB);
    }
}
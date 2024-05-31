using System;

// This definition is now marked as partial
partial class Program {  
    public static void Main (string[] args) {
        const double cm_per_inch = 2.54;
        var inches = 15994;
        double centimeters = inches * cm_per_inch;        
        Console.WriteLine (centimeters +  " centimeters"); 
    }    
}
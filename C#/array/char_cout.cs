using System;

public class FirstNonRepeatingCharacter {
    public static void Main(string[] args) {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int[] charCount = new int[256];  

        foreach (char ch in input) {
            charCount[ch]++; 
        }

        foreach (char ch in input) {
            if (charCount[ch] == 1) {
                Console.WriteLine("First non-repeating character: " + ch);
                return; 
            }
        }

        Console.WriteLine("No non-repeating character found.");
    }
}

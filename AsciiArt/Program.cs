using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine().ToUpper();
        string[] displayArray = NewDisplayArray(H);
        char[] alphabetArray = NewAlphabetArray();

        string[] outputArray = ConvertStringToDisplay(T,displayArray,alphabetArray,L,H);

        PrintAnswer(outputArray);
    }

    static string[] NewDisplayArray(int H)
    {
        string[] displayArray = new string[H];
        for (int i = 0; i < H; i++)
        {
            displayArray[i] = Console.ReadLine();
        }
        return displayArray;
    }

    static char[] NewAlphabetArray ()
    {
        return ("ABCDEFGHIJKLMNOPQRSTUVWXYZ").ToCharArray();
    }

    static string[] ConvertStringToDisplay (string input, string[] displayArray, char[] alphabetArray, int L, int H)
    {
        string[] output = new string[H];
        foreach (char letter in input)
        {
            int letterIndex = Array.IndexOf(alphabetArray,letter);
            if (letterIndex == -1) { letterIndex = 26; }
            int scanPosition = L * letterIndex;
            
            for (int i = 0; i < H; i++)
            {
                output[i] += displayArray[i].Substring(scanPosition,L);
            } 
        }
        return output;
    }

    static void PrintAnswer (string[] outputArray)
    {
        foreach (string displayRow in outputArray)
        {
            Console.WriteLine(displayRow);
        }
    }
} 
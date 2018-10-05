using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();

        string binaryStringResult = ConvertToBinary(MESSAGE);
        // Console.Error.WriteLine(binaryStringResult);

        string unaryStringResult = ConvertToUnary(binaryStringResult);
        // Console.Error.WriteLine(unaryStringResult);

        Console.WriteLine(unaryStringResult);
    }

    // I got the idea from:
    // https://stackoverflow.com/questions/16659787/convert-string-to-binary-zeros-and-ones
    static string ConvertToBinary(string message)
    {
        string binaryString = "";
        foreach(char character in message) 
        {
            binaryString += Convert.ToString(character,2).PadLeft(7,'0'); 
        }
        return binaryString;
    }

    static string ConvertToUnary(string message)
    {
        List<string> result = new List<string>();
        int i = 0;
        int currentBitCount = 0;
        char currentBit;
        while (i < message.Length)
        {
            // Console.Error.WriteLine("Iteration " + i.ToString());
            currentBit = message[i];
            for (int j = i; j < message.Length; j++) 
            {
                if (message[j] == currentBit) // 
                {
                    currentBitCount++;
                    if (j == message.Length - 1) {
                        i = message.Length;
                        result.Add(sequenceToUnary(currentBit,currentBitCount));
                    }
                } else {
                    i = j;
                    result.Add(sequenceToUnary(currentBit,currentBitCount));
                    break;
                }
            }
            
            currentBitCount = 0;
        }

        return String.Join(" ",result.ToArray());
    }

    static string sequenceToUnary (char bit, int count)
    {
        string firstBlock = "";
        string secondBlock = "";
        
        // What the first block of unary is. Bit 0 is "00" and bit 1 is "0".
        if (bit == "0".ToCharArray()[0]) {
            firstBlock = "00";
        } else {
            firstBlock = "0";
        }

        // Print a zero "count" times.
        for (int i = 0; i < count; i++)
        {
            secondBlock += "0";
        }

        return firstBlock + ' ' + secondBlock;
    }
}

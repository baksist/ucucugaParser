using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ucucugaParser
{
    class Program
    {
        private const int lines = 6;
        private const int columns = 62133;
        
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../ya.txt", Encoding.UTF8);
            var matrix = new char[lines][];
            for (var i = 0; i < lines; i++)
            {
                matrix[i] = new char[columns];
                for (var j = 0; j < columns; j++)
                {
                    matrix[i][j] = (char)reader.Read();
                }
            }

            var decoded = "";
            
            var currentChar = new List<char[]>();
            for (var i = 1; i < columns;)
            {
                currentChar.Add(Enumerable.Range(0, matrix.GetLength(0)).Select(x => matrix[x][i]).ToArray());
                var c = Alphabet.FindChar(currentChar);
                if (c != null)
                {
                    decoded += c;
                    currentChar.Clear();
                }
                i++;
            }
            
            Console.WriteLine(decoded);
        }
    }
}

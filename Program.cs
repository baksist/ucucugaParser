using System.IO;
using System.Text;


namespace ucucugaParser
{
    class Program
    {
        private const int lines = 6;
        private const int columns = 62133;
        
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../ascii.txt", Encoding.UTF8);

            var matrix = reader.ReadToEnd().To2DCharArray();
            reader.Close();
            
            var decoded = "";
            int startPos = 0, endPos = 1;
            while (endPos < columns)
            {
                string c = null;
                while (c == null)
                {
                    var sample = new char[lines, endPos - startPos];
                    for (var i = 0; i < lines; i++)
                    {
                        for (var j = startPos; j < endPos; j++)
                        {
                            sample[i, j - startPos] = matrix[i, j];
                        }
                    }

                    c = Alphabet.FindChar(sample);
                    if (c == null)
                        endPos++;
                    else
                    {
                        startPos = endPos;
                        endPos = startPos + 1;
                        decoded += c;
                    }
                }
            }
            
            var writer = new StreamWriter("result.txt");
            writer.Write(decoded);
            writer.Close();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ucucugaParser
{
    public static class Alphabet
    {
        public static Dictionary<string, char[,]> alphabet = new Dictionary<string, char[,]>
        {
            {
                "а", ("╔══╗\n" +
                      "║╔╗║\n" +
                      "║╚╝║\n" +
                      "║╔╗║\n" +
                      "║║║║\n" +
                      "╚╝╚╝").To2DCharArray()
            },
            {
                "б", ("╔═══╗\n" +
                      "║╔══╝\n" +
                      "║╚══╗\n" +
                      "║╔═╗║\n" +
                      "║╚═╝║\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "в", ("╔══╗─\n" +
                      "║╔╗║─\n" +
                      "║╚╝╚╗\n" +
                      "║╔═╗║\n" +
                      "║╚═╝║\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "г", ("╔══╗\n" +
                      "║╔═╝\n" +
                      "║║──\n" +
                      "║║──\n" +
                      "║║──\n" +
                      "╚╝──").To2DCharArray()
            },
            {
                "д", ("─╔══╗─\n" +
                      "─║╔╗║─\n" +
                      "─║║║║─\n" +
                      "─║║║║─\n" +
                      "╔╝╚╝╚╗\n" +
                      "╚════╝").To2DCharArray()
            },
            {
                "e", ("╔═══╗\n" +
                      "║╔══╝\n" +
                      "║╚══╗\n" +
                      "║╔══╝\n" +
                      "║╚══╗\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "ё", ("╔╩═╩╗\n" +
                      "║╔══╝\n" +
                      "║╚══╗\n" +
                      "║╔══╝\n" +
                      "║╚══╗\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "ж", ("╔╗╔╗╔╗\n" +
                      "║║║║║║\n" +
                      "║╚╝╚╝║\n" +
                      "║╔╗╔╗║\n" +
                      "║║║║║║\n" +
                      "╚╝╚╝╚╝").To2DCharArray()
            },
            {
                "з", ("╔═══╗\n" +
                      "╚══╗║\n" +
                      "─╔═╝║\n" +
                      "─╚═╗║\n" +
                      "╔══╝║\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "и", ("╔╗╔╗\n" +
                      "║║║║\n" +
                      "║║║║\n" +
                      "║║╔║\n" +
                      "║╚╝║\n" +
                      "╚══╝").To2DCharArray()
            },
            {
                "й", ("╔╗╩╔╗\n" +
                      "║║─║║\n" +
                      "║║─║║\n" +
                      "║║─╔║\n" +
                      "║╚═╝║\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "к", ("╔╗╔══╗\n" +
                      "║║║╔═╝\n" +
                      "║╚╝║──\n" +
                      "║╔╗║──\n" +
                      "║║║╚═╗\n" +
                      "╚╝╚══╝").To2DCharArray()
            },
            {
                "л", ("─╔══╗\n" +
                      "─║╔╗║\n" +
                      "─║║║║\n" +
                      "─║║║║\n" +
                      "╔╝║║║\n" +
                      "╚═╝╚╝").To2DCharArray()
            },
            {
                "м", ("╔╗──╔╗\n" +
                      "║║──║║\n" +
                      "║╚╗╔╝║\n" +
                      "║╔╗╔╗║\n" +
                      "║║╚╝║║\n" +
                      "╚╝──╚╝").To2DCharArray()
            },
            {
                "н", ("╔╗╔╗\n" +
                      "║║║║\n" +
                      "║╚╝║\n" +
                      "║╔╗║\n" +
                      "║║║║\n" +
                      "╚╝╚╝").To2DCharArray()
            },
            {
                "о", ("╔══╗\n" +
                      "║╔╗║\n" +
                      "║║║║\n" +
                      "║║║║\n" +
                      "║╚╝║\n" +
                      "╚══╝").To2DCharArray()
            },
            {
                "п", ("╔══╗\n" +
                      "║╔╗║\n" +
                      "║║║║\n" +
                      "║║║║\n" +
                      "║║║║\n" +
                      "╚╝╚╝").To2DCharArray()
            },
            {
                "р", ("╔═══╗\n" +
                      "║╔═╗║\n" +
                      "║╚═╝║\n" +
                      "║╔══╝\n" +
                      "║║───\n" +
                      "╚╝───").To2DCharArray()
            },
            {
                "с", ("╔══╗\n" +
                      "║╔═╝\n" +
                      "║║──\n" +
                      "║║──\n" +
                      "║╚═╗\n" +
                      "╚══╝").To2DCharArray()
            },
            {
                "т", ("╔════╗\n" +
                      "╚═╗╔═╝\n" +
                      "──║║──\n" +
                      "──║║──\n" +
                      "──║║──\n" +
                      "──╚╝──").To2DCharArray()
            },
            {
                "у", ("╔╗╔╗\n" +
                      "║║║║\n" +
                      "║╚╝║\n" +
                      "╚═╗║\n" +
                      "─╔╝║\n" +
                      "─╚═╝").To2DCharArray()
            },
            {
                "ф", ("╔═════╗\n" +
                      "║─╔╦╗─║\n" +
                      "║─║║║─║\n" +
                      "║─╚╩╝─║\n" +
                      "╚═╗─╔═╝\n" +
                      "──╚═╝──").To2DCharArray()
            },
            {
                "х", ("╔══╗╔══╗\n" +
                      "╚═╗║║╔═╝\n" +
                      "──║╚╝║──\n" +
                      "──║╔╗║──\n" +
                      "╔═╝║║╚═╗\n" +
                      "╚══╝╚══╝").To2DCharArray()
            },
            {
                "ц", ("╔╗╔╗\n" +
                      "║║║║\n" +
                      "║║║║\n" +
                      "║║║║\n" +
                      "║╚╝║\n" +
                      "╚══╗").To2DCharArray()
            },
            {
                "ч", ("╔╗╔╗\n" +
                      "║║║║\n" +
                      "║╚╝║\n" +
                      "╚═╗║\n" +
                      "──║║\n" +
                      "──╚╝").To2DCharArray()
            },
            {
                "ш", ("╔╗╔╗╔╗\n" +
                      "║║║║║║\n" +
                      "║║║║║║\n" +
                      "║║║║║║\n" +
                      "║╚╝╚╝║\n" +
                      "╚════╝").To2DCharArray()
            },
            {
                "щ", ("╔╗╔╗╔╗\n" +
                      "║║║║║║\n" +
                      "║║║║║║\n" +
                      "║║║║║║\n" +
                      "║╚╝╚╝║\n" +
                      "╚════╗").To2DCharArray()
            },
            {
                "ъ", ("═╗───\n" +
                      "╗║───\n" +
                      "║╚══╗\n" +
                      "║╔═╗║\n" +
                      "║╚═╝║\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "ы", ("╔╗──╔╗\n" +
                      "║║──║║\n" +
                      "║╚══╣║\n" +
                      "║╔═╗║║\n" +
                      "║╚═╝║║\n" +
                      "╚═══╩╝").To2DCharArray()
            },
            {
                "ь", ("╔╗───\n" +
                      "║║───\n" +
                      "║╚══╗\n" +
                      "║╔═╗║\n" +
                      "║╚═╝║\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "э", ("╔═══╗\n" +
                      "╚══╗║\n" +
                      "─╔═╝╝\n" +
                      "─╚═╗╗\n" +
                      "╔══╝║\n" +
                      "╚═══╝").To2DCharArray()
            },
            {
                "ю", ("╔╗╔══╗\n" +
                      "║║║╔╗║\n" +
                      "║╚╝║║║\n" +
                      "║╔╗║║║\n" +
                      "║║║╚╝║\n" +
                      "╚╝╚══╝").To2DCharArray()
            },
            {
                "я", ("╔═══╗\n" +
                      "║╔═╗║\n" +
                      "║╚═╝║\n" +
                      "╚╗╔╗║\n" +
                      "─║║║║\n" +
                      "─╚╝╚╝").To2DCharArray()
            },
            {
                ".", ("──\n" +
                      "──\n" +
                      "──\n" +
                      "──\n" +
                      "╔╗\n" +
                      "╚╝").To2DCharArray()
            },
            {
                ",", ("──\n" +
                      "──\n" +
                      "──\n" +
                      "──\n" +
                      "╔╗\n" +
                      "╚╣").To2DCharArray()
            },
            {
                "!", ("╔╗\n" +
                      "║║\n" +
                      "║║\n" +
                      "╚╝\n" +
                      "╔╗\n" +
                      "╚╝").To2DCharArray()
            },
            {
                "?", ("╔═╗\n" +
                      "╚╗║\n" +
                      "╔╝║\n" +
                      "║╔╝\n" +
                      "╔╗─\n" +
                      "╚╝─").To2DCharArray()
            },
            {
                ":", ("──\n" +
                      "╔╗\n" +
                      "╚╝\n" +
                      "╔╗\n" +
                      "╚╝\n" +
                      "──").To2DCharArray()
            },
            {
                ";", ("──\n" +
                      "╔╗\n" +
                      "╚╝\n" +
                      "╔╗\n" +
                      "╚╣\n" +
                      "──").To2DCharArray()
            },
            {
                "+", ("────\n" +
                      "─╔╗─\n" +
                      "╔╝╚╗\n" +
                      "╚╗╔╝\n" +
                      "─╚╝─\n" +
                      "────").To2DCharArray()
            },
            {
                "-", ("────\n" +
                      "────\n" +
                      "╔══╗\n" +
                      "╚══╝\n" +
                      "────\n" +
                      "────").To2DCharArray()
            },
            {
                "=", ("─────\n" +
                      "╔═══╗\n" +
                      "╚═══╝\n" +
                      "╔═══╗\n" +
                      "╚═══╝\n" +
                      "─────").To2DCharArray()
            },
            {
                "(", ("╔═╗\n" +
                      "║╔╝\n" +
                      "║║─\n" +
                      "║║─\n" +
                      "║╚╗\n" +
                      "╚═╝").To2DCharArray()
            },
            {
                ")", ("╔═╗\n" +
                      "╚╗║\n" +
                      "─║║\n" +
                      "─║║\n" +
                      "╔╝║\n" +
                      "╚═╝").To2DCharArray()
            },
            {
                "'", ("╔╗\n" +
                      "╚╝\n" +
                      "──\n" +
                      "──\n" +
                      "──\n" +
                      "──").To2DCharArray()
            },
            {
                " ", (" \n \n \n \n \n ").To2DCharArray()  // spacebar
            }
        };

        public static string FindChar(char[,] possibleLetter)
        {
            foreach (var item in alphabet)
            {
                var flag = true;

                if (possibleLetter.GetLength(0) == item.Value.GetLength(0) &&
                    possibleLetter.GetLength(1) == item.Value.GetLength(1))
                {
                    for (var i = 0; i < possibleLetter.GetLength(0); i++)
                    {
                        for (var j = 0; j < possibleLetter.GetLength(1); j++)
                        {
                            if (possibleLetter[i, j] != item.Value[i, j])
                                flag = false;
                        }
                    }

                    if (flag)
                        return item.Key;
                }
            }
            return null;
        }
        
        // debug functions to ensure that ASCII-art characters are stored correctly
        public static void DrawArt(string key)
        {
            var letter = alphabet[key];
            for (int i = 0; i < letter.GetLength(0); i++)
            {
                for (int j = 0; j < letter.GetLength(1); j++)
                {
                    Console.Write(letter[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void DrawAll()
        {
            foreach (var item in alphabet.Keys)
            {
                DrawArt(item);
                Console.WriteLine("-----------------------------");
            }
        }
    }

    // String class extension to convert ASCII-art characters to char[,] 
    public static class StringExtension
    {
        public static char[,] To2DCharArray(this String input)
        {
            var str_rows = input.Split("\n");
            var cols = str_rows[0].Length;

            var result = new char[6, cols];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = str_rows[i][j];
                }
            }
            return result;
        }
    }
}
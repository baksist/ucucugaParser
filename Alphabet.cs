using System;
using System.Collections.Generic;
using System.Linq;

namespace ucucugaParser
{
    public static class Alphabet
    {
        public static Dictionary<string, char[][]> alphabet = new Dictionary<string, char[][]>
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
                "д", ("─╔══╗\n" +
                      "─║╔╗║\n" +
                      "─║║║║\n" +
                      "─║║║║\n" +
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
                " ", (" \n \n \n \n \n ").To2DCharArray()  // spacebar
            },
            {
                "  ", ("  \n  \n  \n  \n  \n  ").To2DCharArray() // two spacebars
            }
            
        };

        public static string FindChar(List<char[]> charsList)
        {
            var flag = true;
            foreach (var item in alphabet)
            {
                flag = true;
                for (var i = 0; i < charsList.Count; i++)
                {
                   if (charsList[i].Equals(item.Value[i])) // error here: item.Value[i] is not a column but a row
                   {
                       // 
                   }
                   else
                   {
                       flag = false;
                       break;
                   }
                }

                if (flag)
                {
                    return item.Key;
                }
            }

            return null;
        }
        
        // debug functions that show that ASCII-art characters are stored correctly
        public static void DrawArt(string key)
        {
            foreach (var line in alphabet[key])
            {
                foreach (var c in line)
                {
                    Console.Write(c);
                }
                Console.Write('\n');
            }
        }

        public static void DrawAll()
        {
            foreach (var item in alphabet.Values)
            {
                foreach (var line in item)
                {
                    foreach (var c in line)
                    {
                        Console.Write(c);
                    }

                    Console.Write('\n');
                }
                Console.WriteLine("-----------------------------");
            }
        }
    }

    // String class extension to convert ASCII-art characters to char[][] 
    public static class StringExtension
    {
        public static char[][] To2DCharArray(this String input)
        {
            return input.Split("\n").Select(item => item.ToArray()).ToArray();
        }
    }
}
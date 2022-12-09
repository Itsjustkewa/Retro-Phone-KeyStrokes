
using Phone.Component;

// See https://aka.ms/new-console-template for more information

// Console.WriteLine("What's your name?");
// var name = Console.ReadLine();
// var currentDate = DateTime.Now;
// Console.WriteLine($"{Environment.NewLine}Hello, {name}, Today is {currentDate:d} at {currentDate:t}!");
// Console.Write($"{Environment.NewLine}Have a Lovely Evening, Please Press ANY key to exit...");
// Console.ReadKey(true);
// Console.WriteLine($"{y.Digits,-6}{string.Join("",y.Characters),6}");

// Preping the encoding/decoding
// var encodingTable = new List<(string, char)>{
//         ("ABC", '2'),
//         ("DEF", '3'),
//         ("GHI", '4'),
//         ("JKL", '5'),
//         ("MNO", '6'),
//         ("PQRS", '7'),
//         ("TUV", '8'),
//         ("WXYZ", '9'),
//         (" ", '0'),
//     };

// var encoder = new Dictionary<char, string> { };
// var decoder = new Dictionary<(char, int), char> { };
// foreach (var (letters, num) in encodingTable)
// {
//     var count = 1;
//     foreach (var letter in letters)
//     {
//         encoder.Add(letter, new string(num, count));
//         decoder.Add((num, count), letter);
//         count++;
//     }
// }
// // Defining Encoder/Decoder functions
// string Encode(string word)
// {
//     var encoding = "";
//     foreach (var letter in word)
//     {
//         var enc = encoder[letter];
//         if (encoding != "" && encoding.Last() == enc.First())
//         {
//             encoding += "_";
//         }
//         encoding += enc;
//     }
//     return encoding;
// }

// string Decode(string numbers)
// {
//     var nums = numbers.ToArray();
//     var count = 1;
//     var last = nums[0];
//     var decoding = "";
//     for (var i = 1; i < nums.Length; i++)
//     {
//         if (nums[i] == last)
//         {
//             count++;
//         }
//         else
//         {
//             if (count != 0)
//                 decoding += decoder[(nums[i - 1], count)];
//             if (nums[i] == '_')
//             {
//                 count = 0;
//             }
//             else
//             {
//                 count = 1;
//             }

//         }
//         last = nums[i];
//     }
//     decoding += decoder[(nums.Last(), count)];
//     return decoding;
// }

// // Command line program
// if (args.Length < 2)
// {
//     Console.WriteLine("Provide 2 arguments, either (encode WORD) or (decode WORD)");
// }
// else if (args[0] == "encode")
// {
//     Console.WriteLine(Encode(args[1].ToUpper()));
// }
// else if (args[0] == "decode")
// {
//     Console.WriteLine(Decode(args[1].ToUpper()));
// }
// else
// {
//     Console.WriteLine("Provide 2 arguments, either (encode WORD) or (decode WORD)");
// }

//PhoneText x = new();
Console.WriteLine(Environment.NewLine +"Please write a message you'd want either Encoded or Decoded");
var keyinp = Console.ReadLine();
PhoneText.UserInput(keyinp);

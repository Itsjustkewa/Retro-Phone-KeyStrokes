namespace Phone.Component
{
    public class PhoneText 
    {
        public static void UserInput(string _input)
        {
            var message = _input.ToArray();
            if(!message.Any())return;
            if(!OnlyNumberInputTable().Contains(message[0]))
            {
                //run the encoder function
                List<char> _result = Encoder(_input);
                List<char> _resultWithUnderScore = EncoderWithUnderScore(_input);
                Console.WriteLine($"{Environment.NewLine}{"Encoded Message : "}{string.Join("",_result),2}");
                Console.WriteLine($"{Environment.NewLine}{"Encoded Message With Underscore : "}{string.Join("",_resultWithUnderScore),2}");
            }
            else
            {
                //run the decoder function
                List<char> _resultDecoded = Decoder(_input);
                Console.WriteLine($"{Environment.NewLine}{"Decoded Message : "}{string.Join("",_resultDecoded),2}");
            }
        }
        
        private static List<char> Encoder(string _input)
        {
            //Input 
            string toUpperCase = _input.ToUpper();
            char[] stringInput = toUpperCase.ToCharArray();
            
            List<char> _encodedMessage = new();

            for(int a=0;a< stringInput.Length;a++)
            {
                foreach(KeyboardLayout keys in Table())
                {
                    for(int i = 0; i< keys.Letters.Length; i++)
                    {   
                        if(keys.Letters.Contains(stringInput[a]))
                        {
                            _encodedMessage.Add(keys.Number);
                            if(stringInput[a] == keys.Letters[i])break;
                        }
                    }
                }
            }
            return _encodedMessage;
        }

        private static List<char> EncoderWithUnderScore(string _input)
        {
            //Input 
            string toUpperCase = _input.ToUpper();
            char[] stringInput = toUpperCase.ToCharArray();
            
            List<char> _encodedMessage = new();

            bool newLetter;

            for(int a=0;a< stringInput.Length;a++)
            {
                newLetter = true;
                foreach(KeyboardLayout keys in Table())
                {
                    for(int i = 0; i< keys.Letters.Length; i++)
                    {   
                        if(keys.Letters.Contains(stringInput[a]))
                        {
                            if(_encodedMessage.Any() && newLetter && _encodedMessage.Last()== keys.Number)
                            {
                                _encodedMessage.Add('_');
                            }
                            _encodedMessage.Add(keys.Number);
                            newLetter = false;
                            if(stringInput[a] == keys.Letters[i])break;
                        }
                    }
                }
            }
            return _encodedMessage;
        }

        private static List<char> Decoder(string _input)
        {
            List<char> _decodeMessage = new();
            var number = _input.ToArray();
            int occurance = new ();
            int previousElement = new();
            
            for (int a= 0; a< number.Length;a++)
            {
                //to avoid the being out of range
                if (a - 1 > -1)
                {
                    previousElement = number[a - 1];
                    //check if the pervious element is the same as the current one
                    if (previousElement == number[a])
                    {
                        occurance += 1;

                        if(_decodeMessage.Any())
                        {
                            //remove the previouly added value if in the same index
                            var lastCount = _decodeMessage.Count-1;
                            _decodeMessage.RemoveAt(lastCount);
                        }
                    }
                    else
                    {
                        occurance = 0;
                    }
                }    
                else
                {
                    previousElement = number[a];
                    occurance = 0;
                }

                //decoding process 
                foreach (KeyboardLayout keys in Table())
                {
                    if(number[a]== '_')break;
                    if(keys.Number == number[a])
                    {
                        for(int i = 0; i<keys.Letters.Length;i++)
                        {
                            if(i==occurance)
                            {
                                _decodeMessage.Add(keys.Letters[occurance]);
                                break;
                            }
                        }
                    }
                }
            }
            return _decodeMessage;
        }

///<summary>
/// Returns the int from the Table with an added "_" 
///</summary>
        private static List<char> OnlyNumberInputTable()
        {
            List<char> _intInput = new();
            foreach(KeyboardLayout keys in Table())
            {
                _intInput.Add(keys.Number);
            }
            _intInput.Add('_');
            return _intInput;
        }

///<summary>
///Returns the Keypad List  
///</summary>
        private static List<KeyboardLayout> Table()
        {
            List<KeyboardLayout> Keyboard = new();
            var keys = new KeyboardLayout
            {
                Number = '2',
                Letters = new char[] {'A','B','C'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '3',
                Letters = new char[] {'D','E','F'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '4',
                Letters = new char[] {'G','H','I'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '5',
                Letters = new char[] {'J','K','L'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '6',
                Letters = new char[] {'M','N','O'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '7',
                Letters = new char[] {'P','Q','R','S'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '8',
                Letters = new char[] {'T','U','V'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '9',
                Letters = new char[] {'W','X','Y','Z'}
            };
            Keyboard.Add(keys);

            keys = new KeyboardLayout
            {
                Number = '0',
                Letters = new char[] {' '}
            };
            Keyboard.Add(keys);

            return Keyboard;
        }
    }


///<summary>
///Takes in and returns the char as both Numbers and Letters 
///</summary>
    public struct KeyboardLayout
    {
        public char Number{get;set;}
        public char [] Letters {get;set;}
    }
}
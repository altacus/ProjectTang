namespace FirstConsole
{
    class Program
    {
        /// <summary>
        /// In the previous program, the program took in a number that user typed in.
        /// It then returned a particular digit from that number, first being the first digit, 
        /// and then you updated it to be the 2nd digit.
        /// 
        /// We are going to update the program to have the digit that is parsed/returned be determined
        /// by the user before they enter the number.
        /// 
        /// Desired program description
        /// The following program will ask the user to enter 2 numbers.  The first number will determine 
        /// the digit to return.  The 2nd number will be the number whose digit is returned.
        /// 
        /// Desired output example
        ///    first number entered:    1
        ///    second number entered:   12546
        ///    answer :                 1
        ///    
        ///    first number entered:    3
        ///    second number entered:   12546
        ///    answer :                 5
        ///    
        /// I have updated to program to read the 2 inputs and passed them to the ParseString method.
        /// If you run the program as is, despite what you enter in as a first number, the result
        /// will always return the 2nd digit. Update the program so it has the desired output above.
        /// 
        /// The ParseString Method is mostly the same as before.  
        /// The only "true" changes is the addtional parameter.
        /// 
        /// Hint: Do not change anything in the Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // I am setting a string to null.  Why?
            string digitToParse = null;

            // Please notice the nifty while loop
            while (digitToParse != "")
            {
                System.Console.WriteLine("Press enter a digit that you want to parse");
                System.Console.WriteLine("Press enter to exit");
                digitToParse = System.Console.ReadLine();

                // This kind of looks the the while statement... right?
                if (digitToParse != "")
                {
                    /* Where did we see this int.Parse thing before.  What is different about this? */
                    int parsedDigit = int.Parse(digitToParse);
                    System.Console.WriteLine("Please enter a number to parse the digit from");
                    string typedText = System.Console.ReadLine();
                    int result = ParseString(typedText, parsedDigit);
                    System.Console.WriteLine("After parsing, we get the answer {0}", result);
                }
            }
        }

        /// <summary>
        /// Note the additional parameter.  Use the parameter to get the desired output.
        /// 
        /// note the code below is logically equivalent to the code before.  I just condensed 
        /// some of the statements.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="digitToParse"></param>
        /// <returns></returns>
        static int ParseString(string s, int digitToParse)
        {
            int result = -1;

            // hint, change something in the next line
            if (s.Length > digitToParse-1)
            {
                // hint, change something in the next line
                result = int.Parse (s[digitToParse-1].ToString());
            }

            return result;
        }
    }
}

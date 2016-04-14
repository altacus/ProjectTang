namespace FirstConsole
{
    class Program
    {
        /// <summary>
        /// This is a simple program.  When you run it, it'll display a message asking to 
        /// input a sequence of numbers.  After inputing numbers and hitting enter,
        /// it'll take what you entered and store it in a string variable called typedText.
        /// It'll then pass this string variable into a method called ParseString.
        /// 
        /// Currently, the parse string will return the first digit of what you input
        /// or it'll return -1 if you entered nothing.
        /// 
        /// Assignment - Run this program with the following input.  Email me the results of each input. 
        /// If something odd happens, tell me why you think it happened.
        ///     1. 1
        ///     2. (just press enter with no text)
        ///     3. 0
        ///     4. 45
        ///     5. AbC
        ///     6. -21
        ///     
        /// Assignment - Currently, the method ParseString will return the first character of the 
        ///     input text if it exists.  Change this method to examine the 2nd digit it exists.
        ///     if only 1 digit exists, return -1.
        ///     After you have this working, document the results of the above input with 
        ///     this 2nd version.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /* Display message to user */
            System.Console.WriteLine("Please enter a number");
            /* Declare variable of type string named typedText */
            string typedText;
            /* Set variable, typedText to what user inputed */
            typedText = System.Console.ReadLine();

            /* declare integer variable named result */
            int result;
            /* Pass the variable typedText into the method ParseString and set
               the result of the method call to the variable named result */
            result = ParseString(typedText);

            /* Display the result of the method call */
            System.Console.WriteLine("After parsing, we get the answer {0}", result);

            // Code to pause the console to so you can read result
            System.Console.WriteLine("Press enter to exit");
            System.Console.ReadLine();
        }


        /// <summary>
        /// for the 2nd part of the assigment, you only need to change the code in here.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int ParseString(string s)
        {
            /* declare an integer variable named result and set the value to -1 
                Hint - this SHOULD NOT change for 2nd part of the assignment */
            int result = -1;

            /* Check the length of string.  If the length is greater than 0 then
               perform actions within brackets 
               Hint - this condition SHOULD change for 2nd part of the assignment */
            if (s.Length > 0)
            {
                /* Declare a string variable named firstDigit.  
                   Set firstDigit to value of variable's s first digit 
                   Hint - this SHOULD change for 2nd part of the assignment */
                string firstDigit = s[0].ToString();
                /* use a system function to convert the string to an integer variable 
                    Hint - this SHOULD NOT change for 2nd part of the assignment */
                result = int.Parse(firstDigit);
            }

            /* return the result 
                Hint - this SHOULD NOT change for 2nd part of the assignment */
            return result;
        }
    }
}

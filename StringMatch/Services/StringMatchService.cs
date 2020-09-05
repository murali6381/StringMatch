namespace StringMatch.Services
{
    using System;
    using System.Text;

    
    public class StringMatchService : IStringMatchService
    {
        //Creating class to match the two strings 
        
        public string FindStartingIndex(string inputString, string subString)
        {
            // Check for null 
            if (inputString == null) throw new ArgumentNullException("inputString");
            if (subString == null) throw new ArgumentNullException("subString");

            // Check for empty occurences, result is an empty string
            if (inputString == string.Empty) return string.Empty;
            if (subString == string.Empty) return string.Empty;

            string result = KMP_Match(inputString, subString);

            return result == string.Empty ? "No match found" : result;
        }

        //perform case insensitive matching
        public bool MatchCaseInsenitive(char a, char b)
        {
            return char.ToUpper(a) == char.ToUpper(b);
        }

        //Using Knuth Morris Pratt algorithm for srting search

        private string KMP_Match(string inputString, string subString)
        {
            StringBuilder result = new StringBuilder();

            
            // Get the length of the two strings
            var inputStringSize = inputString.Length;
            var subStringSize = subString.Length;

            // get the index of the strings
            var subStringMarker = 0;
            var inputStringMarker = 0;

            // loop till the end of the text
            while (inputStringMarker < inputStringSize)
            {

                if (MatchCaseInsenitive(inputString[inputStringMarker], subString[subStringMarker]))
                {
                    subStringMarker++; // go to the next substring position
                    inputStringMarker++; // go to the next inputstring position

                    // if end of the subString is reached
                    if (subStringMarker == subStringSize)
                    {
                       
                        result.AppendFormat("{0},",(inputStringMarker - subStringSize) + 1);
                       
                        subStringMarker = 0;
                    }
                }


                else if (subStringMarker > 0) //Not reached the end of the string
                    subStringMarker = 0;

                else
                    inputStringMarker++;
            }

            return result.ToString().TrimEnd(',');
        }
    }
}
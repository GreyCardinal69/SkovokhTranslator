using System;
using System.Text;

namespace Skovokh_Translator
{
    public class TranslationTools
    {
        public static string NonLettersOnly ( string word )
        {
            StringBuilder result = new();

            foreach (var val in word)
                if (!char.IsLetter( val ))
                    result.Append( val );

            return result.ToString();
        }

        public static string NonLetterSkovokhOnly ( string word )
        {
            StringBuilder result = new();

            foreach (var val in word)
                if (IsNonLetterSkovokh( val ))
                    result.Append( val );

            return result.ToString();
        }

        public static string LettersOnly ( string word )
        {
            StringBuilder result = new();

            foreach (var val in word)
                if (char.IsLetter( val ) && !IsNonLetterSkovokh( val ))
                    result.Append( val );

            return result.ToString();
        }

        public static bool IsNonLetterSkovokh ( char ch )
        {
            return ch == ' '  ||
                   ch == ','  ||
                   ch == '.'  ||
                   ch == ':'  ||
                   ch == ')'  ||
                   ch == '('  ||
                   ch == '*'  ||
                   ch == '\'' ||
                   ch == '"'  ||
                   ch == '?'  ||
                   ch == '!';
        }

        public static bool ImperfectLatinSkovokh ( String str )
        {
            bool letter = false;
            bool none = false;
            foreach (var item in str)
            {
                if (!IsNonLetterSkovokh( item ))
                    letter = true;
                if (IsNonLetterSkovokh( item ))
                    none = true;
            }
            return none == true && letter == true;
        }

        public static void VowelRuleSolver ( string[] lines, ref bool[] useCuts )
        {
            // dEHR
            // d EH R
            // di ei ro    e after i
            // removes i
            // d ei ro
            // vovels after: a, e, i, o, u
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length == 1)
                {
                    if (IsNonLetterSkovokh( char.Parse( lines[i] ) ))
                    {
                        continue;
                    }
                }
                if (Mappings.VowelRuleLetters.Contains( lines[i] ))
                {
                    if (i + 1 <= lines.Length - 1)
                    {
                        if (Mappings.VowelTriggers.Contains( lines[i + 1] ))
                        {
                            useCuts[i] = true;
                        }
                    }
                }
            }
        }

        public static string LatinSkovokhSlicer ( string str )
        {
            var maps = Mappings.LatinToSkovokhMappings;
            StringBuilder final = new();
            string last = "";
            string resultAsString = str;

            for (int i = 0; i < resultAsString.Length; i++)
            {
                var charc = resultAsString[i];

                // checks if the character is "!", ".", ",", ":", """, "'", "(",")" or "?".
                if (IsNonLetterSkovokh( charc ))
                {
                    // appends the current content of "last", the current char, since concatenation to last is done after the method
                    // finally appends "_" which is letter used to split the characters.
                    final.Append( last ).Append( charc ).Append( '_' );
                    // reset
                    // skips iteration to avoid bugs and incorrect additional concatenations.
                    last = "";
                    continue;
                }

                last += charc;

                // done when "last" has 2 characters, needed for pair latin character checking.
                if (last.Length > 1)
                {
                    // if the mappings contant the current pair of characters
                    // appends the pair and a delimeter for later
                    // skip current loop iteration to avoid errors.
                    if (maps.ContainsKey( last ))
                    {
                        final.Append( last ).Append( '_' );
                        last = "";
                        continue;
                    }

                    // pair is not a valid pair, takes the first character of the pair.
                    string first = last[0].ToString();

                    // checks if the mappings contain a valid entry for the first character of the pair.
                    if (maps.ContainsKey( first ))
                    {
                        // checks if the first + the next character dont make a valid pair
                        // if they dont append the first character with a delimeter.
                        if (i < resultAsString.Length - 1)
                        {
                            if (!maps.ContainsKey( first + resultAsString[i + 1] ))
                            {
                                // appends the first character with a delimeter
                                // removes the first character from "last".
                                final.Append( last[0] ).Append( '_' );
                                last = last[1..];
                                continue;
                            }
                            else
                            {
                                final.Append( first + resultAsString[i + 1] ).Append( '_' );
                                last = last[1..];
                            }
                        }
                        // checks if the second character of the pair is a valid entry
                        // and checks that a pair of the second character and the next character in the string is not a valid pair
                        // if both are true appends the second character too.
                        if (maps.ContainsKey( first ) && !maps.ContainsKey( first + resultAsString[i + 1] ))
                        {
                            final.Append( last[0] ).Append( '_' );
                            last = last[1..];
                            continue;
                        }
                        // skip iteration.
                        continue;
                    }

                    // this check is done if both the pair is not a valid entry and
                    // only the first character of the pair is valid ( second character + next is a valid pair ).
                    if (maps.ContainsKey( last[1].ToString() ))
                    {
                        // checks if the second character is not the last character in the text
                        if (i < resultAsString.Length - 1)
                        {
                            // checks if a valid pair exists.
                            // the pair consists of the second character of the current pair
                            // and the next character in the text
                            if (maps.ContainsKey( last + resultAsString[i + 1] ))
                            {
                                final.Append( last + resultAsString[i + 1] ).Append( '_' );
                                last = "";
                                continue;
                            }
                        }
                        // appends the second character of the current pair.
                        // either it is the last in the text
                        // or no valid pair exists of this character + the next in the text.
                        final.Append( last[1] ).Append( '_' );
                        last = last[..1];
                        continue;
                    }
                }
            }
            if (last.Length != 0)
            {
                final.Append( last ).Append( '_' );
            }
            return final.ToString();
        }
    }
}
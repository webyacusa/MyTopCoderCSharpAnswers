using System;
using System.Collections.Generic;

public class Lexer
{
	public string[] tokenize(string[] tokens, string input)
    {        
            var currentNumOfChars = 1;
            var misses = 0;
            var output = new List<string>();      
            var currentMatch = string.Empty;        
            while (!string.IsNullOrEmpty(input))
            {
                var currentCandidate = (input.Substring(0, currentNumOfChars));           
                
                foreach (var token in tokens)
                {
                    if (token.StartsWith(currentCandidate))
                    {
                        if (token == currentCandidate)
                        {
                            currentMatch = token;                    
                        }
                    }
                    else
                    {
                        misses++;
                    }
                }
            
                if (misses == tokens.Length)
                {
                    if (currentMatch != string.Empty)
                    {
                        output.Add(currentMatch);                    
                        currentNumOfChars =  currentMatch.Length;                    
                        currentMatch = string.Empty;
                    }
                    else
                    {
                        if (currentNumOfChars > 1)
                        {
                            currentNumOfChars--;
                        }
                    }
                    input = input.Substring(currentNumOfChars);
                    currentNumOfChars = 0;
                }
                currentNumOfChars++;
                misses = 0;

                if (currentNumOfChars > input.Length)
                {
                    break;
                }
            }

            if (currentMatch != string.Empty)
            {
                output.Add(currentMatch);     
            }
        
            return output.ToArray();
        }
}

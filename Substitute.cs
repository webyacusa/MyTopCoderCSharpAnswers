using System;
using System.Collections.Generic;

public class Substitute
{
	public static int getValue(string key, string code)
    {
        var dictionary = new Dictionary<string, string>();
        //get the key inside the dictionary
        
        for (int i = 0; i < key.Length ; i++)
        {
            if (i+1 == key.Length)
            {
            	dictionary.Add(key.Substring(i, 1), "0");    
            }
            else
            {
            	dictionary.Add(key.Substring(i, 1), (i+1).ToString());
            }
        }        
        
        //get the value
        var substitutedValue = "";
        for (int i = 0; i < code.Length ; i++)
        {
            if (dictionary.ContainsKey(code.Substring(i, 1)))
            {
                substitutedValue += dictionary[code.Substring(i, 1)]; 
            }
        }
        
    	return Convert.ToInt32(substitutedValue);
    }
}

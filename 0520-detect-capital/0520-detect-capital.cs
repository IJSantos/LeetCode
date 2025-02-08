public class Solution {
    public bool DetectCapitalUse(string word) {


        // Verifica se todo word é Upper
        if (word.ToUpper() == word)
           return true;

        // Verifica se todo word é Lower
        if (word.ToLower() == word)
           return true;

        if (char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1))
           return true;

         return false;    
       
        
    }
}
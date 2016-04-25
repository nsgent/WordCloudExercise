namespace Gent_WordCloudExercies.Utilities
{
    public static class UtilityMethods
    {
        /// <summary>
        /// Removes any non-letter characters at the start or end of each word
        /// </summary>
        /// <param name="word">the word from which punctuation is being removed</param>
        /// <returns>word without punctuation</returns>
        internal static string RemovePunctuation(string word)
        {
            //the only way to break out of this while loop is if the word is/becomes an empty string
            //or the first and last characters are both letters
            while (true)
            {
                if (word.Equals(""))
                {
                    return word;
                }

                char firstCharacter = word[0];
                char lastCharacter = word[word.Length - 1];

                if (!char.IsPunctuation(firstCharacter) && !char.IsPunctuation(lastCharacter))
                {
                    return word;
                }

                if (char.IsPunctuation(firstCharacter))
                {
                    word = word.Substring(1);
                }

                if (char.IsPunctuation(lastCharacter) && word.Length > 0)
                {
                    word = word.Substring(0, word.Length - 1);
                }
            }
        }
    }
}

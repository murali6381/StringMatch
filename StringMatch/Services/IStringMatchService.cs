namespace StringMatch.Services
{
    /// <summary>
    /// Service class to implement the Text match Services.
    /// </summary>
    public interface IStringMatchService
    {
        /// <summary>
        /// Method to perform the pattern match. Looks for the occurences of the <paramref name="subString"/>
        /// in the <paramref name="inputString"/> and returns a comma separated string with the <paramref name="inputString"/>
        /// string 1-based indexes.
        /// </summary>
        /// <param name="inputString">The Input string which will be used to search for the <paramref name="subString"/></param>
        /// <param name="subString">The pattern string whose occurances will be search for in the <paramref name="inputString"/>.</param>
        /// <returns>A comma separated string with the occurences of the <paramref name="subString"/> in the <paramref name="inputString"/></returns>
        string FindStartingIndex(string inputString, string subString);
    }
}

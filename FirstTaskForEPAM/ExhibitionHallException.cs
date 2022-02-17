namespace FirstTaskForEPAM
{
    /// <summary>
    /// Custom exception class that fires on errors associated with objects of class "Exhibition hall"
    /// </summary>
    public class ExhibitionHallException : Exception
    {
        /// <summary>
        /// Constructor of the exception
        /// </summary>
        /// <param name="message">Message of the exception</param>
        public ExhibitionHallException(string message) : base(message) { }
    }
}

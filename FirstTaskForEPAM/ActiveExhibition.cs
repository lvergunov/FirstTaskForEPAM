namespace FirstTaskForEPAM
{
    /// <summary>
    /// A class for storing information about the current exhibition for a given painting. Base class for class "exhibition"
    /// </summary>
    public class ActiveExhibition : IExhibition
    {
        /// <summary>
        /// Exhibition start date
        /// </summary>
        public DateTime DateOfBeginning { get; }
        /// <summary>
        /// Constructor of this class
        /// </summary>
        /// <param name="exhibitionBeginning">Given param of date</param>
        public ActiveExhibition(DateTime exhibitionBeginning)
        {
            DateOfBeginning = exhibitionBeginning;
        }
    }
}

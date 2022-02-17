namespace FirstTaskForEPAM
{
    /// <summary>
    /// Struct that contains information about finished ehhibition
    /// </summary>
    public class FinishedExhibition : ActiveExhibition
    {
        /// <summary>
        /// Date of exhibition's end
        /// </summary>
        public DateTime DateOfEnding { get; }
        /// <summary>
        /// Property that counts and returns duration of exhibition
        /// </summary>
        public TimeSpan DurationOfExhibition { get { return DateOfEnding - DateOfBeginning; } }
        /// <summary>
        /// Constructor of this and base class
        /// </summary>
        /// <param name="begining">Date of exhibition beginning</param>
        /// <param name="end">Date of exhibition end</param>
        public FinishedExhibition(DateTime begining, DateTime end) : base(begining)
        {
            DateOfEnding = end;
        }
    }
}
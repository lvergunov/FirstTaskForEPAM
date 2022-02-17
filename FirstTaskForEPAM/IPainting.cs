
namespace FirstTaskForEPAM
{
    /// <summary>
    /// Interface containing properties for a class of type "painting"
    /// </summary>
    public interface IPainting
    {
        /// <summary>
        /// Property returning the value of paint direction
        /// </summary>
        string Direction { get; }
        /// <summary>
        /// Property returning the value of paint genre
        /// </summary>
        string Genre { get; }
        /// <summary>
        /// Property returning the value of author's name
        /// </summary>
        string NameOfAuthor { get; }
        /// <summary>
        /// Property returning the value of painting's name
        /// </summary>
        string NameOfPainting { get; }
        /// <summary>
        /// Property returning the value of painting's year of creation
        /// </summary>
        ushort YearOfCreation { get; }
        /// <summary>
        /// Method adding any list of exhibition story
        /// </summary>
        /// <param name="exhibitions">List of exhibitions</param>
        void AddHistoryOfExhibition(List<ActiveExhibition> exhibitions);
        /// <summary>
        /// Method that adds one exhibition by counting inner values
        /// </summary>
        /// <param name="dayBegin">day of exhibition's beginning</param>
        /// <param name="monthBegin">month of exhibition's beginning</param>
        /// <param name="yearBegin">year of exhibition's beginning</param>
        /// <param name="dayEnd">day of exhibition's end</param>
        /// <param name="monthEnd">month of exhibition's end</param>
        /// <param name="yearEnd">year of exhibition's end</param>
        void AddHistoryOfExhibition(ushort dayBegin, ushort monthBegin, ushort yearBegin, ushort dayEnd, ushort monthEnd, ushort yearEnd);
    }
}
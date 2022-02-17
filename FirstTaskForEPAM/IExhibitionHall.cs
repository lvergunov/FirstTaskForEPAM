namespace FirstTaskForEPAM
{
    /// <summary>
    /// Interface containing properties for a class of type "exhibition hall"
    /// </summary>
    public interface IExhibitionHall
    {
        /// <summary>
        /// Property returning the value of hall's number
        /// </summary>
        string NameOfHall { get; }
        /// <summary>
        /// Property returning the value of hall's name
        /// </summary>
        ushort NumberOfHall { get; }
    }
}
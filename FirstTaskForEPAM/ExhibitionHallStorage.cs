namespace FirstTaskForEPAM
{
    /// <summary>
    /// Class with storage of all exhibition halls
    /// </summary>
    public static class ExhibitionHallStorage
    {
        /// <summary>
        /// Storage of all exhibition halls
        /// </summary>
        public static Dictionary<ushort,IExhibitionHall> halls = new Dictionary<ushort,IExhibitionHall>();
    }
}

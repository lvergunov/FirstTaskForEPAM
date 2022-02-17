namespace FirstTaskForEPAM
{
    /// <summary>
    /// Class that contains information about exhibition hall
    /// </summary>
    public class ExhibitionHall : IExhibitionHall
    {
        /// <summary>
        /// Property returning the value of hall's number
        /// </summary>
        public ushort NumberOfHall { get; }
        /// <summary>
        /// Property returning the value of hall's name
        /// </summary>
        public string NameOfHall { get; }
        /// <summary>
        /// Constructor that creates an instance of the exhibition hall
        /// </summary>
        /// <param name="numberOfHall">Value of hall's number</param>
        /// <param name="nameOfHall">Value of hall's name</param>
        public ExhibitionHall(ushort numberOfHall, string nameOfHall = "")
        {
            if (InformationCollector.DoesHallExists(numberOfHall))
                throw new ExhibitionHallException("Hall with this number has been created yet.");
            else
            {
                NumberOfHall = numberOfHall;
                NameOfHall = nameOfHall;
                ExhibitionHallStorage.halls.Add(numberOfHall,this);
            }
        }
    }
}

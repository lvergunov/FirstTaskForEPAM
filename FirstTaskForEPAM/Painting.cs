using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// Abstract class that contains total information about all type of paintings
    /// </summary>
    public abstract class Painting
    {
        /// <summary>
        /// Property returning the value of painting's name
        /// </summary>
        public string NameOfPainting { get; }
        /// <summary>
        /// Property returning the value of painting's author
        /// </summary>
        public string NameOfAuthor { get; }
        /// <summary>
        /// Property returning the value of painting's genre
        /// </summary>
        public string Genre { get; }
        /// <summary>
        /// Property returning the value of painting's direction
        /// </summary>
        public string Direction { get; }
        /// <summary>
        /// Property returning the value of painting's year of creation
        /// </summary>
        public ushort YearOfCreation { get; }
        /// <summary>
        /// List of information about exhibitions
        /// </summary>
        public List<FinishedExhibition> exhibitions = new List<FinishedExhibition>();
        /// <summary>
        /// Constructor that creates an instance of the "picture" class according to the main data
        /// </summary>
        /// <param name="name">Name of painting</param>
        /// <param name="author">Name of author</param>
        /// <param name="genre">Name of genre</param>
        /// <param name="direction">Name of direction</param>
        /// <param name="year">Value of year</param>
        public Painting(string name, string author, string genre, string direction, ushort year)
        {
            NameOfPainting = name;
            NameOfAuthor = author;
            Genre = genre;
            Direction = direction;
            YearOfCreation = year;
        }
        /// <summary>
        /// Constructor that creates an instance of the "picture" class from another instance of this class
        /// </summary>
        /// <param name="painting">Value of painting object</param>
        public Painting(Painting painting) {
            this.NameOfPainting = painting.NameOfPainting;
            this.NameOfAuthor = painting.NameOfAuthor;
            this.Genre = painting.Genre;
            this.Direction = painting.Direction;
            this.YearOfCreation = painting.YearOfCreation;
            this.exhibitions = painting.exhibitions;
        }
        /// <summary>
        /// Method that adds one exhibition by counting inner values
        /// </summary>
        /// <param name="dayBegin">day of exhibition's beginning</param>
        /// <param name="monthBegin">month of exhibition's beginning</param>
        /// <param name="yearBegin">year of exhibition's beginning</param>
        /// <param name="dayEnd">day of exhibition's end</param>
        /// <param name="monthEnd">month of exhibition's end</param>
        /// <param name="yearEnd">year of exhibition's end</param>
        public void AddHistoryOfExhibition(ushort dayBegin, ushort monthBegin, ushort yearBegin, ushort dayEnd, ushort monthEnd, ushort yearEnd)
        {
            try
            {
                DateTime begining = new DateTime(yearBegin, monthBegin, dayBegin);
                DateTime end = new DateTime(yearEnd, monthEnd, dayEnd);
                exhibitions.Add(new FinishedExhibition(begining, end));
            }
            catch { }
        }
        /// <summary>
        /// Method that accepts params of exhibition story as a "DateTime" objects
        /// </summary>
        /// <param name="firstDay">Date of the first day</param>
        /// <param name="lastDay">Date of the last day</param>
        public void AddHistoryOfExhibition(DateTime firstDay,DateTime lastDay) {
            exhibitions.Add(new FinishedExhibition(firstDay,lastDay));
        }
        /// <summary>
        /// Method that accepts params of exhibition story as a list 
        /// </summary>
        /// <param name="exhibitions">List of exhibitions</param>
        public void AddHistoryOfExhibition(List<ActiveExhibition> exhibitions)
        {
            exhibitions.AddRange(exhibitions);
        }
        /// <summary>
        /// Overrided method that gives information about main fields of current object
        /// </summary>
        /// <returns>String information</returns>
        public override string ToString()
        {
            return $"Painting called {NameOfPainting} was created by {NameOfAuthor} in {YearOfCreation}. " +
                $"Painting direction is {Direction}. Genre is {Genre}.";
        }
        /// <summary>
        /// Overrided method that allows you to compare the current object with the entered one
        /// </summary>
        /// <param name="obj">Entered object</param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is Painting pt)
            {
                return this.NameOfPainting == pt.NameOfPainting&&this.NameOfAuthor == pt.NameOfAuthor&&this.Genre == pt.Genre&&this.Direction == pt.Direction&&this.YearOfCreation == pt.YearOfCreation;
            }
            else return false;
        }
        /// <summary>
        /// Overrided method returning integer hash-code of current object. Used with method "Equals" 
        /// </summary>
        /// <returns>Integer hash-code of current object</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

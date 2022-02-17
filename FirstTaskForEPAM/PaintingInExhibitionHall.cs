using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// Class reflecting the state of the picture in the gallery
    /// </summary>
    public class PaintingInExhibitionHall : Painting
    {
        /// <summary>
        /// Property that returns the value of the exhibition hall where the painting is located
        /// </summary>
        public IExhibitionHall ExhibitionHall { get; private set; }
        /// <summary>
        /// Property that returns the value of position in exhibition hall where painting is located
        /// </summary>
        public ushort NumberOfPosition { get; private set; }
        /// <summary>
        /// Property that returns the start date of the current exhibition
        /// </summary>
        public ActiveExhibition ExhibitionBeginning { get; private set; }
        /// <summary>
        /// Instance constructor of the current class
        /// </summary>
        /// <param name="name">Name of painting</param>
        /// <param name="author">Name of author</param>
        /// <param name="genre">Genre of painting</param>
        /// <param name="direction">Painting direction</param>
        /// <param name="year">Year of painting's creation</param>
        /// <param name="hall">Object of hall where painting must be placed</param>
        /// <param name="pos">Number of position in hall</param>
        public PaintingInExhibitionHall(string name, string author, string genre, string direction, ushort year, IExhibitionHall hall, ushort pos) : base(name, author, genre, direction, year) {
            TakePlaceInExhibitionHall(hall,pos);
            PaintingStorage.paintings.Add(this);
        }
        /// <summary>
        /// Constructor that allows you to create an instance from another instance of the base class
        /// </summary>
        /// <param name="painting">Instance of base class</param>
        /// <param name="hall">Instance of hal where painting must be placed</param>
        /// <param name="pos">Number of position in hall</param>
        public PaintingInExhibitionHall(Painting painting,IExhibitionHall hall,ushort pos) : base(painting) {
            TakePlaceInExhibitionHall(hall,pos);
        }
        /// <summary>
        /// A method that allows you to move a painting to another location within the current room
        /// </summary>
        /// <param name="newPosition">Number of new position</param>
        /// <returns>A string indicating whether the object was placed successfully</returns>
        public string ChangePosition(ushort newPosition)
        {
            try {
                DateTime today = DateTime.Today;
                this.AddHistoryOfExhibition(this.ExhibitionBeginning.DateOfBeginning,today);
                TakePlaceInExhibitionHall(this.ExhibitionHall,newPosition);
                return "Position is changed";
            }
            catch(Exception ex) { return ex.Message; }
        }
        /// <summary>
        /// An internal class method that is given the opportunity to place an instance of a painting in a specific place in a specific room
        /// </summary>
        /// <param name="exhibitionHall">An instance of exhibition hall</param>
        /// <param name="position">Position in hall</param>
        /// <exception cref="PlaceIsTakenException">Exception which can be thrown if given place has been taken yet</exception>
        private void TakePlaceInExhibitionHall(IExhibitionHall exhibitionHall, ushort position)
        {
            foreach (Painting pt in PaintingStorage.paintings)
            {
                if (pt is PaintingInExhibitionHall painting && painting.ExhibitionHall == exhibitionHall && painting.NumberOfPosition == position)
                {
                    throw new PlaceIsTakenException("Current place is taken yet!");
                }
            }
            try
            {
                ActiveExhibition firstDayOfExhibition = new ActiveExhibition(DateTime.Today);
                this.ExhibitionHall = exhibitionHall;
                this.NumberOfPosition = position;
                this.ExhibitionBeginning = firstDayOfExhibition;
            }
            catch { }
        }
    }  
}

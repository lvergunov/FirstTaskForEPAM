using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// A class containing methods for searching for similar paintings by certain parameters
    /// </summary>
    public class Searcher
    {
        /// <summary>
        /// Method searching paintings with the same name
        /// </summary>
        /// <param name="name">Name of painting</param>
        /// <returns>List of similar painting</returns>
        public static List<Painting> FindPaintingByName(string name) {
            List<Painting> searched = new List<Painting>();
            foreach(Painting pt in PaintingStorage.paintings)
            {
                if (pt.NameOfPainting.ToLower()==name.ToLower()) {
                    searched.Add(pt);
                }
            }
            return searched;
        }
        /// <summary>
        /// Method searching painting of entered author
        /// </summary>
        /// <param name="author">Author's name</param>
        /// <returns>List of paintings</returns>
        public static List<Painting> FindPaintingByAuthor(string author) {
            List<Painting> searched = new List<Painting>();
            foreach (Painting pt in PaintingStorage.paintings)
            {
                if (pt.NameOfAuthor.ToLower() == author.ToLower())
                {
                    searched.Add(pt);
                }
            }
            return searched;
        }
        /// <summary>
        /// Method searching painting of entered genre
        /// </summary>
        /// <param name="genre">Genre name</param>
        /// <returns>List of paintings</returns>
        public static List<Painting> FindPaintingsByGenre(string genre)
        {
            List<Painting> searched = new List<Painting>();
            foreach (Painting pt in PaintingStorage.paintings)
            {
                if (pt.Genre.ToLower() == genre.ToLower())
                {
                    searched.Add(pt);
                }
            }
            return searched;
        }
        /// <summary>
        /// Method searching painting of entered direction
        /// </summary>
        /// <param name="direction">Name of direction</param>
        /// <returns>List of paintings</returns>
        public static List<Painting> FindPaintingsByDirection(string direction)
        {
            List<Painting> searched = new List<Painting>();
            foreach (Painting pt in PaintingStorage.paintings)
            {
                if (pt.Direction.ToLower() == direction.ToLower())
                {
                    searched.Add(pt);
                }
            }
            return searched;
        }
        /// <summary>
        /// Method that gives list of paintings which was created in the same year
        /// </summary>
        /// <param name="year">Year param</param>
        /// <returns>List of paintings</returns>
        public static List<Painting> FindPaintingsByYear(ushort year)
        {
            List<Painting> searched = new List<Painting>();
            foreach (Painting pt in PaintingStorage.paintings)
            {
                if (pt.YearOfCreation == year)
                {
                    searched.Add(pt);
                }
            }
            return searched;
        }
        /// <summary>
        /// Method that searches paintings similar to entered
        /// </summary>
        /// <param name="painting">An instance of painting</param>
        /// <returns>List of paintings</returns>
        public static List<Painting> FindSimilar(Painting painting)
        {
            List<Painting> searched = new List<Painting>();
            foreach(Painting pt in PaintingStorage.paintings)
            {
                if (Compare(painting,pt)&&painting!=pt)
                {
                    searched.Add(pt);
                }
            }
            return searched;
        }
        /// <summary>
        /// A method that checks whether the pictures are similar in at least one of their parameters
        /// </summary>
        /// <param name="p1">First painting object</param>
        /// <param name="p2">Second painting object</param>
        /// <returns>Comparison result</returns>
        private static bool Compare(Painting p1, Painting p2)
        {
            if (p1.NameOfAuthor.ToLower() == p2.NameOfAuthor.ToLower()) return true;
            if (p1.Genre.ToLower() == p2.Genre.ToLower()) return true;
            if (p1.Direction.ToLower() == p2.Direction.ToLower()) return true;
            if (p1.NameOfPainting.ToLower() == p2.NameOfPainting.ToLower()) return true;
            if (p1.YearOfCreation == p2.YearOfCreation) return true;
            return false;
        }
    }
}

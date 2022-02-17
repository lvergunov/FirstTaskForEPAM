using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// Class that groups all methods that return information about all existing paintings or halls
    /// </summary>
    public class InformationCollector
    {
        /// <summary>
        /// Method that can be used to recieve object of exhibition hall from storage by his number
        /// </summary>
        /// <param name="numberOfHall">Number of hall</param>
        /// <returns>Object of hall</returns>
        /// <exception cref="ExhibitionHallException">Can be thrown if there was introduced invalid number</exception>
        public static IExhibitionHall GetExhibitionHallObject(ushort numberOfHall)
        {
            if (ExhibitionHallStorage.halls.ContainsKey(numberOfHall))
                return ExhibitionHallStorage.halls[numberOfHall];
            else throw new ExhibitionHallException("Excuse me, but the hall with this number is missing");
        }
        /// <summary>
        /// Method that checks does exist hall with given number
        /// </summary>
        /// <param name="numberOfHall">Inner number of hall</param>
        /// <returns>True if hall exists, and false if not</returns>
        public static bool DoesHallExists(ushort numberOfHall)
        {
            try
            {
                GetExhibitionHallObject(numberOfHall);
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// Method that searches list of paintings which belongs to the same hall
        /// </summary>
        /// <param name="numberOfHall">Inner number of hall</param>
        /// <returns>List of paintings which belongs to the same hall</returns>
        public static List<Painting> GetPaintingsByTheirHall(ushort numberOfHall)
        {
            List<Painting> searchedPaintings = new List<Painting>();
            try
            {
                IExhibitionHall exhibitionHall = GetExhibitionHallObject(numberOfHall);
                foreach (Painting pt in PaintingStorage.paintings)
                {
                    if (pt is PaintingInExhibitionHall painting && painting.ExhibitionHall == exhibitionHall)
                        searchedPaintings.Add(pt);
                }
            }
            catch { }
            return searchedPaintings;
        }
        /// <summary>
        /// Method that gives an abililty to get an index of inner painting in total base 
        /// </summary>
        /// <param name="p">inner painting</param>
        /// <returns>Index of painting (returns -1 if painting does not exists)</returns>
        public static int FindIndexOfObject(Painting p) {
            for(int i = 0; i < PaintingStorage.paintings.Count; i++) {
                if (p == PaintingStorage.paintings[i]) return i;
            }
            return -1;
        } 
    }
}

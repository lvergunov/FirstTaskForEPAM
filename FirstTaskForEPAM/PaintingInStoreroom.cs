using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// A class that displays the state of a painting in storage
    /// </summary>
    public class PaintingInStoreroom : Painting
    {
        /// <summary>
        /// Method that adds one exhibition by counting inner values
        /// </summary>
        /// <param name="dayBegin">day of exhibition's beginning</param>
        /// <param name="monthBegin">month of exhibition's beginning</param>
        /// <param name="yearBegin">year of exhibition's beginning</param>
        /// <param name="dayEnd">day of exhibition's end</param>
        /// <param name="monthEnd">month of exhibition's end</param>
        /// <param name="yearEnd">year of exhibition's end</param>
        public PaintingInStoreroom(string name, string author, string genre, string direction, ushort year) : base(name, author, genre, direction, year) {
            PaintingStorage.paintings.Add(this);
        }
        /// <summary>
        /// Method adding any list of exhibition story
        /// </summary>
        /// <param name="exhibitions">List of exhibitions</param>
        public PaintingInStoreroom(Painting painting) : base(painting) {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// Class which stores information about paintings and their techniques
    /// </summary>
    public static class PaintingTechniquesStorage
    {
        /// <summary>
        /// List with information about paintings and their techniques
        /// </summary>
        public static List<IPaintingWithHerTechiques> techniquesStorage = new List<IPaintingWithHerTechiques>();
    }
}

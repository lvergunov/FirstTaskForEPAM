using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// A custom exception thrown when a painting tries to occupy an existing space
    /// </summary>
    public class PlaceIsTakenException : Exception
    {
        /// <summary>
        /// Constructor for throwing an exception
        /// </summary>
        /// <param name="message">Message given to the user</param>
        public PlaceIsTakenException(string message) : base(message) { }
    }
}

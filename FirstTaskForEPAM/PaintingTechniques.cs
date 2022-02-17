using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// Structure storing information about painting techniques
    /// </summary>
    public struct PainingTechniques : IPainingTechniques
    {
        /// <summary>
        /// Property returning a list of techniques
        /// </summary>
        public List<string> Techniques {
            get {
                return _techniques;    
            } 
        }
        /// <summary>
        /// A method that adds several performance techniques
        /// </summary>
        /// <param name="techniques">List of params</param>
        /// <returns>Was added successfully or not</returns>
        public string AddTechniques(params string[] techniques)
        {
            if (Techniques.Count + techniques.Length < 4)
            {
                _techniques.AddRange(techniques);
                return "Added successfully";
            }
            else return "Too lot of params";
        }
        private List<string> _techniques = new List<string>(0);
    }
}

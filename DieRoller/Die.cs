using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die(1 - 6)
    /// </summary>
    internal class Die
    {
        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>

        public bool IsHeld { get; set; }
        // Face up value (What was rolled?)
        // Is the die held?

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/>
        /// to the new number
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public void Roll()
        {
            // Generate random number
            // Set to face value
            throw new NotImplementedException();
        }
    }
}

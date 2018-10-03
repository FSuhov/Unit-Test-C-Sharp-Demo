// <copyright file="GirlDriver.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProductionCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The class that contains method of dominating the gladiatrixes.
    /// </summary>
    public class GirlDriver
    {
        /// <summary>
        /// The class that contains method of dominating the gladiatrixes.
        /// </summary>
        /// <param name="dominating"> the object tries to dominate></param>
        /// <param name="dominated"> the object is subject to domination></param>
        /// <returns>wether first object can dominate the second</returns>
        public static bool CanBeDominated(Gladiatrix dominating, Gladiatrix dominated)
        {
            if (dominating.IsQueen == true)
            {
                return true;
            }

            if (dominating.CurrentRating > dominated.CurrentRating)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

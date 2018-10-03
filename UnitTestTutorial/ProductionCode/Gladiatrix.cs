// <copyright file="Gladiatrix.cs" company="PlaceholderCompany">
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
    /// The class describing gladiatrix object.
    /// </summary>
    public class Gladiatrix
    {
        /// <summary>
        /// Gets or sets the name of gladiatrix.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this gladiatrix is current queen.
        /// </summary>
        public bool IsQueen { get; set; }

        /// <summary>
        /// Gets or sets the current rating of gladiatrix.
        /// </summary>
        public float CurrentRating { get; set; }
    }
}

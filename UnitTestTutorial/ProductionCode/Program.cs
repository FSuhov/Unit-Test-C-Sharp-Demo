// <copyright file="Program.cs" company="PlaceholderCompany">
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
    /// The program class contains an entry point for application.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Gladiatrix tanya = new Gladiatrix { Name = "Tanya Danielle", IsQueen = true, CurrentRating = 9.01F };
            Gladiatrix goldie = new Gladiatrix { Name = "Goldie Blair", IsQueen = false, CurrentRating = 8.88F };
            Gladiatrix amber = new Gladiatrix { Name = "Amber Michaelle", IsQueen = false, CurrentRating = 5.98F };

            Console.WriteLine(GirlDriver.CanBeDominated(tanya, goldie));
        }
    }
}

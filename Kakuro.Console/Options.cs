// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Options.cs" company="">
//   
// </copyright>
// <summary>
//   The options.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Kakuro.Console
{
    using System.Collections.Generic;

    using CommandLine;

    /// <summary>
    /// The options.
    /// </summary>
    public class Options
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the exclusions.
        /// </summary>
        [OptionList('e', "exclusions", ',', DefaultValue = null, HelpText = "Numbers to Exclude.")]
        public IEnumerable<short> Exclusions { get; set; }

        /// <summary>
        /// Gets or sets the spaces.
        /// </summary>
        [Option('p', "spaces", DefaultValue = (short)2, HelpText = "Number of spaces to fill.")]
        public short Spaces { get; set; }

        /// <summary>
        /// Gets or sets the sum.
        /// </summary>
        [Option('s', "sum", Required = true, HelpText = "Desired Sum.")]
        public short Sum { get; set; }

        #endregion
    }
}
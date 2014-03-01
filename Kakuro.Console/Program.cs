// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Kakuro.Console
{
    using System;
    using System.Linq;
    using System.Text;

    using CommandLine;

    using Kakuro;
    using Kakuro.Core;

    /// <summary>
    ///     The program.
    /// </summary>
    public class Program
    {
        #region Public Methods and Operators

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            // Parse Command Line
            var options = new Options();
            var parser = new Parser();

            if (!parser.ParseArguments(args, options))
            {
                return;
            }

            var combinations = new KakuroCombinationCollection(options.Sum, options.Spaces, options.Exclusions);

            for(var comboIndex = 0; comboIndex < combinations.Count; comboIndex++)            
            {
                var sb = new StringBuilder();
                short[] currentCombo = combinations[comboIndex];
                for (int numberIndex = 0; numberIndex < currentCombo.Count(); numberIndex++)
                {
                    sb.Append(combinations[comboIndex][numberIndex].ToString().PadLeft(2, ' '));
                    if (numberIndex + 1 < currentCombo.Count())
                    {
                        sb.Append(' ');
                    }
                }

                Console.Write(sb.ToString());
                if (comboIndex + 1 < combinations.Count)
                {
                    Console.WriteLine();
                }
            }
        }

        #endregion
    }
}
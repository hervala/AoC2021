using CliFx;
using CliFx.Attributes;
using System.Threading.Tasks;
using System.Linq;
using System;
using CliFx.Infrastructure;
using System.Collections.Generic;

namespace AdventOfCode2021
{
    [Command(nameof(DayXX))]
    public class DayXX : DayCommand, ICommand
    {
        public override ValueTask Part01(IConsole console)
        {
            var input = ParseInput(DayXX.input);
            return default;
        }

        public override ValueTask Part02(IConsole console)
        {
            var input = ParseInput(DayXX.input);
            return default;
        }

        private string[] ParseInput(string input) =>
            input.Split(Environment.NewLine).ToArray();

        private static string smallInput = @"";

        private static string testInput = @"";

        private static string input = @"";


    }
}
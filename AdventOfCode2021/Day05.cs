using CliFx;
using CliFx.Attributes;
using System.Threading.Tasks;
using System.Linq;
using System;
using CliFx.Infrastructure;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode2021
{
    [Command(nameof(Day05))]
    public class Day05 : DayCommand, ICommand
    {
        public override ValueTask Part01(IConsole console)
        {
            var input = ParseInput();
            return default;
        }

        public override ValueTask Part02(IConsole console)
        {
            var input = ParseInput();
            return default;
        }

        private string[] ParseInput() =>
            input.Split(Environment.NewLine).ToArray();

        private static string input = @"";


    }
}
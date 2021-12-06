using CliFx;
using CliFx.Attributes;
using System.Threading.Tasks;
using System.Linq;
using System;
using CliFx.Infrastructure;
using System.Collections.Generic;

namespace AdventOfCode2021
{
    [Command(nameof(Day06))]
    public class Day06 : DayCommand, ICommand
    {
        public override ValueTask Part01(IConsole console)
        {
            var fishes = ParseInput(Day06.input);
            
            foreach(var day in Enumerable.Range(1, 80))
            {
                var newFishes = new List<long>();
                for (int i = 0; i < fishes.Count; i++)
                {
                    if (fishes[i] == 0)
                    {
                        fishes[i] = 6;
                        newFishes.Add(8);
                    }
                    else
                    {
                        fishes[i]--;
                    }
                }
                fishes.AddRange(newFishes);
                console.Output.WriteLine(day);
            }

            console.Output.WriteLine(fishes.Count);
            return default;
        }

        public override ValueTask Part02(IConsole console)
        {
            var initialFishes = ParseInput(Day06.input);
            var newFishes = new long[256];

            foreach (var fishDay in initialFishes)
            {
                newFishes[fishDay]++;

                var dayCnt = fishDay;
                while (dayCnt <= 255)
                {
                    dayCnt += 6 + 1;

                    if (dayCnt <= 255)
                    {
                        newFishes[dayCnt]++;
                    }
                }
            }

            foreach (var day in Enumerable.Range(0,256))
            {
                var newFishCnt = newFishes[day];
                var dayCnt = day;
                while (newFishCnt > 0 && dayCnt <= 255)
                {
                    dayCnt += (dayCnt == day ? 9 : 7);

                    if (dayCnt <= 255)
                    {
                        newFishes[dayCnt] += newFishCnt;
                    }
                }
            }

            console.Output.WriteLine(newFishes.Sum() + initialFishes.Count);
            return default;
        }

        private List<long> ParseInput(string input) =>
            input.Split(',').Select(o => long.Parse(o)).ToList();

        private static string testInput = @"3,4,3,1,2";

        private static string input = @"2,4,1,5,1,3,1,1,5,2,2,5,4,2,1,2,5,3,2,4,1,3,5,3,1,3,1,3,5,4,1,1,1,1,5,1,2,5,5,5,2,3,4,1,1,1,2,1,4,1,3,2,1,4,3,1,4,1,5,4,5,1,4,1,2,2,3,1,1,1,2,5,1,1,1,2,1,1,2,2,1,4,3,3,1,1,1,2,1,2,5,4,1,4,3,1,5,5,1,3,1,5,1,5,2,4,5,1,2,1,1,5,4,1,1,4,5,3,1,4,5,1,3,2,2,1,1,1,4,5,2,2,5,1,4,5,2,1,1,5,3,1,1,1,3,1,2,3,3,1,4,3,1,2,3,1,4,2,1,2,5,4,2,5,4,1,1,2,1,2,4,3,3,1,1,5,1,1,1,1,1,3,1,4,1,4,1,2,3,5,1,2,5,4,5,4,1,3,1,4,3,1,2,2,2,1,5,1,1,1,3,2,1,3,5,2,1,1,4,4,3,5,3,5,1,4,3,1,3,5,1,3,4,1,2,5,2,1,5,4,3,4,1,3,3,5,1,1,3,5,3,3,4,3,5,5,1,4,1,1,3,5,5,1,5,4,4,1,3,1,1,1,1,3,2,1,2,3,1,5,1,1,1,4,3,1,1,1,1,1,1,1,1,1,2,1,1,2,5,3";


    }
}
﻿#region

using System;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace PokemonGo.RocketAPI.Helpers
{
    public class RandomHelper
    {
        private static readonly Random _random = new Random();

        public static long GetLongRandom(long min, long max)
        {
            var buf = new byte[8];
            _random.NextBytes(buf);
            var longRand = BitConverter.ToInt64(buf, 0);

            return Math.Abs(longRand%(max - min)) + min;
        }

        public static async Task RandomDelay(int maxDelay = 5000)
        {
            await Task.Delay(_random.Next((maxDelay > 500) ? 500 : 0, maxDelay));
        }

        public static async Task RandomDelay(int min, int max)
        {
            await Task.Delay(_random.Next(min, max));
        }

        public static void RandomSleep(int min, int max)
        {
            Thread.Sleep(_random.Next(min, max));
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
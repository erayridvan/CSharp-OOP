 using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();

        public string RandomString(RandomList vs)
        {
            int currentWord = random.Next(vs.Count);

            return vs[currentWord];
        }

        public void RemovesRandomElement(RandomList vs)
        {
            int currentWord = random.Next(vs.Count);

            vs.Remove(vs[currentWord]);
        }
    }
}

using System;

namespace SICPChapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new Accumulator(0);
            Console.WriteLine("Accumulator Value: {0}", acc.Value);
            acc.Increment(3);
            Console.WriteLine("Accumulator Value: {0}", acc.Value);

            var counter = new Counter();
            Console.WriteLine("Counter Value: {0}", counter.Value);
            counter.Increment();
            Console.WriteLine("Counter Value: {0}", counter.Value);
            counter.Reset();
            Console.WriteLine("Counter Value: {0}", counter.Value);

            // What is it I'm going to monitor? 
            

        }
    }

    public class Counter
    {
        public Accumulator Accumulator { get; set; }

        public int Value 
        { 
            get { return Accumulator.Value; } 
        }

        public Counter()
        {
            Reset();
        }

        public void Increment() 
        {
            Accumulator.Increment(1);
        }

        public void Reset() 
        {
            Accumulator = new Accumulator(0);
        }

    }

    public class Accumulator
    {
        public int Value { get; set; }

        public Accumulator(int initial)
        {
            Value = initial;
        }

        public void Increment(int amount) 
        {
            Value += amount;
        }
        
    }
}

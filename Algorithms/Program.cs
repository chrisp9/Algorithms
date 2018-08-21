using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DoBinarySearch(new[] { 1, 3, 5, 6, 8 }, 3);
            DoStackEndedQueue();

            Console.ReadKey();
        }

        static void DoBinarySearch(int[] input, int value)
        {
            var binarySearch = new BinarySearch();
            var output = BinarySearch.Rank(value, input);
            Console.WriteLine(output);
        }

        static void DoStackEndedQueue()
        {
            var seq = new StackEndedQueue<string>(5);

            seq.Push("Hello");
            seq.Push("World");
            seq.Enqueue("Well");

            AssertEqual("World", seq.Pop());
            AssertEqual("Hello", seq.Pop());
            AssertEqual("Well", seq.Pop());

            seq.Enqueue("Hi");
            seq.Enqueue("There");
            seq.Push("World2");

            AssertEqual("World2", seq.Pop());
            AssertEqual("Hi", seq.Pop());
            AssertEqual("There", seq.Pop());
        }

        static void AssertEqual<T>(T expected, T actual)
        {
            if (!Equals(expected, actual))
                throw new Exception("Unexpected value");
        }

    }
}

using System.Collections.Generic;
using System.Diagnostics;

namespace ListsBenchmark
{
    /// <summary>
    /// Класс для замеров работы с коллекциями List<T> и LinkedList<T>
    /// </summary>
    internal class Benchmark
    {
        /// <summary>
        /// Метод получает индекс среднего элемента,
        /// и в зависимости от типа коллекции запускает замер.
        /// </summary>
        /// <typeparam name="TCollection">Тип коллеции</typeparam>
        /// <param name="input">Коллекция над котороый будет проводится тест</param>
        /// <param name="items">Массив элементов для вставки</param>
        internal static void InsertionBenchmark<TCollection>(TCollection input, String[] items)
            where TCollection : ICollection<String>
        {
            Console.WriteLine($"Benchmarking {input.GetType().Name} insertion");

            Int32 midIndex = input.Count / 2;
            Double elapsed = 0D;

            if (input is List<String> list)
            {
                Stopwatch sw = Stopwatch.StartNew();

                foreach (String item in items)
                {
                    list.Insert(midIndex, item);
                }

                sw.Stop();

                elapsed = sw.Elapsed.TotalMilliseconds;
            }

            if (input is LinkedList<String> lList)
            {
                LinkedListNode<String> middleNode = GetNodeAt(lList, midIndex);

                Stopwatch sw = Stopwatch.StartNew();

                foreach (String item in items)
                {
                    lList.AddAfter(middleNode, item);
                }

                sw.Stop();

                elapsed = sw.Elapsed.TotalMilliseconds;
            }

            Console.WriteLine($"Elapsed: {elapsed} ms{Environment.NewLine}");
        }

        /// <summary>
        /// Метод находит средний узел в коллекции <see cref="LinkedList{T}"/>.
        /// </summary>
        /// <param name="input">Коллекция в которой осуществляется поиск</param>
        /// <param name="index">Индекс среднего узла</param>
        /// <returns>Объект <see cref="LinkedListNode{T}"/> или null если объект не найден</returns>
        private static LinkedListNode<String> GetNodeAt(LinkedList<String> input, Int32 index)
        {
            Int32 counter = 0;

            for(LinkedListNode<String> node = input.First; node != null; node = node.Next)
            {
                if (counter == index) return node;
                counter++;
            }

            return null;
        }
    }
}

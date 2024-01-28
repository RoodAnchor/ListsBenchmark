namespace ListsBenchmark
{
    internal class Program
    {
        static void Main(String[] args)
        {
            String filePath = String.Empty;

            if (args.Length > 0 )
                filePath = args[0];

            String[] wordsArr = FileProcessor.GetWordsArr(filePath);

            List<String> wordsList = new List<String>(wordsArr);
            LinkedList<String> wordsLinkedList = new LinkedList<String>(wordsArr);

            Benchmark.InsertionBenchmark<List<String>>(wordsList, wordsArr);
            Benchmark.InsertionBenchmark<LinkedList<String>>(wordsLinkedList, wordsArr);

            Console.ReadLine();
        }
    }
}
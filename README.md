# ListsBenchmark
 Репо для задачи 13.6.1

## Task 1
### Задача
Сравнить производительность вставки в List<T> и LinkedList<T>. 
На примере представленного текста, выясните, какие будут различия между этими коллекциями.

### Реализация
Пусть к файлу с текстом передаётся в качестве параметра приложения. Например: ListsBenchmark.exe C:\file.txt
Чтением текста из файла занимается статический метод GetWordsArr() класса FileProcessor.
Замеры реализованы статическим обобщённым методом InsertionBenchmark<T> в классе Benchmark.
Для замеров используется вставка в середину списка. 
Для получения среднего узла в двусвязном списке есть статический метод Benchmark.GetNodeAt(). В замерах не участвует.
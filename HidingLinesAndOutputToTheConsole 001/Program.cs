using System.Text;

namespace HidingLinesAndOutputToTheConsole_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Декларация лямбда-выражения
			Action<int[]> stringJoinPrint = (numbers) =>
			{
				// Создание экземпляра StringBuilder для эффективной сборки строки
				StringBuilder sb = new StringBuilder();

				// Цикл для обработки каждого элемента в массиве
				for (int i = 0; i < numbers.Length; i++)
				{
					// Использование switch-expression для определения последнего элемента в массиве
					_ = i switch
					{
						// Если элемент не последний, добавляем его в строку с разделителем
						_ when i < numbers.Length - 1 => sb.Append($"{numbers[i]}, "),
						// Если элемент последний, добавляем его в строку без разделителя
						_ => sb.AppendLine($"{numbers[i]}")
					};
				}

				// Вывод результата на консоль
				Console.WriteLine(sb.ToString());
			};

			// Создание примерного массива чисел
			int[] numbers = [ 2, 3, 4, 5 ];

			// Вызов метода с примерным массивом
			stringJoinPrint(numbers);

			Console.ReadKey();
        }
    }
}

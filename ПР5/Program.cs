using System;

class Program
{
    static void Main()
    {
        // Запрос у пользователя начального элемента
        Console.Write("Введите A[0]: ");
        int firstElement = Convert.ToInt32(Console.ReadLine());

        // Установка размера массива
        int size = 10; // Длина массива должна быть не менее 10 элементов
        int[] A = new int[size];

        // Инициализация первого элемента
        A[0] = firstElement;

        // Заполнение массива согласно правилам
        for (int i = 1; i < size; i++)
        {
            A[i] = A[i / 2] + A[i - 1];
        }

        // Вывод массива
        Console.WriteLine("Сгенерированный массив A:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"A[{i}] = {A[i]}");
        }

        // Запрос у пользователя числа для вставки и позиции
        Console.Write("Введите число для вставки: ");
        int numberToInsert = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите позицию для вставки (0-" + (size - 1) + "): ");
        int position = Convert.ToInt32(Console.ReadLine());

        // Проверка корректности позиции
        if (position < 0 || position >= size)
        {
            Console.WriteLine("Некорректная позиция. Вставка невозможна.");
            return;
        }

        // Создание нового массива для вставки элемента
        int[] newArray = new int[size + 1];

        // Вставка элемента
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i < position)
            {
                newArray[i] = A[i]; // Копируем элементы до позиции
            }
            else if (i == position)
            {
                newArray[i] = numberToInsert; // Вставляем новый элемент
            }
            else
            {
                newArray[i] = A[i - 1]; // Копируем элементы после позиции
            }
        }

        // Вывод нового массива
        Console.WriteLine("Массив после вставки:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine($"newArray[{i}] = {newArray[i]}");
        }
    }
}

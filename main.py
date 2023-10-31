"""
Модуль основной программы
"""
from list_comparator import ListComparator


if __name__ == "__main__":
    # Создание списков для сравнения
    list1 = [1, 2, 3, 4, 5]
    list2 = [6, 7, 8, 9, 10]

    # Создание экземпляра класса ListComparator
    comparator = ListComparator(list1, list2)

    # Вызов метода compare_averages для сравнения средних значений
    RESULT = comparator.compare_averages()

    # Вывод результата на экран
    print(RESULT)

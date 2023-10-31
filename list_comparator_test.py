"""
Модуль для тестирования класса ListComparator
"""
import pytest
from list_comparator import ListComparator


def test_calculate_average_non_empty_list():
    """Проверка среднего значения для непустого списка"""
    input_list = [1, 2, 3, 4, 5]
    comparator = ListComparator([], [])
    assert comparator.calculate_average(input_list) == 3.0


def test_calculate_average_empty_list():
    """Проверка среднего значения для пустого списка"""
    input_list = []
    comparator = ListComparator([], [])
    assert comparator.calculate_average(input_list) == 0


def test_calculate_average_negative_numbers():
    """Проверка среднего значения для списка с отрицательными числами"""
    input_list = [-1, -2, -3, -4, -5]
    comparator = ListComparator([], [])
    assert comparator.calculate_average(input_list) == -3.0


def test_calculate_average_mixed_numbers():
    """Проверка среднего значения для списка с положительными и отрицательными числами"""
    input_list = [-1, 2, -3, 4, -5]
    comparator = ListComparator([], [])
    assert comparator.calculate_average(input_list) == -0.6


def test_compare_averages_list1_greater():
    """Проверка сравнения среднего значения list1 > list2"""
    list1 = [4, 5, 6]
    list2 = [1, 2, 3]
    comparator = ListComparator(list1, list2)
    result = comparator.compare_averages()
    assert result == "Первый список имеет большее среднее значение"

def test_compare_averages_list2_greater():
    """Проверка сравнения среднего значения list2 > list1"""
    list1 = [1, 2, 3]
    list2 = [4, 5, 6]
    comparator = ListComparator(list1, list2)
    result = comparator.compare_averages()
    assert result == "Второй список имеет большее среднее значение"

def test_compare_averages_equal_averages():
    """Проверка сравнения средних значений, когда они равны"""
    list1 = [1, 2, 3]
    list2 = [1, 2, 3]
    comparator = ListComparator(list1, list2)
    result = comparator.compare_averages()
    assert result == "Средние значения равны"


if __name__ == "__main__":
    pytest.main()

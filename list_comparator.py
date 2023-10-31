"""
Модуль, содержащий класс ListComparator для сравнения списков.
"""


class ListComparator:
    """Класс, который предназначен для сравнения двух списков чисел и определения,
    какой из них имеет большее среднее значение
    """
    def __init__(self, list1, list2):
        """
        Конструктор класса ListComparator.
        """
        self.list1 = list1
        self.list2 = list2

    def calculate_average(self, input_list):
        """
        Вычисляет среднее значение списка чисел. Если список пуст, возвращает 0.
        """
        if len(input_list) == 0:
            return 0
        return sum(input_list) / len(input_list)

    def compare_averages(self):
        """
        Сравнивает средние значения двух списков и возвращает соответствующее сообщение.
        """
        average_list1 = self.calculate_average(self.list1)
        average_list2 = self.calculate_average(self.list2)

        if average_list1 > average_list2:
            return "Первый список имеет большее среднее значение"
        if average_list1 < average_list2:
            return "Второй список имеет большее среднее значение"
        return "Средние значения равны"

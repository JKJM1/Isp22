import random
A = input("Введите элементы массива A через пробел: ").split()
B = []

for element in A:
    if int(element) > 0:
        B.append(int(element))

print("Наибольший элемент в массиве B:", max(B))

array = []

for i in range(15):
    array.append(random.uniform(-50, 50))

print("Массив из случайных вещественных значений:", array)
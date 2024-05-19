import random
size = int(input("Введите размер массива: "))
array = []

for i in range(size):
    array.append(random.randint(0, 5))
print("Сгенерированный массив:", array)

repeat_count = 0

for i in range(len(array)):
    for j in range(i + 1, len(array)):
        if array[i] == array[j]:
            repeat_count += 1
            break

print("Количество повторяющихся элементов в массиве:", repeat_count)
import math
result = 0
for number in range(1000, 10000):
    thousand = number // 1000
    hundred = (number // 100) % 10
    ten = (number // 10) % 10
    one = number % 10

    digit_sum = thousand + hundred + ten + one

    if digit_sum == 20:
        result += number

print("Сумма всех четырехзначных чисел, сумма цифр каждого из которых равно 20, равна:", result)

result = 0
for number in range(10, 100):
    result += number

print("Сумма всех двузначных чисел равна:", result)

result = 0
number = 1

while number <= 99:
    if number % 2 != 0:
        result += number
    number += 1

print("Сумма всех нечетных чисел от 1 до 99 равна:", result)

N = int(input("Введите количество чисел: "))
n_count = 0
p_count = 0
z_count = 0

for i in range(N):
    number = float(input("Введите число: "))
    if number < 0:
        n_count += 1
    elif number > 0:
        p_count += 1
    else:
        z_count += 1

print("Количество отрицательных чисел:", n_count)
print("Количество положительных чисел:", p_count)
print("Количество нулей:", z_count)

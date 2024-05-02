import math
number = int(input("Введите натуральное число больше 1: "))

divisor = 2
while divisor <= math.isqrt(number):
    if number % 2 == 0:
        print("Число", number, "не является простым.")
        break
    divisor += 1
else:
    print("Число", number, "является простым.")

number = int(input("Введите натуральное число: "))

while number > 1 and number % 3 == 0:
    number /= 3

if number == 1:
    print("Число является степенью числа 3")
else:
    print("Число не является степенью числа 3")
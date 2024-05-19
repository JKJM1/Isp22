#1

num1 = float(input("Введите первое число: "))
num2 = float(input("Введите второе число: "))
num3 = float(input("Введите третье число: "))

def avrg_three(a, b, c):
    return (a + b + c) / 3

result = avrg_three(num1, num2, num3)
print("Среднее значение трех чисел:", result)

#2
a = float(input("Введите первое число: "))
b = float(input("Введите второе число: "))

def gcd(a, b):
    while b:
        a, b = b, a % b
    return a

result = gcd(a, b)
print("Наибольший общий делитель:", result)

#3

def is_prime(n):
    if n <= 1:
        return False
    for i in range(2, int(n ** 0.5) + 1):
        if n % i == 0:
            return False
    return True

num = int(input("Введите число для проверки: "))

if is_prime(num):
    print(num, "является простым числом.")
else:
    print(num, "не является простым числом.")

#4

def factorial(n):
    if n == 0:
        return 1
    else:
        result = 1
        for i in range(1, n + 1):
            result *= i
        return result

num = int(input("Введите число для вычисления факториала: "))
print("Факториал числа", num, "равен", factorial(num))


#5

def reverse_string(input_str):
    return input_str[::-1]

input_str = input("Введите строку: ")
reverse_str = reverse_string(input_str)
print("Строка в обратном порядке:", reverse_str)

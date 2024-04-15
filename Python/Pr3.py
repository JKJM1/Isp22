import math

N = int(input("Введите целое число N (> 1): "))
k = 0
while 5**k <= N: k += 1
print("Наименьшее целое число K, при котором 5^K > N:", k)


a = int(input("Введите значение a: "))
b = int(input("Введите значение b: "))
if b < a:
    print("Ошибка! b должно быть больше или равно a.")
else:
    count = b - a + 1
    sum = (count * (a + b)) //2

    print("Сумма всех целых чисел от", a, "до", b, ":", sum)

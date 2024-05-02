import math

a = int(input("Введите значение a: "))
b = int(input("Введите значение b (Больше a): "))

result = 0
if b >= a:
    n = b - a + 1
    S = (n * (a + b)) / 2
    print("Сумма всех целых чисел от", a, "до", b, "равна", S)
else:
    print("b должно быть больше или равно a")

N = int(input("Введите целое число N (> 1): "))

if N > 1:
    K = math.ceil(math.log(N, 5))
    print("Наименьшее целое число K, при котором 5^K > N, равно:", K)
else:
    print("N должно быть больше 1.")

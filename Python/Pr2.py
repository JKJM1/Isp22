import math

print("Введите год")
year = int(input())
if (year % 4 == 0 and year%100 != 0) or (year%400 == 0):
    print("Высокосный")
else:
    print("Обычный")


print("Введите сторону A отверстия")
a = int(input())
print("Введите сторону B отверстия")
b = int(input())
print("Введите сторону X кирпича")
x = int(input())
print("Введите сторону Y кирпича")
y = int(input())
print("Введите сторону Z кирпича")
z = int(input())

v = a * b

if ((a == x and b == y) or (b == x and a == y) or (a == y and b == z) or
        (a == z and b == x) or (a == z and b == y) or (a == x and b == z)):
    print("Кирпич пройдёт в отверстие")
else:
    print("Кирпич не пройдет в отверстие")

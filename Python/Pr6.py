import math
text = input("Введите текст: ")

plus_count = 0
star_count = 0

for char in text:
    if char == "+":
        plus_count += 1
    elif char == "*":
        star_count += 1

print("Количество символов '+' в тексте:", plus_count)
print("Количество символов '*' в тексте:", star_count)


word = input("Введите слово: ")
reverse_word = word[::-1]

if word == reverse_word:
    print("Слово", word, "является перевертышем.")
else:
    print("Слово", word, "не является перевертышем.")


sentence = input("Введите предложение: ")
new_sentence = sentence.replace(" ", "_")
print("Предложение с замененными пробелами:")
print(new_sentence)


text = input("Введите текст: ")
result = ""

for char in text:
    if char.isdigit():
        result += char + " "

print("Цифры, найденные в тексте:", result)

text = input("Введите текст: ")
result = 0

for char in text:
    if char.isdigit():
        result += int(char)

print("Сумма всех чисел в тексте:", result)

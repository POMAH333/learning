num_1 = int(input('Введите первое число: '))
num_2 = int(input('Введите второе число: '))
num_3 = int(input('Введите третье число: '))
num_4 = int(input('Введите четвёртое число: '))
max = num_1
if max < num_2:
	max = num_2
if max < num_3:
	max = num_3
if max < num_4:
	max = num_4
print('Наибольшее число = ', max)
n = int(input('Введите основание факториала: '))
f = 1
i = 1
while i <= n:
	f *= i
	i += 1
print('F(', n, ') = ', f)
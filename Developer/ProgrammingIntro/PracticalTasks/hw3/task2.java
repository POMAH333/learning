numbers = [1, 8, 3, 8, 2, 6, 8, 8]
index = 0
maximum = numbers[index]
count_maximal = 0
while index < numbers.length do
	if numbers[index] > maximum then
		maximum = numbers[index]
		count_maximal = 1
	else
		if numbers[index] == maximum then
			count_maximal = count_maximal + 1
	index = index + 1
print(count_maximal)
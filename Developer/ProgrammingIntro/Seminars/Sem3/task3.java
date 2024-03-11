import java.util.Arrays;

class task3 {
	public static void main(String[] args) {
		int[] numbers = { 2, 5, 13, 7, 6, 4 };
		int size = 6;
		int index = 0;
		int max_idx = 0;
		int max = numbers[max_idx];
		while (index < size) {
			if (numbers[index] > max) {
				max_idx = index;
				max = numbers[index];
			}
			index++;
		}
		numbers[max_idx] = numbers[size - 1];
		numbers[size - 1] = max;
		System.out.println(Arrays.toString(numbers));
	}
}
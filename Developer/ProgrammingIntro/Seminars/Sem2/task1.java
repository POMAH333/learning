public class task1 {
	public static void main(String[] args) {
		// A. Найти скалярное произведение 2-х векторов
		int[] vec1 = { 3, 12, 25, 7 };
		int[] vec2 = { 30, 14, 9, 11 };
		int scal = 0;
		if (vec1.length == vec2.length) {
			for (int i = 0; i < vec1.length; i++) {
				scal += vec1[i] * vec2[i];
			}
		}
		System.out.println(scal);
		System.out.println("");

		// B. Посчитать количество положительных чисел в произвольно заданном массиве
		int[] array1 = { 3, 12, -25, 7 };
		int num1 = 0;
		for (int i = 0; i < array1.length; i++) {
			if (array1[i] > 0) {
				num1++;
			}
		}
		System.out.println(num1);
		System.out.println("");

		// C. Найти сумму всех элементов массива с нечетными индексами
		int[] array2 = { 3, 12, -25, 7 };
		int sum1 = 0;
		for (int i = 0; i < array2.length; i++) {
			if (i % 2 != 0) {
				sum1 += array2[i];
			}
		}
		System.out.println(sum1);
		System.out.println("");

		// D. Найти сумму всех элементов массива с нечетным значением
		int[] array3 = { 1, 2, 4, 6 };
		int sum2 = 0;
		for (int i = 0; i < array2.length; i++) {
			if (array3[i] % 2 != 0) {
				sum2 += array3[i];
			}
		}
		System.out.println(sum2);
		System.out.println("");
	}
}
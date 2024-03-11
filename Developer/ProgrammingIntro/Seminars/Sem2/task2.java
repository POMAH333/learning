import java.util.Arrays;

public class task2 {
	public static void main(String[] args) {
		// A. Записать алгоритм, который «перенесет» самое большое значение элемента в
		// правый край массива
		int[] array1 = { 3, 12, 25, 7 };
		System.out.println(Arrays.toString(array1));
		int index = 0;
		for (int i = 0; i < array1.length; i++) {
			if (array1[i] > array1[index]) {
				index = i;
			}
		}
		int temp = array1[array1.length - 1];
		array1[array1.length - 1] = array1[index];
		array1[index] = temp;
		System.out.println(Arrays.toString(array1));
		System.out.println("");

		// B. Записать сортировку массива
		int[] array2 = { 3, 12, 25, 7 };
		System.out.println(Arrays.toString(array2));
		int size = array2.length - 1;
		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size - i; j++) {
				if (array2[j + 1] < array2[j]) {
					temp = array2[j + 1];
					array2[j + 1] = array2[j];
					array2[j] = temp;
				}
			}
		}
		System.out.println(Arrays.toString(array2));
		System.out.println("");

		int[] array3 = { 3, 12, 25, 7 };
		System.out.println(Arrays.toString(array3));
		size = array3.length - 1;
		for (int i = 0; i < size; i++) {
			int ind = 0;
			for (int j = 0; j < size - i; j++) {
				if (array3[j] > array3[ind]) {
					ind = j;
				}
				temp = array3[size - i];
				array3[size - i] = array3[ind];
				array3[ind] = temp;
			}
		}
		System.out.println(Arrays.toString(array3));
		System.out.println("");

		// C. Нахождение максимального и минимального элемента массива
		int[] array4 = { 1, 2, 4, 6 };
		System.out.println(Arrays.toString(array4));
		int max = array4[0];
		int min = array4[0];
		for (int i = 0; i < array4.length; i++) {
			if (array4[i] > max) {
				max = array4[i];
			}
			if (array4[i] < min) {
				min = array4[i];
			}
		}
		System.out.println(max);
		System.out.println(min);
	}
}
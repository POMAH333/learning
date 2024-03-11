import java.util.Arrays;

public class task {
	public static void main(String[] args) {
		// 1. Нахождение индексов максимального и минимального элемента массива
		int[] array1 = { 1, 2, 4, 6 };
		System.out.println(Arrays.toString(array1));
		int max = 0;
		int min = 0;
		for (int i = 0; i < array1.length; i++) {
			if (array1[i] > array1[max]) {
				max = i;
			}
			if (array1[i] < array1[min]) {
				min = i;
			}
		}
		System.out.println(max);
		System.out.println(min);
		System.out.println("");

		// 2. Задание на «разворот» массива
		int[] array2 = { 3, 12, 25, 7, 9 };
		System.out.println(Arrays.toString(array2));
		int size = array2.length;
		for (int i = 0; i < size / 2; i++) {
			int temp = array2[size - i - 1];
			array2[size - i - 1] = array2[i];
			array2[i] = temp;
		}
		System.out.println(Arrays.toString(array2));
		System.out.println("");

		// 3. Найти сумму элементов массива, лежащих между максимальным и минимальным по
		// значению элементами
		int[] array3 = { 3, 12, 17, 11, 25, 7 };
		System.out.println(Arrays.toString(array3));
		int indexMin = 0;
		int indexMax = 0;
		int sum = 0;
		for (int i = 0; i < array3.length; i++) {
			if (array3[i] > array3[max]) {
				indexMax = i;
			}
			if (array3[i] < array3[min]) {
				indexMin = i;
			}
		}
		if (indexMax > indexMin) {
			int temp = indexMin;
			indexMin = indexMax;
			indexMax = temp;
		}
		for (int i = indexMax + 1; i < indexMin; i++) {
			sum += array3[i];
		}
		System.out.println(sum);
		System.out.println("");

		// 4. *Найти среднее арифметическое среди всех элементов массива
		int[] array4 = { 1, 2, 4, 6 };
		System.out.println(Arrays.toString(array4));
		sum = 0;
		double avg = 0;
		for (int i = 0; i < array4.length; i++) {
			sum += array4[i];
		}
		avg = (double) sum / array4.length;
		System.out.println(avg);
		System.out.println("");
	}
}
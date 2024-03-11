public class task1 {
	public static void main(String[] args) {
		int[] numbers = { 2, -5, 13, -7, -6, -4 };
		int size = 6;
		int count = 0;
		int index = 0;
		while (index < size) {
			if (numbers[index] > 0) {
				count++;
			}
			index++;
		}
		System.out.println(count);
	}
}
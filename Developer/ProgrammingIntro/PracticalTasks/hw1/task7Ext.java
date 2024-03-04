
public class task7Ext {
	public static void main(String[] args) {
		int count = 0;
		double distance = 100;
		int firstFriendSpeed = 2;
		int secondFriendSpeed = 1;
		int dogSpeed = 5;
		int friend = 2;
		double time = 0;
		if (firstFriendSpeed <= secondFriendSpeed || dogSpeed <= secondFriendSpeed) {
			System.out.println("Собака пробежит 0 раз");
			return;
		}
		while (distance > 10) {
			if (friend == 1) {
				time = distance / (firstFriendSpeed + dogSpeed);
				friend = 2;
			} else {
				time = distance / (dogSpeed - secondFriendSpeed);
				friend = 1;
			}
			distance = distance - (firstFriendSpeed - secondFriendSpeed) * time;
			count++;
		}
		System.out.println("Собака пробежала " + count + " раз");
	}
}
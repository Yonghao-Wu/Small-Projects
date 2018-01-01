import java.util.Calendar;
import java.util.Scanner;

public class get_Age {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner scanner = new Scanner(System.in);
		
		System.out.println("Enter your birthdate (MM-DD-YYYY):");
		
		String string_date = scanner.next();
		
		scanner.close();
		
		int[] birthdate_array = process_user_birth_date(string_date);
		int birth_monthday = birthdate_array[0];
		int birth_year = birthdate_array[1];
		
		int[] todays_date = get_todays_date();
		int now_monthday = todays_date[0];
		int now_year = todays_date[1];
		
		int age = get_age(birth_monthday, birth_year, now_monthday, now_year);
		
		System.out.println("Your age is: " + age);
	}
	
	private static int get_age(int birth_monthday, int birth_year, int now_monthday, int now_year) {
		
		int age = now_year - birth_year; 
		
		if(now_monthday < birth_monthday) {
			age -= 1; 
		}
		
		return age;
	}
	
	private static int[] process_user_birth_date(String birthdate) {
		
		String date = birthdate.replaceFirst("-", "");
		String[] split_date = date.split("-");
		int[] int_birthdate = new int[split_date.length];
		
		for(int i = 0; i < split_date.length; i++) {
			int_birthdate[i] = Integer.parseInt(split_date[i]);
		}
		
		return int_birthdate;
	}
	
	private static int[] get_todays_date() {
		
		int now_year = Calendar.getInstance().get(Calendar.YEAR);
		int now_month = Calendar.getInstance().get(Calendar.MONTH) + 1;
		int now_day = Calendar.getInstance().get(Calendar.DAY_OF_MONTH);
		
		String string_now_day; 
		
		if(now_day < 10) {
			string_now_day = Integer.toString(now_day).replace(Integer.toString(now_day), "0").concat(Integer.toString(now_day));
		}
		else {
			string_now_day = Integer.toString(now_day);
		}
		
		int now_monthday = Integer.parseInt(Integer.toString(now_month).concat(string_now_day));
	
		int[] todays_date = {now_monthday, now_year};
		
		return todays_date;
	}

}

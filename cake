import java .util.*;
public class Main
{
	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		int totalingredients=sc.nextInt();
		int onecake=sc.nextInt();
		int totalcake=totalingredients/onecake;
		System.out.println(totalcake);
	}
}

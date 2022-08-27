import java.util.Scanner;

public class Mystery
{
  public static void foo(int n, String left, String middle, String right)
  {
    if (n > 0)
    {
      foo(n - 1, left, right, middle);
      System.out.println("Move one disk from " + left + " to " + right);
      foo(n - 1, middle, left, right);
    }
  }
  
	public static void main(String[] args) 
	{
    Scanner kbd = new Scanner(System.in);
    int n;
    String left, middle, right;
    
    System.out.print("Enter n:  ");
    n = kbd.nextInt();
    kbd.nextLine();
    System.out.print("Enter String 'left':  ");
    left = kbd.nextLine();
    System.out.print("Enter String 'middle':  ");
    middle = kbd.nextLine();
    System.out.print("Enter String 'right':  ");
    right = kbd.nextLine();
    System.out.println();
    
    foo(n, left, middle, right);
    
  } 
}

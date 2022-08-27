import java.util.Scanner;

public class RecursiveMethods
{
   public static void main(String [] args)
   {
     // WRITE code to test your methods here.  
     // You MAY hardcode tests, but do enough to be sure it works:
     // Always try the base case and small cases as well as some bigger ones.
      int[] a = new int[5];
      a[0] = 93;
      a[1] = 32;
      a[2] = 175;
      a[3] = 88;
      a[4] = 4;
      System.out.println(largest(a));
      int n=9;
      printDown(n);
      System.out.println(sum(a));
      inputAndPrintReverse();
      
   
   }
//********************************************************************  
// NO LOOPING STATEMENTS IN ANY OF THE FOLLOWING METHODS!!
   public static int sum(int [] A)
   {
      return sumRec(A, 0, A.length - 1);
   }
  
// WRITE THIS METHOD that returns the sum of the elements in A
// that are indexed from low to high.  RECURSIVELY!
   private static int sumRec(int [] A, int low, int high)
   {
   
      if(low> high)
      {
         return 0;
      }
      else
      {
         return A[low]+sumRec(A, low+1,high);
      }
   
   }
   

//********************************************************************  
   public static int largest(int [] A)
   {
      return largestRec(A, 0, A.length - 1);
   }

// WRITE THIS METHOD that returns the largest of the elements in A
// that are indexed from low to high.  RECURSIVELY!
   private static int largestRec(int [] A, int low, int high)
   {
      int temp = A[low];
      
      if(A[low] > A[high] && high != 0)
      {
         temp = A[low];
         return largestRec(A, low, high-1);
      }
      else if (A[high] > A[low] && low != high)
      {  
         temp = A[high];
         return largestRec(A, low+1, high);
      }
      else
         return  temp;
         
   }
  
//********************************************************************  
// WRITE THIS METHOD that takes an integer n and prints the numbers n
// down to 1, one per line, RECURSIVELY!  This method needs no 
// helper method, like the array ones above.
   public static void printDown(int n)
   {
      if(n!=1)
      {
         System.out.println(n);
         printDown(n-1);
      }
      else
      {
         System.out.println("1");
      }
   }
//********************************************************************  
// WRITE THIS METHOD that asks the user to input integers until the
// value 0 is entered, then it prints the numbers entered in reverse order.
// RECURSIVELY!  This method needs no helper method, like the array ones above.
// You may not use any arrays or stacks or any other object other than the Scanner.
   public static void inputAndPrintReverse()
   {
    // NO ARRAYS or ARRAY like structures here
    
      Scanner kbd = new Scanner(System.in);
      System.out.println("Integer: ");
      String n = kbd.nextLine();
      int z = Integer.parseInt(n);
      
      if(z != 0)
      {
         System.out.println("Integer: ");
         n += kbd.nextInt();
         inputAndPrintReverse();
      }
      else
         System.out.println(n);
   
   } 
   
}
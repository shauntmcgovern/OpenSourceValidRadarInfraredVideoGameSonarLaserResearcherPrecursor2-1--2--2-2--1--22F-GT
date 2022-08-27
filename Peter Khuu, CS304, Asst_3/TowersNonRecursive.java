import java.util.Scanner;

public class TowersNonRecursive
{
   public static void tnr(int n, String left, String middle, String right)
   {
    // WRITE THIS METHOD--NO RECURSION, USE A STACK OF TOWERSJOBS (USE THE GENERIC STACK)
       
      LinkedStack<TowersJob> toh = new LinkedStack<TowersJob>();
      TowersJob T = new TowersJob(n,left,middle,right);
      System.out.println(T.toString());
      toh.push(T);
      
      while(!toh.isEmpty())
      {  
         T=toh.pop();
         
         if (T.n==1)
         {
            System.out.println("Move "+T.left+ " to "+ T.right);
         }
         else 
         {
            TowersJob u,v,z;
            u=new TowersJob(T.n-1, T.left,T.right,T.middle);
            v=new TowersJob(1, T.left,T.middle,T.right);
            z=new TowersJob(T.n-1, T.middle,T.left,T.right);
           
            toh.push(z);
            toh.push(v);
            toh.push(u);
           
         }
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
      
      tnr(n, left, middle, right);
      
   } 
}

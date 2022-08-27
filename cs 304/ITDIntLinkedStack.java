import java.util.Scanner;

public class ITDIntLinkedStack
{
  public static void displayMenu()
  {
    System.out.println("\n(1) display menu");
    System.out.println("(2) check isEmpty");
    System.out.println("(3) push");
    System.out.println("(4) peek");
    System.out.println("(5) pop");
    System.out.println("(6) empty the stack");
    System.out.println("(7) size");
    System.out.println("(8) toString");
    System.out.println("(0) quit");
  }

  public static void main(String [] args)
  {
    if (true || false)
      System.out.println("YES");
      
   
    
    Scanner kbd = new Scanner(System.in);
    IntLinkedStack x = new IntLinkedStack();
    int choice = 1;
    int value;
    
    System.out.println("Here are your choices: ");
    displayMenu();
    
    System.out.print("\nEnter your choice#:  ");
      choice = kbd.nextInt();

    while (choice >= 1 && choice <= 8)
    {
      if (choice == 1)
        displayMenu();
      else if (choice == 2)
        System.out.println("Stack isEmpty?:  " + x.isEmpty() );
      else if (choice == 3)
      {
        System.out.print("Enter value to push:  ");
        value = kbd.nextInt();
        x.push(value);
        System.out.println("Pushed value " + value + ".");
      }
      else if (choice == 4)
      {
        value = x.peek();
        System.out.println("Peeked at top of stack:  " + value + ".");
      }
      else if (choice == 5)
      {
        value = x.pop();
        System.out.println("Popped " + value + " off the stack.");
      }
      
      else if (choice == 6)
      {
        System.out.println("Emptying stack...");
        while (!x.isEmpty())
          System.out.println("Popped " + x.pop());
        System.out.println("Stack is now emptied.");
      }
      
      else if (choice == 7)
        System.out.println("Size is " + x.size());
        
      else if (choice == 8)
      {
        System.out.println("Here is a view of the stack: ");
        System.out.println(x.toString());
      }
        
                
      System.out.print("\nEnter your choice#:  ");
      choice = kbd.nextInt();
      
    }  // end while (choice >= 1 && <= 9)
    
    System.out.println("Bye!");
    
  } // end public static void main(String [] args)
         
        
} // end public class ITDArrayStack
 
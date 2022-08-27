public class TestGenericLinkedStack
{
  public static void main(String [] args)
  {
    LinkedStack<Integer> intStack = new LinkedStack<Integer>();
    LinkedStack<String> stringStack = new LinkedStack<String>();
    LinkedStack<Double> doubleStack = new LinkedStack<Double>();
    LinkedStack<TowersJob> tjStack = new LinkedStack<TowersJob>();
    
    int i;
    for (i = 1; i <= 5; i++)
    {
      intStack.push(i*10);
      stringStack.push("hello, i = " + i);
      doubleStack.push(i*100/7.0);
      tjStack.push(new TowersJob (3*i, "left"+i, "middle"+i, "right"+i));
    }
  
    while(!intStack.isEmpty())
    {
      System.out.println("intStack, popped:  " + intStack.pop());
    }
    System.out.println();
    
    
  
    while(!stringStack.isEmpty())
    {
      System.out.println("stringStack, popped:  " + stringStack.pop());
    }
    System.out.println();
    
    
    while(!doubleStack.isEmpty())
    {
      System.out.println("doubleStack, popped:  " + doubleStack.pop());
    }
    System.out.println();
    
    
    while(!tjStack.isEmpty())
    {
      System.out.println("towerJobStack, popped:  " + tjStack.pop());
    }
    System.out.println();
    
    
    
    
  
  } // end public static void main(String [] args)
         
        
} // end public class TestGenericLinkedStack
 
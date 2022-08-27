public class IntLinkedStack
{
   private IntNode top;
   
   public boolean isEmpty()
   {
      if (top == null)
         return true;
      else
         return false;
   }
   
   public int size()
   {
      return sizeRec(top);
   }// WRITE THIS METHOD:  sizeRec
   private int sizeRec(IntNode t)
   {
      //return the length of the stack
     
      
      if(t==null)
      {
      
         return 0;
         
      }
      else
      {  
         return 1+ sizeRec(t.next);
      }
     
   }
  
   public String toString()
   {
      return toStringRec(top);
   }
   
// WRITE THIS METHOD:  toStringRec
   private String toStringRec(IntNode t)
   {
          
      if(t==null)
      {
         return " ";   
      
      }  
      
      else
      { 
      
       return t.data + "\n" + toStringRec(t.next);
      
      }
     
         
   }
  
   public int peek()
   {
      if (isEmpty())
         throw new RuntimeException("Peek attempted on empty stack");
      else
         return top.data;
   }
   
   public void push(int m)
   {
      IntNode temp;
      temp = new IntNode();
      temp.data = m;
      
      temp.next = top;
      top = temp;
   }
   
   public int pop()
   {
      int value;
      
      if (isEmpty())
         throw new RuntimeException("Pop attempted on empty stack");
      else
      {
         value = top.data;
         top = top.next;
         return value;
      } 
   }
   
}

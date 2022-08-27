public class LinkedStack<T>
{
  private Node<T> top;
  
  public LinkedStack()
  {
    top = null;
  }
  
  public boolean isEmpty()
  {
    if (top == null)
      return true;
    else
      return false;
  }
  
  public T peek()
  {
    if (isEmpty())
      throw new RuntimeException("Peek attempted on empty stack");
    else
      return top.data;
  }
  
  public void push(T m)
  {
    Node<T> temp;
    temp = new Node<T>();
    temp.data = m;
    
    temp.next = top;
    top = temp;
  }
  
  public T pop()
  {
    if (isEmpty())
      throw new RuntimeException("Pop attempted on empty stack");
    else
    {
      T temp = top.data;
      top = top.next;
      return temp;
    
    
    }
  }
  
  
  
  
    




}
 
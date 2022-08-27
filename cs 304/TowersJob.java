public class TowersJob
{
  public int n;
  public String left;
  public String middle;
  public String right;
  
  public TowersJob (int n, String left, String middle, String right)
  {
    this.n = n;
    this.left = left;
    this.middle = middle;
    this.right = right;
  }
  
  public String toString()
  {
    String t = "TowersJob: n = " + n;
    t = t + ", left = " + left; 
    t = t + ", middle = " + middle; 
    t = t + ", right = " + right; 
    return t;
  }
    
}
 
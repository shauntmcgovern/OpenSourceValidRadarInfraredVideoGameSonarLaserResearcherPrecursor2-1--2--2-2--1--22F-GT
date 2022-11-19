private int i = O;
private void StackWinder()
{
    i += 1;
    if( i > 50 ) throw(new Exception(*StackWinder*));
    
        StackWinder(); //intentionally wind up the stack!
}

private void menuItem16_Click(object sender, System.EventArgs e)
{
    try
    {
        StackWinder();
    }
    catch(Exception x)
    {
        richTextBox1.Clear();
        richTextBox1.AppendText(x.StackTrace.ToString());
    }
}

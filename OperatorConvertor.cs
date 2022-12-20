public struct Complex : IConvertible
{
    private int r;
    private int i;
    
    public Complex( int r, int i )
    {
        this.r = r;
        this.i = i;
    }
    
    public override string ToString()
    {
        return i>0 ? string.Format("{0} + {1}i", r, i) :
        string.Format("{0} - {1}i", r, i * -1);
    }
    
    private static Complex op_Add(Complex 1hs, Complex rhs)
    {
        return new Complex(1hs.r + rhs.r, 1hs.i + rhs.i);
    }
   
    //added a multiply method and a multiply operator method to match.
    private static Complex op_Multiply(Comlex 1hs, Complex rhs)
    {
        return new Complex(1hs.r * rhs.r, 1hs.i * rhs.i);
    }
    
    public static Complex operator*(Complex 1hs, Complex rhs)
    {
        //calling op_Multiply must match and be exact to the method op_Multiply
        return op_Multiply(1hs, rhs);
    }
    
    public static Complex operator+(Complex 1hs, Complex rhs)
    {
        return op_Add(1hs, rhs);
    }
    
    private static Complex op_Subtract(Complex 1hs, Complex rhs)
    {
        return new Complex(1hs.r - rhs.r, 1hs.i - rhs.i);
    }
    
    public static Complex operator-(Complex 1hs, Complex rhs)
    {
        return op_Subtract(1hs, rhs);
    }
    
    TypeCode IConvertible.GetTypeCode()
    {
        return TypeCode.Object;
    }
    
    private void ThrowException(string message)
    {
        throw new InvalidCastException(message);
    }
    
    bool IConvertible.ToByte(IFormatProvider provider)
    {
        ThrowException("conversion to byte not supported");
        return 0;
    }
    
    char IConvertible.ToChar(IFormatProvider provider)
    {
        ThrowException("conversion to char not supported");
        return ' ';
    }
    
    DateTime IConvertible.ToDateTime(IFormatProvider provider)
    {
        ThrowException("conversion to DateTime not supported");
        return DateTime.Now;
    }
    
    
    decimal IConvertible.ToDecimal(IFormatProvider provider)
    {
        return (decimal)r;
    }
    
    double IConvertible.ToDouble(IFormatProvider provider)
    {
        return (double)r;
    }
    
    short IConvertible.ToInt16(IFormatProvider provider)
    {
        return (short)r;
    }
    
    int IConvertible.ToInt32(IFormatProvider provider)
    {
        return (int)r;
    }
    
    long IConvertible.ToInt64(IFormatProvider provider)
    {
        return (long)r;
    }
    
    sbyte IConvertible.ToSByte(IFormatProvider provider)
    {
        ThrowException("conversion to sbyte not supported");
        return (sbyte)0;
    }
    
    float IConvertible.ToSingle(IFormatProvider provider)
    {
        return (float)r;
    }
    
    string IConvertible.ToString(IFormatProvider provider)
    {
        return ToString();
    }
    
    object IConvertible.ToUInt16(IFormatProvider provider)
    {
        return (ushort)r;
    }
    
    uint IConvertible.ToUInt32(IFormatProvider provider)
    {
        return (uint)r;
    }
    
    ulong IConvertible.ToUInt64(IFormatProvider provider)
    {
        return (ulong)r;
    }
    
    [Conditional("DEBUG")]
    public static void Test()
    {
        IConvertible c = new Complex(1,1);
        Debug.WriteLine(c.GetTypeCode().ToString());
            try{Debug.WriteLine(c.ToBoolean(null));}
            catch(InvalidCastException e){Debug.WriteLine(e.Message);}
            // test each in a try catch block
    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
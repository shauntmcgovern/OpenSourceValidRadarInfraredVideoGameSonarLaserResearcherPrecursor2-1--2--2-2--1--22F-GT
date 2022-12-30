public class DateTimeBinder : Binder
{
    
    public override MethodBase BindToMethod (
        BindingFlags bindingAttr,
        MethodBase[] match, 
        ref object[] args,
        ParameterModifier[] modifiers,
        CultureInfo culture,
        string[] names,
        out object state)
    {
        state = null;
        return match.Length == 1 ? match[0] : null;
    }
    
    public override FieldInfo BindToField(
        BindingFlags bindingAttr,
        FieldInfo[] match,
        object value,
        CultureInfo culture)
    {
        return null;
    }
    
    public override MethodBase SelectMethod (
        BindingFlags bindingAttr,
        MethodBase[] match,
        Type[] types,
        ParameterModifier[] modifiers)
    {
        return null;
    }
    
    public override PropertyInfo SelectProperty(
        BindingFlags bindingAttr,
        PropertyInfo[] match,
        Type returnType,
        Type[] indexes,
        ParameterModifier[] modifiers)
    {
        return null;
    }
    
    public override object ChangeType(
        object value, 
        Type type, 
        CultureInfo culture)
    {
        if ( value.GetType() != typeof(string)) return value;
        
        try
        {
            return Convert.ToDateTime(value);
        }
        catch
        {
            return value;
        }
    }
    
    public override void ReorderArgumentArray(
        ref object[] args,
        object state) {}
} 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
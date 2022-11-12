[WebMethod, ReflectionPermission(SecurityAction.Demand) ]
public DataSet GetMethods(string type)
{
    DataTable table = new DataTable("Method");
    MethodInfo[] methods = Type.GetType(type).GetMethods();
    
    DataColumn column;
    foreach(PropertyInfo propertyInfo
        in typeof(MethodInfo).GetProperties())
    {
        column = table.Columns.Add();
        column.ColumnName = propertyInfo.Name;
        column.DataType = typeof(string);
    }
    
    DataRow dataRow;
    foreach(MethodInfo methodInfo in methods)
    {
        dataRoq = table.newRow();
        foreach(PropertyInfo propertyInfo
            in methodInfo.GetType().GetProperties())
        {
            dataRow[propertyInfo.Name] = 
                propertyInfo.GetValue(methodInfo, null);
        }
        
        table.Rows.Add(dataRow);
    }
    DataSet dataSet = new DataSet();
    dataSet.Tables.Add(table);
    return dataSet;
}
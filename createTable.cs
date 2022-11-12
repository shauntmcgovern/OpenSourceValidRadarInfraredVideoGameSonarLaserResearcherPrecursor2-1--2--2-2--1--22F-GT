const string connectionString =
    @"Provider-Microsoft.Jet.OLEDB.4.0;Password=;" +
    @"User ID=;Data Source=C:Temp\Reference.mdb;";
OleDbConnection connection = new OleDbConnection();
const string SQL =
    @"CREATE TABLE Constructor ([ID] COUNTER (1,1), " +
    @"[MemberType] string, [MethodHandle] string, " +
    @"[Attributes] string, [IsPublic] string, " +
    @"[IsPrivate] string, [IsFamily] string, " +
    @"[IsAssembly] string, [IsFamilyAndAssembly] string, " +
    @"[IsFamilyOrAssembly] string, [IsStatic] string, " +
    @"[IsFinal] string, [IsVirtual] string, [IsHideBySig] string, " +
    @"[IsAbstract] string, [IsSpecialName] string, " +
    @"[IsConstructor] string, [CallingCovention] string, " +
    @"[Name] string, [DeclaringType] string, " +
    @"CONSTRAINT [Index1] PRIMARY KEY ([ID]))";
OleDbCommand command = new OleDbCommand(SQL, connection);
command.ExecuteNonQuery();
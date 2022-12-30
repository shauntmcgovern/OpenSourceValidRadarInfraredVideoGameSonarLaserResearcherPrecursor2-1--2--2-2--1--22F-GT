private void EmitConstructor(TypeBuilder typeBuilder)
{
    ContructorBuilder constructor = 
        CreateConstructorBuilder(typeBuilder, new Type[]{});
    
    ILGenerator generator = constructor.GetILGenerator();
    EmitConstructorCode(generator);
}

private void EmitConstructorCode(ILGenerator generator)
{
    generator.Emit(OpCodes.Ldarg_0);
    Type type = typeof(System.Collections.CollectionBase);
    ConstructorInfo parent = 
        type.GetConstructor(BindingFlags.NonPublic | 
        BindingFlags.Instance, null, Type.EmptyTypes, null);
        
    generator.Emit(OpCodes.Call, parent);
    generator.Emit(Opcodes.Ret);
}
namespace TJC.Decorator;

public class DecoratorBaseClass<TDecoratable>(TDecoratable decoratable) : IDecoratable
    where TDecoratable : IDecoratable
{
    protected readonly TDecoratable Decoratable = decoratable;

    public virtual T1? GetAs<T1>()
        where T1 : class =>
        GetType() == typeof(T1) || GetType().GetInterfaces().Any(x => x == typeof(T1))
            ? this as T1
            : Decoratable.GetAs<T1>();

    public bool IsType<T2>()
        where T2 : class => GetAs<T2>() != null;
}

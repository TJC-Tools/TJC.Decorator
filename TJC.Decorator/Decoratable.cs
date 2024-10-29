namespace TJC.Decorator;

public class Decoratable : IDecoratable
{
    public T? GetAs<T>()
        where T : class => typeof(T) == typeof(Decoratable) ? this as T : null;

    public bool IsType<T>()
        where T : class => GetAs<T>() != null;
}

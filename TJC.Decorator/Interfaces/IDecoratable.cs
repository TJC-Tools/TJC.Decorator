namespace TJC.Decorator.Interfaces;

public interface IDecoratable
{
    T? GetAs<T>()
        where T : class;

    bool IsType<T>()
        where T : class;
}

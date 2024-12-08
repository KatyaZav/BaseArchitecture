using System;

namespace Assets.Game.Develop.Utils.Reactive
{
    public interface IReadOnlyVariable<T>
    {
        event Action<T, T> Changed;

        T Value { get; }
    }
}

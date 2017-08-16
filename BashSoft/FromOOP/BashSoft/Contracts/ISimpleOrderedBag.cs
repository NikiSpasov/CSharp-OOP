namespace BashSoft.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ISimpleOrderedBag<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        int Size { get; }

        string JoinWith(string joiner);

        void Add(T element);

        void AddAll(ICollection<T> collection);
    }
}

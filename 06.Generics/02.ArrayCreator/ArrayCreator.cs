public static class ArrayCreator
{
    public static T[] Create<T>(int lenght, T item)
    {
        var myArray = new T[lenght];
        for (int i = 0; i < lenght - 1; i++)
        {
            myArray[i] = item;
        }
        return myArray;
    }
}


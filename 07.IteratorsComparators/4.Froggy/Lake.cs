
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Lake : IEnumerable<int>
{
    public List<int> StoneNumbers;

    public Lake(List<int> stones)
    {
        this.StoneNumbers = stones;
    }
    public void Jump()
    {
        foreach (var stone in StoneNumbers)
        {
            Console.WriteLine(stone);
        }
    }
    public IEnumerator<int> GetEnumerator()
    {
        StringBuilder sb = new StringBuilder();


        for (int i = 0; i < StoneNumbers.Count; i += 2)
        {
            sb.Append(StoneNumbers[i] + " ");
        }
        if (StoneNumbers.Count % 2 != 0)
        {
            for (int i = StoneNumbers.Count - 2; i >= 1; i -= 2)
            {
                sb.Append(StoneNumbers[i] + " ");
            }
        }
        else
        {
            for (int i = StoneNumbers.Count - 1; i >= 1; i -= 2)
            {
                sb.Append(StoneNumbers[i] + " ");
            }
        }      
        List<string> final = sb.ToString().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        foreach (var num in final)
        {
            yield return int.Parse(num);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


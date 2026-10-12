using UnityEngine;
using System;

public class UnityIntegerSorter : MonoBehaviour
{
    public void TestSort(int[] a, int length)
    {
        if (a == null)
        {
            Debug.LogError("Array cannot be null.");
            return;
        }

        if (length < 0 || length > a.Length)
        {
            Debug.LogError("Length is outside the array bounds.");
            return;
        }

        Array.Sort(a, 0, length);
    }
}
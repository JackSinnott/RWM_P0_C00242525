using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diff : MonoBehaviour
{
    public static int[] Difference(int[] xs)
    {
        int[] copyArrayBaby = new int[xs.Length];
        int finalNum = 0;
        int prevNum = 0;

        for (int i = 0; i < xs.Length; i++)
        {
            int num = xs[i];

            // initially subsitute 0
            if (i == 0)
            {
                prevNum = 0;
                finalNum = num - prevNum;
            }
            // Then subsitute previous number in array
            else
            {
                prevNum = xs[i - 1];
                finalNum = prevNum - num;
            }

            // Absolute values so change any negative numbers to positive ones
            if (finalNum < 0)
                finalNum *= -1;

            Debug.Log(finalNum);
            copyArrayBaby[i] = finalNum;

        }
        return copyArrayBaby;
    }
}

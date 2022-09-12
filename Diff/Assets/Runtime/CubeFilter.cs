using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFilter : MonoBehaviour
{
    //static int[] numbersBaby = new int[10] {4, 2, 8, 3, 9, 4, 10, 5, 11, 6};

 //   foreach (var nums in numbersBaby)
	//{
 //       int = numBaby; // initial num
 //       numBaby = nums;
 //       int numBabyJr = 0; // log of number thats next
 //       numBaby = nums;

 //       int diffBaby = numBaby - numBabyjr; // sum to output

 //       console.writeLine(diffBaby);
	//}
    public static int[] Diff(int[] xs)
    {
        int[] copyArrayBaby = new int[xs.Length];
        int finalNum = 0;
        int prevNum = 0;

        for (int i = 0; i < xs.Length; i++)
        {
            int num = xs[i];
            
            if (i == 0)
            {
                prevNum = 0;
                finalNum = num - prevNum;
            }
            else
            {
                prevNum = xs[i - 1];
                finalNum = prevNum - num;
            }
            

            
            


            if (finalNum < 0)
                finalNum *= -1;

            Debug.Log(finalNum);
            copyArrayBaby[i] = finalNum;

        }
        return copyArrayBaby;
    }
}

/*An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.

Your goal is to find that missing element.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A, returns the value of the missing element.

For example, given array A such that:

  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5
the function should return 4, as it is the missing element.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..100,000];
the elements of A are all distinct;
each element of array A is an integer within the range [1..(N + 1)].
Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.*/

using System;

class Solution {
    public int solution(int[] A) {
        if(A.Length==0){
            return 1;
        }
        if(A.Length==1){
            return A[0]==1 ? 2: 1;
        }

        int result=0;

        Array.Sort(A);

        for(int i=0; i<A.Length; i++){
            if(A[i] != i+1){
                result = i+1;
                break;
            }                
        }
        if(result!=0){
            return result;
        }else{
            return A.Length+1;
        }
        
    }
}

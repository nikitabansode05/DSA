//Find the Missing Number: Given an array containing $n-1$ integers in the range of $[1, n]$, find the one that is missing.
//key concept:Math / XOR

class Solution {
    public static int[] twoSum(int[] nums, int target) {
        int[] answer=new int[2];
       for(int i=0;i<nums.length;i++){
        for(int j=i+1;j<nums.length;j++){
            if(nums[i]+nums[j]==target){  
                 answer[0]=i;
                 answer[1]=j;
                 return answer;
            }   
        }       
    }
    return answer;
    }

    public static void main(String[] args){
        int[] numbers={3,3};
        int[] result=twoSum(numbers,6);
        System.out.println("Indices: " + result[0] + ", " + result[1]);
    }
}

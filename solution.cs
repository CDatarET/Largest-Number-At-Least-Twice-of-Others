public class Solution {
    public int DominantIndex(int[] nums) {
        int max = nums[0];
        int ret = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > max){
                max = nums[i];
                ret = i;
            }
        }

        for(int i = 0; i < nums.Length; i++){
            if(i == ret){
                continue;
            }
            if(max < nums[i] * 2){
                return(-1);
            }
        }
        return(ret);
    }
}

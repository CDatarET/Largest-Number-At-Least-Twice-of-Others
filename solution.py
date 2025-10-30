class Solution:
    def dominantIndex(self, nums: List[int]) -> int:
        m = nums[0]
        ret = 0
        for i in range(len(nums)):
            if nums[i] > m:
                m = nums[i]
                ret = i
        
        for i in range(len(nums)):
            if i == ret:
                continue
            
            if m < nums[i] * 2:
                return -1
        
        return ret

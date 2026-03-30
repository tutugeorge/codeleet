class Solution(object):
    def divideArray(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """

        # resultMap = {}
        # for num in nums:
        #     if resultMap.get(num) is None:
        #         resultMap[num]= 1
        #     else:
        #         del resultMap[num]
        
        # return resultMap == {}

        resultMap = set()
        for num in nums:
            if num not in resultMap:
                resultMap.add(num)
            else:
                resultMap.remove(num)
        
        return len(resultMap) == 0 

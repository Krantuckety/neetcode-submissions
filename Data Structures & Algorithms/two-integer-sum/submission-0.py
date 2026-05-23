class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hash_table = defaultdict(list)
        output = [0] * 2
        for index, value in enumerate(nums):
            diff = target - value
            if diff in hash_table:
                output[0] = hash_table[diff][0]
                output[1] = index
                break
            hash_table[value].append(index)
        return output
            
        
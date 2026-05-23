class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        checkDupes = set()
        for item in nums:
            if item in checkDupes:
                return True
            checkDupes.add(item)
        return False
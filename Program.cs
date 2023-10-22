int FindDuplicate(int[] nums) {
    int slow = 0, fast = 0;
    while(true)
    {
        slow = nums[slow];
        fast = nums[nums[fast]];
        if(slow == fast) break;
    }

    int slow_ = 0;

    while(true)
    {
        slow = nums[slow];
        slow_ = nums[slow_];
        if(slow == slow_) return slow_;
    }
}
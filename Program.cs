using System;
// each question have own branch

int[][] Merge(int[][] intervals) 
{
    Array.Sort(intervals,(x,y)=> x[0] - y[0]);

    int resIndex = 0;
    for(int i=1;i < intervals.Length;i++){
        var interval = intervals[resIndex][1];
        if(interval >= intervals[i][0])
        {
            if(interval < intervals[i][1])
                intervals[resIndex][1] = intervals[i][1];
        }else
        {
            resIndex++;
            intervals[resIndex] = intervals[i];
        }
    }

    resIndex++;
    return intervals[..resIndex];
}
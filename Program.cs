// each question have own branch

public bool CanFinish(int numCourses, int[][] prerequisites) {
{
    var dict = new Dictionary<int,List<int>>();
    for(int i=0;i< numCourses;i++)
    {
        dict.Add(i,new List<int>());
    }

    foreach(var prerequisite in prerequisites)
    {
        dict[prerequisite[0]].Add(prerequisite[1]);
    }
    
    var visitSet = new HashSet<int>();

    bool DFS(int course)
    {
        if(visitSet.Contains(course))
        {
            return false;
        }

        if(dict[course].Count == 0)
        {
            return true;
        }
        visitSet.Add(course);

        foreach(int child in dict[course])
        {
            if(!DFS(child)) 
            {
                return false;
            }
        }
        visitSet.Remove(course);
        dict[course] = new List<int>();
        return true;
    }

    for(int i=0;i< numCourses;i++)
    {
        if(!DFS(0)) return false;
    }

    return true;
}
    

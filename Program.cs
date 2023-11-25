using System.Collections;

bool CheckInclusion(string s1, string s2) 
    {
                 int l1 = s1.Length;
            int l2 = s2.Length;
            if(l1 > l2)
            {
                return false;
            }
            var h1 = new int[26];
            var h2 = new int[26];
            int matches = 0;

            foreach(char ch in s1)
            {
                h1[Index(ch)]++;
                h2[Index(ch)]++;
            }     

            for(int i=0;i<26;i++)
            {
                if(h1[i] == h2[i])
                {
                    matches++;
                }
            }

            int j = 0;
            for(int i = l1;i < l2;i++)
            {  
                if(matches == 26)return true;

                var index = Index(s2[i]);
                h2[index]++;
                if(h1[index] == h2[index])
                {
                    matches++;
                }
                else if(h1[index] + 1 == h2[index])
                {
                    matches--;
                }


                index = Index(s2[j]);
                h2[index]--;
                if(h1[index] == h2[index])
                {
                    matches++;
                }
                else if(h1[index]  - 1 == h2[index])
                {
                    matches--;
                }

                j++;
            }

            return matches == 26;
    }

    int Index(int ch) => ch - 97;

Console.WriteLine(CheckInclusion("ab","eidbaooo"));
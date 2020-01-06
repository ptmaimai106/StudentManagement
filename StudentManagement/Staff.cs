using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class Staff
    {
        internal void Post(Category group, string content, string[] topics)
        {
            group.AddPost( content,
                PrepareTopicDictionary(topics));
        }

        internal Dictionary<string, int> PrepareTopicDictionary(string[] topics)
        {
            Dictionary<string, int> res = new Dictionary<string, int>();
            for (int i = 0; i < topics.Length; i++)
                res.Add(topics[i], 1);
            return res;
        }

        // add student

    }
}
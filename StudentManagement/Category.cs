using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class Category
    {
        Dictionary<CObject, string[]> subscribers = new Dictionary<CObject, string[]>();
        List<Post> posts = new List<Post>();
        private string Name;

        public Category(string name)
        {
            this.Name = name;
        }

        public bool Join(CObject u, string[] topics)
        {
            subscribers.Add(u, topics);
            return true;
        }


        public bool UpdateUserTopics(CObject u, string[] newtopics)
        {
            if (subscribers.ContainsKey(u))
            {
                subscribers[u] = newtopics;
                return true;
            }
            return false;
        }

        public bool AddPost( string content, Dictionary<string, int> topics)
        {
            Post p = new Post(content, topics);
            NotifyAll(p);
            posts.Add(p);
            return true;
        }

        private void NotifyAll(Post p)
        {
            foreach (CObject u in subscribers.Keys)
            {
                if (IsAppropriate(p, u))
                    u.GetNotify(p);
            }
        }

        private bool IsAppropriate(Post p, CObject u)
        {
            TopicChecker checker = new DefaultChecker();
            if (checker.IsOK(p, subscribers[u]))
                return true;
            return false;
        }

    }
}
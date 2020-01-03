using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class Post
    {
        public string Content;
        public Dictionary<string, int> Topics;

        public Post(string content, Dictionary<string, int> topics)
        {
            Content = content;
            Topics = topics;
        }
    }
}
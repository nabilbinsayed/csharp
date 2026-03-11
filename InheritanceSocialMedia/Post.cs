using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMed
{
    class Post
    {
        private static int currentPostId = 0;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }



        public Post()
        {
            ID = 0;
            Title = "first post";
            IsPublic = true;
            SendByUsername = "bodi";
        }

        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendByUsername}");
        }

        

    }
}
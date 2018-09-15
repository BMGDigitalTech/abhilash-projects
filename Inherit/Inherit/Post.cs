using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Post:IMessage
    {
        private static int currentId=0;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string UserName { get; set; }

        public Post()
        {
            this.ID = 0;
            this.Title = "My First Post";
            this.UserName = "User";
        }

        public Post(string postTitle, string uname)
        {
            this.ID = getCurrentId();
            this.Title = postTitle;
            this.UserName = uname;
        }

        public string getDate()
        {
            DateTime dt = new DateTime();
            return dt.Date.ToString();
        }

        public void sendMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        protected int getCurrentId()
        {
            return ++currentId;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.ID, this.Title, this.UserName);
        }

       
    }
}

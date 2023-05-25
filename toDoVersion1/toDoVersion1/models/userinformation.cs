using System;
namespace VIlla.models
{
    public class userinformation
    {
        //public todoDTO storedTodo = new todoDTO();
        public string username { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public string taskName { set; get; }
        public DateTime dateAdded { get; set; }
        public DateTime deadLineDate { get; set; }
        public string description { get; set; }
    }
}


using System;
using VIlla.models;

namespace VIlla.database
{
    public static class dataStore
    {



        public static todoDTOstore storedTodo = new todoDTOstore();
        public static List<userinformation> store = new List<userinformation>{
        new userinformation{ username="sam",email="lemgn@gmail.com",password="asd",
            taskName=storedTodo.todostore.taskName, dateAdded=storedTodo.todostore.dateAdded,description=storedTodo.todostore.description}



        };
        //	storedTodo=new todoDTO
        //{
        //	taskName="learning", dateAdded=DateTime.Now, deadLineDate=DateTime.Now, description="C# study"
        //}


    }
}


using System;
using VIlla.models;

namespace VIlla.database
{
    public class todoDTOstore
    {
        static DateTime day = DateTime.Now;
        public todoDTO todostore = new todoDTO()
        {
            taskName = "learning",
            dateAdded = day,
            deadLineDate = day.AddDays(2),
            description = "study c# in home"
        };
        //      static DateTime day = DateTime.Now;
        //public static List<todoDTO> todoStore = new List<todoDTO>{
        //	new todoDTO{taskName="study", dateAdded=day,deadLineDate=day.AddDays(2), description=" learn C#"}
        //};



    }
}


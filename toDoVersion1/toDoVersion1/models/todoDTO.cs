using System;
namespace VIlla.models
{
    public class todoDTO
    {
        public string taskName { get; set; }
        public DateTime dateAdded { get; set; }
        public DateTime deadLineDate { get; set; }
        public string description { get; set; }

        //public static implicit operator todoDTO(todoDTO v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}


using System;
namespace TodoBusinessLayer.DataContract.Todo
{
    public class TodoUpdateDTO
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

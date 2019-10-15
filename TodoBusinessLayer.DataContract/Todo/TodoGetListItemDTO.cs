using System;
namespace TodoBusinessLayer.DataContract.Todo
{
    public class TodoGetListItemDTO
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsCompleted { get; set; }
    }
}

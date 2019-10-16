using System;
namespace TodoWebApi.DataContract.Todo
{
    public class TodoGetListItemRAO
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}

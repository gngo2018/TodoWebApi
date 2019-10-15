using System;
namespace TodoWebApi.DataContract.Todo
{
    public class TodoGetListItemResponse
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsCompleted { get; set; }

    }
}

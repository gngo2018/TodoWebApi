using System;
namespace TodoWebApi.DataContract.Todo
{
    public class TodoCreateRequest
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}

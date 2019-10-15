using System;
using System.ComponentModel.DataAnnotations;

namespace TodoData.Entities
{
    public class TodoDataModel
    {
        [Key]
        public int TodoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
    }
}

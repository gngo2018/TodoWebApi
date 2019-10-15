using System;
using Microsoft.EntityFrameworkCore;
using TodoData.DataModelConfig;
using TodoData.Entities;

namespace TodoData.DataContext
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfiguration(new TodoConfig());

        //Setting the DB, Need to make sure that you name it exactly as it is in the database
        public DbSet<TodoDataModel> Todo { get; set; }
        
    }
}

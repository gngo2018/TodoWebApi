using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoData.Entities;

namespace TodoData.DataModelConfig
{
    public class TodoConfig : IEntityTypeConfiguration<TodoDataModel>
    {
        public void Configure(EntityTypeBuilder<TodoDataModel> builder)
        {
            builder.HasKey(prop => prop.TodoId);

            builder.Property(prop => prop.CreatedOn)
                .HasColumnType("TIMESTAMP(0)")
                .IsRequired();

            builder.Property(prop => prop.Body)
                .HasMaxLength(1000);

            builder.Property(prop => prop.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(prop => prop.IsCompleted)
                .IsRequired();
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StackClone.Models;

namespace StackClone.Migrations
{
    [DbContext(typeof(StackCloneDBContext))]
    partial class StackCloneDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5");

            modelBuilder.Entity("StackClone.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AnswersAnswerId");

                    b.Property<string>("Content");

                    b.Property<string>("Name");

                    b.Property<int>("PostId");

                    b.HasKey("AnswerId");

                    b.HasIndex("AnswersAnswerId");

                    b.HasIndex("PostId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("StackClone.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Question");

                    b.Property<string>("Title");

                    b.Property<string>("Username");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("StackClone.Models.Answer", b =>
                {
                    b.HasOne("StackClone.Models.Answer", "Answers")
                        .WithMany()
                        .HasForeignKey("AnswersAnswerId");

                    b.HasOne("StackClone.Models.Post")
                        .WithMany("Answers")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

// <auto-generated />
using System;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.NETCoreWebApiWithEFCoreUsingStudentDetails.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RollNo")
                        .HasColumnType("int");

                    b.Property<string>("StudentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentMarks")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("RollNo");

                    b.ToTable("Studentss");
                });

            modelBuilder.Entity("ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model.StudentPerformance", b =>
                {
                    b.Property<int>("RollNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RollNo"));

                    b.Property<string>("ExamType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Performance")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RollNo");

                    b.ToTable("StudentPerformances");
                });

            modelBuilder.Entity("ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model.Student", b =>
                {
                    b.HasOne("ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model.StudentPerformance", "StudentPerformance")
                        .WithMany()
                        .HasForeignKey("RollNo");

                    b.Navigation("StudentPerformance");
                });
#pragma warning restore 612, 618
        }
    }
}

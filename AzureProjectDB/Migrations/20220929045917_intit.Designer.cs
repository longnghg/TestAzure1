// <auto-generated />
using AzureProjectDB.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AzureProjectDB.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220929045917_intit")]
    partial class intit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AzureProjectDB.Models.ErrorViewModel", b =>
                {
                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdProVip")
                        .HasColumnType("int");

                    b.HasKey("RequestId");

                    b.ToTable("tableFir");
                });
#pragma warning restore 612, 618
        }
    }
}

// <auto-generated />
using FirstWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstWebApplication.Migrations
{
    [DbContext(typeof(BankCustomerDetails))]
    partial class BankCustomerDetailsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FirstWebApplication.Models.BankCustomer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OpeningBalance")
                        .HasColumnType("varchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("bankCustomers");
                });
#pragma warning restore 612, 618
        }
    }
}

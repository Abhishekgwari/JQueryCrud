using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JQueryCrud.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    Nominee = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    IFSCCode = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}

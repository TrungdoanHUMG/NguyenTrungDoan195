using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenTrungDoan195.Migrations
{
    /// <inheritdoc />
    public partial class sinhvien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    SoBaoDanh = table.Column<string>(type: "TEXT", nullable: false),
                    Diem = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSinhVien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVien");
        }
    }
}

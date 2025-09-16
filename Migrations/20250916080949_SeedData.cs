using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BaithuchanhWeb2.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Nguyễn Nhật Ánh" },
                    { 2, "Tô Hoài" },
                    { 3, "Nam Cao" },
                    { 4, "Ngô Tất Tố" },
                    { 5, "Vũ Trọng Phụng" },
                    { 6, "Nguyễn Du" },
                    { 7, "Xuân Quỳnh" },
                    { 8, "Hồ Chí Minh" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "NXB Kim Đồng" },
                    { 2, "NXB Trẻ" },
                    { 3, "NXB Văn học" },
                    { 4, "NXB Giáo dục Việt Nam" },
                    { 5, "NXB Hội Nhà văn" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CoverUrl", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "PublisherId", "Rate", "Title" },
                values: new object[,]
                {
                    { 1, "https://example.com/kinh-van-hoa.jpg", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một cuốn sách hay về tuổi thơ và những kỷ niệm đẹp", "Văn học thiếu nhi", true, 1, 5, "Kính vạn hoa" },
                    { 2, "https://example.com/de-men.jpg", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuốn sách kinh điển về cuộc phiêu lưu của chú dế Mèn", "Văn học thiếu nhi", true, 2, 5, "Dế Mèn phiêu lưu ký" },
                    { 3, "https://example.com/chi-pheo.jpg", new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tác phẩm nổi tiếng của Nam Cao về số phận con người", "Văn học hiện đại", true, 3, 4, "Chí Phèo" },
                    { 4, "https://example.com/tat-den.jpg", new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tiểu thuyết đầu tay của Ngô Tất Tố về đời sống nông thôn", "Văn học hiện đại", false, 3, null, "Tắt đèn" },
                    { 5, "https://example.com/so-do.jpg", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tác phẩm châm biếm xã hội của Vũ Trọng Phụng", "Văn học hiện đại", true, 4, 4, "Số đỏ" },
                    { 6, "https://example.com/truyen-kieu.jpg", new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kiệt tác văn học cổ điển Việt Nam", "Văn học cổ điển", false, 5, null, "Truyện Kiều" },
                    { 7, "https://example.com/song.jpg", new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tập thơ nổi tiếng của nhà thơ Xuân Quỳnh", "Thơ", true, 5, 5, "Sóng" }
                });

            migrationBuilder.InsertData(
                table: "Books_Authors",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books_Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books_Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books_Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books_Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books_Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books_Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books_Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

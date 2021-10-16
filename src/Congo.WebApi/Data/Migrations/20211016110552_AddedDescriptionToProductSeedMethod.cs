using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Congo.WebApi.Data.Migrations
{
    public partial class AddedDescriptionToProductSeedMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e162912-7a39-4df6-a4c0-d2a55f02e855"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ede58c0-b070-4b49-a8e9-5aaee4dc8124"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67c458f5-f8c7-49b4-b874-6ad8da2a1e27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("731bb48b-09dc-4291-88fc-85bcda4dea8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85149cb8-4aba-4ff0-92e4-81cea519c220"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a047ba0b-58d7-45ac-8d49-647c9f92b2bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d104a0b8-32b1-434e-a005-7ccbeba2af14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1cd6557-984c-46f5-819a-79b6c5b5e210"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db6a7d0b-630a-4125-8e70-d5f7c76c63be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee05fa67-e090-485e-aaee-e325bc2f60e4"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4e434a20-7661-458e-9be0-994b01272f85"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Screwdriver", 5.99m },
                    { new Guid("511fa7ab-f70b-45a1-827b-d9214fc80fd3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "AMD Ryzen 7 5900X", 499.99m },
                    { new Guid("66ec0969-5566-4752-83e6-828e047a2c0e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "A Rock", 0.99m },
                    { new Guid("7f2090cc-c768-4ee8-8595-65a8d6555678"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "5-Piece Gardening Kit", 34.99m },
                    { new Guid("9ca58986-b5f5-4106-bf76-cf084f8ffb7f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Box of Chocolates", 9.99m },
                    { new Guid("a50eb43e-5047-4722-a5f7-e5012c3c3121"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Window Cleaning Solution", 4.99m },
                    { new Guid("5119d346-7730-478b-a45b-98e4e01126b7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Paper shredder", 44.99m },
                    { new Guid("8a421ed9-5374-4a6c-a0b9-f3682e1a3ac1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Xbox Controller", 119.99m },
                    { new Guid("bf8dd84e-7d15-4d3b-a012-542531124288"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "LED Light Bulb - 8 pack", 44.99m },
                    { new Guid("4de38e9f-70dc-497a-b791-e7c41ddd6158"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "A Dance With Dragons - Hard Cover", 39.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4de38e9f-70dc-497a-b791-e7c41ddd6158"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e434a20-7661-458e-9be0-994b01272f85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5119d346-7730-478b-a45b-98e4e01126b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("511fa7ab-f70b-45a1-827b-d9214fc80fd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66ec0969-5566-4752-83e6-828e047a2c0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f2090cc-c768-4ee8-8595-65a8d6555678"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a421ed9-5374-4a6c-a0b9-f3682e1a3ac1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ca58986-b5f5-4106-bf76-cf084f8ffb7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a50eb43e-5047-4722-a5f7-e5012c3c3121"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf8dd84e-7d15-4d3b-a012-542531124288"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a047ba0b-58d7-45ac-8d49-647c9f92b2bf"), null, "https://via.placeholder.com/150", "Screwdriver", 5.99m },
                    { new Guid("d1cd6557-984c-46f5-819a-79b6c5b5e210"), null, "https://via.placeholder.com/150", "AMD Ryzen 7 5900X", 499.99m },
                    { new Guid("67c458f5-f8c7-49b4-b874-6ad8da2a1e27"), null, "https://via.placeholder.com/150", "A Rock", 0.99m },
                    { new Guid("0e162912-7a39-4df6-a4c0-d2a55f02e855"), null, "https://via.placeholder.com/150", "5-Piece Gardening Kit", 34.99m },
                    { new Guid("d104a0b8-32b1-434e-a005-7ccbeba2af14"), null, "https://via.placeholder.com/150", "Box of Chocolates", 9.99m },
                    { new Guid("db6a7d0b-630a-4125-8e70-d5f7c76c63be"), null, "https://via.placeholder.com/150", "Window Cleaning Solution", 4.99m },
                    { new Guid("85149cb8-4aba-4ff0-92e4-81cea519c220"), null, "https://via.placeholder.com/150", "Paper shredder", 44.99m },
                    { new Guid("731bb48b-09dc-4291-88fc-85bcda4dea8f"), null, "https://via.placeholder.com/150", "Xbox Controller", 119.99m },
                    { new Guid("2ede58c0-b070-4b49-a8e9-5aaee4dc8124"), null, "https://via.placeholder.com/150", "LED Light Bulb - 8 pack", 44.99m },
                    { new Guid("ee05fa67-e090-485e-aaee-e325bc2f60e4"), null, "https://via.placeholder.com/150", "A Dance With Dragons - Hard Cover", 39.99m }
                });
        }
    }
}

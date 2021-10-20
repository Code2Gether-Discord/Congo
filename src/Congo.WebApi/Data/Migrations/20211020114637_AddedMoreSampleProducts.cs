using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Congo.WebApi.Data.Migrations
{
    public partial class AddedMoreSampleProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("8730bfc5-2346-48d5-8daf-f19d2a829c98"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Screwdriver", 331.583643352666m },
                    { new Guid("26811ed8-02fb-475b-a895-65105f56463a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "A Rock", 29.9549600102403m },
                    { new Guid("982c1fa5-806d-453a-955e-40a1b0a5293c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "5-Piece Gardening Kit", 814.20028616196m },
                    { new Guid("d32eaa9d-c382-4313-a938-645e031f52f4"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Box of Chocolates", 334.044173271197m },
                    { new Guid("cc503db9-189c-4fb3-b525-61beff664e3d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Window Cleaning Solution", 283.883111852414m },
                    { new Guid("7ff9d613-f177-4585-b69c-68fa96551339"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Paper shredder", 236.233716050984m },
                    { new Guid("d7cb17ea-6684-4439-9be0-a2ca55aad2a0"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Xbox Controller", 797.477404482666m },
                    { new Guid("3767a915-c0af-4b64-b3e6-8c834c349356"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "LED Light Bulb - 8 pack", 177.567304362588m },
                    { new Guid("1b839928-4a82-4528-9399-d92c5787f999"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "A Dance With Dragons - Hard Cover", 27.9466723457336m },
                    { new Guid("35813104-0708-4c0d-ab32-42541c7cb1d1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Licensed Steel Pants", 601.436806830096m },
                    { new Guid("76130ab1-800c-4b8d-8c57-aa369822d49c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "AMD Ryzen 7 5900X", 105.361059035124m },
                    { new Guid("683b2bcd-c42c-4a1f-b245-d7c9a3817c2e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Practical Steel Gloves", 107.722829317792m },
                    { new Guid("c157d2c1-3b80-4eb6-99a2-364a312a96e5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Incredible Fresh Fish", 741.761513731112m },
                    { new Guid("1b9bb5c9-7825-4849-a093-a28448489096"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Practical Granite Cheese", 722.345746221894m },
                    { new Guid("3adf7f41-0675-4e29-ba0d-c664381269d1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Sleek Soft Chair", 769.439450031132m },
                    { new Guid("d99b733f-d23b-4f5f-bbb8-6ba9d48d52e4"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Generic Steel Chair", 48.0442431250467m },
                    { new Guid("281c10e1-724a-4c11-8f85-40416f3f3a5e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Refined Concrete Shoes", 93.5110182706458m },
                    { new Guid("e17bfe95-006b-46bc-b4ee-c3e451a0397d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Tasty Rubber Table", 223.84518762416m },
                    { new Guid("96c8e13f-46c3-4ddb-930c-9b5ff819b001"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Handmade Steel Ball", 87.2483528553407m },
                    { new Guid("4fb0810d-41ec-4819-a546-c164f467f5c5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Jewelery", 120.564707629427m },
                    { new Guid("a8d29e39-a550-4bc2-94eb-a7ceae88b848"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Refined Cotton Gloves", 866.484198041733m },
                    { new Guid("2e0e3e45-28f0-4056-b027-8e71fb218f6d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Refined Plastic Shoes", 773.426819913535m },
                    { new Guid("3f242320-6551-43ba-9d0f-90b991de40ed"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Screwdriver", 570.942643662204m },
                    { new Guid("c303b5a2-91d2-476b-9a6a-6d44ad4495db"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Fantastic Plastic Table", 474.35146603914m },
                    { new Guid("266e413c-2b6e-4a74-880f-69caa0417886"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Generic Rubber Pants", 367.287782614034m },
                    { new Guid("03517da3-d3d1-4267-9a7d-0fe039a23425"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "AMD Ryzen 7 5900X", 798.685430532422m },
                    { new Guid("94377578-c249-40ff-87d7-bbb965893df1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "A Rock", 217.587337448782m },
                    { new Guid("84fc9da7-a72c-491b-a5eb-27b7b5366bfc"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "5-Piece Gardening Kit", 414.537652129805m },
                    { new Guid("fee898f3-8630-4632-924f-52c41cdd2246"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Box of Chocolates", 189.636132677629m },
                    { new Guid("62b47a87-2f12-4221-9195-815acec605c8"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Window Cleaning Solution", 657.576191211169m },
                    { new Guid("5418c5e4-51c1-4be7-867b-23ab69259095"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Paper shredder", 96.2439118548175m },
                    { new Guid("00b306e8-164e-4881-b9ef-e180bf5f7d4a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Xbox Controller", 499.487247335267m },
                    { new Guid("4a4ab74b-1205-415e-93c4-dc87d0e37575"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "LED Light Bulb - 8 pack", 199.710894823652m },
                    { new Guid("4dc42389-013a-4b97-8858-587683d93587"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "A Dance With Dragons - Hard Cover", 976.883902110818m },
                    { new Guid("5c08caa4-4cff-451c-ae34-96ba993e5035"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Licensed Steel Pants", 259.713725624254m },
                    { new Guid("83a6dc04-30a7-4be2-a98a-e6102da16ef1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Practical Steel Gloves", 493.797046540457m },
                    { new Guid("9aff7b6d-245a-48b6-bb11-e70d5558cce7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Refined Plastic Shoes", 623.719017679453m },
                    { new Guid("bc927a9f-e066-4a5a-8751-9f8c1e4c821e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Incredible Fresh Fish", 521.400573404474m },
                    { new Guid("06301511-f05c-49d4-a99f-dd7ac24dad1e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Practical Granite Cheese", 541.776629823868m },
                    { new Guid("b528af0c-bbc1-4263-801c-b143b6aeb63a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Sleek Soft Chair", 379.418682911875m },
                    { new Guid("41ce9544-79ce-4177-a13a-994010c623e7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Generic Steel Chair", 202.787549832984m },
                    { new Guid("36d4ded2-b436-4495-9ba7-32eed3d6c1e3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Refined Concrete Shoes", 143.025703857446m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("85597b9a-f24f-424a-bc8a-e8a16f3123ca"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Tasty Rubber Table", 366.157638220437m },
                    { new Guid("f772c0c9-e480-4539-a70f-d4f0e50afb4d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Handmade Steel Ball", 857.057672045002m },
                    { new Guid("cbd243c1-5416-44b7-a3f1-1f85ec521aca"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Jewelery", 538.416145007101m },
                    { new Guid("6aff83f7-347f-4e53-8e3e-fef2fe387ee5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Refined Cotton Gloves", 333.070613260195m },
                    { new Guid("e5b7a2fd-1838-44de-91d6-e02b857f857f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Generic Rubber Pants", 706.623188653566m },
                    { new Guid("d299db9b-0417-4432-87f7-6f27eb85f95d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ", "https://via.placeholder.com/150", "Fantastic Plastic Table", 295.138525146371m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00b306e8-164e-4881-b9ef-e180bf5f7d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03517da3-d3d1-4267-9a7d-0fe039a23425"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06301511-f05c-49d4-a99f-dd7ac24dad1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b839928-4a82-4528-9399-d92c5787f999"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b9bb5c9-7825-4849-a093-a28448489096"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("266e413c-2b6e-4a74-880f-69caa0417886"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26811ed8-02fb-475b-a895-65105f56463a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("281c10e1-724a-4c11-8f85-40416f3f3a5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e0e3e45-28f0-4056-b027-8e71fb218f6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35813104-0708-4c0d-ab32-42541c7cb1d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36d4ded2-b436-4495-9ba7-32eed3d6c1e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3767a915-c0af-4b64-b3e6-8c834c349356"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3adf7f41-0675-4e29-ba0d-c664381269d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f242320-6551-43ba-9d0f-90b991de40ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41ce9544-79ce-4177-a13a-994010c623e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a4ab74b-1205-415e-93c4-dc87d0e37575"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4dc42389-013a-4b97-8858-587683d93587"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fb0810d-41ec-4819-a546-c164f467f5c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5418c5e4-51c1-4be7-867b-23ab69259095"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c08caa4-4cff-451c-ae34-96ba993e5035"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62b47a87-2f12-4221-9195-815acec605c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("683b2bcd-c42c-4a1f-b245-d7c9a3817c2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6aff83f7-347f-4e53-8e3e-fef2fe387ee5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76130ab1-800c-4b8d-8c57-aa369822d49c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ff9d613-f177-4585-b69c-68fa96551339"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83a6dc04-30a7-4be2-a98a-e6102da16ef1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84fc9da7-a72c-491b-a5eb-27b7b5366bfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85597b9a-f24f-424a-bc8a-e8a16f3123ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8730bfc5-2346-48d5-8daf-f19d2a829c98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94377578-c249-40ff-87d7-bbb965893df1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96c8e13f-46c3-4ddb-930c-9b5ff819b001"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("982c1fa5-806d-453a-955e-40a1b0a5293c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9aff7b6d-245a-48b6-bb11-e70d5558cce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8d29e39-a550-4bc2-94eb-a7ceae88b848"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b528af0c-bbc1-4263-801c-b143b6aeb63a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc927a9f-e066-4a5a-8751-9f8c1e4c821e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c157d2c1-3b80-4eb6-99a2-364a312a96e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c303b5a2-91d2-476b-9a6a-6d44ad4495db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd243c1-5416-44b7-a3f1-1f85ec521aca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc503db9-189c-4fb3-b525-61beff664e3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d299db9b-0417-4432-87f7-6f27eb85f95d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d32eaa9d-c382-4313-a938-645e031f52f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7cb17ea-6684-4439-9be0-a2ca55aad2a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d99b733f-d23b-4f5f-bbb8-6ba9d48d52e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e17bfe95-006b-46bc-b4ee-c3e451a0397d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5b7a2fd-1838-44de-91d6-e02b857f857f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f772c0c9-e480-4539-a70f-d4f0e50afb4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fee898f3-8630-4632-924f-52c41cdd2246"));

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
    }
}

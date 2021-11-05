using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Congo.WebApi.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("9f981f1e-9c44-45e6-b9d3-04e5e509838b"), "Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.", null, "Galliano", 47.27m },
                    { new Guid("630c4e4c-b762-4275-b83d-2f351832a6d7"), "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", null, "Wine - Cahors Ac 2000, Clos", 16.1m },
                    { new Guid("5b1a6774-0898-4a22-9c2a-ae00de07344d"), "Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", null, "Beans - Navy, Dry", 69.82m },
                    { new Guid("304407cd-7d9a-4cfc-9d61-e646f02347d4"), "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.", null, "Myers Planters Punch", 72.67m },
                    { new Guid("ef9b9624-140b-441e-b847-fbdef078f6eb"), "Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.", null, "Buffalo - Short Rib Fresh", 92.89m },
                    { new Guid("2ecf8354-c4c4-4bd8-91ce-13f0e5668aaf"), "Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.", null, "Pepper - Orange", 54.53m },
                    { new Guid("e62e46a8-180b-4e09-9321-e8475cb43d58"), "Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.", null, "Lemonade - Strawberry, 591 Ml", 49.11m },
                    { new Guid("70e16cd5-649f-4f09-8fc0-bd0905ef770e"), "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.", null, "Calypso - Strawberry Lemonade", 20.31m },
                    { new Guid("aad6b496-5bd3-4a23-8724-cef5723d67b4"), "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", null, "Goulash Seasoning", 69.31m },
                    { new Guid("2d2b71e4-8e3b-4dc1-bca6-d3c1a726b263"), "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", null, "Cabbage - Nappa", 44.3m },
                    { new Guid("0973289e-67fe-4d40-83e4-775939600ab3"), "Mauris sit amet eros.", null, "Dc Hikiage Hira Huba", 92.37m },
                    { new Guid("7c981f44-ecf7-4084-800c-807c1b679f2c"), "Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.", null, "Vanilla Beans", 37.37m },
                    { new Guid("92484d54-b429-4279-b3fd-885572559279"), "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.", null, "Pepper - Paprika, Hungarian", 35.67m },
                    { new Guid("547cc858-16f5-4d7b-b1f3-b93d2f861420"), "Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", null, "Wine - White, Lindemans Bin 95", 24.82m },
                    { new Guid("c70ca54e-cb09-4326-8b02-ca5e0f6f558b"), "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.", null, "Amaretto", 30.39m },
                    { new Guid("113461d8-ab58-498b-8db6-544d9e4cfe01"), "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum.", null, "Wine - Black Tower Qr", 8.82m },
                    { new Guid("7a0f5ef9-c0c8-4af7-8220-ffcd55b4b8d2"), "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.", null, "Beer - Upper Canada Light", 32.81m },
                    { new Guid("c9d01104-b717-45ee-87ec-82f4f4299310"), "Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero.", null, "Veal - Provimi Inside", 49.46m },
                    { new Guid("ecd916a5-1cd3-43df-a493-77a94b13e9a1"), "Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", null, "Soup - Campbells Bean Medley", 81.47m },
                    { new Guid("364849de-d48d-4034-9c68-6375b8bdcf88"), "Donec dapibus. Duis at velit eu est congue elementum.", null, "Tea Leaves - Oolong", 93.3m },
                    { new Guid("39319e43-2eea-4a46-95c4-645594d0b3b4"), "Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.", null, "Nantucket - Orange Mango Cktl", 36.31m },
                    { new Guid("88db15b1-df1c-43fa-a648-93ca92ba63ca"), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", null, "Wine - Magnotta - Red, Baco", 77.7m },
                    { new Guid("ed1bcbee-5dd1-4dd9-9684-7750ba6d5d74"), "Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", null, "Milk - 2% 250 Ml", 49.17m },
                    { new Guid("ace08bd5-4d88-4e8d-a04c-cbe369a43092"), "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", null, "Apple - Delicious, Red", 22.3m },
                    { new Guid("1f22beb2-73f7-4d27-b820-b0e3497eaf5f"), "Nullam varius. Nulla facilisi.", null, "Cake - Bande Of Fruit", 10.11m },
                    { new Guid("5138faf7-8adf-4417-b017-621270614590"), "Proin risus. Praesent lectus.", null, "Wine - Rubyport", 99.19m },
                    { new Guid("647fc15f-1b8e-4c85-a310-6d7d1431d39d"), "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", null, "Wine - Marlbourough Sauv Blanc", 64.14m },
                    { new Guid("cba80506-74e7-409f-b639-b282f2236702"), "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", null, "Foil Cont Round", 27.82m },
                    { new Guid("f772879a-4cd9-42f4-8f69-448b9c9d41a4"), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", null, "Shrimp - Prawn", 97.42m },
                    { new Guid("324242bd-222d-44cc-bf67-92dcae38659a"), "Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.", null, "Sugar - Splenda Sweetener", 93.17m },
                    { new Guid("fec512f0-4af9-4a03-abf4-0cc66aabb76d"), "Curabitur at ipsum ac tellus semper interdum.", null, "Soup - Knorr, Veg / Beef", 92.12m },
                    { new Guid("8b003e59-1642-4193-90d1-643b7541a9b0"), "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", null, "Cheese - Mozzarella", 93.55m },
                    { new Guid("ce08e977-d8b6-4db8-b4f6-6ad8b81070dc"), "Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", null, "Mustard Prepared", 82.12m },
                    { new Guid("ac60efb3-fe44-4f41-a17a-c533991e389e"), "Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus.", null, "Sesame Seed", 25.7m },
                    { new Guid("9f0acd2c-ea44-498b-9d13-61de95a988af"), "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo.", null, "Chicken - White Meat, No Tender", 22.74m },
                    { new Guid("0b609d3e-e073-4988-9597-6df6bdfc9979"), "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", null, "Brandy Cherry - Mcguinness", 83.52m },
                    { new Guid("b14ca1e5-448e-49ba-8ad7-53343971829f"), "Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.", null, "Chicken - Leg / Back Attach", 87.01m },
                    { new Guid("0ef89f06-ae54-4dc4-bf10-51c57036102b"), "Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.", null, "Pickerel - Fillets", 79.11m },
                    { new Guid("47ff5bd8-9ec4-4eea-bc92-2e3e150b34c1"), "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.", null, "Lettuce - Mini Greens, Whole", 65.13m },
                    { new Guid("ef99b662-7364-46cb-8494-bc300f5523ec"), "In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.", null, "Cheese - Parmesan Grated", 28.2m },
                    { new Guid("d61331b6-a804-42ca-bf80-4933543982bb"), "Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", null, "Paper Cocktail Umberlla 80 - 180", 91.08m },
                    { new Guid("9b0739a8-7916-411b-a569-768822a05768"), "In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.", null, "Paste - Black Olive", 8.57m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("b2952959-0ca1-441d-b4d0-141831f0ec01"), "Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat.", null, "Thyme - Fresh", 84.55m },
                    { new Guid("13d7e0a5-829e-45e0-9ea0-bfb091b1a529"), "In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", null, "Wine - Vouvray Cuvee Domaine", 45.9m },
                    { new Guid("297a4e0d-749f-419b-bbbc-0708da476929"), "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl.", null, "Pears - Bartlett", 92.71m },
                    { new Guid("0deaf50c-5730-48ab-a0f2-b9ed0ad66abd"), "Phasellus id sapien in sapien iaculis congue.", null, "Glass - Juice Clear 5oz 55005", 48.93m },
                    { new Guid("4b4fef09-11d9-4b29-9595-43d86f13e016"), "Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.", null, "Squid - U - 10 Thailand", 9.55m },
                    { new Guid("1072759d-fb9d-4d54-bcae-2d33a3a38ffe"), "Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.", null, "Curry Paste - Green Masala", 21.48m },
                    { new Guid("4792c5ac-9be2-4a1e-b83f-759c6dd16a13"), "Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", null, "Sole - Fillet", 85.36m },
                    { new Guid("19679e24-ee61-4387-abd1-260a3a8661c8"), "Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.", null, "V8 Splash Strawberry Kiwi", 82.16m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0973289e-67fe-4d40-83e4-775939600ab3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b609d3e-e073-4988-9597-6df6bdfc9979"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0deaf50c-5730-48ab-a0f2-b9ed0ad66abd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ef89f06-ae54-4dc4-bf10-51c57036102b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1072759d-fb9d-4d54-bcae-2d33a3a38ffe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("113461d8-ab58-498b-8db6-544d9e4cfe01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13d7e0a5-829e-45e0-9ea0-bfb091b1a529"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19679e24-ee61-4387-abd1-260a3a8661c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f22beb2-73f7-4d27-b820-b0e3497eaf5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("297a4e0d-749f-419b-bbbc-0708da476929"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d2b71e4-8e3b-4dc1-bca6-d3c1a726b263"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ecf8354-c4c4-4bd8-91ce-13f0e5668aaf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("304407cd-7d9a-4cfc-9d61-e646f02347d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("324242bd-222d-44cc-bf67-92dcae38659a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("364849de-d48d-4034-9c68-6375b8bdcf88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39319e43-2eea-4a46-95c4-645594d0b3b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4792c5ac-9be2-4a1e-b83f-759c6dd16a13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47ff5bd8-9ec4-4eea-bc92-2e3e150b34c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b4fef09-11d9-4b29-9595-43d86f13e016"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5138faf7-8adf-4417-b017-621270614590"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("547cc858-16f5-4d7b-b1f3-b93d2f861420"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b1a6774-0898-4a22-9c2a-ae00de07344d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("630c4e4c-b762-4275-b83d-2f351832a6d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("647fc15f-1b8e-4c85-a310-6d7d1431d39d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70e16cd5-649f-4f09-8fc0-bd0905ef770e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a0f5ef9-c0c8-4af7-8220-ffcd55b4b8d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c981f44-ecf7-4084-800c-807c1b679f2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88db15b1-df1c-43fa-a648-93ca92ba63ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b003e59-1642-4193-90d1-643b7541a9b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92484d54-b429-4279-b3fd-885572559279"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b0739a8-7916-411b-a569-768822a05768"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f0acd2c-ea44-498b-9d13-61de95a988af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f981f1e-9c44-45e6-b9d3-04e5e509838b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aad6b496-5bd3-4a23-8724-cef5723d67b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac60efb3-fe44-4f41-a17a-c533991e389e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ace08bd5-4d88-4e8d-a04c-cbe369a43092"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b14ca1e5-448e-49ba-8ad7-53343971829f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2952959-0ca1-441d-b4d0-141831f0ec01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c70ca54e-cb09-4326-8b02-ca5e0f6f558b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9d01104-b717-45ee-87ec-82f4f4299310"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cba80506-74e7-409f-b639-b282f2236702"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce08e977-d8b6-4db8-b4f6-6ad8b81070dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d61331b6-a804-42ca-bf80-4933543982bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e62e46a8-180b-4e09-9321-e8475cb43d58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecd916a5-1cd3-43df-a493-77a94b13e9a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed1bcbee-5dd1-4dd9-9684-7750ba6d5d74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef99b662-7364-46cb-8494-bc300f5523ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef9b9624-140b-441e-b847-fbdef078f6eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f772879a-4cd9-42f4-8f69-448b9c9d41a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fec512f0-4af9-4a03-abf4-0cc66aabb76d"));
        }
    }
}

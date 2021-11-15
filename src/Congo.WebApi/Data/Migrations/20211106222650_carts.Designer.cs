﻿// <auto-generated />
using System;
using Congo.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Congo.WebApi.Data.Migrations
{
    [DbContext(typeof(CongoContext))]
    [Migration("20211106222650_carts")]
    partial class carts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Congo.WebApi.Data.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(19,4)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(19,4)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f981f1e-9c44-45e6-b9d3-04e5e509838b"),
                            Description = "Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.",
                            Name = "Galliano",
                            Price = 47.27m
                        },
                        new
                        {
                            Id = new Guid("647fc15f-1b8e-4c85-a310-6d7d1431d39d"),
                            Description = "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                            Name = "Wine - Marlbourough Sauv Blanc",
                            Price = 64.14m
                        },
                        new
                        {
                            Id = new Guid("cba80506-74e7-409f-b639-b282f2236702"),
                            Description = "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.",
                            Name = "Foil Cont Round",
                            Price = 27.82m
                        },
                        new
                        {
                            Id = new Guid("f772879a-4cd9-42f4-8f69-448b9c9d41a4"),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.",
                            Name = "Shrimp - Prawn",
                            Price = 97.42m
                        },
                        new
                        {
                            Id = new Guid("324242bd-222d-44cc-bf67-92dcae38659a"),
                            Description = "Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.",
                            Name = "Sugar - Splenda Sweetener",
                            Price = 93.17m
                        },
                        new
                        {
                            Id = new Guid("fec512f0-4af9-4a03-abf4-0cc66aabb76d"),
                            Description = "Curabitur at ipsum ac tellus semper interdum.",
                            Name = "Soup - Knorr, Veg / Beef",
                            Price = 92.12m
                        },
                        new
                        {
                            Id = new Guid("8b003e59-1642-4193-90d1-643b7541a9b0"),
                            Description = "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.",
                            Name = "Cheese - Mozzarella",
                            Price = 93.55m
                        },
                        new
                        {
                            Id = new Guid("ce08e977-d8b6-4db8-b4f6-6ad8b81070dc"),
                            Description = "Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.",
                            Name = "Mustard Prepared",
                            Price = 82.12m
                        },
                        new
                        {
                            Id = new Guid("ac60efb3-fe44-4f41-a17a-c533991e389e"),
                            Description = "Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus.",
                            Name = "Sesame Seed",
                            Price = 25.7m
                        },
                        new
                        {
                            Id = new Guid("9f0acd2c-ea44-498b-9d13-61de95a988af"),
                            Description = "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo.",
                            Name = "Chicken - White Meat, No Tender",
                            Price = 22.74m
                        },
                        new
                        {
                            Id = new Guid("0b609d3e-e073-4988-9597-6df6bdfc9979"),
                            Description = "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.",
                            Name = "Brandy Cherry - Mcguinness",
                            Price = 83.52m
                        },
                        new
                        {
                            Id = new Guid("0ef89f06-ae54-4dc4-bf10-51c57036102b"),
                            Description = "Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.",
                            Name = "Pickerel - Fillets",
                            Price = 79.11m
                        },
                        new
                        {
                            Id = new Guid("4792c5ac-9be2-4a1e-b83f-759c6dd16a13"),
                            Description = "Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.",
                            Name = "Sole - Fillet",
                            Price = 85.36m
                        },
                        new
                        {
                            Id = new Guid("47ff5bd8-9ec4-4eea-bc92-2e3e150b34c1"),
                            Description = "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.",
                            Name = "Lettuce - Mini Greens, Whole",
                            Price = 65.13m
                        },
                        new
                        {
                            Id = new Guid("ef99b662-7364-46cb-8494-bc300f5523ec"),
                            Description = "In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.",
                            Name = "Cheese - Parmesan Grated",
                            Price = 28.2m
                        },
                        new
                        {
                            Id = new Guid("d61331b6-a804-42ca-bf80-4933543982bb"),
                            Description = "Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.",
                            Name = "Paper Cocktail Umberlla 80 - 180",
                            Price = 91.08m
                        },
                        new
                        {
                            Id = new Guid("9b0739a8-7916-411b-a569-768822a05768"),
                            Description = "In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.",
                            Name = "Paste - Black Olive",
                            Price = 8.57m
                        },
                        new
                        {
                            Id = new Guid("b2952959-0ca1-441d-b4d0-141831f0ec01"),
                            Description = "Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat.",
                            Name = "Thyme - Fresh",
                            Price = 84.55m
                        },
                        new
                        {
                            Id = new Guid("13d7e0a5-829e-45e0-9ea0-bfb091b1a529"),
                            Description = "In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.",
                            Name = "Wine - Vouvray Cuvee Domaine",
                            Price = 45.9m
                        },
                        new
                        {
                            Id = new Guid("297a4e0d-749f-419b-bbbc-0708da476929"),
                            Description = "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl.",
                            Name = "Pears - Bartlett",
                            Price = 92.71m
                        },
                        new
                        {
                            Id = new Guid("0deaf50c-5730-48ab-a0f2-b9ed0ad66abd"),
                            Description = "Phasellus id sapien in sapien iaculis congue.",
                            Name = "Glass - Juice Clear 5oz 55005",
                            Price = 48.93m
                        },
                        new
                        {
                            Id = new Guid("4b4fef09-11d9-4b29-9595-43d86f13e016"),
                            Description = "Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.",
                            Name = "Squid - U - 10 Thailand",
                            Price = 9.55m
                        },
                        new
                        {
                            Id = new Guid("1072759d-fb9d-4d54-bcae-2d33a3a38ffe"),
                            Description = "Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.",
                            Name = "Curry Paste - Green Masala",
                            Price = 21.48m
                        },
                        new
                        {
                            Id = new Guid("5138faf7-8adf-4417-b017-621270614590"),
                            Description = "Proin risus. Praesent lectus.",
                            Name = "Wine - Rubyport",
                            Price = 99.19m
                        },
                        new
                        {
                            Id = new Guid("1f22beb2-73f7-4d27-b820-b0e3497eaf5f"),
                            Description = "Nullam varius. Nulla facilisi.",
                            Name = "Cake - Bande Of Fruit",
                            Price = 10.11m
                        },
                        new
                        {
                            Id = new Guid("ace08bd5-4d88-4e8d-a04c-cbe369a43092"),
                            Description = "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                            Name = "Apple - Delicious, Red",
                            Price = 22.3m
                        },
                        new
                        {
                            Id = new Guid("ed1bcbee-5dd1-4dd9-9684-7750ba6d5d74"),
                            Description = "Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.",
                            Name = "Milk - 2% 250 Ml",
                            Price = 49.17m
                        },
                        new
                        {
                            Id = new Guid("630c4e4c-b762-4275-b83d-2f351832a6d7"),
                            Description = "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.",
                            Name = "Wine - Cahors Ac 2000, Clos",
                            Price = 16.1m
                        },
                        new
                        {
                            Id = new Guid("5b1a6774-0898-4a22-9c2a-ae00de07344d"),
                            Description = "Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.",
                            Name = "Beans - Navy, Dry",
                            Price = 69.82m
                        },
                        new
                        {
                            Id = new Guid("304407cd-7d9a-4cfc-9d61-e646f02347d4"),
                            Description = "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.",
                            Name = "Myers Planters Punch",
                            Price = 72.67m
                        },
                        new
                        {
                            Id = new Guid("ef9b9624-140b-441e-b847-fbdef078f6eb"),
                            Description = "Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.",
                            Name = "Buffalo - Short Rib Fresh",
                            Price = 92.89m
                        },
                        new
                        {
                            Id = new Guid("2ecf8354-c4c4-4bd8-91ce-13f0e5668aaf"),
                            Description = "Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.",
                            Name = "Pepper - Orange",
                            Price = 54.53m
                        },
                        new
                        {
                            Id = new Guid("e62e46a8-180b-4e09-9321-e8475cb43d58"),
                            Description = "Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.",
                            Name = "Lemonade - Strawberry, 591 Ml",
                            Price = 49.11m
                        },
                        new
                        {
                            Id = new Guid("70e16cd5-649f-4f09-8fc0-bd0905ef770e"),
                            Description = "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.",
                            Name = "Calypso - Strawberry Lemonade",
                            Price = 20.31m
                        },
                        new
                        {
                            Id = new Guid("aad6b496-5bd3-4a23-8724-cef5723d67b4"),
                            Description = "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.",
                            Name = "Goulash Seasoning",
                            Price = 69.31m
                        },
                        new
                        {
                            Id = new Guid("2d2b71e4-8e3b-4dc1-bca6-d3c1a726b263"),
                            Description = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.",
                            Name = "Cabbage - Nappa",
                            Price = 44.3m
                        },
                        new
                        {
                            Id = new Guid("0973289e-67fe-4d40-83e4-775939600ab3"),
                            Description = "Mauris sit amet eros.",
                            Name = "Dc Hikiage Hira Huba",
                            Price = 92.37m
                        },
                        new
                        {
                            Id = new Guid("7c981f44-ecf7-4084-800c-807c1b679f2c"),
                            Description = "Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.",
                            Name = "Vanilla Beans",
                            Price = 37.37m
                        },
                        new
                        {
                            Id = new Guid("92484d54-b429-4279-b3fd-885572559279"),
                            Description = "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.",
                            Name = "Pepper - Paprika, Hungarian",
                            Price = 35.67m
                        },
                        new
                        {
                            Id = new Guid("547cc858-16f5-4d7b-b1f3-b93d2f861420"),
                            Description = "Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.",
                            Name = "Wine - White, Lindemans Bin 95",
                            Price = 24.82m
                        },
                        new
                        {
                            Id = new Guid("c70ca54e-cb09-4326-8b02-ca5e0f6f558b"),
                            Description = "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.",
                            Name = "Amaretto",
                            Price = 30.39m
                        },
                        new
                        {
                            Id = new Guid("113461d8-ab58-498b-8db6-544d9e4cfe01"),
                            Description = "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum.",
                            Name = "Wine - Black Tower Qr",
                            Price = 8.82m
                        },
                        new
                        {
                            Id = new Guid("7a0f5ef9-c0c8-4af7-8220-ffcd55b4b8d2"),
                            Description = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.",
                            Name = "Beer - Upper Canada Light",
                            Price = 32.81m
                        },
                        new
                        {
                            Id = new Guid("c9d01104-b717-45ee-87ec-82f4f4299310"),
                            Description = "Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero.",
                            Name = "Veal - Provimi Inside",
                            Price = 49.46m
                        },
                        new
                        {
                            Id = new Guid("ecd916a5-1cd3-43df-a493-77a94b13e9a1"),
                            Description = "Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.",
                            Name = "Soup - Campbells Bean Medley",
                            Price = 81.47m
                        },
                        new
                        {
                            Id = new Guid("364849de-d48d-4034-9c68-6375b8bdcf88"),
                            Description = "Donec dapibus. Duis at velit eu est congue elementum.",
                            Name = "Tea Leaves - Oolong",
                            Price = 93.3m
                        },
                        new
                        {
                            Id = new Guid("39319e43-2eea-4a46-95c4-645594d0b3b4"),
                            Description = "Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.",
                            Name = "Nantucket - Orange Mango Cktl",
                            Price = 36.31m
                        },
                        new
                        {
                            Id = new Guid("88db15b1-df1c-43fa-a648-93ca92ba63ca"),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.",
                            Name = "Wine - Magnotta - Red, Baco",
                            Price = 77.7m
                        },
                        new
                        {
                            Id = new Guid("b14ca1e5-448e-49ba-8ad7-53343971829f"),
                            Description = "Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.",
                            Name = "Chicken - Leg / Back Attach",
                            Price = 87.01m
                        },
                        new
                        {
                            Id = new Guid("19679e24-ee61-4387-abd1-260a3a8661c8"),
                            Description = "Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.",
                            Name = "V8 Splash Strawberry Kiwi",
                            Price = 82.16m
                        });
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.CartItem", b =>
                {
                    b.HasOne("Congo.WebApi.Data.Models.Cart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Congo.WebApi.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.OrderItem", b =>
                {
                    b.HasOne("Congo.WebApi.Data.Models.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("Congo.WebApi.Data.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Congo.WebApi.Data.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}

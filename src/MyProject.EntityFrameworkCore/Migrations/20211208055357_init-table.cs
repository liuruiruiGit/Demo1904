using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class inittable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.CreateTable(
                name: "GoodsImgModels",
                columns: table => new
                {
                    gi_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    go_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    im_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsImgModels", x => x.gi_id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsModels",
                columns: table => new
                {
                    tg_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    goodsname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    goodsprice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    goodsnum = table.Column<int>(type: "int", nullable: false),
                    goodsstate = table.Column<bool>(type: "bit", nullable: false),
                    gen_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsModels", x => x.tg_id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsSpecificationModels",
                columns: table => new
                {
                    gs_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    go_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sp_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsSpecificationModels", x => x.gs_id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsTypeModels",
                columns: table => new
                {
                    gt_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    go_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ty_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsTypeModels", x => x.gt_id);
                });

            migrationBuilder.CreateTable(
                name: "ImgModels",
                columns: table => new
                {
                    im_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    im_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upl_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImgModels", x => x.im_id);
                });

            migrationBuilder.CreateTable(
                name: "IndentDetailModels",
                columns: table => new
                {
                    ind_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dateOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayWayInfoId = table.Column<int>(type: "int", nullable: false),
                    ur_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderInfoAddre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderInfoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoppAddreTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderInfoSalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommodCountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderInfoBarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderInfoPayPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderInfoActiveName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPrivilPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderInfoActivePrice = table.Column<int>(type: "int", nullable: false),
                    OrderInvoiceM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderWheShipments = table.Column<int>(type: "int", nullable: false),
                    OrderInfoAuditState = table.Column<int>(type: "int", nullable: false),
                    OrderInfoWhetherPay = table.Column<int>(type: "int", nullable: false),
                    OrderInfoState = table.Column<int>(type: "int", nullable: false),
                    OrderInfoDeliveryState = table.Column<int>(type: "int", nullable: false),
                    OrderInfoWaybillNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogComId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodEvaluaGrade = table.Column<int>(type: "int", nullable: false),
                    CommodEvaluaTime = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommodEvaluaOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndentDetailModels", x => x.ind_id);
                });

            migrationBuilder.CreateTable(
                name: "IndentModels",
                columns: table => new
                {
                    ind_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderInfoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Num = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmallImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndentModels", x => x.ind_id);
                });

            migrationBuilder.CreateTable(
                name: "LogModels",
                columns: table => new
                {
                    log_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    op_type = table.Column<int>(type: "int", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tu_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gen_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogModels", x => x.log_id);
                });

            migrationBuilder.CreateTable(
                name: "MenuModels",
                columns: table => new
                {
                    tm_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    superiorid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    menu_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuModels", x => x.tm_id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationModels",
                columns: table => new
                {
                    to_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    superiorid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    org_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gen_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationModels", x => x.to_id);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenuModels",
                columns: table => new
                {
                    tro_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tr_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tm_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenuModels", x => x.tro_id);
                });

            migrationBuilder.CreateTable(
                name: "RoleModels",
                columns: table => new
                {
                    tr_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    parent_tr_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    role_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gen_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleModels", x => x.tr_id);
                });

            migrationBuilder.CreateTable(
                name: "SiteModels",
                columns: table => new
                {
                    si_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    si_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    superiorid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    si_minute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteModels", x => x.si_id);
                });

            migrationBuilder.CreateTable(
                name: "SpecificationModels",
                columns: table => new
                {
                    sp_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sp_color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sp_edition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sp_weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    sp_size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationModels", x => x.sp_id);
                });

            migrationBuilder.CreateTable(
                name: "UserImgModels",
                columns: table => new
                {
                    ui_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    us_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    im_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImgModels", x => x.ui_id);
                });

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    tu_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ligin_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gen_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    login_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_login_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    count = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.tu_id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleModels",
                columns: table => new
                {
                    tug_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tu_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tr_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleModels", x => x.tug_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsImgModels");

            migrationBuilder.DropTable(
                name: "GoodsModels");

            migrationBuilder.DropTable(
                name: "GoodsSpecificationModels");

            migrationBuilder.DropTable(
                name: "GoodsTypeModels");

            migrationBuilder.DropTable(
                name: "ImgModels");

            migrationBuilder.DropTable(
                name: "IndentDetailModels");

            migrationBuilder.DropTable(
                name: "IndentModels");

            migrationBuilder.DropTable(
                name: "LogModels");

            migrationBuilder.DropTable(
                name: "MenuModels");

            migrationBuilder.DropTable(
                name: "OrganizationModels");

            migrationBuilder.DropTable(
                name: "RoleMenuModels");

            migrationBuilder.DropTable(
                name: "RoleModels");

            migrationBuilder.DropTable(
                name: "SiteModels");

            migrationBuilder.DropTable(
                name: "SpecificationModels");

            migrationBuilder.DropTable(
                name: "UserImgModels");

            migrationBuilder.DropTable(
                name: "UserModels");

            migrationBuilder.DropTable(
                name: "UserRoleModels");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }
    }
}

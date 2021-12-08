using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class inittables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tu_id",
                table: "UserRoleModels",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "tr_id",
                table: "UserRoleModels",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "tug_id",
                table: "UserRoleModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "UserModels",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "UserModels",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "vsername",
                table: "UserModels",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "UserModels",
                newName: "LoginPwd");

            migrationBuilder.RenameColumn(
                name: "login_time",
                table: "UserModels",
                newName: "LoginDate");

            migrationBuilder.RenameColumn(
                name: "ligin_name",
                table: "UserModels",
                newName: "LoginName");

            migrationBuilder.RenameColumn(
                name: "last_login_time",
                table: "UserModels",
                newName: "LastDate");

            migrationBuilder.RenameColumn(
                name: "gen_time",
                table: "UserModels",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "count",
                table: "UserModels",
                newName: "LoginCount");

            migrationBuilder.RenameColumn(
                name: "tu_id",
                table: "UserModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "us_id",
                table: "UserImgModels",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "im_id",
                table: "UserImgModels",
                newName: "ImgId");

            migrationBuilder.RenameColumn(
                name: "ui_id",
                table: "UserImgModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "sp_weight",
                table: "SpecificationModels",
                newName: "SpeciWeight");

            migrationBuilder.RenameColumn(
                name: "sp_size",
                table: "SpecificationModels",
                newName: "SpeciSize");

            migrationBuilder.RenameColumn(
                name: "sp_edition",
                table: "SpecificationModels",
                newName: "SpeciEdition");

            migrationBuilder.RenameColumn(
                name: "sp_color",
                table: "SpecificationModels",
                newName: "SpeciColor");

            migrationBuilder.RenameColumn(
                name: "sp_id",
                table: "SpecificationModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "SiteModels",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "superiorid",
                table: "SiteModels",
                newName: "AddrFatherId");

            migrationBuilder.RenameColumn(
                name: "si_name",
                table: "SiteModels",
                newName: "ExtraProperties");

            migrationBuilder.RenameColumn(
                name: "si_minute",
                table: "SiteModels",
                newName: "DetailedAddr");

            migrationBuilder.RenameColumn(
                name: "si_id",
                table: "SiteModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "role_name",
                table: "RoleModels",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "parent_tr_id",
                table: "RoleModels",
                newName: "FatherId");

            migrationBuilder.RenameColumn(
                name: "gen_time",
                table: "RoleModels",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "RoleModels",
                newName: "RoleMessage");

            migrationBuilder.RenameColumn(
                name: "tr_id",
                table: "RoleModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tr_id",
                table: "RoleMenuModels",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "tm_id",
                table: "RoleMenuModels",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "tro_id",
                table: "RoleMenuModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "superiorid",
                table: "OrganizationModels",
                newName: "FatherId");

            migrationBuilder.RenameColumn(
                name: "org_name",
                table: "OrganizationModels",
                newName: "OrganizationName");

            migrationBuilder.RenameColumn(
                name: "gen_time",
                table: "OrganizationModels",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "OrganizationModels",
                newName: "OrganizationMessage");

            migrationBuilder.RenameColumn(
                name: "to_id",
                table: "OrganizationModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "superiorid",
                table: "MenuModels",
                newName: "FatherId");

            migrationBuilder.RenameColumn(
                name: "menu_name",
                table: "MenuModels",
                newName: "MenuName");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "MenuModels",
                newName: "MenuMessage");

            migrationBuilder.RenameColumn(
                name: "tm_id",
                table: "MenuModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tu_id",
                table: "LogModels",
                newName: "OpenPeople");

            migrationBuilder.RenameColumn(
                name: "op_type",
                table: "LogModels",
                newName: "OpenType");

            migrationBuilder.RenameColumn(
                name: "gen_time",
                table: "LogModels",
                newName: "OpenDate");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "LogModels",
                newName: "OpenMessAge");

            migrationBuilder.RenameColumn(
                name: "log_id",
                table: "LogModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommodityId",
                table: "IndentModels",
                newName: "GoodId");

            migrationBuilder.RenameColumn(
                name: "ind_id",
                table: "IndentModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ind_id",
                table: "IndentDetailModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "upl_time",
                table: "ImgModels",
                newName: "ImgDate");

            migrationBuilder.RenameColumn(
                name: "im_url",
                table: "ImgModels",
                newName: "ImgUrl");

            migrationBuilder.RenameColumn(
                name: "im_id",
                table: "ImgModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ty_id",
                table: "GoodsTypeModels",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "go_id",
                table: "GoodsTypeModels",
                newName: "GoodId");

            migrationBuilder.RenameColumn(
                name: "gt_id",
                table: "GoodsTypeModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "sp_id",
                table: "GoodsSpecificationModels",
                newName: "SpecId");

            migrationBuilder.RenameColumn(
                name: "go_id",
                table: "GoodsSpecificationModels",
                newName: "GoodId");

            migrationBuilder.RenameColumn(
                name: "gs_id",
                table: "GoodsSpecificationModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "goodsname",
                table: "GoodsModels",
                newName: "GoodsName");

            migrationBuilder.RenameColumn(
                name: "goodsstate",
                table: "GoodsModels",
                newName: "GoodState");

            migrationBuilder.RenameColumn(
                name: "goodsprice",
                table: "GoodsModels",
                newName: "GoodPrice");

            migrationBuilder.RenameColumn(
                name: "goodsnum",
                table: "GoodsModels",
                newName: "GoodNum");

            migrationBuilder.RenameColumn(
                name: "gen_time",
                table: "GoodsModels",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "GoodsModels",
                newName: "GoodMessAge");

            migrationBuilder.RenameColumn(
                name: "tg_id",
                table: "GoodsModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "im_id",
                table: "GoodsImgModels",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "go_id",
                table: "GoodsImgModels",
                newName: "ImgId");

            migrationBuilder.RenameColumn(
                name: "gi_id",
                table: "GoodsImgModels",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "UserRoleModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "UserRoleModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "UserRoleModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "UserRoleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "UserRoleModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "UserRoleModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "UserModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "UserModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "UserModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "UserModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "UserModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "UserModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "UserImgModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "UserImgModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "UserImgModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "UserImgModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "UserImgModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "UserImgModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "SpecificationModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "SpecificationModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "SpecificationModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "SpecificationModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "SpecificationModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "SpecificationModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrName",
                table: "SiteModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "SiteModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "SiteModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "SiteModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "SiteModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "SiteModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "RoleModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "RoleModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "RoleModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "RoleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "RoleModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "RoleModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "RoleMenuModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "RoleMenuModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "RoleMenuModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "RoleMenuModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "RoleMenuModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "RoleMenuModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "OrganizationModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "OrganizationModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "OrganizationModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "OrganizationModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "OrganizationModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "OrganizationModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "MenuModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "MenuModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "MenuModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "MenuModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "MenuModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "MenuModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "LogModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "LogModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "LogModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "LogModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "LogModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "LogModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "IndentModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IndentModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IndentModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "IndentModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "IndentModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "IndentModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "IndentDetailModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IndentDetailModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IndentDetailModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "IndentDetailModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "IndentDetailModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "IndentDetailModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ImgModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "ImgModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "ImgModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "ImgModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "ImgModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "ImgModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "GoodsTypeModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "GoodsTypeModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "GoodsTypeModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "GoodsTypeModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "GoodsTypeModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "GoodsTypeModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "GoodsSpecificationModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "GoodsSpecificationModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "GoodsSpecificationModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "GoodsSpecificationModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "GoodsSpecificationModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "GoodsSpecificationModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "GoodsModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "GoodsModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "GoodsModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "GoodsModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "GoodsModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "GoodsModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "GoodsImgModels",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "GoodsImgModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "GoodsImgModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "GoodsImgModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "GoodsImgModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "GoodsImgModels",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "UserRoleModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "UserRoleModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "UserRoleModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "UserRoleModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "UserRoleModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "UserRoleModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "UserImgModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "UserImgModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "UserImgModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "UserImgModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "UserImgModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "UserImgModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "SpecificationModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "SpecificationModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "SpecificationModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "SpecificationModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "SpecificationModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "SpecificationModels");

            migrationBuilder.DropColumn(
                name: "AddrName",
                table: "SiteModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "SiteModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "SiteModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "SiteModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "SiteModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "SiteModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "RoleModels");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "RoleModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "RoleModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "RoleModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "RoleModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "RoleModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "RoleMenuModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "RoleMenuModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "RoleMenuModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "RoleMenuModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "RoleMenuModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "RoleMenuModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "OrganizationModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "OrganizationModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "OrganizationModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "OrganizationModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "OrganizationModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "OrganizationModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "MenuModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "MenuModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "MenuModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "MenuModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "MenuModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "MenuModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "LogModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "LogModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "LogModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "LogModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "LogModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "LogModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "IndentModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "IndentModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IndentModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "IndentModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "IndentModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "IndentModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "IndentDetailModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "IndentDetailModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IndentDetailModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "IndentDetailModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "IndentDetailModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "IndentDetailModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ImgModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "ImgModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "ImgModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "ImgModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "ImgModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "ImgModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "GoodsTypeModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "GoodsTypeModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "GoodsTypeModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "GoodsTypeModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "GoodsTypeModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "GoodsTypeModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "GoodsSpecificationModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "GoodsSpecificationModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "GoodsSpecificationModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "GoodsSpecificationModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "GoodsSpecificationModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "GoodsSpecificationModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "GoodsModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "GoodsModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "GoodsModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "GoodsModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "GoodsModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "GoodsModels");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "GoodsImgModels");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "GoodsImgModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "GoodsImgModels");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "GoodsImgModels");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "GoodsImgModels");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "GoodsImgModels");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserRoleModels",
                newName: "tu_id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "UserRoleModels",
                newName: "tr_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserRoleModels",
                newName: "tug_id");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "UserModels",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "UserModels",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserModels",
                newName: "vsername");

            migrationBuilder.RenameColumn(
                name: "LoginPwd",
                table: "UserModels",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LoginName",
                table: "UserModels",
                newName: "ligin_name");

            migrationBuilder.RenameColumn(
                name: "LoginDate",
                table: "UserModels",
                newName: "login_time");

            migrationBuilder.RenameColumn(
                name: "LoginCount",
                table: "UserModels",
                newName: "count");

            migrationBuilder.RenameColumn(
                name: "LastDate",
                table: "UserModels",
                newName: "last_login_time");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "UserModels",
                newName: "gen_time");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserModels",
                newName: "tu_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserImgModels",
                newName: "us_id");

            migrationBuilder.RenameColumn(
                name: "ImgId",
                table: "UserImgModels",
                newName: "im_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserImgModels",
                newName: "ui_id");

            migrationBuilder.RenameColumn(
                name: "SpeciWeight",
                table: "SpecificationModels",
                newName: "sp_weight");

            migrationBuilder.RenameColumn(
                name: "SpeciSize",
                table: "SpecificationModels",
                newName: "sp_size");

            migrationBuilder.RenameColumn(
                name: "SpeciEdition",
                table: "SpecificationModels",
                newName: "sp_edition");

            migrationBuilder.RenameColumn(
                name: "SpeciColor",
                table: "SpecificationModels",
                newName: "sp_color");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SpecificationModels",
                newName: "sp_id");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "SiteModels",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "ExtraProperties",
                table: "SiteModels",
                newName: "si_name");

            migrationBuilder.RenameColumn(
                name: "DetailedAddr",
                table: "SiteModels",
                newName: "si_minute");

            migrationBuilder.RenameColumn(
                name: "AddrFatherId",
                table: "SiteModels",
                newName: "superiorid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SiteModels",
                newName: "si_id");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "RoleModels",
                newName: "role_name");

            migrationBuilder.RenameColumn(
                name: "RoleMessage",
                table: "RoleModels",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "FatherId",
                table: "RoleModels",
                newName: "parent_tr_id");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "RoleModels",
                newName: "gen_time");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoleModels",
                newName: "tr_id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "RoleMenuModels",
                newName: "tr_id");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "RoleMenuModels",
                newName: "tm_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoleMenuModels",
                newName: "tro_id");

            migrationBuilder.RenameColumn(
                name: "OrganizationName",
                table: "OrganizationModels",
                newName: "org_name");

            migrationBuilder.RenameColumn(
                name: "OrganizationMessage",
                table: "OrganizationModels",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "FatherId",
                table: "OrganizationModels",
                newName: "superiorid");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "OrganizationModels",
                newName: "gen_time");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrganizationModels",
                newName: "to_id");

            migrationBuilder.RenameColumn(
                name: "MenuName",
                table: "MenuModels",
                newName: "menu_name");

            migrationBuilder.RenameColumn(
                name: "MenuMessage",
                table: "MenuModels",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "FatherId",
                table: "MenuModels",
                newName: "superiorid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MenuModels",
                newName: "tm_id");

            migrationBuilder.RenameColumn(
                name: "OpenType",
                table: "LogModels",
                newName: "op_type");

            migrationBuilder.RenameColumn(
                name: "OpenPeople",
                table: "LogModels",
                newName: "tu_id");

            migrationBuilder.RenameColumn(
                name: "OpenMessAge",
                table: "LogModels",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "OpenDate",
                table: "LogModels",
                newName: "gen_time");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LogModels",
                newName: "log_id");

            migrationBuilder.RenameColumn(
                name: "GoodId",
                table: "IndentModels",
                newName: "CommodityId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IndentModels",
                newName: "ind_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IndentDetailModels",
                newName: "ind_id");

            migrationBuilder.RenameColumn(
                name: "ImgUrl",
                table: "ImgModels",
                newName: "im_url");

            migrationBuilder.RenameColumn(
                name: "ImgDate",
                table: "ImgModels",
                newName: "upl_time");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ImgModels",
                newName: "im_id");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "GoodsTypeModels",
                newName: "ty_id");

            migrationBuilder.RenameColumn(
                name: "GoodId",
                table: "GoodsTypeModels",
                newName: "go_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsTypeModels",
                newName: "gt_id");

            migrationBuilder.RenameColumn(
                name: "SpecId",
                table: "GoodsSpecificationModels",
                newName: "sp_id");

            migrationBuilder.RenameColumn(
                name: "GoodId",
                table: "GoodsSpecificationModels",
                newName: "go_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsSpecificationModels",
                newName: "gs_id");

            migrationBuilder.RenameColumn(
                name: "GoodsName",
                table: "GoodsModels",
                newName: "goodsname");

            migrationBuilder.RenameColumn(
                name: "GoodState",
                table: "GoodsModels",
                newName: "goodsstate");

            migrationBuilder.RenameColumn(
                name: "GoodPrice",
                table: "GoodsModels",
                newName: "goodsprice");

            migrationBuilder.RenameColumn(
                name: "GoodNum",
                table: "GoodsModels",
                newName: "goodsnum");

            migrationBuilder.RenameColumn(
                name: "GoodMessAge",
                table: "GoodsModels",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "GoodsModels",
                newName: "gen_time");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsModels",
                newName: "tg_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "GoodsImgModels",
                newName: "im_id");

            migrationBuilder.RenameColumn(
                name: "ImgId",
                table: "GoodsImgModels",
                newName: "go_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsImgModels",
                newName: "gi_id");
        }
    }
}

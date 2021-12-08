using AutoMapper;
using MyProject.Dto.RbacDto;
using MyProject.Dto.ShoppingDto;
using MyProject.DtoInfo.CreateUpdateDto;
using MyProject.Rbac;
using MyProject.Shopping;

namespace MyProject
{
    public class MyProjectApplicationAutoMapperProfile : Profile
    {
        public MyProjectApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<MenuModel,MenuModelDto>();
            CreateMap<CreateUpdateMenuModel,MenuModel>();

            CreateMap<OrganizationModel, OrganizationModelDto>();
            CreateMap<CreateUpdateOrganizationModel,OrganizationModel>();

            CreateMap<RoleMenuModel,RoleMenuModelDto>();
            CreateMap<CreateUpdateRoleMenuModel, RoleMenuModel>();

            CreateMap<RoleModel,RoleModelDto>();
            CreateMap<CreateUpdateRoleModel,RoleModel>();

            CreateMap<UserModel, UserModelDto>();
            CreateMap<CreateUpdateUserModel, UserModel>();


            CreateMap<UserRoleModel, UserRoleModelDto>();
            CreateMap<CreateUpdateUserRoleModel, UserRoleModel>();

            CreateMap<GoodsModel, GoodsModelDto>();
            CreateMap<CreateUpdateGoodsModel, GoodsModel>();

            CreateMap<GoodsSpecificationModel, GoodsSpecificationModelDto>();
            CreateMap<CreateUpdateGoodsSpecificationModel, GoodsSpecificationModel>();

            CreateMap<GoodsTypeModel, GoodsTypeModelDto>();
            CreateMap<CreateUpdateGoodsTypeModel,GoodsTypeModel>();

            CreateMap<ImgModel, ImgModelDto>();
            CreateMap<CreateUpdateImgModel,ImgModel>();

            CreateMap<IndentDetailModel, IndentDetailModelDto>();
            CreateMap<CreateUpdateIndentDetailModel,IndentDetailModel>();

            CreateMap<IndentModel, IndentModelDto>();
            CreateMap<CreateUpdateIndentModel, IndentModel>();

            CreateMap<LogModel, LogModelDto>();
            CreateMap<CreateUpdateLogModel, LogModel>();

            CreateMap<SiteModel, SiteModelDto>();
            CreateMap<CreateUpdateSiteModel, SiteModel>();

            CreateMap<SpecificationModel, SpecificationModelDto>();
            CreateMap<CreateUpdateSpecificationModel,SpecificationModel>();

            CreateMap<UserImgModel, UserImgModelDto>();
            CreateMap<CreateUpdateUserImgModel,UserImgModel>();


        }
    }
}

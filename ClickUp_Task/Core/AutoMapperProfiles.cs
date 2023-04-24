using AutoMapper;
using ClickUp_Task.DTOs.GroupDtos;
using ClickUp_Task.DTOs.RoleDTOs;
using ClickUp_Task.DTOs.TaskDTOs;
using ClickUp_Task.DTOs.TaskStatusDTOs;
using ClickUp_Task.DTOs.UserDTOs;
using ClickUp_Task.Entity;
using Group = ClickUp_Task.Entity.Group;

namespace ClickUp_Task.Core
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            #region Role DTOs
            CreateMap<Role,RoleToListDto>();
            CreateMap<Role,RoleByIdDto>();
            CreateMap<Role, RoleToIsDeletedDto>();
            CreateMap<RoleToAddDto, Role>();
            CreateMap<RoleToUpdateDto,Role>();
            #endregion

            #region User DTOs
            CreateMap<User,UserToLIstDto>();
            CreateMap<User,UserByIdDto>();
            CreateMap<User,UserToIsDeletedDto>();
            CreateMap<UserToAddDto,User>();
            CreateMap<UserToUpdateDto,User>();
            #endregion

            #region TaskStatus DTOs
            CreateMap<Entity.TaskStatus,StatusToListDto>();
            CreateMap<Entity.TaskStatus,StatusByIdDto>();
            CreateMap<Entity.TaskStatus,StatusToIsDeletedDto>();
            CreateMap<StatusToUpdateDto,Entity.TaskStatus>();
            CreateMap<StatusToAddDto,Entity.TaskStatus>();
            #endregion

            #region Group DTOs
            CreateMap<Group,GroupToListDto>();
            CreateMap<Group,GroupByIdDto>();
            CreateMap<Group,GroupToIsDeletedDto>();
            CreateMap<GroupToAddDto,Group>();
            CreateMap<GroupToUpdateDto,Group>();
            #endregion

            #region Task DTOs
            CreateMap<Entity.Task,TaskToListDto>();
            CreateMap<Entity.Task,TaskByIdDto>();
            CreateMap<Entity.Task,TaskToIsDeletedDto>();
            CreateMap<TaskToUpdateDto,Entity.Task>();
            CreateMap<TaskToChangeStatusDto, Entity.Task>();
            CreateMap<TaskToAddDto,Entity.Task>();
            #endregion
        }
    }
}

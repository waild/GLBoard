using AutoMapper;
using Domain;
using GLBoard.MVC.Models;

namespace GLBoard.MVC.Configurations
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration() {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostViewModel, Post>();

            CreateMap<Comment, CommentViewModel>();
            CreateMap<CommentViewModel, Comment>();

            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}

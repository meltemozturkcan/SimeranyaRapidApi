using AutoMapper;
using Simeranya.EntityLayer.Concreate;
using SimeranyaProject.WebUI.Dtos.AboutDto;
using SimeranyaProject.WebUI.Dtos.AppUserDto;
using SimeranyaProject.WebUI.Dtos.BookingDto;
using SimeranyaProject.WebUI.Dtos.GuestDto;
using SimeranyaProject.WebUI.Dtos.LoginDto;
using SimeranyaProject.WebUI.Dtos.RegisterDto;
using SimeranyaProject.WebUI.Dtos.ServiceDto;
using SimeranyaProject.WebUI.Dtos.StaffDto;
using SimeranyaProject.WebUI.Dtos.SubscribeDto;
using SimeranyaProject.WebUI.Dtos.TestimonialDto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimeranyaProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<ResultAppUserDto, AppUser>().ReverseMap();

        }
    }
}

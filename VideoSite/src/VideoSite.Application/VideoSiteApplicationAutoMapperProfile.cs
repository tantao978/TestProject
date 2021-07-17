using AutoMapper;
using VideoSite.Videos;

namespace VideoSite
{
    public class VideoSiteApplicationAutoMapperProfile : Profile
    {
        public VideoSiteApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Video, VideoDto>();
            CreateMap<CreateUpdateVideoDto, Video>();
        }
    }
}

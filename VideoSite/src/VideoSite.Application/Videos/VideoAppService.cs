using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace VideoSite.Videos
{
    public class VideoAppService : CrudAppService<Video, VideoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateVideoDto>, IVideoAppService
    {

        public VideoAppService(IRepository<Video, Guid> repository)
            : base(repository)
        {

        }
    }
}

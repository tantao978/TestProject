using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VideoSite.Videos
{
    public interface IVideoAppService : ICrudAppService<VideoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateVideoDto>
    {
    }
}

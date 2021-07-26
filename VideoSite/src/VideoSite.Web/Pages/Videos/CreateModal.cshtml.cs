using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VideoSite.Videos;

namespace VideoSite.Web.Pages.Videos
{
    public class CreateModalModel : VideoSitePageModel
    {
        [BindProperty]
        public CreateUpdateVideoDto Video { get; set; }

        private readonly IVideoAppService _videoAppService;

        public CreateModalModel(IVideoAppService videoAppService)
        {
            _videoAppService = videoAppService;
        }

        public void OnGet()
        {
            Video = new CreateUpdateVideoDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _videoAppService.CreateAsync(Video);
            return NoContent();
        }
    }
}

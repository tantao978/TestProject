using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace VideoSite.Videos
{
    public class Video : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public  float Price { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Blogging.Tagging.Dtos;

namespace Volo.Blogging.Posts
{
    public class PostWithDetailsDto : FullAuditedEntityDto<Guid>
    {
        public Guid BlogId { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Content { get; set; }

        public List<TagDto> Tags { get; set; }
    }
}

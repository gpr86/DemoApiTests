using System;
using System.Collections.Generic;

namespace DemoApiTests.Models.CoronavirusSamartable
{
    public class News
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string SourceUrl { get; set; }
        public string WebUrl { get; set; }
        public string OriginalUrl { get; set; }
        public string FeaturedContent { get; set; }
        public string Highlight { get; set; }
        public int? Heat { get; set; }
        public List<string> Tags { get; set; }
        public List<Image> Images { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public string AmpWebUrl { get; set; }
        public string CdnAmpWebUrl { get; set; }
        public DateTimeOffset PublishedDateTime { get; set; }
        public DateTimeOffset? UpdatedDateTime { get; set; }
        public Provider Provider { get; set; }
        public string Locale { get; set; }
        public List<string> Categories { get; set; }
        public List <string> Topics { get; set; }
    }
}

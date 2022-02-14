using System;
using System.Collections.Generic;

namespace DemoApiTests.Models.CoronavirusSamartable
{
    internal class GetNewsResponseBody
    {
        public Location Location { get; set; }
        public DateTimeOffset UpdatedDateTime { get; set; }
        public List<News> News { get; set; }
    }
}

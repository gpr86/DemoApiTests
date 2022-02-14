using System.Collections.Generic;

namespace DemoApiTests.Models.CoronavirusSamartable
{
    public class Provider
    {
        public string Name { get; set; }
        public string Domain { get; set; }
        public List<Image> Images { get; set; }

        // Not sure about right type for Publishers.
        // Name suggests that it is array of strings or structures
        // Always null in available data.
        public List<string> Publishers { get; set; }

        // Not sure about right type for Authors.
        // Name suggests that it is array of strings or structures
        // Always null i awailable data.
        public List<string> Authors { get; set; }
    }
}

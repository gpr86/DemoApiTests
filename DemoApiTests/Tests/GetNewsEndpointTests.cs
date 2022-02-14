using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoApiTests.Endpoints;
using DemoApiTests.Models.CoronavirusSamartable;
using System.Net.Http;
using System.Net;
using FluentAssertions;
using System.Text.Json;

namespace DemoApiTests.Tests
{
    public class GetNewsEndpointTests
    {
        [Fact]
        public async Task GetNewsForUS()
        {
            // arrange
            var endpoint = new GetNewsEndpoint();

            var expectedLocation = new Location
            {
                Longitude = -95.712891,
                CountryOrRegion = "United States",
                ProvinceOrState = null,
                County = null,
                IsoCode = "US",
                Latitude = 37.09024
            };

            // act
            var response = await endpoint.SendGetRequest("US");
            var bodystr = await response.Content.ReadAsStringAsync();
            var body = JsonSerializer.Deserialize<GetNewsResponseBody>(bodystr, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, });

            // assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            body.Location.Should().BeEquivalentTo(expectedLocation);
        }

        [Theory]
        [InlineData("US")]
        [InlineData("FR")]
        [InlineData("PL")]
        public async Task GetNews(string region)
        {
            // arrange
            var endpoint = new GetNewsEndpoint();

            // act
            var response = await endpoint.SendGetRequest(region);
            var bodystr = await response.Content.ReadAsStringAsync();
            var body = JsonSerializer.Deserialize<GetNewsResponseBody>(bodystr, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, });

            // assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            body.Location.IsoCode.Should().Be(region);
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Propella.Application.Interfaces;
using Propella.Application.Queries;

namespace Propella.UnitTests.Application.Queries
{
    public class GetResidentialSearchHandlerTests
    {
        private GetResidentialSearch.GetResidentialSearchHandler Sut => new(ResidentialSearchService);
        
        private IResidentialSearchService ResidentialSearchService { get; set; }

        [SetUp]
        public void Setup()
        {
            ResidentialSearchService = Substitute.For<IResidentialSearchService>();
        }

        [Test]
        public async Task It_Should_Return_Correct_Count()
        {
            ResidentialSearchService.GetCountAsync()
                .Returns(Task.FromResult(2));

            var result = await Sut.Handle(new GetResidentialSearch(), CancellationToken.None);

            result.Data.Should().Be(2);
        }
    }
}
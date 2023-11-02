namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using System.Threading.Tasks;
    using Xunit;

    public class ErrorTests: GraphTestBase
    {
        [Fact(Skip = "Setup Fiddler autoresponder")]
        public async Task ErrorThrottlingError()
        {
            // To get a throttling error, I mocked up a 429 response in a text file and turned on the Fiddler
            // autoresponder to return the text file as the response envelope. The autoresponder for this 
            // scenario responds to EXACT:https://graph.microsoft.com/v1.0/groups/036bd54c-c6e5-43eb-b8b5-03e019e75bd1
            ServiceException e = await Assert.ThrowsAsync<ServiceException>(() => graphClient.Groups["036bd54c-c6e5-43eb-b8b5-03e019e75bd1"].GetAsync(requestConfiguration => requestConfiguration.Headers.Add("client-request-id", "dddddddd-dddd-dddd-dddd-dddddddddddd")));

            Assert.Contains("tooManyRetries", e.Message);
        }
    }
}

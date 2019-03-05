using System.Net.Http;
using Xunit;
using Async = System.Threading.Tasks;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    /// <summary>
    /// Ad hoc functional tests to make sure that the Reports API works.
    /// https://developer.microsoft.com/en-us/graph/docs/api-reference/beta/resources/report
    /// Your test app registration will require the Reports.Read.All which requires admin consent.
    /// </summary>
    public class ReportTests : GraphTestBase
    {
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task ReportingGetUserCounts()
        {
            try
            {
                // Create the request message.
                string getOffice365ActiveUserCountsRequestUrl = graphClient.Reports.GetOffice365ActiveUserCounts("D7").Request().RequestUrl;
                HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Get, getOffice365ActiveUserCountsRequestUrl);

                // Send the request and get the response. It will automatically follow the redirect to get the Report file.
                HttpResponseMessage response = await graphClient.HttpProvider.SendAsync(hrm);

                // Get the csv report file
                string csvReportFile = await response.Content.ReadAsStringAsync();

                Assert.Contains(csvReportFile, "Report"); // Expected: 'Report', it isn't in the file.
                Assert.Contains(csvReportFile, "Office 365"); // Expected: 'Office 365', it isn't in the file.
                Assert.Contains(csvReportFile, "Exchange"); // Expected: 'Exchange', it isn't in the file.
                Assert.Contains(csvReportFile, "SharePoint"); // Expected: 'SharePoint', it isn't in the file.
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Something happened, check out a trace. Error code: {e.Error.Code}");
            }
        }
    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.Graph.Beta.Models.ODataErrors;
    using Xunit;
    /// <summary>
    /// Ad hoc functional tests to make sure that the Reports API works.
    /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/resources/report
    /// Your test app registration will require the Reports.Read.All which requires admin consent.
    /// </summary>
    public class ReportTests : GraphTestBase
    {
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task ReportingGetUserCounts()
        {
            try
            {
                // Create the request message.
                var getOffice365ActiveUserCountsRequest = graphClient.Reports.GetOffice365ActiveUserCountsWithPeriod("D7").ToGetRequestInformation();

                // Send the request and get the response. It will automatically follow the redirect to get the Report file.
                var responseStream = await graphClient.RequestAdapter.SendPrimitiveAsync<Stream>(getOffice365ActiveUserCountsRequest);

                // Get the csv report file
                var streamReader = new StreamReader(responseStream);
                string csvReportFile = await streamReader.ReadToEndAsync();

                Assert.Contains("Report", csvReportFile);
                Assert.Contains("Office 365", csvReportFile);
                Assert.Contains("Exchange", csvReportFile);
                Assert.Contains("SharePoint", csvReportFile);
            }
            catch (ODataError e)
            {
                Assert.Fail($"Something happened, check out a trace. Error code: {e.Error.Code}");
            }
        }
    }
}

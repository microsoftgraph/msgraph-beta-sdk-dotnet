// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Generated
{
    public class ReportRequestTests : RequestTestBase
    {
        /// <summary>
        /// Tests building a request for a report.
        /// </summary>
        [Fact]
        public void BuildReportRequest()
        {
            var expectedRequestUri = new Uri(string.Format(Constants.Url.GraphBaseUrlFormatString, "beta") + "/reports/microsoft.graph.getM365AppUserDetail(period='D7')/content");
            var m365AppUserDetailRequestBuilder = this.graphServiceClient.Reports.GetM365AppUserDetail("D7") as ReportRootGetM365AppUserDetailRequestBuilder;

            Assert.NotNull(m365AppUserDetailRequestBuilder);
            Assert.Equal(expectedRequestUri, new Uri(m365AppUserDetailRequestBuilder.RequestUrl));

            var m365AppUserDetailReferenceRequest = m365AppUserDetailRequestBuilder.Request() as ReportRootGetM365AppUserDetailRequest;
            Assert.NotNull(m365AppUserDetailReferenceRequest);
            Assert.Equal(expectedRequestUri, new Uri(m365AppUserDetailReferenceRequest.RequestUrl));
        }

 
    }
}

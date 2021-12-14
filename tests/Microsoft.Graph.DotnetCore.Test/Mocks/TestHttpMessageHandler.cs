// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace Microsoft.Graph.DotnetCore.Core.Test.Mocks
{
    public class TestHttpMessageHandler : HttpMessageHandler
    {
        private Dictionary<string, HttpResponseMessage> responseMessages;

        public TestHttpMessageHandler()
        {
            this.responseMessages = new Dictionary<string, HttpResponseMessage>();
        }

        public void AddResponseMapping(string requestUrl, HttpResponseMessage responseMessage)
        {
            this.responseMessages.Add(requestUrl, responseMessage);
        }

        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage responseMessage;

            if (this.responseMessages.TryGetValue(request.RequestUri.ToString(), out responseMessage))
            {
                responseMessage.RequestMessage = request;
                return System.Threading.Tasks.Task.FromResult(responseMessage);
            }

            return System.Threading.Tasks.Task.FromResult<HttpResponseMessage>(null);
        }
    }
}

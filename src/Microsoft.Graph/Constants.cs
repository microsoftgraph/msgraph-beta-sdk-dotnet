// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    /// <summary>
    /// Constants used for navigating Graph
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// URL segment constants
        /// </summary>
        public static class Url
        {
            /// <summary>
            /// The AppRoot folder
            /// </summary>
            public const string AppRoot = "approot";

            /// <summary>
            /// The Deleted Items folder
            /// </summary>
            public const string DeletedItems = "DeletedItems";

            /// <summary>
            /// The Drafts folder
            /// </summary>
            public const string Drafts = "Drafts";

            /// <summary>
            /// The base URL format for Graph
            /// </summary>
            public const string GraphBaseUrlFormatString = "https://graph.microsoft.com/{0}";

            /// <summary>
            /// The Inbox folder
            /// </summary>
            public const string Inbox = "Inbox";

            /// <summary>
            /// The Sent Items folder
            /// </summary>
            public const string SentItems = "SentItems";
        }

        /// <summary>
        /// Constants used for HTTP property names
        /// </summary>
        public static class HttpPropertyNames
        {
            /// <summary>
            /// The Response Headers string
            /// </summary>
            public const string ResponseHeaders = "responseHeaders";

            /// <summary>
            /// The Status Code string
            /// </summary>
            public const string StatusCode = "statusCode";
        }

        /// <summary>
        /// Constants used to specify content types
        /// </summary>
        public static class ContentTypes
        {
            /// <summary>
            /// The deltaLink annotations string.
            /// </summary>
            public const string JsonContentType = "application/json";

            /// <summary>
            /// The deltaLink annotations string.
            /// </summary>
            public const string StreamContentType = "application/octet-stream";
        }

        /// <summary>
        /// Constants used to specify Http methods
        /// </summary>
        public static class HttpMethods
        {
            /// <summary>
            /// The GET method.
            /// </summary>
            public const string Get = "GET";

            /// <summary>
            /// The POST method.
            /// </summary>
            public const string Post = "POST";

            /// <summary>
            /// The PATCH method.
            /// </summary>
            public const string Patch = "PATCH";

            /// <summary>
            /// The PUT method.
            /// </summary>
            public const string Put = "PUT";

            /// <summary>
            /// The DELETE method.
            /// </summary>
            public const string Delete = "DELETE";
        }
    }
}

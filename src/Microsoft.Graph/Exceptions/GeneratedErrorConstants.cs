// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    /// <summary>
    /// Used for error messages in ClientException thrown by
    /// generated code files.
    /// </summary>
    public static class GeneratedErrorConstants
    {
        /// <summary>
        /// The error codes for ClientException.
        /// </summary>
        public static class Codes
        {
            /// <summary>
            /// Sepcifies that the action is not allowed.
            /// </summary>
            public static string NotAllowed = "notAllowed";
        }

        /// <summary>
        /// Messages for mapped codes.
        /// </summary>
        public static class Messages
        {
            /// <summary>
            /// Message to indicate that response objects should not be used in requests.
            /// </summary>
            public static string ResponseObjectUsedForUpdate = "Do not use objects returned in a response for updating an object in Microsoft Graph. " +
                                                                 "Create a new {0} object and only set the updated properties on it.";
        }
    }
}

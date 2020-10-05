// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    public static class GeneratedErrorConstants
    {
        public static class Codes
        {
            public static string NotAllowed = "notAllowed";
        }

        public static class Messages
        {
            public static string ResponseObjectUsedForUpdate = "Do not use objects returned in a response for updating an object in Microsoft Graph. " +
                                                                 "Create a new {0} object and only set the updated properties on it.";
        }
    }
}

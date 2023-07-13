// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using Microsoft.Graph.Beta.Models;
    using Microsoft.Graph.Beta.Models.ODataErrors;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xunit;
    public class ExtensionTests : GraphTestBase
    {
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task ExtensionAddRoamingProfile()
        {
            try
            {
                var openTypeExtension = new OpenTypeExtension
                {
                    ExtensionName = "com.contoso.mysettings2", AdditionalData = new Dictionary<string, object>()
                };
                openTypeExtension.AdditionalData.Add("theme", "dark");

                var e = await graphClient.Me.Extensions.PostAsync(openTypeExtension);

                Assert.NotNull(e);
                Assert.Equal(openTypeExtension.ExtensionName, e.Id); // The extension name and identifier should match.
            }
            catch (ODataError e)
            {
                if (e.Error.Message == "An extension already exists with given id.")
                {
                    Assert.Fail("The extension already exists. Delete the extension step missing.");
                }
            }
        }
    }
}

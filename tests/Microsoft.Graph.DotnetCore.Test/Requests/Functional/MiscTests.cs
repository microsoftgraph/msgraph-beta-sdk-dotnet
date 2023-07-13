
namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xunit;
    using Microsoft.Graph.Beta.Models;
    using Microsoft.Graph.Beta.Models.ODataErrors;

    public class MiscTests: GraphTestBase
    {
        /// <summary>
        /// This test will fail since the service doesn't expect Odata.type=extension. This is a break in the naming pattern that the service expects.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task GroupCreateExtension()
        {
            // Get a groups collection. We'll use the first entry to add the extension. Results in a call to the service.
            var groupPage = await graphClient.Groups.GetAsync();

            // Create the extension property.
            OpenTypeExtension newExtension = new OpenTypeExtension
            {
                ExtensionName = "com.contoso.trackingKey", AdditionalData = new Dictionary<string, object>()
            };
            newExtension.AdditionalData.Add("trackingKeyMajor", "ABC");
            newExtension.AdditionalData.Add("trackingKeyMinor", "123");

            try
            {
                // Add an extension to the group. Results in a call to the service.
                var extension = await graphClient.Groups[groupPage.Value[0].Id].Extensions.PostAsync(newExtension);

                // Delete the extension. Results in a call to the service.
                await graphClient.Groups[groupPage.Value[0].Id].Extensions["com.contoso.trackingKey"].DeleteAsync();
            }
            catch (ODataError e)
            {
                Assert.Fail(e.Error.ToString());
            }
        }
    }
}

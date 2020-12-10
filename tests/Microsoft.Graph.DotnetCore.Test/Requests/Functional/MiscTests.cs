using System.Collections.Generic;
using Xunit;
using Async = System.Threading.Tasks;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    public class MiscTests : GraphTestBase
    {
        /// <summary>
        /// This test will fail since the service doesn't expect Odata.type=extension. This is a break in the naming pattern that the service expects.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task GroupCreateExtension()
        {
            // Get a groups collection. We'll use the first entry to add the extension. Results in a call to the service.
            IGraphServiceGroupsCollectionPage groupPage = await graphClient.Groups.Request().GetAsync();

            // Create the extension property.
            OpenTypeExtension newExtension = new OpenTypeExtension();
            newExtension.ExtensionName = "com.contoso.trackingKey";
            newExtension.AdditionalData = new Dictionary<string, object>();
            newExtension.AdditionalData.Add("trackingKeyMajor", "ABC");
            newExtension.AdditionalData.Add("trackingKeyMinor", "123");

            try
            {
                // Add an extension to the group. Results in a call to the service.
                var extension = await graphClient.Groups[groupPage[0].Id].Extensions.Request().AddAsync(newExtension);

                // Delete the extension. Results in a call to the service.
                await graphClient.Groups[groupPage[0].Id].Extensions["com.contoso.trackingKey"].Request().DeleteAsync();
            }
            catch (ServiceException e)
            {
                Assert.True(false, e.Error.ToString());
            }
        }

        /// <summary>
        /// Manual test to determine whether the client library supports setting a custom timeout.
        /// https://github.com/microsoftgraph/msgraph-sdk-dotnet/pull/214/files
        /// This test requires that you can have Fiddler or some other mechanism to delay the response.
        /// For example, I used the Fiddler autoresponder with a captured response and set the latency in the responder.
        /// I set the autoresponder latency to 10 seconds, and the client's timeout to 7 sec (2 minutes).
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task ManualAdHocTimeoutTest()
        {
            // graphClient.HttpProvider.OverallTimeout = new TimeSpan(0, 0, 7);
            ServiceException ex = await Assert.ThrowsAsync<ServiceException>(async () => await graphClient.Me.Request().GetAsync());
            Assert.IsType<Async.TaskCanceledException>(ex.InnerException);
        }

        /// <summary>
        /// Test manually created partial ExternalItem partial with PutAsync()
        /// Matches https://docs.microsoft.com/en-us/graph/api/externalconnection-put-items?view=graph-rest-beta&tabs=csharp#request
        /// </summary>
        /// <returns></returns>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task AddExternalItemWithPutPartialTest()
        { 
            var externalItem = new ExternalItem
            {
                Acl = new List<Acl>()
            {
                new Acl
                {
                    Type = AclType.User,
                    Value = "e811976d-83df-4cbd-8b9b-5215b18aa874",
                    AccessType = AccessType.Grant,
                    IdentitySource = "azureActiveDirectory"
                },
                new Acl
                {
                    Type = AclType.Group,
                    Value = "14m1b9c38qe647f6a",
                    AccessType = AccessType.Deny,
                    IdentitySource = "external"
                }
            },
            Properties = new Microsoft.Graph.Properties
            {
                AdditionalData = new Dictionary<string, object>()
                {
                    {"title", "Error in the payment gateway"},
                    {"priority", "1"},
                    {"assignee", "john@contoso.com"}
                }
                },
                Content = new ExternalItemContent
                {
                    Value = "Error in payment gateway...",
                    Type = ExternalItemContentType.Text
                }
            };


            await graphClient.External.Connections["contosohr"].Items["TSP228082938"].Request().PutAsync(externalItem);
        }
    }
}


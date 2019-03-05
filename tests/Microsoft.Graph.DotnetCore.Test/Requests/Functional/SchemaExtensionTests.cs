using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Xunit;
using Async = System.Threading.Tasks;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class MyDBExtensionClass
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fid", Required = Newtonsoft.Json.Required.Default)]
        public int FID { get; set; }

        public MyDBExtensionClass(int fid)
        {
            FID = fid;
        }
    }

    public class SchemaExtensionTests : GraphTestBase
    {
        /// <summary>
        /// Create a schema extension test 
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/beta/api/schemaextension_post_schemaextensions
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task SchemaExtensionTest()
        {
            // Create a schema extension on a contact.
            // TODO: a tool that creates an object based on a schemaExtension definition.
            SchemaExtension extensionDefinition = new SchemaExtension()
            {
                Description = "This extension correlates a group with a foreign database.",
                Id = $"crmForeignKey", // Microsoft Graph will prepend 8 chars
                Properties = new List<ExtensionSchemaProperty>()
                {
                    new ExtensionSchemaProperty() { Name = "fid", Type = "Integer" }
                },
                TargetTypes = new List<string>()
                {
                    "Group"
                }
            };

            // Create the schema extension. This results in a call to Microsoft Graph.
            SchemaExtension schemaExtension = await graphClient.SchemaExtensions.Request().AddAsync(extensionDefinition);
            Assert.NotNull(schemaExtension); // Expected: schemaExtension is not null; Actual: it returned null
            Assert.Equal("InDevelopment", schemaExtension.Status); // Expected: a new schem extension has a status as InDevelopment; Actual: {schemaExtension.Status}
            Assert.Contains(schemaExtension.Id, extensionDefinition.Id); // Expected: the payload identifier is contained in the schema extension returned by the service; Actual: it is not returned
            Assert.NotNull(schemaExtension.Owner); // Expected: the owner value is set by the service; Actual: it wasn't set by the service.

            // List all of the schema extensions available to this application.
            IGraphServiceSchemaExtensionsCollectionPage schemaExtensions = await graphClient.SchemaExtensions.Request().GetAsync();
            Assert.True(schemaExtensions.Count > 0, "Expected: at least one schema extension; Actual: 0");
            Assert.NotNull(schemaExtensions[0].Properties); // Expected: the extension properties are set; Actual: extension properties are not set.
            Assert.True(schemaExtensions[0].Description.Length > 0); // Expected: the description has at least one character; Actual: the description was not set
            Assert.NotNull(schemaExtensions[0].TargetTypes); // Expected: the extension targets are set; Actual: extension targets are not set.
            Assert.NotNull(schemaExtensions[0].Id); // Expected: the Id property is set; Actual: Id property is not set.

            // Get a specific schema extension.
            SchemaExtension extensionFromGet = await graphClient.SchemaExtensions[schemaExtension.Id].Request().GetAsync();
            Assert.NotNull(extensionFromGet); // Expected: returned a schema extension object; Actual: an object wasn't returned.

            // Add header so we get back a representation of the updated schema extension.
            List<HeaderOption> headers = new List<HeaderOption>();
            HeaderOption preferHeader = new HeaderOption("Prefer", "return=representation");
            headers.Add(preferHeader);

            // Update a specific schema extension.
            extensionFromGet.Description = "This extension will be deleted";

            // Potential bug: state transition from deprecated to available is not working.
            // Potential bug here as the service is not returning the SchemaExtension on update. Must delete test until this is fixed. 5/30/2017
            // SchemaExtension extensionFromUpdate = await graphClient.SchemaExtensions[extensionFromGet.Id].Request(headers).UpdateAsync(extensionFromGet);
            await graphClient.SchemaExtensions[extensionFromGet.Id].Request(headers).UpdateAsync(extensionFromGet);

            // Enable or re-write test when we learn expected behavior.
            //Assert.AreEqual(extensionFromGet.Status, extensionFromUpdate.Status, "Expected: the patch object status property matches the returned status property; Actual: they don't match.");

            // Create a group with the schema extension defined earlier.
            IDictionary<string, object> extensionInstance = new Dictionary<string, object>();
            extensionInstance.Add(schemaExtension.Id, new MyDBExtensionClass(123123));
            Group group = new Group()
            {
                DisplayName = $"Test group - {Guid.NewGuid().ToString()}",
                Description = "This group was created with a schema extension",
                MailEnabled = false,
                MailNickname = "nickname", // silly requirement since this isn't mail enabled.
                SecurityEnabled = false,
                GroupTypes = new List<string>() { "Unified"},
                AdditionalData = extensionInstance
            };
            await Async.Task.Delay(10000); // It takes some time for the schema extension def to be available for the creation of a group.
            group = await graphClient.Groups.Request().AddAsync(group);
            
            // Delete a specific schema extension.
            await graphClient.SchemaExtensions[extensionFromGet.Id].Request().DeleteAsync();
            try
            {
                var deletedSchemaExtension = await graphClient.SchemaExtensions[extensionFromGet.Id].Request().GetAsync();
                Assert.True(false, "Expected: ServiceException since the schema extension ws deleted; Actual: the GET on the supposedly deleted schema extension returned successfully.");
            }
            catch (ServiceException e)
            {
                Assert.Equal(System.Net.HttpStatusCode.NotFound, e.StatusCode); // "Expected: {System.Net.HttpStatusCode.NotFound}; Actual: {e.StatusCode}
            }

            // Delete the group.
            try
            {
                await graphClient.Groups[group.Id].Request().DeleteAsync();
            }
            catch (ServiceException e)
            {
                Assert.True(false, $"Error: {e.Error.ToString()}");
            }
        }
    }
}

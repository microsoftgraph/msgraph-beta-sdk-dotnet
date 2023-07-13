// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using Microsoft.Graph.Beta.Models;
    using Microsoft.Graph.Beta.Models.ODataErrors;
    using System;
    using System.Collections.Generic;
    using Async = System.Threading.Tasks;
    using Newtonsoft.Json;
    using Xunit;

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
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/schemaextension_post_schemaextensions
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
            SchemaExtension schemaExtension = await graphClient.SchemaExtensions.PostAsync(extensionDefinition);
            Assert.NotNull(schemaExtension);
            Assert.Equal("InDevelopment", schemaExtension.Status);
            Assert.Contains(extensionDefinition.Id, schemaExtension.Id);
            Assert.NotNull(schemaExtension.Owner);

            // List all of the schema extensions available to this application.
            var schemaExtensions = await graphClient.SchemaExtensions.GetAsync();
            Assert.True(schemaExtensions.Value.Count > 0);
            Assert.NotNull(schemaExtensions.Value[0].Properties);
            Assert.True(schemaExtensions.Value[0].Description.Length > 0);
            Assert.NotNull(schemaExtensions.Value[0].TargetTypes);
            Assert.NotNull(schemaExtensions.Value[0].Id);

            // Get a specific schema extension.
            SchemaExtension extensionFromGet = await graphClient.SchemaExtensions[schemaExtension.Id].GetAsync();
            Assert.NotNull(extensionFromGet);

            // Update a specific schema extension.
            extensionFromGet.Description = "This extension will be deleted";

            // Potential bug: state transition from deprecated to available is not working.
            // Potential bug here as the service is not returning the SchemaExtension on update. Must delete test until this is fixed. 5/30/2017
            // SchemaExtension extensionFromUpdate = await graphClient.SchemaExtensions[extensionFromGet.Id].Request(headers).UpdateAsync(extensionFromGet);
            await graphClient.SchemaExtensions[extensionFromGet.Id].PatchAsync(extensionFromGet, requestConfiguration => requestConfiguration.Headers.Add("Prefer", "return=representation"));

            // Enable or re-write test when we learn expected behavior.
            //Assert.Equal(extensionFromGet.Status, extensionFromUpdate.Status, "Expected: the patch object status property matches the returned status property; Actual: they don't match.");

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
            await Async.Task.Delay(15000); // It takes some time for the schema extension def to be available for the creation of a group.
            group = await graphClient.Groups.PostAsync(group);
            
            // Delete a specific schema extension.
            await graphClient.SchemaExtensions[extensionFromGet.Id].DeleteAsync();
            try
            {
                var deletedSchemaExtension = await graphClient.SchemaExtensions[extensionFromGet.Id].GetAsync();
                Assert.Fail("Expected: ServiceException since the schema extension ws deleted; Actual: the GET on the supposedly deleted schema extension returned successfully.");
            }
            catch (ODataError e)
            {
                Assert.NotEmpty(e.Error.Message);
            }

            // Delete the group.
            try
            {
                await graphClient.Groups[group.Id].DeleteAsync();
            }
            catch (ODataError e)
            {
                Assert.Fail(($"Error: {e.Error.ToString()}"));
            }
        }
    }
}

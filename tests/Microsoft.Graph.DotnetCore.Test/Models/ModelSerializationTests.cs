// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Models
{
    using System;
    using Xunit;
    using Microsoft.Graph.Beta.Models;
    using Microsoft.Kiota.Abstractions;
    using Microsoft.Kiota.Serialization.Json;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class ModelSerializationTests
    {
        private readonly JsonParseNodeFactory parseNodeFactory;

        public ModelSerializationTests()
        {
            this.parseNodeFactory = new JsonParseNodeFactory();
        }

        [Fact]
        public void DeserializeDerivedType()
        {
            var userId = "userId";
            var givenName = "name";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"microsoft.graph.user\", \"givenName\":\"{1}\"}}",
                userId,
                givenName);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var user = parseNode.GetObjectValue<User>(User.CreateFromDiscriminatorValue);

            Assert.NotNull(user);
            Assert.Equal(userId, user.Id);
            Assert.Equal(givenName, user.GivenName);
            //Assert.Null(user.GetEtag());
        }

        [Fact]
        public void DeserializeInvalidODataType()
        {
            var directoryObjectId = "directoryObjectId";
            var givenName = "name";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"invalid\", \"givenName\":\"{1}\"}}",
                directoryObjectId,
                givenName);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var directoryObject = parseNode.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue);

            Assert.NotNull(directoryObject);
            Assert.Equal(directoryObjectId, directoryObject.Id);
            Assert.NotNull(directoryObject.AdditionalData);
            Assert.Equal(givenName, directoryObject.AdditionalData["givenName"].ToString());
        }

        [Fact(Skip = "TODO fix pending enum handling bug")]
        public void DeserializeUnknownEnumValue()
        {
            var enumValue = "newValue";
            var bodyContent = "bodyContent";

            var stringToDeserialize = string.Format(
                "{{\"contentType\":\"{1}\",\"content\":\"{0}\"}}",
                bodyContent,
                enumValue);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var itemBody = parseNode.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue);

            Assert.NotNull(itemBody);
            Assert.Equal(bodyContent, itemBody.Content);
            Assert.Null(itemBody.ContentType);
            Assert.NotNull(itemBody.AdditionalData);
            Assert.Equal(enumValue, itemBody.AdditionalData["contentType"].ToString());
        }

        [Fact]
        public void DeserializeDateValue()
        {
            var now = DateTimeOffset.UtcNow;

            var stringToDeserialize = string.Format("{{\"startDate\":\"{0}\"}}", now.ToString("yyyy-MM-dd"));

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var recurrenceRange = parseNode.GetObjectValue<RecurrenceRange>(RecurrenceRange.CreateFromDiscriminatorValue);

            Assert.Equal(now.Year, recurrenceRange.StartDate.Value.Year);
            Assert.Equal(now.Month, recurrenceRange.StartDate.Value.Month);
            Assert.Equal(now.Day, recurrenceRange.StartDate.Value.Day);
        }

        [Fact]
        public void NewAbstractEntityDerivedClassInstance()
        {
            var entityId = "entityId";
            var additionalKey = "key";
            var additionalValue = "value";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"newentity\", \"{1}\":\"{2}\"}}",
                entityId,
                additionalKey,
                additionalValue);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var entity = parseNode.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue);

            Assert.NotNull(entity);
            Assert.Equal(entityId, entity.Id);
            Assert.NotNull(entity.AdditionalData);
            Assert.Equal(additionalValue, entity.AdditionalData[additionalKey].ToString());
        }

        [Fact(Skip = "TODO fix pending enum handling bug")]
        public void SerializeAndDeserializeKnownEnumValue()
        {
            var itemBody = new ItemBody
            {
                OdataType = "microsoft.graph.itemBody",
                Content = "bodyContent",
                ContentType = BodyType.Text,
            };

            var expectedSerializedStream = string.Format(
                "{{\"content\":\"{0}\",\"contentType\":\"{1}\",\"@odata.type\":\"microsoft.graph.itemBody\"}}",
                itemBody.Content,
                "text");

            // Serialize
            using var jsonSerializerWriter = new JsonSerializationWriter();
            jsonSerializerWriter.WriteObjectValue(string.Empty, itemBody);
            var serializedStream = jsonSerializerWriter.GetSerializedContent();

            //Assert
            var streamReader = new StreamReader(serializedStream);
            Assert.Equal(expectedSerializedStream, streamReader.ReadToEnd());

            // De serialize
            serializedStream.Position = 0; //reset the stream to be read again
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, serializedStream);
            var newItemBody = parseNode.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue);

            Assert.NotNull(newItemBody);
            Assert.Equal(itemBody.Content, itemBody.Content);
            Assert.Equal(BodyType.Text, itemBody.ContentType);
            Assert.Null(itemBody.AdditionalData);
        }

        [Fact]
        public void SerializeDateValue()
        {
            var now = DateTimeOffset.UtcNow;

            var expectedSerializedString = string.Format("{{\"startDate\":\"{0}\"}}", now.ToString("yyyy-MM-dd"));

            var recurrence = new RecurrenceRange
            {
                StartDate = new Date(now.Year, now.Month, now.Day),
            };

            using var jsonSerializerWriter = new JsonSerializationWriter();
            jsonSerializerWriter.WriteObjectValue(string.Empty, recurrence);
            var serializedStream = jsonSerializerWriter.GetSerializedContent();

            // Assert
            var streamReader = new StreamReader(serializedStream);
            Assert.Equal(expectedSerializedString, streamReader.ReadToEnd());
        }
        [Fact]
        public void TestEtagHelper()
        {
            var userId = "userId";
            var testEtag = "testEtag";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"microsoft.graph.user\", \"@odata.etag\":\"{1}\"}}",
                userId,
                testEtag);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var user = parseNode.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue);

            Assert.NotNull(user);
            Assert.Equal(userId, user.Id);
            //Assert.Equal(testEtag, user.GetEtag());
        }
        [Fact]
        public void TestPlannerAssigmentSerialization()
        {
            var planTask = new PlannerTask
            {
                PlanId = "PLAN_ID",
                BucketId = "BUCKET_ID",
                Title = "My Planner Task",
                Assignments = new PlannerAssignments
                {
                    AdditionalData = new Dictionary<string, object>
                    {
                        {"USER_ID", new PlannerAssignment()}
                    }
                }
            };

            string expectedSerializedString = "{\"assignments\":{\"USER_ID\":{\"@odata.type\":\"#microsoft.graph.plannerAssignment\",\"orderHint\":\"!\"}},\"bucketId\":\"BUCKET_ID\",\"planId\":\"PLAN_ID\",\"title\":\"My Planner Task\"}";
            using var jsonSerializerWriter = new JsonSerializationWriter();
            jsonSerializerWriter.WriteObjectValue(string.Empty, planTask);
            var serializedStream = jsonSerializerWriter.GetSerializedContent();

            // Assert
            var streamReader = new StreamReader(serializedStream);
            Assert.Equal(expectedSerializedString, streamReader.ReadToEnd());
        }
        [Fact]
        public void TestChangeNoticationCollectionDeserialization()
        {
            var json = @"{
                ""value"": [
                    {
                        ""changeType"": ""updated"",
                        ""subscriptionId"": ""c224ac82-d3f3-4079-80ed-b6cd355e0f56"",
                        ""resource"": ""external"",
                        ""clientState"": null,
                        ""resourceData"": {
                            ""@odata.type"": ""#Microsoft.Graph.connector"",
                            ""@odata.id"": ""external"",
                            ""id"": ""cf6c33ae-e462-41c8-928b-88a8dd410f23"",
                            ""state"": ""enabled"",
                            ""connectorsTicket"": ""eyJhbGciOiJIU...""
                        },
                        ""subscriptionExpirationDateTime"": ""2023-09-20T20:39:46.8577199+00:00"",
                        ""tenantId"": ""cf6c33ae-e462-41c8-928b-88a8dd410f23""
                    }
                ],
                ""validationTokens"": [
                    ""eyJ0eXAiOiJKV1...""
                ]
            }";

            using var memStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
            var parseNode = new JsonParseNodeFactory().GetRootParseNode("application/json", memStream);
            var changeNotifications = parseNode.GetObjectValue(ChangeNotificationCollection.CreateFromDiscriminatorValue);

            Assert.NotNull(changeNotifications.Value);
            Assert.Single(changeNotifications.Value);
            Assert.NotNull(changeNotifications.ValidationTokens);
            Assert.Single(changeNotifications.ValidationTokens);
        }
    }
}

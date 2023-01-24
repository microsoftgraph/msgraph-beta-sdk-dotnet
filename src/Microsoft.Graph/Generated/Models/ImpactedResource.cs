using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ImpactedResource : Entity, IParsable {
        /// <summary>The addedDateTime property</summary>
        public DateTimeOffset? AddedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("addedDateTime"); }
            set { BackingStore?.Set("addedDateTime", value); }
        }
        /// <summary>The additionalDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>?>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#nullable restore
#else
        public List<KeyValue> AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#endif
        /// <summary>The apiUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApiUrl {
            get { return BackingStore?.Get<string?>("apiUrl"); }
            set { BackingStore?.Set("apiUrl", value); }
        }
#nullable restore
#else
        public string ApiUrl {
            get { return BackingStore?.Get<string>("apiUrl"); }
            set { BackingStore?.Set("apiUrl", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy {
            get { return BackingStore?.Get<string?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public string LastModifiedBy {
            get { return BackingStore?.Get<string>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedDateTime {
            get { return BackingStore?.Get<string?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
#nullable restore
#else
        public string LastModifiedDateTime {
            get { return BackingStore?.Get<string>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
#endif
        /// <summary>The owner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner {
            get { return BackingStore?.Get<string?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public string Owner {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The portalUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PortalUrl {
            get { return BackingStore?.Get<string?>("portalUrl"); }
            set { BackingStore?.Set("portalUrl", value); }
        }
#nullable restore
#else
        public string PortalUrl {
            get { return BackingStore?.Get<string>("portalUrl"); }
            set { BackingStore?.Set("portalUrl", value); }
        }
#endif
        /// <summary>The postponeUntilDateTime property</summary>
        public DateTimeOffset? PostponeUntilDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("postponeUntilDateTime"); }
            set { BackingStore?.Set("postponeUntilDateTime", value); }
        }
        /// <summary>The rank property</summary>
        public int? Rank {
            get { return BackingStore?.Get<int?>("rank"); }
            set { BackingStore?.Set("rank", value); }
        }
        /// <summary>The recommendationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendationId {
            get { return BackingStore?.Get<string?>("recommendationId"); }
            set { BackingStore?.Set("recommendationId", value); }
        }
#nullable restore
#else
        public string RecommendationId {
            get { return BackingStore?.Get<string>("recommendationId"); }
            set { BackingStore?.Set("recommendationId", value); }
        }
#endif
        /// <summary>The resourceType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType {
            get { return BackingStore?.Get<string?>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#nullable restore
#else
        public string ResourceType {
            get { return BackingStore?.Get<string>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#endif
        /// <summary>The status property</summary>
        public RecommendationStatus? Status {
            get { return BackingStore?.Get<RecommendationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The subjectId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectId {
            get { return BackingStore?.Get<string?>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#nullable restore
#else
        public string SubjectId {
            get { return BackingStore?.Get<string>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ImpactedResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImpactedResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addedDateTime", n => { AddedDateTime = n.GetDateTimeOffsetValue(); } },
                {"additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"apiUrl", n => { ApiUrl = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"portalUrl", n => { PortalUrl = n.GetStringValue(); } },
                {"postponeUntilDateTime", n => { PostponeUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"recommendationId", n => { RecommendationId = n.GetStringValue(); } },
                {"resourceType", n => { ResourceType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<RecommendationStatus>(); } },
                {"subjectId", n => { SubjectId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("addedDateTime", AddedDateTime);
            writer.WriteCollectionOfObjectValues<KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("apiUrl", ApiUrl);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteStringValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("portalUrl", PortalUrl);
            writer.WriteDateTimeOffsetValue("postponeUntilDateTime", PostponeUntilDateTime);
            writer.WriteIntValue("rank", Rank);
            writer.WriteStringValue("recommendationId", RecommendationId);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteEnumValue<RecommendationStatus>("status", Status);
            writer.WriteStringValue("subjectId", SubjectId);
        }
    }
}

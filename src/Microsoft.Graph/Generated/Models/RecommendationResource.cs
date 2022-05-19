using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the directory singleton.</summary>
    public class RecommendationResource : Entity, IParsable {
        /// <summary>The addedDateTime property</summary>
        public DateTimeOffset? AddedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(AddedDateTime)); }
            set { BackingStore?.Set(nameof(AddedDateTime), value); }
        }
        /// <summary>The additionalDetails property</summary>
        public List<KeyValue> AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>>(nameof(AdditionalDetails)); }
            set { BackingStore?.Set(nameof(AdditionalDetails), value); }
        }
        /// <summary>The apiUrl property</summary>
        public string ApiUrl {
            get { return BackingStore?.Get<string>(nameof(ApiUrl)); }
            set { BackingStore?.Set(nameof(ApiUrl), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The owner property</summary>
        public string Owner {
            get { return BackingStore?.Get<string>(nameof(Owner)); }
            set { BackingStore?.Set(nameof(Owner), value); }
        }
        /// <summary>The portalUrl property</summary>
        public string PortalUrl {
            get { return BackingStore?.Get<string>(nameof(PortalUrl)); }
            set { BackingStore?.Set(nameof(PortalUrl), value); }
        }
        /// <summary>The rank property</summary>
        public int? Rank {
            get { return BackingStore?.Get<int?>(nameof(Rank)); }
            set { BackingStore?.Set(nameof(Rank), value); }
        }
        /// <summary>The recommendationId property</summary>
        public string RecommendationId {
            get { return BackingStore?.Get<string>(nameof(RecommendationId)); }
            set { BackingStore?.Set(nameof(RecommendationId), value); }
        }
        /// <summary>The resourceType property</summary>
        public string ResourceType {
            get { return BackingStore?.Get<string>(nameof(ResourceType)); }
            set { BackingStore?.Set(nameof(ResourceType), value); }
        }
        /// <summary>The status property</summary>
        public RecommendationStatus? Status {
            get { return BackingStore?.Get<RecommendationStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RecommendationResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecommendationResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addedDateTime", n => { AddedDateTime = n.GetDateTimeOffsetValue(); } },
                {"additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"apiUrl", n => { ApiUrl = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"portalUrl", n => { PortalUrl = n.GetStringValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"recommendationId", n => { RecommendationId = n.GetStringValue(); } },
                {"resourceType", n => { ResourceType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<RecommendationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("addedDateTime", AddedDateTime);
            writer.WriteCollectionOfObjectValues<KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("apiUrl", ApiUrl);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("portalUrl", PortalUrl);
            writer.WriteIntValue("rank", Rank);
            writer.WriteStringValue("recommendationId", RecommendationId);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteEnumValue<RecommendationStatus>("status", Status);
        }
    }
}

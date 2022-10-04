using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class RecommendationResource : Entity, IParsable {
        /// <summary>The addedDateTime property</summary>
        public DateTimeOffset? AddedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("addedDateTime"); }
            set { BackingStore?.Set("addedDateTime", value); }
        }
        /// <summary>The additionalDetails property</summary>
        public List<KeyValue> AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
        /// <summary>The apiUrl property</summary>
        public string ApiUrl {
            get { return BackingStore?.Get<string>("apiUrl"); }
            set { BackingStore?.Set("apiUrl", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The owner property</summary>
        public string Owner {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
        /// <summary>The portalUrl property</summary>
        public string PortalUrl {
            get { return BackingStore?.Get<string>("portalUrl"); }
            set { BackingStore?.Set("portalUrl", value); }
        }
        /// <summary>The rank property</summary>
        public int? Rank {
            get { return BackingStore?.Get<int?>("rank"); }
            set { BackingStore?.Set("rank", value); }
        }
        /// <summary>The recommendationId property</summary>
        public string RecommendationId {
            get { return BackingStore?.Get<string>("recommendationId"); }
            set { BackingStore?.Set("recommendationId", value); }
        }
        /// <summary>The resourceType property</summary>
        public string ResourceType {
            get { return BackingStore?.Get<string>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
        /// <summary>The status property</summary>
        public RecommendationStatus? Status {
            get { return BackingStore?.Get<RecommendationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new recommendationResource and sets the default values.
        /// </summary>
        public RecommendationResource() : base() {
            OdataType = "#microsoft.graph.recommendationResource";
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
                {"additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
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

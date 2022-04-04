using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RecommendationResource : Entity, IParsable {
        /// <summary>The addedDateTime property</summary>
        public DateTimeOffset? AddedDateTime { get; set; }
        /// <summary>The additionalDetails property</summary>
        public List<KeyValue> AdditionalDetails { get; set; }
        /// <summary>The apiUrl property</summary>
        public string ApiUrl { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The owner property</summary>
        public string Owner { get; set; }
        /// <summary>The portalUrl property</summary>
        public string PortalUrl { get; set; }
        /// <summary>The rank property</summary>
        public int? Rank { get; set; }
        /// <summary>The recommendationId property</summary>
        public string RecommendationId { get; set; }
        /// <summary>The resourceType property</summary>
        public string ResourceType { get; set; }
        /// <summary>The status property</summary>
        public RecommendationStatus? Status { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addedDateTime", (o,n) => { (o as RecommendationResource).AddedDateTime = n.GetDateTimeOffsetValue(); } },
                {"additionalDetails", (o,n) => { (o as RecommendationResource).AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"apiUrl", (o,n) => { (o as RecommendationResource).ApiUrl = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as RecommendationResource).DisplayName = n.GetStringValue(); } },
                {"owner", (o,n) => { (o as RecommendationResource).Owner = n.GetStringValue(); } },
                {"portalUrl", (o,n) => { (o as RecommendationResource).PortalUrl = n.GetStringValue(); } },
                {"rank", (o,n) => { (o as RecommendationResource).Rank = n.GetIntValue(); } },
                {"recommendationId", (o,n) => { (o as RecommendationResource).RecommendationId = n.GetStringValue(); } },
                {"resourceType", (o,n) => { (o as RecommendationResource).ResourceType = n.GetStringValue(); } },
                {"status", (o,n) => { (o as RecommendationResource).Status = n.GetEnumValue<RecommendationStatus>(); } },
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

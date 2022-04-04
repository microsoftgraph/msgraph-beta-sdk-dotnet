using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Recommendation : Entity, IParsable {
        /// <summary>The actionSteps property</summary>
        public List<ActionStep> ActionSteps { get; set; }
        /// <summary>The benefits property</summary>
        public string Benefits { get; set; }
        /// <summary>The category property</summary>
        public RecommendationCategory? Category { get; set; }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The impactedResources property</summary>
        public List<RecommendationResource> ImpactedResources { get; set; }
        /// <summary>The impactStartDateTime property</summary>
        public DateTimeOffset? ImpactStartDateTime { get; set; }
        /// <summary>The impactType property</summary>
        public string ImpactType { get; set; }
        /// <summary>The insights property</summary>
        public string Insights { get; set; }
        /// <summary>The lastCheckedDateTime property</summary>
        public DateTimeOffset? LastCheckedDateTime { get; set; }
        /// <summary>The lastModifiedBy property</summary>
        public string LastModifiedBy { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The postponeUntilDateTime property</summary>
        public DateTimeOffset? PostponeUntilDateTime { get; set; }
        /// <summary>The priority property</summary>
        public RecommendationPriority? Priority { get; set; }
        /// <summary>The status property</summary>
        public RecommendationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Recommendation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Recommendation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionSteps", (o,n) => { (o as Recommendation).ActionSteps = n.GetCollectionOfObjectValues<ActionStep>(ActionStep.CreateFromDiscriminatorValue).ToList(); } },
                {"benefits", (o,n) => { (o as Recommendation).Benefits = n.GetStringValue(); } },
                {"category", (o,n) => { (o as Recommendation).Category = n.GetEnumValue<RecommendationCategory>(); } },
                {"createdDateTime", (o,n) => { (o as Recommendation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as Recommendation).DisplayName = n.GetStringValue(); } },
                {"impactedResources", (o,n) => { (o as Recommendation).ImpactedResources = n.GetCollectionOfObjectValues<RecommendationResource>(RecommendationResource.CreateFromDiscriminatorValue).ToList(); } },
                {"impactStartDateTime", (o,n) => { (o as Recommendation).ImpactStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"impactType", (o,n) => { (o as Recommendation).ImpactType = n.GetStringValue(); } },
                {"insights", (o,n) => { (o as Recommendation).Insights = n.GetStringValue(); } },
                {"lastCheckedDateTime", (o,n) => { (o as Recommendation).LastCheckedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", (o,n) => { (o as Recommendation).LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Recommendation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"postponeUntilDateTime", (o,n) => { (o as Recommendation).PostponeUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", (o,n) => { (o as Recommendation).Priority = n.GetEnumValue<RecommendationPriority>(); } },
                {"status", (o,n) => { (o as Recommendation).Status = n.GetEnumValue<RecommendationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ActionStep>("actionSteps", ActionSteps);
            writer.WriteStringValue("benefits", Benefits);
            writer.WriteEnumValue<RecommendationCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<RecommendationResource>("impactedResources", ImpactedResources);
            writer.WriteDateTimeOffsetValue("impactStartDateTime", ImpactStartDateTime);
            writer.WriteStringValue("impactType", ImpactType);
            writer.WriteStringValue("insights", Insights);
            writer.WriteDateTimeOffsetValue("lastCheckedDateTime", LastCheckedDateTime);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("postponeUntilDateTime", PostponeUntilDateTime);
            writer.WriteEnumValue<RecommendationPriority>("priority", Priority);
            writer.WriteEnumValue<RecommendationStatus>("status", Status);
        }
    }
}

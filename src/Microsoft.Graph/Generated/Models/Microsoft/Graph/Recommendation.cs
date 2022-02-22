using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Recommendation : Entity, IParsable {
        public List<ActionStep> ActionSteps { get; set; }
        public string Benefits { get; set; }
        public RecommendationCategory? Category { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string DisplayName { get; set; }
        public List<RecommendationResource> ImpactedResources { get; set; }
        public DateTimeOffset? ImpactStartDateTime { get; set; }
        public string ImpactType { get; set; }
        public string Insights { get; set; }
        public DateTimeOffset? LastCheckedDateTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public DateTimeOffset? PostponeUntilDateTime { get; set; }
        public RecommendationPriority? Priority { get; set; }
        public RecommendationStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionSteps", (o,n) => { (o as Recommendation).ActionSteps = n.GetCollectionOfObjectValues<ActionStep>().ToList(); } },
                {"benefits", (o,n) => { (o as Recommendation).Benefits = n.GetStringValue(); } },
                {"category", (o,n) => { (o as Recommendation).Category = n.GetEnumValue<RecommendationCategory>(); } },
                {"createdDateTime", (o,n) => { (o as Recommendation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as Recommendation).DisplayName = n.GetStringValue(); } },
                {"impactedResources", (o,n) => { (o as Recommendation).ImpactedResources = n.GetCollectionOfObjectValues<RecommendationResource>().ToList(); } },
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

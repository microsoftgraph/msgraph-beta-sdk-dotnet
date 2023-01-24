using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RecommendationBase : Entity, IParsable {
        /// <summary>The actionSteps property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ActionStep>? ActionSteps {
            get { return BackingStore?.Get<List<ActionStep>?>("actionSteps"); }
            set { BackingStore?.Set("actionSteps", value); }
        }
#nullable restore
#else
        public List<ActionStep> ActionSteps {
            get { return BackingStore?.Get<List<ActionStep>>("actionSteps"); }
            set { BackingStore?.Set("actionSteps", value); }
        }
#endif
        /// <summary>The benefits property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Benefits {
            get { return BackingStore?.Get<string?>("benefits"); }
            set { BackingStore?.Set("benefits", value); }
        }
#nullable restore
#else
        public string Benefits {
            get { return BackingStore?.Get<string>("benefits"); }
            set { BackingStore?.Set("benefits", value); }
        }
#endif
        /// <summary>The category property</summary>
        public RecommendationCategory? Category {
            get { return BackingStore?.Get<RecommendationCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The currentScore property</summary>
        public double? CurrentScore {
            get { return BackingStore?.Get<double?>("currentScore"); }
            set { BackingStore?.Set("currentScore", value); }
        }
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
        /// <summary>The featureAreas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RecommendationFeatureAreas?>? FeatureAreas {
            get { return BackingStore?.Get<List<RecommendationFeatureAreas?>?>("featureAreas"); }
            set { BackingStore?.Set("featureAreas", value); }
        }
#nullable restore
#else
        public List<RecommendationFeatureAreas?> FeatureAreas {
            get { return BackingStore?.Get<List<RecommendationFeatureAreas?>>("featureAreas"); }
            set { BackingStore?.Set("featureAreas", value); }
        }
#endif
        /// <summary>The impactedResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImpactedResource>? ImpactedResources {
            get { return BackingStore?.Get<List<ImpactedResource>?>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
#nullable restore
#else
        public List<ImpactedResource> ImpactedResources {
            get { return BackingStore?.Get<List<ImpactedResource>>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
#endif
        /// <summary>The impactStartDateTime property</summary>
        public DateTimeOffset? ImpactStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("impactStartDateTime"); }
            set { BackingStore?.Set("impactStartDateTime", value); }
        }
        /// <summary>The impactType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImpactType {
            get { return BackingStore?.Get<string?>("impactType"); }
            set { BackingStore?.Set("impactType", value); }
        }
#nullable restore
#else
        public string ImpactType {
            get { return BackingStore?.Get<string>("impactType"); }
            set { BackingStore?.Set("impactType", value); }
        }
#endif
        /// <summary>The insights property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Insights {
            get { return BackingStore?.Get<string?>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#nullable restore
#else
        public string Insights {
            get { return BackingStore?.Get<string>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#endif
        /// <summary>The lastCheckedDateTime property</summary>
        public DateTimeOffset? LastCheckedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckedDateTime"); }
            set { BackingStore?.Set("lastCheckedDateTime", value); }
        }
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
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The maxScore property</summary>
        public double? MaxScore {
            get { return BackingStore?.Get<double?>("maxScore"); }
            set { BackingStore?.Set("maxScore", value); }
        }
        /// <summary>The postponeUntilDateTime property</summary>
        public DateTimeOffset? PostponeUntilDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("postponeUntilDateTime"); }
            set { BackingStore?.Set("postponeUntilDateTime", value); }
        }
        /// <summary>The priority property</summary>
        public RecommendationPriority? Priority {
            get { return BackingStore?.Get<RecommendationPriority?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The recommendationType property</summary>
        public Microsoft.Graph.Beta.Models.RecommendationType? RecommendationType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RecommendationType?>("recommendationType"); }
            set { BackingStore?.Set("recommendationType", value); }
        }
        /// <summary>The remediationImpact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationImpact {
            get { return BackingStore?.Get<string?>("remediationImpact"); }
            set { BackingStore?.Set("remediationImpact", value); }
        }
#nullable restore
#else
        public string RemediationImpact {
            get { return BackingStore?.Get<string>("remediationImpact"); }
            set { BackingStore?.Set("remediationImpact", value); }
        }
#endif
        /// <summary>The status property</summary>
        public RecommendationStatus? Status {
            get { return BackingStore?.Get<RecommendationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RecommendationBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.recommendation" => new Recommendation(),
                _ => new RecommendationBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionSteps", n => { ActionSteps = n.GetCollectionOfObjectValues<ActionStep>(ActionStep.CreateFromDiscriminatorValue)?.ToList(); } },
                {"benefits", n => { Benefits = n.GetStringValue(); } },
                {"category", n => { Category = n.GetEnumValue<RecommendationCategory>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"currentScore", n => { CurrentScore = n.GetDoubleValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"featureAreas", n => { FeatureAreas = n.GetCollectionOfEnumValues<RecommendationFeatureAreas>()?.ToList(); } },
                {"impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<ImpactedResource>(ImpactedResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"impactStartDateTime", n => { ImpactStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"impactType", n => { ImpactType = n.GetStringValue(); } },
                {"insights", n => { Insights = n.GetStringValue(); } },
                {"lastCheckedDateTime", n => { LastCheckedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"maxScore", n => { MaxScore = n.GetDoubleValue(); } },
                {"postponeUntilDateTime", n => { PostponeUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", n => { Priority = n.GetEnumValue<RecommendationPriority>(); } },
                {"recommendationType", n => { RecommendationType = n.GetEnumValue<RecommendationType>(); } },
                {"remediationImpact", n => { RemediationImpact = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<RecommendationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ActionStep>("actionSteps", ActionSteps);
            writer.WriteStringValue("benefits", Benefits);
            writer.WriteEnumValue<RecommendationCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDoubleValue("currentScore", CurrentScore);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfEnumValues<RecommendationFeatureAreas>("featureAreas", FeatureAreas);
            writer.WriteCollectionOfObjectValues<ImpactedResource>("impactedResources", ImpactedResources);
            writer.WriteDateTimeOffsetValue("impactStartDateTime", ImpactStartDateTime);
            writer.WriteStringValue("impactType", ImpactType);
            writer.WriteStringValue("insights", Insights);
            writer.WriteDateTimeOffsetValue("lastCheckedDateTime", LastCheckedDateTime);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDoubleValue("maxScore", MaxScore);
            writer.WriteDateTimeOffsetValue("postponeUntilDateTime", PostponeUntilDateTime);
            writer.WriteEnumValue<RecommendationPriority>("priority", Priority);
            writer.WriteEnumValue<RecommendationType>("recommendationType", RecommendationType);
            writer.WriteStringValue("remediationImpact", RemediationImpact);
            writer.WriteEnumValue<RecommendationStatus>("status", Status);
        }
    }
}

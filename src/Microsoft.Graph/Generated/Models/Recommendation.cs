using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Recommendation : Entity, IParsable {
        /// <summary>The actionSteps property</summary>
        public List<ActionStep> ActionSteps {
            get { return BackingStore?.Get<List<ActionStep>>("actionSteps"); }
            set { BackingStore?.Set("actionSteps", value); }
        }
        /// <summary>The benefits property</summary>
        public string Benefits {
            get { return BackingStore?.Get<string>("benefits"); }
            set { BackingStore?.Set("benefits", value); }
        }
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
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The impactedResources property</summary>
        public List<RecommendationResource> ImpactedResources {
            get { return BackingStore?.Get<List<RecommendationResource>>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
        /// <summary>The impactStartDateTime property</summary>
        public DateTimeOffset? ImpactStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("impactStartDateTime"); }
            set { BackingStore?.Set("impactStartDateTime", value); }
        }
        /// <summary>The impactType property</summary>
        public string ImpactType {
            get { return BackingStore?.Get<string>("impactType"); }
            set { BackingStore?.Set("impactType", value); }
        }
        /// <summary>The insights property</summary>
        public string Insights {
            get { return BackingStore?.Get<string>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
        /// <summary>The lastCheckedDateTime property</summary>
        public DateTimeOffset? LastCheckedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckedDateTime"); }
            set { BackingStore?.Set("lastCheckedDateTime", value); }
        }
        /// <summary>The lastModifiedBy property</summary>
        public string LastModifiedBy {
            get { return BackingStore?.Get<string>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
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
        /// <summary>The status property</summary>
        public RecommendationStatus? Status {
            get { return BackingStore?.Get<RecommendationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new Recommendation and sets the default values.
        /// </summary>
        public Recommendation() : base() {
            OdataType = "#microsoft.graph.recommendation";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionSteps", n => { ActionSteps = n.GetCollectionOfObjectValues<ActionStep>(ActionStep.CreateFromDiscriminatorValue).ToList(); } },
                {"benefits", n => { Benefits = n.GetStringValue(); } },
                {"category", n => { Category = n.GetEnumValue<RecommendationCategory>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<RecommendationResource>(RecommendationResource.CreateFromDiscriminatorValue).ToList(); } },
                {"impactStartDateTime", n => { ImpactStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"impactType", n => { ImpactType = n.GetStringValue(); } },
                {"insights", n => { Insights = n.GetStringValue(); } },
                {"lastCheckedDateTime", n => { LastCheckedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"postponeUntilDateTime", n => { PostponeUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", n => { Priority = n.GetEnumValue<RecommendationPriority>(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerPlanConfiguration : Entity, IParsable {
        /// <summary>The buckets property</summary>
        public List<PlannerPlanConfigurationBucketDefinition> Buckets {
            get { return BackingStore?.Get<List<PlannerPlanConfigurationBucketDefinition>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
        /// <summary>The createdBy property</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The defaultLanguage property</summary>
        public string DefaultLanguage {
            get { return BackingStore?.Get<string>("defaultLanguage"); }
            set { BackingStore?.Set("defaultLanguage", value); }
        }
        /// <summary>The lastModifiedBy property</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The localizations property</summary>
        public List<PlannerPlanConfigurationLocalization> Localizations {
            get { return BackingStore?.Get<List<PlannerPlanConfigurationLocalization>>("localizations"); }
            set { BackingStore?.Set("localizations", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerPlanConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlanConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buckets", n => { Buckets = n.GetCollectionOfObjectValues<PlannerPlanConfigurationBucketDefinition>(PlannerPlanConfigurationBucketDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"defaultLanguage", n => { DefaultLanguage = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"localizations", n => { Localizations = n.GetCollectionOfObjectValues<PlannerPlanConfigurationLocalization>(PlannerPlanConfigurationLocalization.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerPlanConfigurationBucketDefinition>("buckets", Buckets);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("defaultLanguage", DefaultLanguage);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<PlannerPlanConfigurationLocalization>("localizations", Localizations);
        }
    }
}

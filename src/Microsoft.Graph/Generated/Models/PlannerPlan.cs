using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class PlannerPlan : PlannerDelta, IParsable {
        /// <summary>Collection of buckets in the plan. Read-only. Nullable.</summary>
        public List<PlannerBucket> Buckets {
            get { return BackingStore?.Get<List<PlannerBucket>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
        /// <summary>Identifies the container of the plan. After it is set, this property can’t be updated. Required.</summary>
        public PlannerPlanContainer Container {
            get { return BackingStore?.Get<PlannerPlanContainer>("container"); }
            set { BackingStore?.Set("container", value); }
        }
        /// <summary>Read-only. Additional user experiences in which this plan is used, represented as plannerPlanContext entries.</summary>
        public PlannerPlanContextCollection Contexts {
            get { return BackingStore?.Get<PlannerPlanContextCollection>("contexts"); }
            set { BackingStore?.Set("contexts", value); }
        }
        /// <summary>Read-only. The user who created the plan.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Additional details about the plan. Read-only. Nullable.</summary>
        public PlannerPlanDetails Details {
            get { return BackingStore?.Get<PlannerPlanDetails>("details"); }
            set { BackingStore?.Set("details", value); }
        }
        /// <summary>The owner property</summary>
        public string Owner {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
        /// <summary>Collection of tasks in the plan. Read-only. Nullable.</summary>
        public List<PlannerTask> Tasks {
            get { return BackingStore?.Get<List<PlannerTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
        /// <summary>Required. Title of the plan.</summary>
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
        /// <summary>
        /// Instantiates a new plannerPlan and sets the default values.
        /// </summary>
        public PlannerPlan() : base() {
            OdataType = "#microsoft.graph.plannerPlan";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PlannerPlan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buckets", n => { Buckets = n.GetCollectionOfObjectValues<PlannerBucket>(PlannerBucket.CreateFromDiscriminatorValue)?.ToList(); } },
                {"container", n => { Container = n.GetObjectValue<PlannerPlanContainer>(PlannerPlanContainer.CreateFromDiscriminatorValue); } },
                {"contexts", n => { Contexts = n.GetObjectValue<PlannerPlanContextCollection>(PlannerPlanContextCollection.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"details", n => { Details = n.GetObjectValue<PlannerPlanDetails>(PlannerPlanDetails.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PlannerTask>(PlannerTask.CreateFromDiscriminatorValue)?.ToList(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerBucket>("buckets", Buckets);
            writer.WriteObjectValue<PlannerPlanContainer>("container", Container);
            writer.WriteObjectValue<PlannerPlanContextCollection>("contexts", Contexts);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<PlannerPlanDetails>("details", Details);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
            writer.WriteStringValue("title", Title);
        }
    }
}

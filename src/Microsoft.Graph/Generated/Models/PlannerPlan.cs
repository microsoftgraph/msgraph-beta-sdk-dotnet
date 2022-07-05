using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class PlannerPlan : PlannerDelta, IParsable {
        /// <summary>Collection of buckets in the plan. Read-only. Nullable.</summary>
        public List<PlannerBucket> Buckets {
            get { return BackingStore?.Get<List<PlannerBucket>>(nameof(Buckets)); }
            set { BackingStore?.Set(nameof(Buckets), value); }
        }
        /// <summary>Identifies the container of the plan. After it is set, this property can’t be updated. Required.</summary>
        public PlannerPlanContainer Container {
            get { return BackingStore?.Get<PlannerPlanContainer>(nameof(Container)); }
            set { BackingStore?.Set(nameof(Container), value); }
        }
        /// <summary>Read-only. Additional user experiences in which this plan is used, represented as plannerPlanContext entries.</summary>
        public PlannerPlanContextCollection Contexts {
            get { return BackingStore?.Get<PlannerPlanContextCollection>(nameof(Contexts)); }
            set { BackingStore?.Set(nameof(Contexts), value); }
        }
        /// <summary>Read-only. The user who created the plan.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Additional details about the plan. Read-only. Nullable.</summary>
        public PlannerPlanDetails Details {
            get { return BackingStore?.Get<PlannerPlanDetails>(nameof(Details)); }
            set { BackingStore?.Set(nameof(Details), value); }
        }
        /// <summary>The owner property</summary>
        public string Owner {
            get { return BackingStore?.Get<string>(nameof(Owner)); }
            set { BackingStore?.Set(nameof(Owner), value); }
        }
        /// <summary>Collection of tasks in the plan. Read-only. Nullable.</summary>
        public List<PlannerTask> Tasks {
            get { return BackingStore?.Get<List<PlannerTask>>(nameof(Tasks)); }
            set { BackingStore?.Set(nameof(Tasks), value); }
        }
        /// <summary>Required. Title of the plan.</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
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
                {"buckets", n => { Buckets = n.GetCollectionOfObjectValues<PlannerBucket>(PlannerBucket.CreateFromDiscriminatorValue).ToList(); } },
                {"container", n => { Container = n.GetObjectValue<PlannerPlanContainer>(PlannerPlanContainer.CreateFromDiscriminatorValue); } },
                {"contexts", n => { Contexts = n.GetObjectValue<PlannerPlanContextCollection>(PlannerPlanContextCollection.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"details", n => { Details = n.GetObjectValue<PlannerPlanDetails>(PlannerPlanDetails.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PlannerTask>(PlannerTask.CreateFromDiscriminatorValue).ToList(); } },
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

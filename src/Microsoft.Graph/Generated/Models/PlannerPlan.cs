using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerPlan : PlannerDelta, IParsable {
        /// <summary>Collection of buckets in the plan. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<PlannerBucket>? Buckets {
            get { return BackingStore?.Get<List<PlannerBucket>?>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#else
        public List<PlannerBucket> Buckets {
            get { return BackingStore?.Get<List<PlannerBucket>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#endif
        /// <summary>Identifies the container of the plan. Specify only the url, the containerId and type, or all properties. After it is set, this property can’t be updated. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerPlanContainer? Container {
            get { return BackingStore?.Get<PlannerPlanContainer?>("container"); }
            set { BackingStore?.Set("container", value); }
        }
#else
        public PlannerPlanContainer Container {
            get { return BackingStore?.Get<PlannerPlanContainer>("container"); }
            set { BackingStore?.Set("container", value); }
        }
#endif
        /// <summary>Read-only. Additional user experiences in which this plan is used, represented as plannerPlanContext entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerPlanContextCollection? Contexts {
            get { return BackingStore?.Get<PlannerPlanContextCollection?>("contexts"); }
            set { BackingStore?.Set("contexts", value); }
        }
#else
        public PlannerPlanContextCollection Contexts {
            get { return BackingStore?.Get<PlannerPlanContextCollection>("contexts"); }
            set { BackingStore?.Set("contexts", value); }
        }
#endif
        /// <summary>Read-only. The user who created the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Contains information about the origin of the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerPlanCreation? CreationSource {
            get { return BackingStore?.Get<PlannerPlanCreation?>("creationSource"); }
            set { BackingStore?.Set("creationSource", value); }
        }
#else
        public PlannerPlanCreation CreationSource {
            get { return BackingStore?.Get<PlannerPlanCreation>("creationSource"); }
            set { BackingStore?.Set("creationSource", value); }
        }
#endif
        /// <summary>Additional details about the plan. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerPlanDetails? Details {
            get { return BackingStore?.Get<PlannerPlanDetails?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#else
        public PlannerPlanDetails Details {
            get { return BackingStore?.Get<PlannerPlanDetails>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The owner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Owner {
            get { return BackingStore?.Get<string?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#else
        public string Owner {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>Collection of tasks in the plan. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<PlannerTask>? Tasks {
            get { return BackingStore?.Get<List<PlannerTask>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#else
        public List<PlannerTask> Tasks {
            get { return BackingStore?.Get<List<PlannerTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>Required. Title of the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"creationSource", n => { CreationSource = n.GetObjectValue<PlannerPlanCreation>(PlannerPlanCreation.CreateFromDiscriminatorValue); } },
                {"details", n => { Details = n.GetObjectValue<PlannerPlanDetails>(PlannerPlanDetails.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PlannerTask>(PlannerTask.CreateFromDiscriminatorValue)?.ToList(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerBucket>("buckets", Buckets);
            writer.WriteObjectValue<PlannerPlanContainer>("container", Container);
            writer.WriteObjectValue<PlannerPlanContextCollection>("contexts", Contexts);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<PlannerPlanCreation>("creationSource", CreationSource);
            writer.WriteObjectValue<PlannerPlanDetails>("details", Details);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
            writer.WriteStringValue("title", Title);
        }
    }
}

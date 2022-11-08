using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class Workflow : WorkflowBase, IParsable {
        /// <summary>When the workflow was deleted.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? DeletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>The unique identifier of the Azure AD identity that last modified the workflow object.</summary>
        public List<Microsoft.Graph.Beta.Models.User> ExecutionScope {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.User>>("executionScope"); }
            set { BackingStore?.Set("executionScope", value); }
        }
        /// <summary>Identifier used for individually addressing a specific workflow.Supports $filter(eq, ne) and $orderby.</summary>
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The date time when the workflow is expected to run next based on the schedule interval, if there are any users matching the execution conditions. Supports $filter(lt,gt) and $orderBy.</summary>
        public DateTimeOffset? NextScheduleRunDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("nextScheduleRunDateTime"); }
            set { BackingStore?.Set("nextScheduleRunDateTime", value); }
        }
        /// <summary>The runs property</summary>
        public List<Run> Runs {
            get { return BackingStore?.Get<List<Run>>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
        /// <summary>Represents the aggregation of task execution data for tasks within a workflow object.</summary>
        public List<TaskReport> TaskReports {
            get { return BackingStore?.Get<List<TaskReport>>("taskReports"); }
            set { BackingStore?.Set("taskReports", value); }
        }
        /// <summary>The userProcessingResults property</summary>
        public List<UserProcessingResult> UserProcessingResults {
            get { return BackingStore?.Get<List<UserProcessingResult>>("userProcessingResults"); }
            set { BackingStore?.Set("userProcessingResults", value); }
        }
        /// <summary>The current version number of the workflow. Value is 1 when the workflow is first created.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>The workflow versions that are available.</summary>
        public List<WorkflowVersion> Versions {
            get { return BackingStore?.Get<List<WorkflowVersion>>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
        /// <summary>
        /// Instantiates a new Workflow and sets the default values.
        /// </summary>
        public Workflow() : base() {
            OdataType = "#microsoft.graph.identityGovernance.workflow";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Workflow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Workflow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"executionScope", n => { ExecutionScope = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue)?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"nextScheduleRunDateTime", n => { NextScheduleRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"runs", n => { Runs = n.GetCollectionOfObjectValues<Run>(Run.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taskReports", n => { TaskReports = n.GetCollectionOfObjectValues<TaskReport>(TaskReport.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userProcessingResults", n => { UserProcessingResults = n.GetCollectionOfObjectValues<UserProcessingResult>(UserProcessingResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"version", n => { Version = n.GetIntValue(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<WorkflowVersion>(WorkflowVersion.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.User>("executionScope", ExecutionScope);
            writer.WriteStringValue("id", Id);
            writer.WriteDateTimeOffsetValue("nextScheduleRunDateTime", NextScheduleRunDateTime);
            writer.WriteCollectionOfObjectValues<Run>("runs", Runs);
            writer.WriteCollectionOfObjectValues<TaskReport>("taskReports", TaskReports);
            writer.WriteCollectionOfObjectValues<UserProcessingResult>("userProcessingResults", UserProcessingResults);
            writer.WriteIntValue("version", Version);
            writer.WriteCollectionOfObjectValues<WorkflowVersion>("versions", Versions);
        }
    }
}

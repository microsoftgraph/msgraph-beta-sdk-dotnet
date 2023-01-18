using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BusinessScenarioPlanner : Entity, IParsable {
        /// <summary>The configuration of Planner plans that will be created for the scenario.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerPlanConfiguration? PlanConfiguration {
            get { return BackingStore?.Get<PlannerPlanConfiguration?>("planConfiguration"); }
            set { BackingStore?.Set("planConfiguration", value); }
        }
#else
        public PlannerPlanConfiguration PlanConfiguration {
            get { return BackingStore?.Get<PlannerPlanConfiguration>("planConfiguration"); }
            set { BackingStore?.Set("planConfiguration", value); }
        }
#endif
        /// <summary>The configuration of Planner tasks that will be created for the scenario.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerTaskConfiguration? TaskConfiguration {
            get { return BackingStore?.Get<PlannerTaskConfiguration?>("taskConfiguration"); }
            set { BackingStore?.Set("taskConfiguration", value); }
        }
#else
        public PlannerTaskConfiguration TaskConfiguration {
            get { return BackingStore?.Get<PlannerTaskConfiguration>("taskConfiguration"); }
            set { BackingStore?.Set("taskConfiguration", value); }
        }
#endif
        /// <summary>The Planner tasks for the scenario.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<BusinessScenarioTask>? Tasks {
            get { return BackingStore?.Get<List<BusinessScenarioTask>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#else
        public List<BusinessScenarioTask> Tasks {
            get { return BackingStore?.Get<List<BusinessScenarioTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BusinessScenarioPlanner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BusinessScenarioPlanner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"planConfiguration", n => { PlanConfiguration = n.GetObjectValue<PlannerPlanConfiguration>(PlannerPlanConfiguration.CreateFromDiscriminatorValue); } },
                {"taskConfiguration", n => { TaskConfiguration = n.GetObjectValue<PlannerTaskConfiguration>(PlannerTaskConfiguration.CreateFromDiscriminatorValue); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<BusinessScenarioTask>(BusinessScenarioTask.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerPlanConfiguration>("planConfiguration", PlanConfiguration);
            writer.WriteObjectValue<PlannerTaskConfiguration>("taskConfiguration", TaskConfiguration);
            writer.WriteCollectionOfObjectValues<BusinessScenarioTask>("tasks", Tasks);
        }
    }
}

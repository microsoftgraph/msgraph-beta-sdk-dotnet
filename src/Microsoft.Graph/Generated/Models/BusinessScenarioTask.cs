using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BusinessScenarioTask : PlannerTask, IParsable {
        /// <summary>Scenario-specific properties of the task. externalObjectId and externalBucketId properties must be specified when creating a task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.BusinessScenarioProperties? BusinessScenarioProperties {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BusinessScenarioProperties?>("businessScenarioProperties"); }
            set { BackingStore?.Set("businessScenarioProperties", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.BusinessScenarioProperties BusinessScenarioProperties {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BusinessScenarioProperties>("businessScenarioProperties"); }
            set { BackingStore?.Set("businessScenarioProperties", value); }
        }
#endif
        /// <summary>Target of the task that specifies where the task should be placed. Must be specified when creating a task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public BusinessScenarioTaskTargetBase? Target {
            get { return BackingStore?.Get<BusinessScenarioTaskTargetBase?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#else
        public BusinessScenarioTaskTargetBase Target {
            get { return BackingStore?.Get<BusinessScenarioTaskTargetBase>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BusinessScenarioTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BusinessScenarioTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"businessScenarioProperties", n => { BusinessScenarioProperties = n.GetObjectValue<Microsoft.Graph.Beta.Models.BusinessScenarioProperties>(Microsoft.Graph.Beta.Models.BusinessScenarioProperties.CreateFromDiscriminatorValue); } },
                {"target", n => { Target = n.GetObjectValue<BusinessScenarioTaskTargetBase>(BusinessScenarioTaskTargetBase.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BusinessScenarioProperties>("businessScenarioProperties", BusinessScenarioProperties);
            writer.WriteObjectValue<BusinessScenarioTaskTargetBase>("target", Target);
        }
    }
}

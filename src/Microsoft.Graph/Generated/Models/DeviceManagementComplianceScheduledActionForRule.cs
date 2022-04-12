using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementComplianceScheduledActionForRule : Entity, IParsable {
        /// <summary>Name of the rule which this scheduled action applies to.</summary>
        public string RuleName { get; set; }
        /// <summary>The list of scheduled action configurations for this compliance policy. This collection can contain a maximum of 100 elements.</summary>
        public List<DeviceManagementComplianceActionItem> ScheduledActionConfigurations { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementComplianceScheduledActionForRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementComplianceScheduledActionForRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"ruleName", n => { RuleName = n.GetStringValue(); } },
                {"scheduledActionConfigurations", n => { ScheduledActionConfigurations = n.GetCollectionOfObjectValues<DeviceManagementComplianceActionItem>(DeviceManagementComplianceActionItem.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteCollectionOfObjectValues<DeviceManagementComplianceActionItem>("scheduledActionConfigurations", ScheduledActionConfigurations);
        }
    }
}

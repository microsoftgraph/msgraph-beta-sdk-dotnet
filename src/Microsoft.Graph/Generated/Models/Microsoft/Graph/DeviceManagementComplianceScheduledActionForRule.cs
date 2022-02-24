using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementComplianceScheduledActionForRule : Entity, IParsable {
        /// <summary>Name of the rule which this scheduled action applies to.</summary>
        public string RuleName { get; set; }
        /// <summary>The list of scheduled action configurations for this compliance policy. This collection can contain a maximum of 100 elements.</summary>
        public List<DeviceManagementComplianceActionItem> ScheduledActionConfigurations { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"ruleName", (o,n) => { (o as DeviceManagementComplianceScheduledActionForRule).RuleName = n.GetStringValue(); } },
                {"scheduledActionConfigurations", (o,n) => { (o as DeviceManagementComplianceScheduledActionForRule).ScheduledActionConfigurations = n.GetCollectionOfObjectValues<DeviceManagementComplianceActionItem>().ToList(); } },
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

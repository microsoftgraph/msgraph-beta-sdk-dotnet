using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GovernancePolicyTemplate : Entity, IParsable {
        public string DisplayName { get; set; }
        public GovernancePolicy Policy { get; set; }
        public BusinessFlowSettings Settings { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as GovernancePolicyTemplate).DisplayName = n.GetStringValue(); } },
                {"policy", (o,n) => { (o as GovernancePolicyTemplate).Policy = n.GetObjectValue<GovernancePolicy>(); } },
                {"settings", (o,n) => { (o as GovernancePolicyTemplate).Settings = n.GetObjectValue<BusinessFlowSettings>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<GovernancePolicy>("policy", Policy);
            writer.WriteObjectValue<BusinessFlowSettings>("settings", Settings);
        }
    }
}

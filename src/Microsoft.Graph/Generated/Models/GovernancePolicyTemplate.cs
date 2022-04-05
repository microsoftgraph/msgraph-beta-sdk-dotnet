using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GovernancePolicyTemplate : Entity, IParsable {
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The policy property</summary>
        public GovernancePolicy Policy { get; set; }
        /// <summary>The settings property</summary>
        public BusinessFlowSettings Settings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GovernancePolicyTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernancePolicyTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as GovernancePolicyTemplate).DisplayName = n.GetStringValue(); } },
                {"policy", (o,n) => { (o as GovernancePolicyTemplate).Policy = n.GetObjectValue<GovernancePolicy>(GovernancePolicy.CreateFromDiscriminatorValue); } },
                {"settings", (o,n) => { (o as GovernancePolicyTemplate).Settings = n.GetObjectValue<BusinessFlowSettings>(BusinessFlowSettings.CreateFromDiscriminatorValue); } },
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

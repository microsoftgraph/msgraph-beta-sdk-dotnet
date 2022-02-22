using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class InsightsSettings : Entity, IParsable {
        /// <summary>The ID of an Azure AD group, of which the specified type of insights are disabled for its members. Default is empty. Optional.</summary>
        public string DisabledForGroup { get; set; }
        /// <summary>true if the specified type of insights are enabled for the organization; false if the specified type of insights are disabled for all users without exceptions. Default is true. Optional.</summary>
        public bool? IsEnabledInOrganization { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"disabledForGroup", (o,n) => { (o as InsightsSettings).DisabledForGroup = n.GetStringValue(); } },
                {"isEnabledInOrganization", (o,n) => { (o as InsightsSettings).IsEnabledInOrganization = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("disabledForGroup", DisabledForGroup);
            writer.WriteBoolValue("isEnabledInOrganization", IsEnabledInOrganization);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementIntent : Entity, IParsable {
        /// <summary>The display name for the management intent. Optional. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>A flag indicating whether the management intent is global. Required. Read-only.</summary>
        public bool? IsGlobal { get; set; }
        /// <summary>The collection of management templates associated with the management intent. Optional. Read-only.</summary>
        public List<ManagementTemplateDetailedInfo> ManagementTemplates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as ManagementIntent).DisplayName = n.GetStringValue(); } },
                {"isGlobal", (o,n) => { (o as ManagementIntent).IsGlobal = n.GetBoolValue(); } },
                {"managementTemplates", (o,n) => { (o as ManagementIntent).ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplateDetailedInfo>().ToList(); } },
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
            writer.WriteBoolValue("isGlobal", IsGlobal);
            writer.WriteCollectionOfObjectValues<ManagementTemplateDetailedInfo>("managementTemplates", ManagementTemplates);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateCollection : Entity, IParsable {
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public List<MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate> ManagementTemplates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as ManagementTemplateCollection).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementTemplateCollection).DisplayName = n.GetStringValue(); } },
                {"managementTemplates", (o,n) => { (o as ManagementTemplateCollection).ManagementTemplates = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate>("managementTemplates", ManagementTemplates);
        }
    }
}

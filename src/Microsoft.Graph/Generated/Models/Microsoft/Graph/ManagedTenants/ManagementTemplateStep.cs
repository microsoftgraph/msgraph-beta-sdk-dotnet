using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateStep : Entity, IParsable {
        public ManagementCategory? Category { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string ManagementPortal { get; set; }
        public MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate ManagementTemplate { get; set; }
        public string PortalLink { get; set; }
        public int? Priority { get; set; }
        public ManagementProvider? Provider { get; set; }
        public List<ManagementTemplateStepVersion> StepVersions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"category", (o,n) => { (o as ManagementTemplateStep).Category = n.GetEnumValue<ManagementCategory>(); } },
                {"description", (o,n) => { (o as ManagementTemplateStep).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementTemplateStep).DisplayName = n.GetStringValue(); } },
                {"managementPortal", (o,n) => { (o as ManagementTemplateStep).ManagementPortal = n.GetStringValue(); } },
                {"managementTemplate", (o,n) => { (o as ManagementTemplateStep).ManagementTemplate = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate>(); } },
                {"portalLink", (o,n) => { (o as ManagementTemplateStep).PortalLink = n.GetStringValue(); } },
                {"priority", (o,n) => { (o as ManagementTemplateStep).Priority = n.GetIntValue(); } },
                {"provider", (o,n) => { (o as ManagementTemplateStep).Provider = n.GetEnumValue<ManagementProvider>(); } },
                {"stepVersions", (o,n) => { (o as ManagementTemplateStep).StepVersions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ManagementCategory>("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("managementPortal", ManagementPortal);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate>("managementTemplate", ManagementTemplate);
            writer.WriteStringValue("portalLink", PortalLink);
            writer.WriteIntValue("priority", Priority);
            writer.WriteEnumValue<ManagementProvider>("provider", Provider);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepVersion>("stepVersions", StepVersions);
        }
    }
}

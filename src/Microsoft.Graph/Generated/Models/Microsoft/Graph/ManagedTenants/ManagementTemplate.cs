using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplate : Entity, IParsable {
        /// <summary>The management category for the management template. Possible values are: custom, devices, identity, unknownFutureValue. Required. Read-only.</summary>
        public ManagementCategory? Category { get; set; }
        /// <summary>The description for the management template. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the management template. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        public List<ManagementTemplateCollection> ManagementTemplateCollections { get; set; }
        public List<ManagementTemplateStep> ManagementTemplateSteps { get; set; }
        /// <summary>The collection of parameters used by the management template. Optional. Read-only.</summary>
        public List<TemplateParameter> Parameters { get; set; }
        public int? Version { get; set; }
        /// <summary>The collection of workload actions associated with the management template. Optional. Read-only.</summary>
        public List<WorkloadAction> WorkloadActions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"category", (o,n) => { (o as ManagementTemplate).Category = n.GetEnumValue<ManagementCategory>(); } },
                {"description", (o,n) => { (o as ManagementTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementTemplate).DisplayName = n.GetStringValue(); } },
                {"managementTemplateCollections", (o,n) => { (o as ManagementTemplate).ManagementTemplateCollections = n.GetCollectionOfObjectValues<ManagementTemplateCollection>().ToList(); } },
                {"managementTemplateSteps", (o,n) => { (o as ManagementTemplate).ManagementTemplateSteps = n.GetCollectionOfObjectValues<ManagementTemplateStep>().ToList(); } },
                {"parameters", (o,n) => { (o as ManagementTemplate).Parameters = n.GetCollectionOfObjectValues<TemplateParameter>().ToList(); } },
                {"version", (o,n) => { (o as ManagementTemplate).Version = n.GetIntValue(); } },
                {"workloadActions", (o,n) => { (o as ManagementTemplate).WorkloadActions = n.GetCollectionOfObjectValues<WorkloadAction>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ManagementTemplateCollection>("managementTemplateCollections", ManagementTemplateCollections);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStep>("managementTemplateSteps", ManagementTemplateSteps);
            writer.WriteCollectionOfObjectValues<TemplateParameter>("parameters", Parameters);
            writer.WriteIntValue("version", Version);
            writer.WriteCollectionOfObjectValues<WorkloadAction>("workloadActions", WorkloadActions);
        }
    }
}

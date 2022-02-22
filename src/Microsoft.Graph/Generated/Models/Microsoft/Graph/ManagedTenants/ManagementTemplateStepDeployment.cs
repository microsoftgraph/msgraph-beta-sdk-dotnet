using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateStepDeployment : Entity, IParsable {
        public GraphAPIErrorDetails Error { get; set; }
        public List<Setting> Settings { get; set; }
        public ManagementTemplateDeploymentStatus? Status { get; set; }
        public ManagementTemplateStepVersion TemplateStepVersion { get; set; }
        public string TenantId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"error", (o,n) => { (o as ManagementTemplateStepDeployment).Error = n.GetObjectValue<GraphAPIErrorDetails>(); } },
                {"settings", (o,n) => { (o as ManagementTemplateStepDeployment).Settings = n.GetCollectionOfObjectValues<Setting>().ToList(); } },
                {"status", (o,n) => { (o as ManagementTemplateStepDeployment).Status = n.GetEnumValue<ManagementTemplateDeploymentStatus>(); } },
                {"templateStepVersion", (o,n) => { (o as ManagementTemplateStepDeployment).TemplateStepVersion = n.GetObjectValue<ManagementTemplateStepVersion>(); } },
                {"tenantId", (o,n) => { (o as ManagementTemplateStepDeployment).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GraphAPIErrorDetails>("error", Error);
            writer.WriteCollectionOfObjectValues<Setting>("settings", Settings);
            writer.WriteEnumValue<ManagementTemplateDeploymentStatus>("status", Status);
            writer.WriteObjectValue<ManagementTemplateStepVersion>("templateStepVersion", TemplateStepVersion);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}

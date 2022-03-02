using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateStepDeployment : Entity, IParsable {
        public string CreatedByUserId { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public GraphAPIErrorDetails Error { get; set; }
        public string LastActionByUserId { get; set; }
        public DateTimeOffset? LastActionDateTime { get; set; }
        public ManagementTemplateDeploymentStatus? Status { get; set; }
        public ManagementTemplateStepVersion TemplateStepVersion { get; set; }
        public string TenantId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdByUserId", (o,n) => { (o as ManagementTemplateStepDeployment).CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ManagementTemplateStepDeployment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", (o,n) => { (o as ManagementTemplateStepDeployment).Error = n.GetObjectValue<GraphAPIErrorDetails>(); } },
                {"lastActionByUserId", (o,n) => { (o as ManagementTemplateStepDeployment).LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", (o,n) => { (o as ManagementTemplateStepDeployment).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<GraphAPIErrorDetails>("error", Error);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<ManagementTemplateDeploymentStatus>("status", Status);
            writer.WriteObjectValue<ManagementTemplateStepVersion>("templateStepVersion", TemplateStepVersion);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateStepDeployment : Entity, IParsable {
        /// <summary>The createdByUserId property</summary>
        public string CreatedByUserId { get; set; }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The error property</summary>
        public GraphAPIErrorDetails Error { get; set; }
        /// <summary>The lastActionByUserId property</summary>
        public string LastActionByUserId { get; set; }
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The status property</summary>
        public ManagementTemplateDeploymentStatus? Status { get; set; }
        /// <summary>The templateStepVersion property</summary>
        public ManagementTemplateStepVersion TemplateStepVersion { get; set; }
        /// <summary>The tenantId property</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementTemplateStepDeployment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepDeployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdByUserId", (o,n) => { (o as ManagementTemplateStepDeployment).CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ManagementTemplateStepDeployment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", (o,n) => { (o as ManagementTemplateStepDeployment).Error = n.GetObjectValue<GraphAPIErrorDetails>(GraphAPIErrorDetails.CreateFromDiscriminatorValue); } },
                {"lastActionByUserId", (o,n) => { (o as ManagementTemplateStepDeployment).LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", (o,n) => { (o as ManagementTemplateStepDeployment).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as ManagementTemplateStepDeployment).Status = n.GetEnumValue<ManagementTemplateDeploymentStatus>(); } },
                {"templateStepVersion", (o,n) => { (o as ManagementTemplateStepDeployment).TemplateStepVersion = n.GetObjectValue<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue); } },
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

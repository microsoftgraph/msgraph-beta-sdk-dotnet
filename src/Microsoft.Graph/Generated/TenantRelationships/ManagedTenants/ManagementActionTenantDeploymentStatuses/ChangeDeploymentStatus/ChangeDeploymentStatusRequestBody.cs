using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementActionTenantDeploymentStatuses.ChangeDeploymentStatus {
    /// <summary>Provides operations to call the changeDeploymentStatus method.</summary>
    public class ChangeDeploymentStatusRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ManagementActionId { get; set; }
        public string ManagementTemplateId { get; set; }
        public int? ManagementTemplateVersion { get; set; }
        public string Status { get; set; }
        public string TenantGroupId { get; set; }
        public string TenantId { get; set; }
        /// <summary>
        /// Instantiates a new changeDeploymentStatusRequestBody and sets the default values.
        /// </summary>
        public ChangeDeploymentStatusRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ChangeDeploymentStatusRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChangeDeploymentStatusRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"managementActionId", (o,n) => { (o as ChangeDeploymentStatusRequestBody).ManagementActionId = n.GetStringValue(); } },
                {"managementTemplateId", (o,n) => { (o as ChangeDeploymentStatusRequestBody).ManagementTemplateId = n.GetStringValue(); } },
                {"managementTemplateVersion", (o,n) => { (o as ChangeDeploymentStatusRequestBody).ManagementTemplateVersion = n.GetIntValue(); } },
                {"status", (o,n) => { (o as ChangeDeploymentStatusRequestBody).Status = n.GetStringValue(); } },
                {"tenantGroupId", (o,n) => { (o as ChangeDeploymentStatusRequestBody).TenantGroupId = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as ChangeDeploymentStatusRequestBody).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managementActionId", ManagementActionId);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteIntValue("managementTemplateVersion", ManagementTemplateVersion);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("tenantGroupId", TenantGroupId);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

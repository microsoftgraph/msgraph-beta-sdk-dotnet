using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateStepVersions.Item.Deployments.Item.ChangeDeploymentStatus {
    /// <summary>Provides operations to call the changeDeploymentStatus method.</summary>
    public class ChangeDeploymentStatusRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The managementTemplateStepId property</summary>
        public string ManagementTemplateStepId { get; set; }
        /// <summary>The status property</summary>
        public string Status { get; set; }
        /// <summary>The tenantId property</summary>
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
                {"managementTemplateStepId", (o,n) => { (o as ChangeDeploymentStatusRequestBody).ManagementTemplateStepId = n.GetStringValue(); } },
                {"status", (o,n) => { (o as ChangeDeploymentStatusRequestBody).Status = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as ChangeDeploymentStatusRequestBody).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managementTemplateStepId", ManagementTemplateStepId);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

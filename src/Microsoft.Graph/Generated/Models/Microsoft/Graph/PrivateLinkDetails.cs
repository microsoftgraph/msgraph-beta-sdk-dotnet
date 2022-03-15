using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class PrivateLinkDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier for the Private Link policy.</summary>
        public string PolicyId { get; set; }
        /// <summary>The name of the Private Link policy in Azure AD.</summary>
        public string PolicyName { get; set; }
        /// <summary>The tenant identifier of the Azure AD tenant the Private Link policy belongs to.</summary>
        public string PolicyTenantId { get; set; }
        /// <summary>The Azure Resource Manager (ARM) path for the Private Link policy resource.</summary>
        public string ResourceId { get; set; }
        /// <summary>
        /// Instantiates a new privateLinkDetails and sets the default values.
        /// </summary>
        public PrivateLinkDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrivateLinkDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivateLinkDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"policyId", (o,n) => { (o as PrivateLinkDetails).PolicyId = n.GetStringValue(); } },
                {"policyName", (o,n) => { (o as PrivateLinkDetails).PolicyName = n.GetStringValue(); } },
                {"policyTenantId", (o,n) => { (o as PrivateLinkDetails).PolicyTenantId = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as PrivateLinkDetails).ResourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteStringValue("policyTenantId", PolicyTenantId);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

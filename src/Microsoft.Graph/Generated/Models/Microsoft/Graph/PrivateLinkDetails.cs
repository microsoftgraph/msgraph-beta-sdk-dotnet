using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PrivateLinkDetails : IParsable {
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

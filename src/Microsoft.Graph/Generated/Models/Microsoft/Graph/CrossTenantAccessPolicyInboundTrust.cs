using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CrossTenantAccessPolicyInboundTrust : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether compliant devices from external Azure AD organizations are trusted.</summary>
        public bool? IsCompliantDeviceAccepted { get; set; }
        /// <summary>Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.</summary>
        public bool? IsHybridAzureADJoinedDeviceAccepted { get; set; }
        /// <summary>Specifies whether MFA from external Azure AD organizations is trusted.</summary>
        public bool? IsMfaAccepted { get; set; }
        /// <summary>
        /// Instantiates a new crossTenantAccessPolicyInboundTrust and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyInboundTrust() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isCompliantDeviceAccepted", (o,n) => { (o as CrossTenantAccessPolicyInboundTrust).IsCompliantDeviceAccepted = n.GetBoolValue(); } },
                {"isHybridAzureADJoinedDeviceAccepted", (o,n) => { (o as CrossTenantAccessPolicyInboundTrust).IsHybridAzureADJoinedDeviceAccepted = n.GetBoolValue(); } },
                {"isMfaAccepted", (o,n) => { (o as CrossTenantAccessPolicyInboundTrust).IsMfaAccepted = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isCompliantDeviceAccepted", IsCompliantDeviceAccepted);
            writer.WriteBoolValue("isHybridAzureADJoinedDeviceAccepted", IsHybridAzureADJoinedDeviceAccepted);
            writer.WriteBoolValue("isMfaAccepted", IsMfaAccepted);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

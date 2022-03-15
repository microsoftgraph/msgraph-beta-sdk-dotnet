using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public class CrossTenantAccessPolicyConfigurationPartner : CrossTenantAccessPolicyConfigurationBase, IParsable {
        /// <summary>Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.</summary>
        public bool? IsServiceProvider { get; set; }
        /// <summary>The tenant identifier for the partner Azure AD organization. Read-only. Key.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CrossTenantAccessPolicyConfigurationPartner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyConfigurationPartner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isServiceProvider", (o,n) => { (o as CrossTenantAccessPolicyConfigurationPartner).IsServiceProvider = n.GetBoolValue(); } },
                {"tenantId", (o,n) => { (o as CrossTenantAccessPolicyConfigurationPartner).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isServiceProvider", IsServiceProvider);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}

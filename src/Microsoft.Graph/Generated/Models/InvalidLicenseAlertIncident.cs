using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class InvalidLicenseAlertIncident : UnifiedRoleManagementAlertIncident, IParsable {
        /// <summary>Status of the tenant&apos;s Azure AD Premium P2 license.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantLicenseStatus {
            get { return BackingStore?.Get<string?>("tenantLicenseStatus"); }
            set { BackingStore?.Set("tenantLicenseStatus", value); }
        }
#nullable restore
#else
        public string TenantLicenseStatus {
            get { return BackingStore?.Get<string>("tenantLicenseStatus"); }
            set { BackingStore?.Set("tenantLicenseStatus", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new InvalidLicenseAlertIncident and sets the default values.
        /// </summary>
        public InvalidLicenseAlertIncident() : base() {
            OdataType = "#microsoft.graph.invalidLicenseAlertIncident";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InvalidLicenseAlertIncident CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvalidLicenseAlertIncident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"tenantLicenseStatus", n => { TenantLicenseStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("tenantLicenseStatus", TenantLicenseStatus);
        }
    }
}

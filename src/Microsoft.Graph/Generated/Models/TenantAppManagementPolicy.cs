using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TenantAppManagementPolicy : PolicyBase, IParsable {
        /// <summary>Restrictions that apply as default to all application objects in the tenant.</summary>
        public AppManagementConfiguration ApplicationRestrictions {
            get { return BackingStore?.Get<AppManagementConfiguration>("applicationRestrictions"); }
            set { BackingStore?.Set("applicationRestrictions", value); }
        }
        /// <summary>Denotes whether the policy is enabled. Default value is false.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Restrictions that apply as default to all service principal objects in the tenant.</summary>
        public AppManagementConfiguration ServicePrincipalRestrictions {
            get { return BackingStore?.Get<AppManagementConfiguration>("servicePrincipalRestrictions"); }
            set { BackingStore?.Set("servicePrincipalRestrictions", value); }
        }
        /// <summary>
        /// Instantiates a new TenantAppManagementPolicy and sets the default values.
        /// </summary>
        public TenantAppManagementPolicy() : base() {
            OdataType = "#microsoft.graph.tenantAppManagementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TenantAppManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantAppManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationRestrictions", n => { ApplicationRestrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"servicePrincipalRestrictions", n => { ServicePrincipalRestrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AppManagementConfiguration>("applicationRestrictions", ApplicationRestrictions);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<AppManagementConfiguration>("servicePrincipalRestrictions", ServicePrincipalRestrictions);
        }
    }
}

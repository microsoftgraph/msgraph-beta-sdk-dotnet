using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TenantAppManagementPolicy : PolicyBase, IParsable {
        /// <summary>Restrictions that apply as default to all application objects in the tenant.</summary>
        public AppManagementConfiguration ApplicationRestrictions { get; set; }
        /// <summary>Denotes whether the policy is enabled. Default value is false.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Restrictions that apply as default to all service principal objects in the tenant.</summary>
        public AppManagementConfiguration ServicePrincipalRestrictions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationRestrictions", (o,n) => { (o as TenantAppManagementPolicy).ApplicationRestrictions = n.GetObjectValue<AppManagementConfiguration>(); } },
                {"isEnabled", (o,n) => { (o as TenantAppManagementPolicy).IsEnabled = n.GetBoolValue(); } },
                {"servicePrincipalRestrictions", (o,n) => { (o as TenantAppManagementPolicy).ServicePrincipalRestrictions = n.GetObjectValue<AppManagementConfiguration>(); } },
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

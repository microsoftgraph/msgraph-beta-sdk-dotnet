using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CrossTenantAccessPolicy : TenantRelationshipAccessPolicyBase, IParsable {
        /// <summary>Defines the default configuration for how your organization interacts with external Azure Active Directory organizations.</summary>
        public CrossTenantAccessPolicyConfigurationDefault Default { get; set; }
        /// <summary>Defines partner-specific configurations for external Azure Active Directory organizations.</summary>
        public List<CrossTenantAccessPolicyConfigurationPartner> Partners { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"default", (o,n) => { (o as CrossTenantAccessPolicy).Default = n.GetObjectValue<CrossTenantAccessPolicyConfigurationDefault>(); } },
                {"partners", (o,n) => { (o as CrossTenantAccessPolicy).Partners = n.GetCollectionOfObjectValues<CrossTenantAccessPolicyConfigurationPartner>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CrossTenantAccessPolicyConfigurationDefault>("default", Default);
            writer.WriteCollectionOfObjectValues<CrossTenantAccessPolicyConfigurationPartner>("partners", Partners);
        }
    }
}

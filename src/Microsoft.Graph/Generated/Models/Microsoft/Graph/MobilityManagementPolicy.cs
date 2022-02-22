using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class MobilityManagementPolicy : Entity, IParsable {
        /// <summary>Indicates the user scope of the mobility management policy. Possible values are: none, all, selected.</summary>
        public PolicyScope? AppliesTo { get; set; }
        /// <summary>Compliance URL of the mobility management application.</summary>
        public string ComplianceUrl { get; set; }
        /// <summary>Description of the mobility management application.</summary>
        public string Description { get; set; }
        /// <summary>Discovery URL of the mobility management application.</summary>
        public string DiscoveryUrl { get; set; }
        /// <summary>Display name of the mobility management application.</summary>
        public string DisplayName { get; set; }
        /// <summary>Azure AD groups under the scope of the mobility management application if appliesTo is selected</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.Group> IncludedGroups { get; set; }
        /// <summary>Whether policy is valid. Invalid policies may not be updated and should be deleted.</summary>
        public bool? IsValid { get; set; }
        /// <summary>Terms of Use URL of the mobility management application.</summary>
        public string TermsOfUseUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appliesTo", (o,n) => { (o as MobilityManagementPolicy).AppliesTo = n.GetEnumValue<PolicyScope>(); } },
                {"complianceUrl", (o,n) => { (o as MobilityManagementPolicy).ComplianceUrl = n.GetStringValue(); } },
                {"description", (o,n) => { (o as MobilityManagementPolicy).Description = n.GetStringValue(); } },
                {"discoveryUrl", (o,n) => { (o as MobilityManagementPolicy).DiscoveryUrl = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MobilityManagementPolicy).DisplayName = n.GetStringValue(); } },
                {"includedGroups", (o,n) => { (o as MobilityManagementPolicy).IncludedGroups = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Group>().ToList(); } },
                {"isValid", (o,n) => { (o as MobilityManagementPolicy).IsValid = n.GetBoolValue(); } },
                {"termsOfUseUrl", (o,n) => { (o as MobilityManagementPolicy).TermsOfUseUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PolicyScope>("appliesTo", AppliesTo);
            writer.WriteStringValue("complianceUrl", ComplianceUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("discoveryUrl", DiscoveryUrl);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Group>("includedGroups", IncludedGroups);
            writer.WriteBoolValue("isValid", IsValid);
            writer.WriteStringValue("termsOfUseUrl", TermsOfUseUrl);
        }
    }
}

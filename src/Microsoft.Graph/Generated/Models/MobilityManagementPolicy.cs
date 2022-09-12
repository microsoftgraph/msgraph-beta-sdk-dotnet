using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobilityManagementPolicy : Entity, IParsable {
        /// <summary>Indicates the user scope of the mobility management policy. Possible values are: none, all, selected.</summary>
        public PolicyScope? AppliesTo {
            get { return BackingStore?.Get<PolicyScope?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
        /// <summary>Compliance URL of the mobility management application.</summary>
        public string ComplianceUrl {
            get { return BackingStore?.Get<string>("complianceUrl"); }
            set { BackingStore?.Set("complianceUrl", value); }
        }
        /// <summary>Description of the mobility management application.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Discovery URL of the mobility management application.</summary>
        public string DiscoveryUrl {
            get { return BackingStore?.Get<string>("discoveryUrl"); }
            set { BackingStore?.Set("discoveryUrl", value); }
        }
        /// <summary>Display name of the mobility management application.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Azure AD groups under the scope of the mobility management application if appliesTo is selected</summary>
        public List<Group> IncludedGroups {
            get { return BackingStore?.Get<List<Group>>("includedGroups"); }
            set { BackingStore?.Set("includedGroups", value); }
        }
        /// <summary>Whether policy is valid. Invalid policies may not be updated and should be deleted.</summary>
        public bool? IsValid {
            get { return BackingStore?.Get<bool?>("isValid"); }
            set { BackingStore?.Set("isValid", value); }
        }
        /// <summary>Terms of Use URL of the mobility management application.</summary>
        public string TermsOfUseUrl {
            get { return BackingStore?.Get<string>("termsOfUseUrl"); }
            set { BackingStore?.Set("termsOfUseUrl", value); }
        }
        /// <summary>
        /// Instantiates a new MobilityManagementPolicy and sets the default values.
        /// </summary>
        public MobilityManagementPolicy() : base() {
            OdataType = "#microsoft.graph.mobilityManagementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobilityManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobilityManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appliesTo", n => { AppliesTo = n.GetEnumValue<PolicyScope>(); } },
                {"complianceUrl", n => { ComplianceUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discoveryUrl", n => { DiscoveryUrl = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"includedGroups", n => { IncludedGroups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isValid", n => { IsValid = n.GetBoolValue(); } },
                {"termsOfUseUrl", n => { TermsOfUseUrl = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<Group>("includedGroups", IncludedGroups);
            writer.WriteBoolValue("isValid", IsValid);
            writer.WriteStringValue("termsOfUseUrl", TermsOfUseUrl);
        }
    }
}

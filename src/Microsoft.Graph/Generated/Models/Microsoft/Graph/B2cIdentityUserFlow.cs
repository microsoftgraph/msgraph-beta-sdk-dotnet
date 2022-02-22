using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class B2cIdentityUserFlow : IdentityUserFlow, IParsable {
        /// <summary>Configuration for enabling an API connector for use as part of the user flow. You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.</summary>
        public UserFlowApiConnectorConfiguration ApiConnectorConfiguration { get; set; }
        /// <summary>Indicates the default language of the b2cIdentityUserFlow that is used when no ui_locale tag is specified in the request. This field is RFC 5646 compliant.</summary>
        public string DefaultLanguageTag { get; set; }
        public List<IdentityProvider> IdentityProviders { get; set; }
        /// <summary>The property that determines whether language customization is enabled within the B2C user flow. Language customization is not enabled by default for B2C user flows.</summary>
        public bool? IsLanguageCustomizationEnabled { get; set; }
        /// <summary>The languages supported for customization within the user flow. Language customization is not enabled by default in B2C user flows.</summary>
        public List<UserFlowLanguageConfiguration> Languages { get; set; }
        /// <summary>The user attribute assignments included in the user flow.</summary>
        public List<IdentityUserFlowAttributeAssignment> UserAttributeAssignments { get; set; }
        public List<IdentityProviderBase> UserFlowIdentityProviders { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apiConnectorConfiguration", (o,n) => { (o as B2cIdentityUserFlow).ApiConnectorConfiguration = n.GetObjectValue<UserFlowApiConnectorConfiguration>(); } },
                {"defaultLanguageTag", (o,n) => { (o as B2cIdentityUserFlow).DefaultLanguageTag = n.GetStringValue(); } },
                {"identityProviders", (o,n) => { (o as B2cIdentityUserFlow).IdentityProviders = n.GetCollectionOfObjectValues<IdentityProvider>().ToList(); } },
                {"isLanguageCustomizationEnabled", (o,n) => { (o as B2cIdentityUserFlow).IsLanguageCustomizationEnabled = n.GetBoolValue(); } },
                {"languages", (o,n) => { (o as B2cIdentityUserFlow).Languages = n.GetCollectionOfObjectValues<UserFlowLanguageConfiguration>().ToList(); } },
                {"userAttributeAssignments", (o,n) => { (o as B2cIdentityUserFlow).UserAttributeAssignments = n.GetCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>().ToList(); } },
                {"userFlowIdentityProviders", (o,n) => { (o as B2cIdentityUserFlow).UserFlowIdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserFlowApiConnectorConfiguration>("apiConnectorConfiguration", ApiConnectorConfiguration);
            writer.WriteStringValue("defaultLanguageTag", DefaultLanguageTag);
            writer.WriteCollectionOfObjectValues<IdentityProvider>("identityProviders", IdentityProviders);
            writer.WriteBoolValue("isLanguageCustomizationEnabled", IsLanguageCustomizationEnabled);
            writer.WriteCollectionOfObjectValues<UserFlowLanguageConfiguration>("languages", Languages);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>("userAttributeAssignments", UserAttributeAssignments);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("userFlowIdentityProviders", UserFlowIdentityProviders);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSCredentialSingleSignOnExtension : MacOSSingleSignOnExtension, IParsable {
        /// <summary>Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.</summary>
        public List<KeyTypedValuePair> Configurations {
            get { return BackingStore?.Get<List<KeyTypedValuePair>>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
        /// <summary>Gets or sets a list of hosts or domain names for which the app extension performs SSO.</summary>
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
        /// <summary>Gets or sets the bundle ID of the app extension that performs SSO for the specified URLs.</summary>
        public string ExtensionIdentifier {
            get { return BackingStore?.Get<string>("extensionIdentifier"); }
            set { BackingStore?.Set("extensionIdentifier", value); }
        }
        /// <summary>Gets or sets the case-sensitive realm name for this profile.</summary>
        public string Realm {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
        /// <summary>Gets or sets the team ID of the app extension that performs SSO for the specified URLs.</summary>
        public string TeamIdentifier {
            get { return BackingStore?.Get<string>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSCredentialSingleSignOnExtension and sets the default values.
        /// </summary>
        public MacOSCredentialSingleSignOnExtension() : base() {
            OdataType = "#microsoft.graph.macOSCredentialSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSCredentialSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSCredentialSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurations", n => { Configurations = n.GetCollectionOfObjectValues<KeyTypedValuePair>(KeyTypedValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"extensionIdentifier", n => { ExtensionIdentifier = n.GetStringValue(); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"teamIdentifier", n => { TeamIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyTypedValuePair>("configurations", Configurations);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteStringValue("extensionIdentifier", ExtensionIdentifier);
            writer.WriteStringValue("realm", Realm);
            writer.WriteStringValue("teamIdentifier", TeamIdentifier);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RedirectSingleSignOnExtension : SingleSignOnExtension, IParsable {
        /// <summary>Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.</summary>
        public List<KeyTypedValuePair> Configurations {
            get { return BackingStore?.Get<List<KeyTypedValuePair>>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
        /// <summary>Gets or sets the bundle ID of the app extension that performs SSO for the specified URLs.</summary>
        public string ExtensionIdentifier {
            get { return BackingStore?.Get<string>("extensionIdentifier"); }
            set { BackingStore?.Set("extensionIdentifier", value); }
        }
        /// <summary>Gets or sets the team ID of the app extension that performs SSO for the specified URLs.</summary>
        public string TeamIdentifier {
            get { return BackingStore?.Get<string>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
        /// <summary>One or more URL prefixes of identity providers on whose behalf the app extension performs single sign-on. URLs must begin with http:// or https://. All URL prefixes must be unique for all profiles.</summary>
        public List<string> UrlPrefixes {
            get { return BackingStore?.Get<List<string>>("urlPrefixes"); }
            set { BackingStore?.Set("urlPrefixes", value); }
        }
        /// <summary>
        /// Instantiates a new RedirectSingleSignOnExtension and sets the default values.
        /// </summary>
        public RedirectSingleSignOnExtension() : base() {
            OdataType = "#microsoft.graph.redirectSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RedirectSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedirectSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurations", n => { Configurations = n.GetCollectionOfObjectValues<KeyTypedValuePair>(KeyTypedValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"extensionIdentifier", n => { ExtensionIdentifier = n.GetStringValue(); } },
                {"teamIdentifier", n => { TeamIdentifier = n.GetStringValue(); } },
                {"urlPrefixes", n => { UrlPrefixes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteStringValue("extensionIdentifier", ExtensionIdentifier);
            writer.WriteStringValue("teamIdentifier", TeamIdentifier);
            writer.WriteCollectionOfPrimitiveValues<string>("urlPrefixes", UrlPrefixes);
        }
    }
}

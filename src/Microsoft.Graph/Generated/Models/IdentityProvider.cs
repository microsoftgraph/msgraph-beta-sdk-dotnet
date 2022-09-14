using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class IdentityProvider : Entity, IParsable {
        /// <summary>The client ID for the application obtained when registering the application with the identity provider. This is a required field.  Required. Not nullable.</summary>
        public string ClientId {
            get { return BackingStore?.Get<string>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
        /// <summary>The client secret for the application obtained when registering the application with the identity provider. This is write-only. A read operation will return ****. This is a required field. Required. Not nullable.</summary>
        public string ClientSecret {
            get { return BackingStore?.Get<string>("clientSecret"); }
            set { BackingStore?.Set("clientSecret", value); }
        }
        /// <summary>The display name of the identity provider. Not nullable.</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The identity provider type is a required field. For B2B scenario: Google, Facebook. For B2C scenario: Microsoft, Google, Amazon, LinkedIn, Facebook, GitHub, Twitter, Weibo,QQ, WeChat, OpenIDConnect. Not nullable.</summary>
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new identityProvider and sets the default values.
        /// </summary>
        public IdentityProvider() : base() {
            OdataType = "#microsoft.graph.identityProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.openIdConnectProvider" => new OpenIdConnectProvider(),
                _ => new IdentityProvider(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"clientSecret", n => { ClientSecret = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("type", Type);
        }
    }
}

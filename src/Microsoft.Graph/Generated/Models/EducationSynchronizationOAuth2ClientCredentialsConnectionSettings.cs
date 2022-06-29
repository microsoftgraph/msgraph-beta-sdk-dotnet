using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationOAuth2ClientCredentialsConnectionSettings : EducationSynchronizationConnectionSettings, IParsable {
        /// <summary>The scope of the access request (see RFC6749).</summary>
        public string Scope {
            get { return BackingStore?.Get<string>(nameof(Scope)); }
            set { BackingStore?.Set(nameof(Scope), value); }
        }
        /// <summary>The URL to get access tokens for the data provider.</summary>
        public string TokenUrl {
            get { return BackingStore?.Get<string>(nameof(TokenUrl)); }
            set { BackingStore?.Set(nameof(TokenUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSynchronizationOAuth2ClientCredentialsConnectionSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationOAuth2ClientCredentialsConnectionSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"tokenUrl", n => { TokenUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("tokenUrl", TokenUrl);
        }
    }
}

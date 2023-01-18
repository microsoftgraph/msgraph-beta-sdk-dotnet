using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationOAuth2ClientCredentialsConnectionSettings : EducationSynchronizationConnectionSettings, IParsable {
        /// <summary>The scope of the access request (see RFC6749).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Scope {
            get { return BackingStore?.Get<string?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#else
        public string Scope {
            get { return BackingStore?.Get<string>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>The URL to get access tokens for the data provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TokenUrl {
            get { return BackingStore?.Get<string?>("tokenUrl"); }
            set { BackingStore?.Set("tokenUrl", value); }
        }
#else
        public string TokenUrl {
            get { return BackingStore?.Get<string>("tokenUrl"); }
            set { BackingStore?.Set("tokenUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new EducationSynchronizationOAuth2ClientCredentialsConnectionSettings and sets the default values.
        /// </summary>
        public EducationSynchronizationOAuth2ClientCredentialsConnectionSettings() : base() {
            OdataType = "#microsoft.graph.educationSynchronizationOAuth2ClientCredentialsConnectionSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("tokenUrl", TokenUrl);
        }
    }
}

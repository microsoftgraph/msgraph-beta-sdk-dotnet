using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationConnectionSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Client ID used to connect to the provider.</summary>
        public string ClientId {
            get { return BackingStore?.Get<string>(nameof(ClientId)); }
            set { BackingStore?.Set(nameof(ClientId), value); }
        }
        /// <summary>Client secret to authenticate the connection to the provider.</summary>
        public string ClientSecret {
            get { return BackingStore?.Get<string>(nameof(ClientSecret)); }
            set { BackingStore?.Set(nameof(ClientSecret), value); }
        }
        /// <summary>
        /// Instantiates a new educationSynchronizationConnectionSettings and sets the default values.
        /// </summary>
        public EducationSynchronizationConnectionSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EducationSynchronizationConnectionSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.educationSynchronizationOAuth1ConnectionSettings" => new EducationSynchronizationOAuth1ConnectionSettings(),
                "#microsoft.graph.educationSynchronizationOAuth2ClientCredentialsConnectionSettings" => new EducationSynchronizationOAuth2ClientCredentialsConnectionSettings(),
                _ => new EducationSynchronizationConnectionSettings(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"clientSecret", n => { ClientSecret = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppManagementConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Collection of keyCredential restrictions settings to be applied to an application or service principal.</summary>
        public List<KeyCredentialConfiguration> KeyCredentials { get; set; }
        /// <summary>Collection of password restrictions settings to be applied to an application or service principal.</summary>
        public List<PasswordCredentialConfiguration> PasswordCredentials { get; set; }
        /// <summary>
        /// Instantiates a new appManagementConfiguration and sets the default values.
        /// </summary>
        public AppManagementConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppManagementConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppManagementConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"keyCredentials", (o,n) => { (o as AppManagementConfiguration).KeyCredentials = n.GetCollectionOfObjectValues<KeyCredentialConfiguration>(KeyCredentialConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordCredentials", (o,n) => { (o as AppManagementConfiguration).PasswordCredentials = n.GetCollectionOfObjectValues<PasswordCredentialConfiguration>(PasswordCredentialConfiguration.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<KeyCredentialConfiguration>("keyCredentials", KeyCredentials);
            writer.WriteCollectionOfObjectValues<PasswordCredentialConfiguration>("passwordCredentials", PasswordCredentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

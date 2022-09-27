using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerDerivedCredentialAuthenticationConfigurationCollectionResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
        public List<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration> Value {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerDerivedCredentialAuthenticationConfigurationCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerDerivedCredentialAuthenticationConfigurationCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration>(AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration>("value", Value);
        }
    }
}

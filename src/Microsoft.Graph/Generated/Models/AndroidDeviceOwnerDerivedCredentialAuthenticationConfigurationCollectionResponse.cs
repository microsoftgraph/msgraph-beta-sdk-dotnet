using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerDerivedCredentialAuthenticationConfigurationCollectionResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration>? Value {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration>?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration> Value {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration>("value", Value);
        }
    }
}

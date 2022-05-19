using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class NetworkLocationDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Provides the name of the network used when signing in.</summary>
        public List<string> NetworkNames {
            get { return BackingStore?.Get<List<string>>(nameof(NetworkNames)); }
            set { BackingStore?.Set(nameof(NetworkNames), value); }
        }
        /// <summary>Provides the type of network used when signing in. Possible values are: intranet, extranet, namedNetwork, trusted, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.NetworkType? NetworkType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.NetworkType?>(nameof(NetworkType)); }
            set { BackingStore?.Set(nameof(NetworkType), value); }
        }
        /// <summary>
        /// Instantiates a new networkLocationDetail and sets the default values.
        /// </summary>
        public NetworkLocationDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static NetworkLocationDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkLocationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"networkNames", n => { NetworkNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"networkType", n => { NetworkType = n.GetEnumValue<NetworkType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("networkNames", NetworkNames);
            writer.WriteEnumValue<NetworkType>("networkType", NetworkType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

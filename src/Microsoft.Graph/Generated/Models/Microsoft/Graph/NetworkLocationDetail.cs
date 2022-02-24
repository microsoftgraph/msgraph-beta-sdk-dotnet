using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class NetworkLocationDetail : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Provides the name of the network used when signing in.</summary>
        public List<string> NetworkNames { get; set; }
        /// <summary>Provides the type of network used when signing in. Possible values are: intranet, extranet, namedNetwork, trusted, unknownFutureValue.</summary>
        public NetworkType? NetworkType { get; set; }
        /// <summary>
        /// Instantiates a new networkLocationDetail and sets the default values.
        /// </summary>
        public NetworkLocationDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"networkNames", (o,n) => { (o as NetworkLocationDetail).NetworkNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"networkType", (o,n) => { (o as NetworkLocationDetail).NetworkType = n.GetEnumValue<NetworkType>(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DelegatedAdminAccessContainer : IParsable {
        public string AccessContainerId { get; set; }
        public DelegatedAdminAccessContainerType? AccessContainerType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>
        /// Instantiates a new delegatedAdminAccessContainer and sets the default values.
        /// </summary>
        public DelegatedAdminAccessContainer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessContainerId", (o,n) => { (o as DelegatedAdminAccessContainer).AccessContainerId = n.GetStringValue(); } },
                {"accessContainerType", (o,n) => { (o as DelegatedAdminAccessContainer).AccessContainerType = n.GetEnumValue<DelegatedAdminAccessContainerType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accessContainerId", AccessContainerId);
            writer.WriteEnumValue<DelegatedAdminAccessContainerType>("accessContainerType", AccessContainerType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Users.Item.Security.InformationProtection.SensitivityLabels {
    public class SensitivityLabelsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<SensitivityLabel> Value { get; set; }
        /// <summary>
        /// Instantiates a new sensitivityLabelsResponse and sets the default values.
        /// </summary>
        public SensitivityLabelsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as SensitivityLabelsResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as SensitivityLabelsResponse).Value = n.GetCollectionOfObjectValues<SensitivityLabel>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

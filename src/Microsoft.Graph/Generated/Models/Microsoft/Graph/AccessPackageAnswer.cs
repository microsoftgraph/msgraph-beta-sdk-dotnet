using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageAnswer : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The question the answer is for. Required and Read-only.</summary>
        public AccessPackageQuestion AnsweredQuestion { get; set; }
        /// <summary>The display value of the answer. Required.</summary>
        public string DisplayValue { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAnswer and sets the default values.
        /// </summary>
        public AccessPackageAnswer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"answeredQuestion", (o,n) => { (o as AccessPackageAnswer).AnsweredQuestion = n.GetObjectValue<AccessPackageQuestion>(); } },
                {"displayValue", (o,n) => { (o as AccessPackageAnswer).DisplayValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AccessPackageQuestion>("answeredQuestion", AnsweredQuestion);
            writer.WriteStringValue("displayValue", DisplayValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

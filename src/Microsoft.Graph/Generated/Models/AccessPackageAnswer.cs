using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAnswer : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAnswer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAnswer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"answeredQuestion", n => { AnsweredQuestion = n.GetObjectValue<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue); } },
                {"displayValue", n => { DisplayValue = n.GetStringValue(); } },
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

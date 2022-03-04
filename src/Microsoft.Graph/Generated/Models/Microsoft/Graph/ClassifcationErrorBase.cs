using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ClassifcationErrorBase : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Code { get; set; }
        public ClassificationInnerError InnerError { get; set; }
        public string Message { get; set; }
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new classifcationErrorBase and sets the default values.
        /// </summary>
        public ClassifcationErrorBase() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClassifcationErrorBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassifcationErrorBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as ClassifcationErrorBase).Code = n.GetStringValue(); } },
                {"innerError", (o,n) => { (o as ClassifcationErrorBase).InnerError = n.GetObjectValue<ClassificationInnerError>(ClassificationInnerError.CreateFromDiscriminatorValue); } },
                {"message", (o,n) => { (o as ClassifcationErrorBase).Message = n.GetStringValue(); } },
                {"target", (o,n) => { (o as ClassifcationErrorBase).Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteObjectValue<ClassificationInnerError>("innerError", InnerError);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

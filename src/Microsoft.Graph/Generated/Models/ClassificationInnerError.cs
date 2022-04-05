using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ClassificationInnerError : IAdditionalDataHolder, IParsable {
        /// <summary>The activityId property</summary>
        public string ActivityId { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The clientRequestId property</summary>
        public string ClientRequestId { get; set; }
        /// <summary>The code property</summary>
        public string Code { get; set; }
        /// <summary>The errorDateTime property</summary>
        public DateTimeOffset? ErrorDateTime { get; set; }
        /// <summary>
        /// Instantiates a new classificationInnerError and sets the default values.
        /// </summary>
        public ClassificationInnerError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClassificationInnerError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassificationInnerError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activityId", (o,n) => { (o as ClassificationInnerError).ActivityId = n.GetStringValue(); } },
                {"clientRequestId", (o,n) => { (o as ClassificationInnerError).ClientRequestId = n.GetStringValue(); } },
                {"code", (o,n) => { (o as ClassificationInnerError).Code = n.GetStringValue(); } },
                {"errorDateTime", (o,n) => { (o as ClassificationInnerError).ErrorDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityId", ActivityId);
            writer.WriteStringValue("clientRequestId", ClientRequestId);
            writer.WriteStringValue("code", Code);
            writer.WriteDateTimeOffsetValue("errorDateTime", ErrorDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

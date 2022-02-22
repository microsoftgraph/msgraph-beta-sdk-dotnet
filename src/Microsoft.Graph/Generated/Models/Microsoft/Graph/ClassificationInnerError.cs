using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ClassificationInnerError : IParsable {
        public string ActivityId { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClientRequestId { get; set; }
        public string Code { get; set; }
        public DateTimeOffset? ErrorDateTime { get; set; }
        /// <summary>
        /// Instantiates a new classificationInnerError and sets the default values.
        /// </summary>
        public ClassificationInnerError() {
            AdditionalData = new Dictionary<string, object>();
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

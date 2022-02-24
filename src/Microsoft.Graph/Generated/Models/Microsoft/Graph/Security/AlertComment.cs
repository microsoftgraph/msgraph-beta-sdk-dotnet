using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    public class AlertComment : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public string CreatedByDisplayName { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new alertComment and sets the default values.
        /// </summary>
        public AlertComment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as AlertComment).Comment = n.GetStringValue(); } },
                {"createdByDisplayName", (o,n) => { (o as AlertComment).CreatedByDisplayName = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AlertComment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("createdByDisplayName", CreatedByDisplayName);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

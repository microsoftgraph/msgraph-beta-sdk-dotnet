using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class OutOfOfficeSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True if either:It is currently in the out of office time window configured on the Outlook or Teams client.There is currently an event on the user's calendar that's marked as Show as Out of OfficeOtherwise, false.</summary>
        public bool? IsOutOfOffice { get; set; }
        /// <summary>The out of office message that the user configured on Outlook client (Automatic Replies (Out of Office)) or the Teams client (Schedule out of office).</summary>
        public string Message { get; set; }
        /// <summary>
        /// Instantiates a new outOfOfficeSettings and sets the default values.
        /// </summary>
        public OutOfOfficeSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isOutOfOffice", (o,n) => { (o as OutOfOfficeSettings).IsOutOfOffice = n.GetBoolValue(); } },
                {"message", (o,n) => { (o as OutOfOfficeSettings).Message = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isOutOfOffice", IsOutOfOffice);
            writer.WriteStringValue("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

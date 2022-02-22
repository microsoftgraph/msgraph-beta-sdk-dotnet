using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class LoggedOnUser : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date time when user logs on</summary>
        public DateTimeOffset? LastLogOnDateTime { get; set; }
        /// <summary>User id</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new loggedOnUser and sets the default values.
        /// </summary>
        public LoggedOnUser() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lastLogOnDateTime", (o,n) => { (o as LoggedOnUser).LastLogOnDateTime = n.GetDateTimeOffsetValue(); } },
                {"userId", (o,n) => { (o as LoggedOnUser).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastLogOnDateTime", LastLogOnDateTime);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ConfigurationManagerClientHealthState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Error code for failed state.</summary>
        public int? ErrorCode { get; set; }
        /// <summary>Datetime for last sync with configuration manager management point.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Current configuration manager client state. Possible values are: unknown, installed, healthy, installFailed, updateFailed, communicationError.</summary>
        public ConfigurationManagerClientState? State { get; set; }
        /// <summary>
        /// Instantiates a new configurationManagerClientHealthState and sets the default values.
        /// </summary>
        public ConfigurationManagerClientHealthState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"errorCode", (o,n) => { (o as ConfigurationManagerClientHealthState).ErrorCode = n.GetIntValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as ConfigurationManagerClientHealthState).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as ConfigurationManagerClientHealthState).State = n.GetEnumValue<ConfigurationManagerClientState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<ConfigurationManagerClientState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

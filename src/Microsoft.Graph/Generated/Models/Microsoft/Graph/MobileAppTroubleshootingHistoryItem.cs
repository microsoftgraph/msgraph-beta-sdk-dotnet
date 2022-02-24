using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MobileAppTroubleshootingHistoryItem : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Time when the history item occurred.</summary>
        public DateTimeOffset? OccurrenceDateTime { get; set; }
        /// <summary>Object containing detailed information about the error and its remediation.</summary>
        public DeviceManagementTroubleshootingErrorDetails TroubleshootingErrorDetails { get; set; }
        /// <summary>
        /// Instantiates a new mobileAppTroubleshootingHistoryItem and sets the default values.
        /// </summary>
        public MobileAppTroubleshootingHistoryItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"occurrenceDateTime", (o,n) => { (o as MobileAppTroubleshootingHistoryItem).OccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"troubleshootingErrorDetails", (o,n) => { (o as MobileAppTroubleshootingHistoryItem).TroubleshootingErrorDetails = n.GetObjectValue<DeviceManagementTroubleshootingErrorDetails>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("occurrenceDateTime", OccurrenceDateTime);
            writer.WriteObjectValue<DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails", TroubleshootingErrorDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

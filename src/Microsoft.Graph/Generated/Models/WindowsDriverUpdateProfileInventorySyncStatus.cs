using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A complex type to store the status of a driver and firmware profile inventory sync. The status includes the last successful sync date time and the state of the last sync.</summary>
    public class WindowsDriverUpdateProfileInventorySyncStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The state of the latest sync. Possible values are: pending, success, failure.</summary>
        public WindowsDriverUpdateProfileInventorySyncState? DriverInventorySyncState { get; set; }
        /// <summary>The last successful sync date and time in UTC.</summary>
        public DateTimeOffset? LastSuccessfulSyncDateTime { get; set; }
        /// <summary>
        /// Instantiates a new windowsDriverUpdateProfileInventorySyncStatus and sets the default values.
        /// </summary>
        public WindowsDriverUpdateProfileInventorySyncStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsDriverUpdateProfileInventorySyncStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDriverUpdateProfileInventorySyncStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"driverInventorySyncState", (o,n) => { (o as WindowsDriverUpdateProfileInventorySyncStatus).DriverInventorySyncState = n.GetEnumValue<WindowsDriverUpdateProfileInventorySyncState>(); } },
                {"lastSuccessfulSyncDateTime", (o,n) => { (o as WindowsDriverUpdateProfileInventorySyncStatus).LastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WindowsDriverUpdateProfileInventorySyncState>("driverInventorySyncState", DriverInventorySyncState);
            writer.WriteDateTimeOffsetValue("lastSuccessfulSyncDateTime", LastSuccessfulSyncDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

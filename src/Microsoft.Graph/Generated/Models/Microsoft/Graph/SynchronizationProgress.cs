using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class SynchronizationProgress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The numerator of a progress ratio; the number of units of changes already processed.</summary>
        public int? CompletedUnits { get; set; }
        /// <summary>The time of a progress observation as an offset in minutes from UTC.</summary>
        public DateTimeOffset? ProgressObservationDateTime { get; set; }
        /// <summary>The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.</summary>
        public int? TotalUnits { get; set; }
        /// <summary>An optional description of the units.</summary>
        public string Units { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationProgress and sets the default values.
        /// </summary>
        public SynchronizationProgress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationProgress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationProgress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"completedUnits", (o,n) => { (o as SynchronizationProgress).CompletedUnits = n.GetIntValue(); } },
                {"progressObservationDateTime", (o,n) => { (o as SynchronizationProgress).ProgressObservationDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalUnits", (o,n) => { (o as SynchronizationProgress).TotalUnits = n.GetIntValue(); } },
                {"units", (o,n) => { (o as SynchronizationProgress).Units = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("completedUnits", CompletedUnits);
            writer.WriteDateTimeOffsetValue("progressObservationDateTime", ProgressObservationDateTime);
            writer.WriteIntValue("totalUnits", TotalUnits);
            writer.WriteStringValue("units", Units);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

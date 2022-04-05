using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcRestorePointSetting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The time interval in hours to take snapshots (restore points) of a Cloud PC automatically. Possible values are 4, 6, 12, 16, and 24. The default frequency is 12 hours.</summary>
        public int? FrequencyInHours { get; set; }
        /// <summary>If true, the user has the ability to use snapshots to restore Cloud PCs. If false, non-admin users cannot use snapshots to restore the Cloud PC.</summary>
        public bool? UserRestoreEnabled { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcRestorePointSetting and sets the default values.
        /// </summary>
        public CloudPcRestorePointSetting() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcRestorePointSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcRestorePointSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"frequencyInHours", (o,n) => { (o as CloudPcRestorePointSetting).FrequencyInHours = n.GetIntValue(); } },
                {"userRestoreEnabled", (o,n) => { (o as CloudPcRestorePointSetting).UserRestoreEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("frequencyInHours", FrequencyInHours);
            writer.WriteBoolValue("userRestoreEnabled", UserRestoreEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

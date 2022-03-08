using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc {
    /// <summary>Provides operations to call the bulkRestoreCloudPc method.</summary>
    public class BulkRestoreCloudPcRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> ManagedDeviceIds { get; set; }
        public DateTimeOffset? RestorePointDateTime { get; set; }
        public RestoreTimeRange? TimeRange { get; set; }
        /// <summary>
        /// Instantiates a new bulkRestoreCloudPcRequestBody and sets the default values.
        /// </summary>
        public BulkRestoreCloudPcRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BulkRestoreCloudPcRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkRestoreCloudPcRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"managedDeviceIds", (o,n) => { (o as BulkRestoreCloudPcRequestBody).ManagedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"restorePointDateTime", (o,n) => { (o as BulkRestoreCloudPcRequestBody).RestorePointDateTime = n.GetDateTimeOffsetValue(); } },
                {"timeRange", (o,n) => { (o as BulkRestoreCloudPcRequestBody).TimeRange = n.GetEnumValue<RestoreTimeRange>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("managedDeviceIds", ManagedDeviceIds);
            writer.WriteDateTimeOffsetValue("restorePointDateTime", RestorePointDateTime);
            writer.WriteEnumValue<RestoreTimeRange>("timeRange", TimeRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.BulkRestoreCloudPc {
    /// <summary>Provides operations to call the bulkRestoreCloudPc method.</summary>
    public class BulkRestoreCloudPcPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The managedDeviceIds property</summary>
        public List<string> ManagedDeviceIds {
            get { return BackingStore?.Get<List<string>>(nameof(ManagedDeviceIds)); }
            set { BackingStore?.Set(nameof(ManagedDeviceIds), value); }
        }
        /// <summary>The restorePointDateTime property</summary>
        public DateTimeOffset? RestorePointDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RestorePointDateTime)); }
            set { BackingStore?.Set(nameof(RestorePointDateTime), value); }
        }
        /// <summary>The timeRange property</summary>
        public RestoreTimeRange? TimeRange {
            get { return BackingStore?.Get<RestoreTimeRange?>(nameof(TimeRange)); }
            set { BackingStore?.Set(nameof(TimeRange), value); }
        }
        /// <summary>
        /// Instantiates a new bulkRestoreCloudPcPostRequestBody and sets the default values.
        /// </summary>
        public BulkRestoreCloudPcPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BulkRestoreCloudPcPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkRestoreCloudPcPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"managedDeviceIds", n => { ManagedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"restorePointDateTime", n => { RestorePointDateTime = n.GetDateTimeOffsetValue(); } },
                {"timeRange", n => { TimeRange = n.GetEnumValue<RestoreTimeRange>(); } },
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

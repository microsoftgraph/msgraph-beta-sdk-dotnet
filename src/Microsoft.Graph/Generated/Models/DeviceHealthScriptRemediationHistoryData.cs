using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The number of devices remediated by a device health script on a given date.</summary>
    public class DeviceHealthScriptRemediationHistoryData : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date on which devices were remediated by the device health script.</summary>
        public Date? Date {
            get { return BackingStore?.Get<Date?>(nameof(Date)); }
            set { BackingStore?.Set(nameof(Date), value); }
        }
        /// <summary>The number of devices that were found to have no issue by the device health script.</summary>
        public int? NoIssueDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(NoIssueDeviceCount)); }
            set { BackingStore?.Set(nameof(NoIssueDeviceCount), value); }
        }
        /// <summary>The number of devices remediated by the device health script.</summary>
        public int? RemediatedDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(RemediatedDeviceCount)); }
            set { BackingStore?.Set(nameof(RemediatedDeviceCount), value); }
        }
        /// <summary>
        /// Instantiates a new deviceHealthScriptRemediationHistoryData and sets the default values.
        /// </summary>
        public DeviceHealthScriptRemediationHistoryData() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceHealthScriptRemediationHistoryData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptRemediationHistoryData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"date", n => { Date = n.GetDateValue(); } },
                {"noIssueDeviceCount", n => { NoIssueDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("date", Date);
            writer.WriteIntValue("noIssueDeviceCount", NoIssueDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

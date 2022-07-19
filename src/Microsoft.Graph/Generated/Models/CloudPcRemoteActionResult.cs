using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcRemoteActionResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The specified action. Supported values in the Microsoft Endpoint Manager portal are: Reprovision, Resize, Restore. Supported values in enterprise Cloud PC devices are: Reboot, Rename, Reprovision, Troubleshoot.</summary>
        public string ActionName {
            get { return BackingStore?.Get<string>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
        /// <summary>State of the action. Possible values are: None, pending, canceled, active, done, failed, notSupported. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.ActionState? ActionState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ActionState?>("actionState"); }
            set { BackingStore?.Set("actionState", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ID of the Cloud PC device on which the remote action is performed. Read-only.</summary>
        public string CloudPcId {
            get { return BackingStore?.Get<string>("cloudPcId"); }
            set { BackingStore?.Set("cloudPcId", value); }
        }
        /// <summary>Last update time for action. The Timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The ID of the Intune managed device on which the remote action is performed. Read-only.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Time the action was initiated. The Timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The details of the Cloud PC status.</summary>
        public CloudPcStatusDetails StatusDetails {
            get { return BackingStore?.Get<CloudPcStatusDetails>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcRemoteActionResult and sets the default values.
        /// </summary>
        public CloudPcRemoteActionResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.cloudPcRemoteActionResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcRemoteActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcRemoteActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetStringValue(); } },
                {"actionState", n => { ActionState = n.GetEnumValue<ActionState>(); } },
                {"cloudPcId", n => { CloudPcId = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"statusDetails", n => { StatusDetails = n.GetObjectValue<CloudPcStatusDetails>(CloudPcStatusDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteStringValue("cloudPcId", CloudPcId);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteObjectValue<CloudPcStatusDetails>("statusDetails", StatusDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

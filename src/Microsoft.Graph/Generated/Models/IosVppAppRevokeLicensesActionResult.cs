using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Defines results for actions on iOS Vpp Apps, contains inherited properties for ActionResult.</summary>
    public class IosVppAppRevokeLicensesActionResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The reason for the revoke licenses action failure. Possible values are: none, appleFailure, internalError, expiredVppToken, expiredApplePushNotificationCertificate.</summary>
        public VppTokenActionFailureReason? ActionFailureReason {
            get { return BackingStore?.Get<VppTokenActionFailureReason?>(nameof(ActionFailureReason)); }
            set { BackingStore?.Set(nameof(ActionFailureReason), value); }
        }
        /// <summary>Action name</summary>
        public string ActionName {
            get { return BackingStore?.Get<string>(nameof(ActionName)); }
            set { BackingStore?.Set(nameof(ActionName), value); }
        }
        /// <summary>State of the action. Possible values are: none, pending, canceled, active, done, failed, notSupported.</summary>
        public Microsoft.Graph.Beta.Models.ActionState? ActionState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ActionState?>(nameof(ActionState)); }
            set { BackingStore?.Set(nameof(ActionState), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A count of the number of licenses for which revoke failed.</summary>
        public int? FailedLicensesCount {
            get { return BackingStore?.Get<int?>(nameof(FailedLicensesCount)); }
            set { BackingStore?.Set(nameof(FailedLicensesCount), value); }
        }
        /// <summary>Time the action state was last updated</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdatedDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdatedDateTime), value); }
        }
        /// <summary>DeviceId associated with the action.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>Time the action was initiated</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>A count of the number of licenses for which revoke was attempted.</summary>
        public int? TotalLicensesCount {
            get { return BackingStore?.Get<int?>(nameof(TotalLicensesCount)); }
            set { BackingStore?.Set(nameof(TotalLicensesCount), value); }
        }
        /// <summary>UserId associated with the action.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Instantiates a new iosVppAppRevokeLicensesActionResult and sets the default values.
        /// </summary>
        public IosVppAppRevokeLicensesActionResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosVppAppRevokeLicensesActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppAppRevokeLicensesActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionFailureReason", n => { ActionFailureReason = n.GetEnumValue<VppTokenActionFailureReason>(); } },
                {"actionName", n => { ActionName = n.GetStringValue(); } },
                {"actionState", n => { ActionState = n.GetEnumValue<ActionState>(); } },
                {"failedLicensesCount", n => { FailedLicensesCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalLicensesCount", n => { TotalLicensesCount = n.GetIntValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<VppTokenActionFailureReason>("actionFailureReason", ActionFailureReason);
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteIntValue("failedLicensesCount", FailedLicensesCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteIntValue("totalLicensesCount", TotalLicensesCount);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

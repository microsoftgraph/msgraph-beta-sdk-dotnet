using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Describes the installation status details of the child app in the context of UPN and device id.
    /// </summary>
    public class MobileAppRelationshipState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The corresponding device id.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The error code for install or uninstall failures of target app.</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.</summary>
        public ResultantAppState? InstallState {
            get { return BackingStore?.Get<ResultantAppState?>("installState"); }
            set { BackingStore?.Set("installState", value); }
        }
        /// <summary>Enum indicating additional details regarding why an application has a particular install state.</summary>
        public ResultantAppStateDetail? InstallStateDetail {
            get { return BackingStore?.Get<ResultantAppStateDetail?>("installStateDetail"); }
            set { BackingStore?.Set("installStateDetail", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The collection of source mobile app&apos;s ids.</summary>
        public List<string> SourceIds {
            get { return BackingStore?.Get<List<string>>("sourceIds"); }
            set { BackingStore?.Set("sourceIds", value); }
        }
        /// <summary>The related target app&apos;s display name.</summary>
        public string TargetDisplayName {
            get { return BackingStore?.Get<string>("targetDisplayName"); }
            set { BackingStore?.Set("targetDisplayName", value); }
        }
        /// <summary>The related target app&apos;s id.</summary>
        public string TargetId {
            get { return BackingStore?.Get<string>("targetId"); }
            set { BackingStore?.Set("targetId", value); }
        }
        /// <summary>The last sync time of the target app.</summary>
        public DateTimeOffset? TargetLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("targetLastSyncDateTime"); }
            set { BackingStore?.Set("targetLastSyncDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new mobileAppRelationshipState and sets the default values.
        /// </summary>
        public MobileAppRelationshipState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MobileAppRelationshipState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppRelationshipState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"installState", n => { InstallState = n.GetEnumValue<ResultantAppState>(); } },
                {"installStateDetail", n => { InstallStateDetail = n.GetEnumValue<ResultantAppStateDetail>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sourceIds", n => { SourceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"targetDisplayName", n => { TargetDisplayName = n.GetStringValue(); } },
                {"targetId", n => { TargetId = n.GetStringValue(); } },
                {"targetLastSyncDateTime", n => { TargetLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteEnumValue<ResultantAppState>("installState", InstallState);
            writer.WriteEnumValue<ResultantAppStateDetail>("installStateDetail", InstallStateDetail);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("sourceIds", SourceIds);
            writer.WriteStringValue("targetDisplayName", TargetDisplayName);
            writer.WriteStringValue("targetId", TargetId);
            writer.WriteDateTimeOffsetValue("targetLastSyncDateTime", TargetLastSyncDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

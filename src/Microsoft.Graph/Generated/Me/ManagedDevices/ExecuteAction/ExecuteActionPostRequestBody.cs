using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.ManagedDevices.ExecuteAction {
    /// <summary>Provides operations to call the executeAction method.</summary>
    public class ExecuteActionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The actionName property</summary>
        public ManagedDeviceRemoteAction? ActionName {
            get { return BackingStore?.Get<ManagedDeviceRemoteAction?>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The carrierUrl property</summary>
        public string CarrierUrl {
            get { return BackingStore?.Get<string>("carrierUrl"); }
            set { BackingStore?.Set("carrierUrl", value); }
        }
        /// <summary>The deprovisionReason property</summary>
        public string DeprovisionReason {
            get { return BackingStore?.Get<string>("deprovisionReason"); }
            set { BackingStore?.Set("deprovisionReason", value); }
        }
        /// <summary>The deviceIds property</summary>
        public List<string> DeviceIds {
            get { return BackingStore?.Get<List<string>>("deviceIds"); }
            set { BackingStore?.Set("deviceIds", value); }
        }
        /// <summary>The deviceName property</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>The keepEnrollmentData property</summary>
        public bool? KeepEnrollmentData {
            get { return BackingStore?.Get<bool?>("keepEnrollmentData"); }
            set { BackingStore?.Set("keepEnrollmentData", value); }
        }
        /// <summary>The keepUserData property</summary>
        public bool? KeepUserData {
            get { return BackingStore?.Get<bool?>("keepUserData"); }
            set { BackingStore?.Set("keepUserData", value); }
        }
        /// <summary>The notificationBody property</summary>
        public string NotificationBody {
            get { return BackingStore?.Get<string>("notificationBody"); }
            set { BackingStore?.Set("notificationBody", value); }
        }
        /// <summary>The notificationTitle property</summary>
        public string NotificationTitle {
            get { return BackingStore?.Get<string>("notificationTitle"); }
            set { BackingStore?.Set("notificationTitle", value); }
        }
        /// <summary>The organizationalUnitPath property</summary>
        public string OrganizationalUnitPath {
            get { return BackingStore?.Get<string>("organizationalUnitPath"); }
            set { BackingStore?.Set("organizationalUnitPath", value); }
        }
        /// <summary>The persistEsimDataPlan property</summary>
        public bool? PersistEsimDataPlan {
            get { return BackingStore?.Get<bool?>("persistEsimDataPlan"); }
            set { BackingStore?.Set("persistEsimDataPlan", value); }
        }
        /// <summary>
        /// Instantiates a new executeActionPostRequestBody and sets the default values.
        /// </summary>
        public ExecuteActionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExecuteActionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExecuteActionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetEnumValue<ManagedDeviceRemoteAction>(); } },
                {"carrierUrl", n => { CarrierUrl = n.GetStringValue(); } },
                {"deprovisionReason", n => { DeprovisionReason = n.GetStringValue(); } },
                {"deviceIds", n => { DeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"keepEnrollmentData", n => { KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", n => { KeepUserData = n.GetBoolValue(); } },
                {"notificationBody", n => { NotificationBody = n.GetStringValue(); } },
                {"notificationTitle", n => { NotificationTitle = n.GetStringValue(); } },
                {"organizationalUnitPath", n => { OrganizationalUnitPath = n.GetStringValue(); } },
                {"persistEsimDataPlan", n => { PersistEsimDataPlan = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ManagedDeviceRemoteAction>("actionName", ActionName);
            writer.WriteStringValue("carrierUrl", CarrierUrl);
            writer.WriteStringValue("deprovisionReason", DeprovisionReason);
            writer.WriteCollectionOfPrimitiveValues<string>("deviceIds", DeviceIds);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteBoolValue("keepEnrollmentData", KeepEnrollmentData);
            writer.WriteBoolValue("keepUserData", KeepUserData);
            writer.WriteStringValue("notificationBody", NotificationBody);
            writer.WriteStringValue("notificationTitle", NotificationTitle);
            writer.WriteStringValue("organizationalUnitPath", OrganizationalUnitPath);
            writer.WriteBoolValue("persistEsimDataPlan", PersistEsimDataPlan);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

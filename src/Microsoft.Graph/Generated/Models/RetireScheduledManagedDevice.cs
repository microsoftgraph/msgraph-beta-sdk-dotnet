using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>ManagedDevices that are scheduled for retire</summary>
    public class RetireScheduledManagedDevice : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The complianceState property</summary>
        public ComplianceStatus? ComplianceState {
            get { return BackingStore?.Get<ComplianceStatus?>("complianceState"); }
            set { BackingStore?.Set("complianceState", value); }
        }
        /// <summary>Device Compliance PolicyId</summary>
        public string DeviceCompliancePolicyId {
            get { return BackingStore?.Get<string>("deviceCompliancePolicyId"); }
            set { BackingStore?.Set("deviceCompliancePolicyId", value); }
        }
        /// <summary>Device Compliance Policy Name</summary>
        public string DeviceCompliancePolicyName {
            get { return BackingStore?.Get<string>("deviceCompliancePolicyName"); }
            set { BackingStore?.Set("deviceCompliancePolicyName", value); }
        }
        /// <summary>Device type.</summary>
        public Microsoft.Graph.Beta.Models.DeviceType? DeviceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceType?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>Key of the entity.</summary>
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>Managed DeviceId</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>Managed Device Name</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
        /// <summary>Management agent type.</summary>
        public ManagementAgentType? ManagementAgent {
            get { return BackingStore?.Get<ManagementAgentType?>("managementAgent"); }
            set { BackingStore?.Set("managementAgent", value); }
        }
        /// <summary>Owner type of device.</summary>
        public ManagedDeviceOwnerType? OwnerType {
            get { return BackingStore?.Get<ManagedDeviceOwnerType?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
        /// <summary>Managed Device Retire After DateTime</summary>
        public DateTimeOffset? RetireAfterDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("retireAfterDateTime"); }
            set { BackingStore?.Set("retireAfterDateTime", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>
        /// Instantiates a new retireScheduledManagedDevice and sets the default values.
        /// </summary>
        public RetireScheduledManagedDevice() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RetireScheduledManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetireScheduledManagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"complianceState", n => { ComplianceState = n.GetEnumValue<ComplianceStatus>(); } },
                {"deviceCompliancePolicyId", n => { DeviceCompliancePolicyId = n.GetStringValue(); } },
                {"deviceCompliancePolicyName", n => { DeviceCompliancePolicyName = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"managementAgent", n => { ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"ownerType", n => { OwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"retireAfterDateTime", n => { RetireAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ComplianceStatus>("complianceState", ComplianceState);
            writer.WriteStringValue("deviceCompliancePolicyId", DeviceCompliancePolicyId);
            writer.WriteStringValue("deviceCompliancePolicyName", DeviceCompliancePolicyName);
            writer.WriteEnumValue<DeviceType>("deviceType", DeviceType);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteEnumValue<ManagementAgentType>("managementAgent", ManagementAgent);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("ownerType", OwnerType);
            writer.WriteDateTimeOffsetValue("retireAfterDateTime", RetireAfterDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Managed Device ComplianceStatus. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? ComplianceState {
            get { return BackingStore?.Get<ComplianceStatus?>(nameof(ComplianceState)); }
            set { BackingStore?.Set(nameof(ComplianceState), value); }
        }
        /// <summary>Device Compliance PolicyId</summary>
        public string DeviceCompliancePolicyId {
            get { return BackingStore?.Get<string>(nameof(DeviceCompliancePolicyId)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicyId), value); }
        }
        /// <summary>Device Compliance Policy Name</summary>
        public string DeviceCompliancePolicyName {
            get { return BackingStore?.Get<string>(nameof(DeviceCompliancePolicyName)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicyName), value); }
        }
        /// <summary>Managed Device Device Type. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, cloudPC, blackberry, palm, unknown.</summary>
        public Microsoft.Graph.Beta.Models.DeviceType? DeviceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceType?>(nameof(DeviceType)); }
            set { BackingStore?.Set(nameof(DeviceType), value); }
        }
        /// <summary>Key of the entity.</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>Managed DeviceId</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>Managed Device Name</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceName), value); }
        }
        /// <summary>Managed Device ManagementAgentType. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, windowsManagementCloudApi.</summary>
        public ManagementAgentType? ManagementAgent {
            get { return BackingStore?.Get<ManagementAgentType?>(nameof(ManagementAgent)); }
            set { BackingStore?.Set(nameof(ManagementAgent), value); }
        }
        /// <summary>Managed Device ManagedDeviceOwnerType. Possible values are: unknown, company, personal.</summary>
        public ManagedDeviceOwnerType? OwnerType {
            get { return BackingStore?.Get<ManagedDeviceOwnerType?>(nameof(OwnerType)); }
            set { BackingStore?.Set(nameof(OwnerType), value); }
        }
        /// <summary>Managed Device Retire After DateTime</summary>
        public DateTimeOffset? RetireAfterDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RetireAfterDateTime)); }
            set { BackingStore?.Set(nameof(RetireAfterDateTime), value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
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

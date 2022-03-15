using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getDevicesScheduledToRetire method.</summary>
    public class RetireScheduledManagedDevice : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Managed Device ComplianceStatus. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? ComplianceState { get; set; }
        /// <summary>Device Compliance PolicyId</summary>
        public string DeviceCompliancePolicyId { get; set; }
        /// <summary>Device Compliance Policy Name</summary>
        public string DeviceCompliancePolicyName { get; set; }
        /// <summary>Managed Device Device Type. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, cloudPC, blackberry, palm, unknown.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceType? DeviceType { get; set; }
        /// <summary>Key of the entity.</summary>
        public string Id { get; set; }
        /// <summary>Managed DeviceId</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Managed Device Name</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>Managed Device ManagementAgentType. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, windowsManagementCloudApi.</summary>
        public ManagementAgentType? ManagementAgent { get; set; }
        /// <summary>Managed Device ManagedDeviceOwnerType. Possible values are: unknown, company, personal.</summary>
        public ManagedDeviceOwnerType? OwnerType { get; set; }
        /// <summary>Managed Device Retire After DateTime</summary>
        public DateTimeOffset? RetireAfterDateTime { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>
        /// Instantiates a new retireScheduledManagedDevice and sets the default values.
        /// </summary>
        public RetireScheduledManagedDevice() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"complianceState", (o,n) => { (o as RetireScheduledManagedDevice).ComplianceState = n.GetEnumValue<ComplianceStatus>(); } },
                {"deviceCompliancePolicyId", (o,n) => { (o as RetireScheduledManagedDevice).DeviceCompliancePolicyId = n.GetStringValue(); } },
                {"deviceCompliancePolicyName", (o,n) => { (o as RetireScheduledManagedDevice).DeviceCompliancePolicyName = n.GetStringValue(); } },
                {"deviceType", (o,n) => { (o as RetireScheduledManagedDevice).DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"id", (o,n) => { (o as RetireScheduledManagedDevice).Id = n.GetStringValue(); } },
                {"managedDeviceId", (o,n) => { (o as RetireScheduledManagedDevice).ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", (o,n) => { (o as RetireScheduledManagedDevice).ManagedDeviceName = n.GetStringValue(); } },
                {"managementAgent", (o,n) => { (o as RetireScheduledManagedDevice).ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"ownerType", (o,n) => { (o as RetireScheduledManagedDevice).OwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"retireAfterDateTime", (o,n) => { (o as RetireScheduledManagedDevice).RetireAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as RetireScheduledManagedDevice).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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

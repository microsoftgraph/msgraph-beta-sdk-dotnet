using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Co-Management eligibility state</summary>
    public class ComanagementEligibleDevice : Entity, IParsable {
        /// <summary>ClientRegistrationStatus. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.</summary>
        public DeviceRegistrationState? ClientRegistrationStatus {
            get { return BackingStore?.Get<DeviceRegistrationState?>(nameof(ClientRegistrationStatus)); }
            set { BackingStore?.Set(nameof(ClientRegistrationStatus), value); }
        }
        /// <summary>DeviceName</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>DeviceType. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.</summary>
        public Microsoft.Graph.Beta.Models.DeviceType? DeviceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceType?>(nameof(DeviceType)); }
            set { BackingStore?.Set(nameof(DeviceType), value); }
        }
        /// <summary>EntitySource</summary>
        public int? EntitySource {
            get { return BackingStore?.Get<int?>(nameof(EntitySource)); }
            set { BackingStore?.Set(nameof(EntitySource), value); }
        }
        /// <summary>ManagementAgents. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, msSense, intuneAosp.</summary>
        public ManagementAgentType? ManagementAgents {
            get { return BackingStore?.Get<ManagementAgentType?>(nameof(ManagementAgents)); }
            set { BackingStore?.Set(nameof(ManagementAgents), value); }
        }
        /// <summary>ManagementState. Possible values are: managed, retirePending, retireFailed, wipePending, wipeFailed, unhealthy, deletePending, retireIssued, wipeIssued, wipeCanceled, retireCanceled, discovered.</summary>
        public Microsoft.Graph.Beta.Models.ManagementState? ManagementState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagementState?>(nameof(ManagementState)); }
            set { BackingStore?.Set(nameof(ManagementState), value); }
        }
        /// <summary>Manufacturer</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>MDMStatus</summary>
        public string MdmStatus {
            get { return BackingStore?.Get<string>(nameof(MdmStatus)); }
            set { BackingStore?.Set(nameof(MdmStatus), value); }
        }
        /// <summary>Model</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>OSDescription</summary>
        public string OsDescription {
            get { return BackingStore?.Get<string>(nameof(OsDescription)); }
            set { BackingStore?.Set(nameof(OsDescription), value); }
        }
        /// <summary>OSVersion</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>OwnerType. Possible values are: unknown, company, personal.</summary>
        public Microsoft.Graph.Beta.Models.OwnerType? OwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OwnerType?>(nameof(OwnerType)); }
            set { BackingStore?.Set(nameof(OwnerType), value); }
        }
        /// <summary>ReferenceId</summary>
        public string ReferenceId {
            get { return BackingStore?.Get<string>(nameof(ReferenceId)); }
            set { BackingStore?.Set(nameof(ReferenceId), value); }
        }
        /// <summary>SerialNumber</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>(nameof(SerialNumber)); }
            set { BackingStore?.Set(nameof(SerialNumber), value); }
        }
        /// <summary>ComanagementEligibleStatus. Possible values are: comanaged, eligible, eligibleButNotAzureAdJoined, needsOsUpdate, ineligible.</summary>
        public ComanagementEligibleType? Status {
            get { return BackingStore?.Get<ComanagementEligibleType?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>UPN</summary>
        public string Upn {
            get { return BackingStore?.Get<string>(nameof(Upn)); }
            set { BackingStore?.Set(nameof(Upn), value); }
        }
        /// <summary>UserEmail</summary>
        public string UserEmail {
            get { return BackingStore?.Get<string>(nameof(UserEmail)); }
            set { BackingStore?.Set(nameof(UserEmail), value); }
        }
        /// <summary>UserId</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>UserName</summary>
        public string UserName {
            get { return BackingStore?.Get<string>(nameof(UserName)); }
            set { BackingStore?.Set(nameof(UserName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ComanagementEligibleDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComanagementEligibleDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clientRegistrationStatus", n => { ClientRegistrationStatus = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"entitySource", n => { EntitySource = n.GetIntValue(); } },
                {"managementAgents", n => { ManagementAgents = n.GetEnumValue<ManagementAgentType>(); } },
                {"managementState", n => { ManagementState = n.GetEnumValue<ManagementState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"mdmStatus", n => { MdmStatus = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetEnumValue<OwnerType>(); } },
                {"referenceId", n => { ReferenceId = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ComanagementEligibleType>(); } },
                {"upn", n => { Upn = n.GetStringValue(); } },
                {"userEmail", n => { UserEmail = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceRegistrationState>("clientRegistrationStatus", ClientRegistrationStatus);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceType>("deviceType", DeviceType);
            writer.WriteIntValue("entitySource", EntitySource);
            writer.WriteEnumValue<ManagementAgentType>("managementAgents", ManagementAgents);
            writer.WriteEnumValue<ManagementState>("managementState", ManagementState);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("mdmStatus", MdmStatus);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteEnumValue<OwnerType>("ownerType", OwnerType);
            writer.WriteStringValue("referenceId", ReferenceId);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteEnumValue<ComanagementEligibleType>("status", Status);
            writer.WriteStringValue("upn", Upn);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
        }
    }
}

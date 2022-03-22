using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ComanagementEligibleDevice : Entity, IParsable {
        /// <summary>ClientRegistrationStatus. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.</summary>
        public DeviceRegistrationState? ClientRegistrationStatus { get; set; }
        /// <summary>DeviceName</summary>
        public string DeviceName { get; set; }
        /// <summary>DeviceType. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceType? DeviceType { get; set; }
        /// <summary>EntitySource</summary>
        public int? EntitySource { get; set; }
        /// <summary>ManagementAgents. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, msSense, intuneAosp.</summary>
        public ManagementAgentType? ManagementAgents { get; set; }
        /// <summary>ManagementState. Possible values are: managed, retirePending, retireFailed, wipePending, wipeFailed, unhealthy, deletePending, retireIssued, wipeIssued, wipeCanceled, retireCanceled, discovered.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ManagementState? ManagementState { get; set; }
        /// <summary>Manufacturer</summary>
        public string Manufacturer { get; set; }
        /// <summary>MDMStatus</summary>
        public string MdmStatus { get; set; }
        /// <summary>Model</summary>
        public string Model { get; set; }
        /// <summary>OSDescription</summary>
        public string OsDescription { get; set; }
        /// <summary>OSVersion</summary>
        public string OsVersion { get; set; }
        /// <summary>OwnerType. Possible values are: unknown, company, personal.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.OwnerType? OwnerType { get; set; }
        /// <summary>ReferenceId</summary>
        public string ReferenceId { get; set; }
        /// <summary>SerialNumber</summary>
        public string SerialNumber { get; set; }
        /// <summary>ComanagementEligibleStatus. Possible values are: comanaged, eligible, eligibleButNotAzureAdJoined, needsOsUpdate, ineligible.</summary>
        public ComanagementEligibleType? Status { get; set; }
        /// <summary>UPN</summary>
        public string Upn { get; set; }
        /// <summary>UserEmail</summary>
        public string UserEmail { get; set; }
        /// <summary>UserId</summary>
        public string UserId { get; set; }
        /// <summary>UserName</summary>
        public string UserName { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"clientRegistrationStatus", (o,n) => { (o as ComanagementEligibleDevice).ClientRegistrationStatus = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"deviceName", (o,n) => { (o as ComanagementEligibleDevice).DeviceName = n.GetStringValue(); } },
                {"deviceType", (o,n) => { (o as ComanagementEligibleDevice).DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"entitySource", (o,n) => { (o as ComanagementEligibleDevice).EntitySource = n.GetIntValue(); } },
                {"managementAgents", (o,n) => { (o as ComanagementEligibleDevice).ManagementAgents = n.GetEnumValue<ManagementAgentType>(); } },
                {"managementState", (o,n) => { (o as ComanagementEligibleDevice).ManagementState = n.GetEnumValue<ManagementState>(); } },
                {"manufacturer", (o,n) => { (o as ComanagementEligibleDevice).Manufacturer = n.GetStringValue(); } },
                {"mdmStatus", (o,n) => { (o as ComanagementEligibleDevice).MdmStatus = n.GetStringValue(); } },
                {"model", (o,n) => { (o as ComanagementEligibleDevice).Model = n.GetStringValue(); } },
                {"osDescription", (o,n) => { (o as ComanagementEligibleDevice).OsDescription = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as ComanagementEligibleDevice).OsVersion = n.GetStringValue(); } },
                {"ownerType", (o,n) => { (o as ComanagementEligibleDevice).OwnerType = n.GetEnumValue<OwnerType>(); } },
                {"referenceId", (o,n) => { (o as ComanagementEligibleDevice).ReferenceId = n.GetStringValue(); } },
                {"serialNumber", (o,n) => { (o as ComanagementEligibleDevice).SerialNumber = n.GetStringValue(); } },
                {"status", (o,n) => { (o as ComanagementEligibleDevice).Status = n.GetEnumValue<ComanagementEligibleType>(); } },
                {"upn", (o,n) => { (o as ComanagementEligibleDevice).Upn = n.GetStringValue(); } },
                {"userEmail", (o,n) => { (o as ComanagementEligibleDevice).UserEmail = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as ComanagementEligibleDevice).UserId = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as ComanagementEligibleDevice).UserName = n.GetStringValue(); } },
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

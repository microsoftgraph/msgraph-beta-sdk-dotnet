using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing the properties used for PolicySet Item.</summary>
    public class PolicySetItem : Entity, IParsable {
        /// <summary>Creation time of the PolicySetItem.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>DisplayName of the PolicySetItem.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Error code if any occured. Possible values are: noError, unauthorized, notFound, deleted.</summary>
        public Microsoft.Graph.Beta.Models.ErrorCode? ErrorCode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ErrorCode?>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>Tags of the guided deployment</summary>
        public List<string> GuidedDeploymentTags {
            get { return BackingStore?.Get<List<string>>(nameof(GuidedDeploymentTags)); }
            set { BackingStore?.Set(nameof(GuidedDeploymentTags), value); }
        }
        /// <summary>policySetType of the PolicySetItem.</summary>
        public string ItemType {
            get { return BackingStore?.Get<string>(nameof(ItemType)); }
            set { BackingStore?.Set(nameof(ItemType), value); }
        }
        /// <summary>Last modified time of the PolicySetItem.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>PayloadId of the PolicySetItem.</summary>
        public string PayloadId {
            get { return BackingStore?.Get<string>(nameof(PayloadId)); }
            set { BackingStore?.Set(nameof(PayloadId), value); }
        }
        /// <summary>Status of the PolicySetItem. Possible values are: unknown, validating, partialSuccess, success, error, notAssigned.</summary>
        public PolicySetStatus? Status {
            get { return BackingStore?.Get<PolicySetStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceCompliancePolicyPolicySetItem" => new DeviceCompliancePolicyPolicySetItem(),
                "#microsoft.graph.deviceConfigurationPolicySetItem" => new DeviceConfigurationPolicySetItem(),
                "#microsoft.graph.deviceManagementConfigurationPolicyPolicySetItem" => new DeviceManagementConfigurationPolicyPolicySetItem(),
                "#microsoft.graph.deviceManagementScriptPolicySetItem" => new DeviceManagementScriptPolicySetItem(),
                "#microsoft.graph.enrollmentRestrictionsConfigurationPolicySetItem" => new EnrollmentRestrictionsConfigurationPolicySetItem(),
                "#microsoft.graph.iosLobAppProvisioningConfigurationPolicySetItem" => new IosLobAppProvisioningConfigurationPolicySetItem(),
                "#microsoft.graph.managedAppProtectionPolicySetItem" => new ManagedAppProtectionPolicySetItem(),
                "#microsoft.graph.managedDeviceMobileAppConfigurationPolicySetItem" => new ManagedDeviceMobileAppConfigurationPolicySetItem(),
                "#microsoft.graph.mdmWindowsInformationProtectionPolicyPolicySetItem" => new MdmWindowsInformationProtectionPolicyPolicySetItem(),
                "#microsoft.graph.mobileAppPolicySetItem" => new MobileAppPolicySetItem(),
                "#microsoft.graph.targetedManagedAppConfigurationPolicySetItem" => new TargetedManagedAppConfigurationPolicySetItem(),
                "#microsoft.graph.windows10EnrollmentCompletionPageConfigurationPolicySetItem" => new Windows10EnrollmentCompletionPageConfigurationPolicySetItem(),
                "#microsoft.graph.windowsAutopilotDeploymentProfilePolicySetItem" => new WindowsAutopilotDeploymentProfilePolicySetItem(),
                _ => new PolicySetItem(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetEnumValue<ErrorCode>(); } },
                {"guidedDeploymentTags", n => { GuidedDeploymentTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"itemType", n => { ItemType = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<PolicySetStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<ErrorCode>("errorCode", ErrorCode);
            writer.WriteCollectionOfPrimitiveValues<string>("guidedDeploymentTags", GuidedDeploymentTags);
            writer.WriteStringValue("itemType", ItemType);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteEnumValue<PolicySetStatus>("status", Status);
        }
    }
}

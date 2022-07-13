using Microsoft.Graph.Beta.Models;
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
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>DisplayName of the PolicySetItem.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The errorCode property</summary>
        public Microsoft.Graph.Beta.Models.ErrorCode? ErrorCode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ErrorCode?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>Tags of the guided deployment</summary>
        public List<string> GuidedDeploymentTags {
            get { return BackingStore?.Get<List<string>>("guidedDeploymentTags"); }
            set { BackingStore?.Set("guidedDeploymentTags", value); }
        }
        /// <summary>policySetType of the PolicySetItem.</summary>
        public string ItemType {
            get { return BackingStore?.Get<string>("itemType"); }
            set { BackingStore?.Set("itemType", value); }
        }
        /// <summary>Last modified time of the PolicySetItem.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>PayloadId of the PolicySetItem.</summary>
        public string PayloadId {
            get { return BackingStore?.Get<string>("payloadId"); }
            set { BackingStore?.Set("payloadId", value); }
        }
        /// <summary>The enum to specify the status of PolicySet.</summary>
        public PolicySetStatus? Status {
            get { return BackingStore?.Get<PolicySetStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new policySetItem and sets the default values.
        /// </summary>
        public PolicySetItem() : base() {
            Type = "#microsoft.graph.policySetItem";
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

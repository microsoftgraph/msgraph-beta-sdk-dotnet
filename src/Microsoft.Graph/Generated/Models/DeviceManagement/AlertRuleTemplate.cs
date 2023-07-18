using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public enum AlertRuleTemplate {
        [EnumMember(Value = "cloudPcProvisionScenario")]
        CloudPcProvisionScenario,
        [EnumMember(Value = "cloudPcImageUploadScenario")]
        CloudPcImageUploadScenario,
        [EnumMember(Value = "cloudPcOnPremiseNetworkConnectionCheckScenario")]
        CloudPcOnPremiseNetworkConnectionCheckScenario,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "cloudPcInGracePeriodScenario")]
        CloudPcInGracePeriodScenario,
    }
}

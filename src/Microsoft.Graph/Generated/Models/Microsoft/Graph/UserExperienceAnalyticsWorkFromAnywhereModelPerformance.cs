using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsWorkFromAnywhereModelPerformance : Entity, IParsable {
        /// <summary>The user experience work from anywhere&apos;s cloud identity score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudIdentityScore { get; set; }
        /// <summary>The user experience work from anywhere&apos;s cloud management score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudManagementScore { get; set; }
        /// <summary>The user experience work from anywhere&apos;s cloud provisioning score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudProvisioningScore { get; set; }
        /// <summary>The health state of the user experience analytics work from anywhere model. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The user experience work from anywhere&apos;s manufacturer name of the devices.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The user experience work from anywhere&apos;s model name of the devices.</summary>
        public string Model { get; set; }
        /// <summary>The user experience work from anywhere&apos;s devices count for the model. Valid values -2147483648 to 2147483647</summary>
        public int? ModelDeviceCount { get; set; }
        /// <summary>The user experience work from anywhere windows score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WindowsScore { get; set; }
        /// <summary>The user experience work from anywhere overall score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsWorkFromAnywhereModelPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereModelPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"cloudIdentityScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).CloudIdentityScore = n.GetDoubleValue(); } },
                {"cloudManagementScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).CloudManagementScore = n.GetDoubleValue(); } },
                {"cloudProvisioningScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).CloudProvisioningScore = n.GetDoubleValue(); } },
                {"healthStatus", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).Model = n.GetStringValue(); } },
                {"modelDeviceCount", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).ModelDeviceCount = n.GetIntValue(); } },
                {"windowsScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).WindowsScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereModelPerformance).WorkFromAnywhereScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("cloudIdentityScore", CloudIdentityScore);
            writer.WriteDoubleValue("cloudManagementScore", CloudManagementScore);
            writer.WriteDoubleValue("cloudProvisioningScore", CloudProvisioningScore);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("modelDeviceCount", ModelDeviceCount);
            writer.WriteDoubleValue("windowsScore", WindowsScore);
            writer.WriteDoubleValue("workFromAnywhereScore", WorkFromAnywhereScore);
        }
    }
}

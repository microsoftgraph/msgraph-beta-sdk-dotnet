using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsBaseline : Entity, IParsable {
        /// <summary>The user experience analytics app health metrics.</summary>
        public UserExperienceAnalyticsCategory AppHealthMetrics { get; set; }
        /// <summary>The user experience analytics battery health metrics.</summary>
        public UserExperienceAnalyticsCategory BatteryHealthMetrics { get; set; }
        /// <summary>The user experience analytics best practices metrics.</summary>
        public UserExperienceAnalyticsCategory BestPracticesMetrics { get; set; }
        /// <summary>The date the custom baseline was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The user experience analytics device boot performance metrics.</summary>
        public UserExperienceAnalyticsCategory DeviceBootPerformanceMetrics { get; set; }
        /// <summary>The name of the user experience analytics baseline.</summary>
        public string DisplayName { get; set; }
        /// <summary>Signifies if the current baseline is the commercial median baseline or a custom baseline.</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>The user experience analytics reboot analytics metrics.</summary>
        public UserExperienceAnalyticsCategory RebootAnalyticsMetrics { get; set; }
        /// <summary>The user experience analytics resource performance metrics.</summary>
        public UserExperienceAnalyticsCategory ResourcePerformanceMetrics { get; set; }
        /// <summary>The user experience analytics work from anywhere metrics.</summary>
        public UserExperienceAnalyticsCategory WorkFromAnywhereMetrics { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBaseline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBaseline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appHealthMetrics", (o,n) => { (o as UserExperienceAnalyticsBaseline).AppHealthMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"batteryHealthMetrics", (o,n) => { (o as UserExperienceAnalyticsBaseline).BatteryHealthMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"bestPracticesMetrics", (o,n) => { (o as UserExperienceAnalyticsBaseline).BestPracticesMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as UserExperienceAnalyticsBaseline).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceBootPerformanceMetrics", (o,n) => { (o as UserExperienceAnalyticsBaseline).DeviceBootPerformanceMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as UserExperienceAnalyticsBaseline).DisplayName = n.GetStringValue(); } },
                {"isBuiltIn", (o,n) => { (o as UserExperienceAnalyticsBaseline).IsBuiltIn = n.GetBoolValue(); } },
                {"rebootAnalyticsMetrics", (o,n) => { (o as UserExperienceAnalyticsBaseline).RebootAnalyticsMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"resourcePerformanceMetrics", (o,n) => { (o as UserExperienceAnalyticsBaseline).ResourcePerformanceMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"workFromAnywhereMetrics", (o,n) => { (o as UserExperienceAnalyticsBaseline).WorkFromAnywhereMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("appHealthMetrics", AppHealthMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("batteryHealthMetrics", BatteryHealthMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("bestPracticesMetrics", BestPracticesMetrics);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("deviceBootPerformanceMetrics", DeviceBootPerformanceMetrics);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("rebootAnalyticsMetrics", RebootAnalyticsMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("resourcePerformanceMetrics", ResourcePerformanceMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("workFromAnywhereMetrics", WorkFromAnywhereMetrics);
        }
    }
}

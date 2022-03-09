using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsInsight : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier of the user experience analytics insight.</summary>
        public string InsightId { get; set; }
        /// <summary>The value of the user experience analytics insight. Possible values are: none, informational, warning, error.</summary>
        public UserExperienceAnalyticsInsightSeverity? Severity { get; set; }
        /// <summary>The unique identifier of the user experience analytics insight.</summary>
        public string UserExperienceAnalyticsMetricId { get; set; }
        /// <summary>The value of the user experience analytics insight.</summary>
        public List<UserExperienceAnalyticsInsightValue> Values { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsInsight and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsInsight() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"insightId", (o,n) => { (o as UserExperienceAnalyticsInsight).InsightId = n.GetStringValue(); } },
                {"severity", (o,n) => { (o as UserExperienceAnalyticsInsight).Severity = n.GetEnumValue<UserExperienceAnalyticsInsightSeverity>(); } },
                {"userExperienceAnalyticsMetricId", (o,n) => { (o as UserExperienceAnalyticsInsight).UserExperienceAnalyticsMetricId = n.GetStringValue(); } },
                {"values", (o,n) => { (o as UserExperienceAnalyticsInsight).Values = n.GetCollectionOfObjectValues<UserExperienceAnalyticsInsightValue>(UserExperienceAnalyticsInsightValue.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("insightId", InsightId);
            writer.WriteEnumValue<UserExperienceAnalyticsInsightSeverity>("severity", Severity);
            writer.WriteStringValue("userExperienceAnalyticsMetricId", UserExperienceAnalyticsMetricId);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsInsightValue>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

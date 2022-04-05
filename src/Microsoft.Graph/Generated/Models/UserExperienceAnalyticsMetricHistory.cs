using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsMetricHistory : Entity, IParsable {
        /// <summary>The user experience analytics device id.</summary>
        public string DeviceId { get; set; }
        /// <summary>The user experience analytics metric date time.</summary>
        public DateTimeOffset? MetricDateTime { get; set; }
        /// <summary>The user experience analytics metric type.</summary>
        public string MetricType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsMetricHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsMetricHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsMetricHistory).DeviceId = n.GetStringValue(); } },
                {"metricDateTime", (o,n) => { (o as UserExperienceAnalyticsMetricHistory).MetricDateTime = n.GetDateTimeOffsetValue(); } },
                {"metricType", (o,n) => { (o as UserExperienceAnalyticsMetricHistory).MetricType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("metricDateTime", MetricDateTime);
            writer.WriteStringValue("metricType", MetricType);
        }
    }
}

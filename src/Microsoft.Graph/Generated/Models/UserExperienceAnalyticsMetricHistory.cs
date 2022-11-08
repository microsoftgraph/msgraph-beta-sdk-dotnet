using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics metric history.</summary>
    public class UserExperienceAnalyticsMetricHistory : Entity, IParsable {
        /// <summary>The user experience analytics device id.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The user experience analytics metric date time.</summary>
        public DateTimeOffset? MetricDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("metricDateTime"); }
            set { BackingStore?.Set("metricDateTime", value); }
        }
        /// <summary>The user experience analytics metric type.</summary>
        public string MetricType {
            get { return BackingStore?.Get<string>("metricType"); }
            set { BackingStore?.Set("metricType", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsMetricHistory and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsMetricHistory() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsMetricHistory";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsMetricHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsMetricHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"metricDateTime", n => { MetricDateTime = n.GetDateTimeOffsetValue(); } },
                {"metricType", n => { MetricType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("metricDateTime", MetricDateTime);
            writer.WriteStringValue("metricType", MetricType);
        }
    }
}

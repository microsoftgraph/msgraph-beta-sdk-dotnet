using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getHealthMetricTimeSeries method.</summary>
    public class TimeSeriesParameter : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>End time of the series being requested. Optional; if not specified, current time is used.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The name of the metric for which a time series is requested.</summary>
        public string MetricName { get; set; }
        /// <summary>Start time of the series being requested.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new timeSeriesParameter and sets the default values.
        /// </summary>
        public TimeSeriesParameter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TimeSeriesParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeSeriesParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDateTime", (o,n) => { (o as TimeSeriesParameter).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"metricName", (o,n) => { (o as TimeSeriesParameter).MetricName = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as TimeSeriesParameter).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("metricName", MetricName);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

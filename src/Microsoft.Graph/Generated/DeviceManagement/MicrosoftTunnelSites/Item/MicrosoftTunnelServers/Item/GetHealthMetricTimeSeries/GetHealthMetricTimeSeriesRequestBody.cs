using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.GetHealthMetricTimeSeries {
    public class GetHealthMetricTimeSeriesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public string MetricName { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new getHealthMetricTimeSeriesRequestBody and sets the default values.
        /// </summary>
        public GetHealthMetricTimeSeriesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDateTime", (o,n) => { (o as GetHealthMetricTimeSeriesRequestBody).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"metricName", (o,n) => { (o as GetHealthMetricTimeSeriesRequestBody).MetricName = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as GetHealthMetricTimeSeriesRequestBody).StartDateTime = n.GetDateTimeOffsetValue(); } },
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

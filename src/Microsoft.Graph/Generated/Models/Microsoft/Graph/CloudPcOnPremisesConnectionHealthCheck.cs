using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CloudPcOnPremisesConnectionHealthCheck : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional details about the health check or the recommended action.</summary>
        public string AdditionalDetails { get; set; }
        /// <summary>The display name for this health check item.</summary>
        public string DisplayName { get; set; }
        /// <summary>The end time of the health check item. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The type of error that occurred during this health check.</summary>
        public CloudPcOnPremisesConnectionHealthCheckErrorType? ErrorType { get; set; }
        /// <summary>The recommended action to fix the corresponding error.</summary>
        public string RecommendedAction { get; set; }
        /// <summary>The start time of the health check item. Read-only.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The status of the health check item. Possible values are: pending, running, passed, failed, unknownFutureValue. Read-only.</summary>
        public CloudPcOnPremisesConnectionStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcOnPremisesConnectionHealthCheck and sets the default values.
        /// </summary>
        public CloudPcOnPremisesConnectionHealthCheck() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"additionalDetails", (o,n) => { (o as CloudPcOnPremisesConnectionHealthCheck).AdditionalDetails = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CloudPcOnPremisesConnectionHealthCheck).DisplayName = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as CloudPcOnPremisesConnectionHealthCheck).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"errorType", (o,n) => { (o as CloudPcOnPremisesConnectionHealthCheck).ErrorType = n.GetEnumValue<CloudPcOnPremisesConnectionHealthCheckErrorType>(); } },
                {"recommendedAction", (o,n) => { (o as CloudPcOnPremisesConnectionHealthCheck).RecommendedAction = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as CloudPcOnPremisesConnectionHealthCheck).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as CloudPcOnPremisesConnectionHealthCheck).Status = n.GetEnumValue<CloudPcOnPremisesConnectionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionHealthCheckErrorType>("errorType", ErrorType);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcOnPremisesConnectionHealthCheck : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcOnPremisesConnectionHealthCheck CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOnPremisesConnectionHealthCheck();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalDetails", n => { AdditionalDetails = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"errorType", n => { ErrorType = n.GetEnumValue<CloudPcOnPremisesConnectionHealthCheckErrorType>(); } },
                {"recommendedAction", n => { RecommendedAction = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcOnPremisesConnectionStatus>(); } },
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

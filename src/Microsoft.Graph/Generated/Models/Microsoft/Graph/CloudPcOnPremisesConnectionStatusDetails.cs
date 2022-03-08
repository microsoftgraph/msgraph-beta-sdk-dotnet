using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class CloudPcOnPremisesConnectionStatusDetails : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The end time of the connection health check. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>All checks that are done on the connection.</summary>
        public List<CloudPcOnPremisesConnectionHealthCheck> HealthChecks { get; set; }
        /// <summary>The start time of the connection health check. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcOnPremisesConnectionStatusDetails and sets the default values.
        /// </summary>
        public CloudPcOnPremisesConnectionStatusDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcOnPremisesConnectionStatusDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOnPremisesConnectionStatusDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDateTime", (o,n) => { (o as CloudPcOnPremisesConnectionStatusDetails).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"healthChecks", (o,n) => { (o as CloudPcOnPremisesConnectionStatusDetails).HealthChecks = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnectionHealthCheck>(CloudPcOnPremisesConnectionHealthCheck.CreateFromDiscriminatorValue).ToList(); } },
                {"startDateTime", (o,n) => { (o as CloudPcOnPremisesConnectionStatusDetails).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<CloudPcOnPremisesConnectionHealthCheck>("healthChecks", HealthChecks);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

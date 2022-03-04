using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CloudPcRemoteActionResult : IParsable {
        /// <summary>The specified action. Supported values in the Microsoft Endpoint Manager portal are: Reprovision, Resize, Restore. Supported values in enterprise Cloud PC devices are: Reboot, Rename, Reprovision, Troubleshoot.</summary>
        public string ActionName { get; set; }
        /// <summary>State of the action. Possible values are: None, pending, canceled, active, done, failed, notSupported. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ActionState? ActionState { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the Cloud PC device on which the remote action is performed. Read-only.</summary>
        public string CloudPcId { get; set; }
        /// <summary>Last update time for action. The Timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as '2014-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The ID of the Intune managed device on which the remote action is performed. Read-only.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Time the action was initiated. The Timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as '2014-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The details of the Cloud PC status.</summary>
        public CloudPcStatusDetails StatusDetails { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcRemoteActionResult and sets the default values.
        /// </summary>
        public CloudPcRemoteActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcRemoteActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcRemoteActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionName", (o,n) => { (o as CloudPcRemoteActionResult).ActionName = n.GetStringValue(); } },
                {"actionState", (o,n) => { (o as CloudPcRemoteActionResult).ActionState = n.GetEnumValue<ActionState>(); } },
                {"cloudPcId", (o,n) => { (o as CloudPcRemoteActionResult).CloudPcId = n.GetStringValue(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as CloudPcRemoteActionResult).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", (o,n) => { (o as CloudPcRemoteActionResult).ManagedDeviceId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as CloudPcRemoteActionResult).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"statusDetails", (o,n) => { (o as CloudPcRemoteActionResult).StatusDetails = n.GetObjectValue<CloudPcStatusDetails>(CloudPcStatusDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteStringValue("cloudPcId", CloudPcId);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteObjectValue<CloudPcStatusDetails>("statusDetails", StatusDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

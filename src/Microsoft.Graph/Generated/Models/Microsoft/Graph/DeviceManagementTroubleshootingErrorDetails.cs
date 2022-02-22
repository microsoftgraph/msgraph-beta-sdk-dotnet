using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementTroubleshootingErrorDetails : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Not yet documented</summary>
        public string Context { get; set; }
        /// <summary>Not yet documented</summary>
        public string Failure { get; set; }
        /// <summary>The detailed description of what went wrong.</summary>
        public string FailureDetails { get; set; }
        /// <summary>The detailed description of how to remediate this issue.</summary>
        public string Remediation { get; set; }
        /// <summary>Links to helpful documentation about this failure.</summary>
        public List<DeviceManagementTroubleshootingErrorResource> Resources { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementTroubleshootingErrorDetails and sets the default values.
        /// </summary>
        public DeviceManagementTroubleshootingErrorDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"context", (o,n) => { (o as DeviceManagementTroubleshootingErrorDetails).Context = n.GetStringValue(); } },
                {"failure", (o,n) => { (o as DeviceManagementTroubleshootingErrorDetails).Failure = n.GetStringValue(); } },
                {"failureDetails", (o,n) => { (o as DeviceManagementTroubleshootingErrorDetails).FailureDetails = n.GetStringValue(); } },
                {"remediation", (o,n) => { (o as DeviceManagementTroubleshootingErrorDetails).Remediation = n.GetStringValue(); } },
                {"resources", (o,n) => { (o as DeviceManagementTroubleshootingErrorDetails).Resources = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingErrorResource>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("context", Context);
            writer.WriteStringValue("failure", Failure);
            writer.WriteStringValue("failureDetails", FailureDetails);
            writer.WriteStringValue("remediation", Remediation);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingErrorResource>("resources", Resources);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

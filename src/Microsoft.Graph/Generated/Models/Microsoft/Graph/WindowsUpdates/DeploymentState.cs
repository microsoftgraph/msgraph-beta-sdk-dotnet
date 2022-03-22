using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    public class DeploymentState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the reasons the deployment has its state value. Read-only.</summary>
        public List<DeploymentStateReason> Reasons { get; set; }
        /// <summary>Specifies the requested state of the deployment. Supports a subset of the values for requestedDeploymentStateValue. Possible values are: none, paused, unknownFutureValue.</summary>
        public RequestedDeploymentStateValue? RequestedValue { get; set; }
        /// <summary>Specifies the state of the deployment. Supports a subset of the values for deploymentStateValue. Possible values are: scheduled, offering, paused, unknownFutureValue. Read-only.</summary>
        public DeploymentStateValue? Value { get; set; }
        /// <summary>
        /// Instantiates a new deploymentState and sets the default values.
        /// </summary>
        public DeploymentState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeploymentState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"reasons", (o,n) => { (o as DeploymentState).Reasons = n.GetCollectionOfObjectValues<DeploymentStateReason>(DeploymentStateReason.CreateFromDiscriminatorValue).ToList(); } },
                {"requestedValue", (o,n) => { (o as DeploymentState).RequestedValue = n.GetEnumValue<RequestedDeploymentStateValue>(); } },
                {"value", (o,n) => { (o as DeploymentState).Value = n.GetEnumValue<DeploymentStateValue>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeploymentStateReason>("reasons", Reasons);
            writer.WriteEnumValue<RequestedDeploymentStateValue>("requestedValue", RequestedValue);
            writer.WriteEnumValue<DeploymentStateValue>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

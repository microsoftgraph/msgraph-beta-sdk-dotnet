using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class DeploymentState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Specifies the reasons the deployment has its state value. Read-only.</summary>
        public List<DeploymentStateReason> Reasons {
            get { return BackingStore?.Get<List<DeploymentStateReason>>("reasons"); }
            set { BackingStore?.Set("reasons", value); }
        }
        /// <summary>The requestedValue property</summary>
        public RequestedDeploymentStateValue? RequestedValue {
            get { return BackingStore?.Get<RequestedDeploymentStateValue?>("requestedValue"); }
            set { BackingStore?.Set("requestedValue", value); }
        }
        /// <summary>The value property</summary>
        public DeploymentStateValue? Value {
            get { return BackingStore?.Get<DeploymentStateValue?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new deploymentState and sets the default values.
        /// </summary>
        public DeploymentState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.windowsUpdates.deploymentState";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeploymentState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reasons", n => { Reasons = n.GetCollectionOfObjectValues<DeploymentStateReason>(DeploymentStateReason.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requestedValue", n => { RequestedValue = n.GetEnumValue<RequestedDeploymentStateValue>(); } },
                {"value", n => { Value = n.GetEnumValue<DeploymentStateValue>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<DeploymentStateReason>("reasons", Reasons);
            writer.WriteEnumValue<RequestedDeploymentStateValue>("requestedValue", RequestedValue);
            writer.WriteEnumValue<DeploymentStateValue>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

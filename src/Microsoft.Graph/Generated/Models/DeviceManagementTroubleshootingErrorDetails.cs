using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Object containing detailed information about the error and its remediation.</summary>
    public class DeviceManagementTroubleshootingErrorDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Not yet documented</summary>
        public string Context {
            get { return BackingStore?.Get<string>(nameof(Context)); }
            set { BackingStore?.Set(nameof(Context), value); }
        }
        /// <summary>Not yet documented</summary>
        public string Failure {
            get { return BackingStore?.Get<string>(nameof(Failure)); }
            set { BackingStore?.Set(nameof(Failure), value); }
        }
        /// <summary>The detailed description of what went wrong.</summary>
        public string FailureDetails {
            get { return BackingStore?.Get<string>(nameof(FailureDetails)); }
            set { BackingStore?.Set(nameof(FailureDetails), value); }
        }
        /// <summary>The detailed description of how to remediate this issue.</summary>
        public string Remediation {
            get { return BackingStore?.Get<string>(nameof(Remediation)); }
            set { BackingStore?.Set(nameof(Remediation), value); }
        }
        /// <summary>Links to helpful documentation about this failure.</summary>
        public List<DeviceManagementTroubleshootingErrorResource> Resources {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingErrorResource>>(nameof(Resources)); }
            set { BackingStore?.Set(nameof(Resources), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementTroubleshootingErrorDetails and sets the default values.
        /// </summary>
        public DeviceManagementTroubleshootingErrorDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementTroubleshootingErrorDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementTroubleshootingErrorDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"context", n => { Context = n.GetStringValue(); } },
                {"failure", n => { Failure = n.GetStringValue(); } },
                {"failureDetails", n => { FailureDetails = n.GetStringValue(); } },
                {"remediation", n => { Remediation = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingErrorResource>(DeviceManagementTroubleshootingErrorResource.CreateFromDiscriminatorValue).ToList(); } },
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

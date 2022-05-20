using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents policy deployment summary per app.</summary>
    public class ManagedAppPolicyDeploymentSummaryPerApp : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of users the policy is applied.</summary>
        public int? ConfigurationAppliedUserCount {
            get { return BackingStore?.Get<int?>(nameof(ConfigurationAppliedUserCount)); }
            set { BackingStore?.Set(nameof(ConfigurationAppliedUserCount), value); }
        }
        /// <summary>Deployment of an app.</summary>
        public Microsoft.Graph.Beta.Models.MobileAppIdentifier MobileAppIdentifier {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MobileAppIdentifier>(nameof(MobileAppIdentifier)); }
            set { BackingStore?.Set(nameof(MobileAppIdentifier), value); }
        }
        /// <summary>
        /// Instantiates a new managedAppPolicyDeploymentSummaryPerApp and sets the default values.
        /// </summary>
        public ManagedAppPolicyDeploymentSummaryPerApp() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagedAppPolicyDeploymentSummaryPerApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppPolicyDeploymentSummaryPerApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"configurationAppliedUserCount", n => { ConfigurationAppliedUserCount = n.GetIntValue(); } },
                {"mobileAppIdentifier", n => { MobileAppIdentifier = n.GetObjectValue<Microsoft.Graph.Beta.Models.MobileAppIdentifier>(Microsoft.Graph.Beta.Models.MobileAppIdentifier.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("configurationAppliedUserCount", ConfigurationAppliedUserCount);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MobileAppIdentifier>("mobileAppIdentifier", MobileAppIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

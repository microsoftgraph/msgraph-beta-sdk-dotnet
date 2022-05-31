using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.RegisteredOwners.Item.User.WipeManagedAppRegistrationsByAzureAdDeviceId {
    /// <summary>Provides operations to call the wipeManagedAppRegistrationsByAzureAdDeviceId method.</summary>
    public class WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The azureAdDeviceId property</summary>
        public string AzureAdDeviceId {
            get { return BackingStore?.Get<string>(nameof(AzureAdDeviceId)); }
            set { BackingStore?.Set(nameof(AzureAdDeviceId), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new wipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody and sets the default values.
        /// </summary>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents an Apple Single Sign-On Extension.</summary>
    public class SingleSignOnExtension : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>
        /// Instantiates a new singleSignOnExtension and sets the default values.
        /// </summary>
        public SingleSignOnExtension() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.singleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.credentialSingleSignOnExtension" => new CredentialSingleSignOnExtension(),
                "#microsoft.graph.iosAzureAdSingleSignOnExtension" => new IosAzureAdSingleSignOnExtension(),
                "#microsoft.graph.iosCredentialSingleSignOnExtension" => new IosCredentialSingleSignOnExtension(),
                "#microsoft.graph.iosKerberosSingleSignOnExtension" => new IosKerberosSingleSignOnExtension(),
                "#microsoft.graph.iosRedirectSingleSignOnExtension" => new IosRedirectSingleSignOnExtension(),
                "#microsoft.graph.iosSingleSignOnExtension" => new IosSingleSignOnExtension(),
                "#microsoft.graph.kerberosSingleSignOnExtension" => new KerberosSingleSignOnExtension(),
                "#microsoft.graph.macOSAzureAdSingleSignOnExtension" => new MacOSAzureAdSingleSignOnExtension(),
                "#microsoft.graph.macOSCredentialSingleSignOnExtension" => new MacOSCredentialSingleSignOnExtension(),
                "#microsoft.graph.macOSKerberosSingleSignOnExtension" => new MacOSKerberosSingleSignOnExtension(),
                "#microsoft.graph.macOSRedirectSingleSignOnExtension" => new MacOSRedirectSingleSignOnExtension(),
                "#microsoft.graph.macOSSingleSignOnExtension" => new MacOSSingleSignOnExtension(),
                "#microsoft.graph.redirectSingleSignOnExtension" => new RedirectSingleSignOnExtension(),
                _ => new SingleSignOnExtension(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

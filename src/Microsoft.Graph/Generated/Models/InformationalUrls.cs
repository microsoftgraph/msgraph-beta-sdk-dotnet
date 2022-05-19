using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InformationalUrls : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The appSignUpUrl property</summary>
        public string AppSignUpUrl {
            get { return BackingStore?.Get<string>(nameof(AppSignUpUrl)); }
            set { BackingStore?.Set(nameof(AppSignUpUrl), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The singleSignOnDocumentationUrl property</summary>
        public string SingleSignOnDocumentationUrl {
            get { return BackingStore?.Get<string>(nameof(SingleSignOnDocumentationUrl)); }
            set { BackingStore?.Set(nameof(SingleSignOnDocumentationUrl), value); }
        }
        /// <summary>
        /// Instantiates a new informationalUrls and sets the default values.
        /// </summary>
        public InformationalUrls() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static InformationalUrls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationalUrls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appSignUpUrl", n => { AppSignUpUrl = n.GetStringValue(); } },
                {"singleSignOnDocumentationUrl", n => { SingleSignOnDocumentationUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appSignUpUrl", AppSignUpUrl);
            writer.WriteStringValue("singleSignOnDocumentationUrl", SingleSignOnDocumentationUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

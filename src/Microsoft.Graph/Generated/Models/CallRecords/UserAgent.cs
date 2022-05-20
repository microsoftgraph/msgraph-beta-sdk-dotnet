using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class UserAgent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Identifies the version of application software used by this endpoint.</summary>
        public string ApplicationVersion {
            get { return BackingStore?.Get<string>(nameof(ApplicationVersion)); }
            set { BackingStore?.Set(nameof(ApplicationVersion), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>User-agent header value reported by this endpoint.</summary>
        public string HeaderValue {
            get { return BackingStore?.Get<string>(nameof(HeaderValue)); }
            set { BackingStore?.Set(nameof(HeaderValue), value); }
        }
        /// <summary>
        /// Instantiates a new userAgent and sets the default values.
        /// </summary>
        public UserAgent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationVersion", n => { ApplicationVersion = n.GetStringValue(); } },
                {"headerValue", n => { HeaderValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationVersion", ApplicationVersion);
            writer.WriteStringValue("headerValue", HeaderValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

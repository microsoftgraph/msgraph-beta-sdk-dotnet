using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using Microsoft.Kiota.Abstractions.Store;

namespace Microsoft.Graph.Beta.Models {
    public class ChangeNotificationCollection : ITokenValidable<ChangeNotification, ChangeNotificationEncryptedContent>,IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        
        /// <summary>
        /// Instantiates a new ChangeNotificationCollection and sets the default values.
        /// </summary>
        public ChangeNotificationCollection() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChangeNotification>? Value {
            get { return BackingStore?.Get<List<ChangeNotification>?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public List<ChangeNotification> Value {
            get { return BackingStore?.Get<List<ChangeNotification>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChangeNotificationCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChangeNotificationCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>() {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"validationTokens", n => { ValidationTokens = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"value", n => { Value = n.GetCollectionOfObjectValues<ChangeNotification>(ChangeNotification.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The stopTones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ValidationTokens {
            get { return BackingStore?.Get<List<string>?>("validationTokens"); }
            set { BackingStore?.Set("validationTokens", value); }
        }
#nullable restore
#else
        public List<string> ValidationTokens {
            get { return BackingStore?.Get<List<string>>("validationTokens"); }
            set { BackingStore?.Set("validationTokens", value); }
        }
#endif
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<ChangeNotification>("value", Value);
            writer.WriteCollectionOfPrimitiveValues<string>("value", ValidationTokens);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

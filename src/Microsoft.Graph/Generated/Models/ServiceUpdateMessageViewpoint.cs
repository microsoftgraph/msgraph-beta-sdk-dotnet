using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ServiceUpdateMessageViewpoint : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether the user archived the message.</summary>
        public bool? IsArchived {
            get { return BackingStore?.Get<bool?>(nameof(IsArchived)); }
            set { BackingStore?.Set(nameof(IsArchived), value); }
        }
        /// <summary>Indicates whether the user marked the message as favorite.</summary>
        public bool? IsFavorited {
            get { return BackingStore?.Get<bool?>(nameof(IsFavorited)); }
            set { BackingStore?.Set(nameof(IsFavorited), value); }
        }
        /// <summary>Indicates whether the user read the message.</summary>
        public bool? IsRead {
            get { return BackingStore?.Get<bool?>(nameof(IsRead)); }
            set { BackingStore?.Set(nameof(IsRead), value); }
        }
        /// <summary>
        /// Instantiates a new serviceUpdateMessageViewpoint and sets the default values.
        /// </summary>
        public ServiceUpdateMessageViewpoint() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ServiceUpdateMessageViewpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceUpdateMessageViewpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isFavorited", n => { IsFavorited = n.GetBoolValue(); } },
                {"isRead", n => { IsRead = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isFavorited", IsFavorited);
            writer.WriteBoolValue("isRead", IsRead);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

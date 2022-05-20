using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IdentitySet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The Identity of the Application. This property is read-only.</summary>
        public Identity Application {
            get { return BackingStore?.Get<Identity>(nameof(Application)); }
            set { BackingStore?.Set(nameof(Application), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Identity of the Device. This property is read-only.</summary>
        public Identity Device {
            get { return BackingStore?.Get<Identity>(nameof(Device)); }
            set { BackingStore?.Set(nameof(Device), value); }
        }
        /// <summary>The Identity of the User. This property is read-only.</summary>
        public Identity User {
            get { return BackingStore?.Get<Identity>(nameof(User)); }
            set { BackingStore?.Set(nameof(User), value); }
        }
        /// <summary>
        /// Instantiates a new identitySet and sets the default values.
        /// </summary>
        public IdentitySet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"application", n => { Application = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"device", n => { Device = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"user", n => { User = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Identity>("application", Application);
            writer.WriteObjectValue<Identity>("device", Device);
            writer.WriteObjectValue<Identity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

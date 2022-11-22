using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationLinkedObjects : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The manager property</summary>
        public SynchronizationJobSubject Manager {
            get { return BackingStore?.Get<SynchronizationJobSubject>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
        /// <summary>All group members that you would like to provision.</summary>
        public List<SynchronizationJobSubject> Members {
            get { return BackingStore?.Get<List<SynchronizationJobSubject>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The owners property</summary>
        public List<SynchronizationJobSubject> Owners {
            get { return BackingStore?.Get<List<SynchronizationJobSubject>>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationLinkedObjects and sets the default values.
        /// </summary>
        public SynchronizationLinkedObjects() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationLinkedObjects CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationLinkedObjects();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"manager", n => { Manager = n.GetObjectValue<SynchronizationJobSubject>(SynchronizationJobSubject.CreateFromDiscriminatorValue); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<SynchronizationJobSubject>(SynchronizationJobSubject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<SynchronizationJobSubject>(SynchronizationJobSubject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SynchronizationJobSubject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<SynchronizationJobSubject>("members", Members);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<SynchronizationJobSubject>("owners", Owners);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

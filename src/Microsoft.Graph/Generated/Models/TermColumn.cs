using Microsoft.Graph.Beta.Models.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TermColumn : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Specifies whether the column will allow more than one value</summary>
        public bool? AllowMultipleValues {
            get { return BackingStore?.Get<bool?>(nameof(AllowMultipleValues)); }
            set { BackingStore?.Set(nameof(AllowMultipleValues), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The parentTerm property</summary>
        public Term ParentTerm {
            get { return BackingStore?.Get<Term>(nameof(ParentTerm)); }
            set { BackingStore?.Set(nameof(ParentTerm), value); }
        }
        /// <summary>Specifies whether to display the entire term path or only the term label.</summary>
        public bool? ShowFullyQualifiedName {
            get { return BackingStore?.Get<bool?>(nameof(ShowFullyQualifiedName)); }
            set { BackingStore?.Set(nameof(ShowFullyQualifiedName), value); }
        }
        /// <summary>The termSet property</summary>
        public Microsoft.Graph.Beta.Models.TermStore.Set TermSet {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TermStore.Set>(nameof(TermSet)); }
            set { BackingStore?.Set(nameof(TermSet), value); }
        }
        /// <summary>
        /// Instantiates a new termColumn and sets the default values.
        /// </summary>
        public TermColumn() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TermColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowMultipleValues", n => { AllowMultipleValues = n.GetBoolValue(); } },
                {"parentTerm", n => { ParentTerm = n.GetObjectValue<Term>(Term.CreateFromDiscriminatorValue); } },
                {"showFullyQualifiedName", n => { ShowFullyQualifiedName = n.GetBoolValue(); } },
                {"termSet", n => { TermSet = n.GetObjectValue<Microsoft.Graph.Beta.Models.TermStore.Set>(Microsoft.Graph.Beta.Models.TermStore.Set.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleValues", AllowMultipleValues);
            writer.WriteObjectValue<Term>("parentTerm", ParentTerm);
            writer.WriteBoolValue("showFullyQualifiedName", ShowFullyQualifiedName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TermStore.Set>("termSet", TermSet);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class TenantAllowOrBlockListAction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The action property</summary>
        public TenantAllowBlockListAction? Action {
            get { return BackingStore?.Get<TenantAllowBlockListAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The note property</summary>
        public string Note {
            get { return BackingStore?.Get<string>("note"); }
            set { BackingStore?.Set("note", value); }
        }
        /// <summary>The results property</summary>
        public List<TenantAllowBlockListEntryResult> Results {
            get { return BackingStore?.Get<List<TenantAllowBlockListEntryResult>>("results"); }
            set { BackingStore?.Set("results", value); }
        }
        /// <summary>
        /// Instantiates a new tenantAllowOrBlockListAction and sets the default values.
        /// </summary>
        public TenantAllowOrBlockListAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TenantAllowOrBlockListAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantAllowOrBlockListAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<TenantAllowBlockListAction>(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"note", n => { Note = n.GetStringValue(); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<TenantAllowBlockListEntryResult>(TenantAllowBlockListEntryResult.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TenantAllowBlockListAction>("action", Action);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("note", Note);
            writer.WriteCollectionOfObjectValues<TenantAllowBlockListEntryResult>("results", Results);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

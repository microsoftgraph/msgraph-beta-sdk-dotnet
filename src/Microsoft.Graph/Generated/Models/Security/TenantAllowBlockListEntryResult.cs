using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class TenantAllowBlockListEntryResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The entryType property</summary>
        public TenantAllowBlockListEntryType? EntryType {
            get { return BackingStore?.Get<TenantAllowBlockListEntryType?>("entryType"); }
            set { BackingStore?.Set("entryType", value); }
        }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The identity property</summary>
        public string Identity {
            get { return BackingStore?.Get<string>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
        /// <summary>The status property</summary>
        public LongRunningOperationStatus? Status {
            get { return BackingStore?.Get<LongRunningOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The value property</summary>
        public string Value {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new tenantAllowBlockListEntryResult and sets the default values.
        /// </summary>
        public TenantAllowBlockListEntryResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TenantAllowBlockListEntryResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantAllowBlockListEntryResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"entryType", n => { EntryType = n.GetEnumValue<TenantAllowBlockListEntryType>(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"identity", n => { Identity = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<LongRunningOperationStatus>(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TenantAllowBlockListEntryType>("entryType", EntryType);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("identity", Identity);
            writer.WriteEnumValue<LongRunningOperationStatus>("status", Status);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

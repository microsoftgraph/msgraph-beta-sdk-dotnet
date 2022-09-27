using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SharingDetail : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>The user who shared the document.</summary>
        public InsightIdentity SharedBy {
            get { return BackingStore?.Get<InsightIdentity>("sharedBy"); }
            set { BackingStore?.Set("sharedBy", value); }
        }
        /// <summary>The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? SharedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("sharedDateTime"); }
            set { BackingStore?.Set("sharedDateTime", value); }
        }
        /// <summary>The sharingReference property</summary>
        public ResourceReference SharingReference {
            get { return BackingStore?.Get<ResourceReference>("sharingReference"); }
            set { BackingStore?.Set("sharingReference", value); }
        }
        /// <summary>The subject with which the document was shared.</summary>
        public string SharingSubject {
            get { return BackingStore?.Get<string>("sharingSubject"); }
            set { BackingStore?.Set("sharingSubject", value); }
        }
        /// <summary>Determines the way the document was shared, can be by a &apos;Link&apos;, &apos;Attachment&apos;, &apos;Group&apos;, &apos;Site&apos;.</summary>
        public string SharingType {
            get { return BackingStore?.Get<string>("sharingType"); }
            set { BackingStore?.Set("sharingType", value); }
        }
        /// <summary>
        /// Instantiates a new sharingDetail and sets the default values.
        /// </summary>
        public SharingDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.sharingDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SharingDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharingDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sharedBy", n => { SharedBy = n.GetObjectValue<InsightIdentity>(InsightIdentity.CreateFromDiscriminatorValue); } },
                {"sharedDateTime", n => { SharedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sharingReference", n => { SharingReference = n.GetObjectValue<ResourceReference>(ResourceReference.CreateFromDiscriminatorValue); } },
                {"sharingSubject", n => { SharingSubject = n.GetStringValue(); } },
                {"sharingType", n => { SharingType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<InsightIdentity>("sharedBy", SharedBy);
            writer.WriteDateTimeOffsetValue("sharedDateTime", SharedDateTime);
            writer.WriteStringValue("sharingSubject", SharingSubject);
            writer.WriteStringValue("sharingType", SharingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ClassificationInnerError : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The activityId property</summary>
        public string ActivityId {
            get { return BackingStore?.Get<string>("activityId"); }
            set { BackingStore?.Set("activityId", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The clientRequestId property</summary>
        public string ClientRequestId {
            get { return BackingStore?.Get<string>("clientRequestId"); }
            set { BackingStore?.Set("clientRequestId", value); }
        }
        /// <summary>The code property</summary>
        public string Code {
            get { return BackingStore?.Get<string>("code"); }
            set { BackingStore?.Set("code", value); }
        }
        /// <summary>The errorDateTime property</summary>
        public DateTimeOffset? ErrorDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("errorDateTime"); }
            set { BackingStore?.Set("errorDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new classificationInnerError and sets the default values.
        /// </summary>
        public ClassificationInnerError() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClassificationInnerError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassificationInnerError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityId", n => { ActivityId = n.GetStringValue(); } },
                {"clientRequestId", n => { ClientRequestId = n.GetStringValue(); } },
                {"code", n => { Code = n.GetStringValue(); } },
                {"errorDateTime", n => { ErrorDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityId", ActivityId);
            writer.WriteStringValue("clientRequestId", ClientRequestId);
            writer.WriteStringValue("code", Code);
            writer.WriteDateTimeOffsetValue("errorDateTime", ErrorDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

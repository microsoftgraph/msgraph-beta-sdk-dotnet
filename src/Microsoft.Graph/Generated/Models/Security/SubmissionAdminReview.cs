using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class SubmissionAdminReview : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The reviewBy property</summary>
        public string ReviewBy {
            get { return BackingStore?.Get<string>("reviewBy"); }
            set { BackingStore?.Set("reviewBy", value); }
        }
        /// <summary>The reviewDateTime property</summary>
        public DateTimeOffset? ReviewDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewDateTime"); }
            set { BackingStore?.Set("reviewDateTime", value); }
        }
        /// <summary>The reviewResult property</summary>
        public SubmissionResultCategory? ReviewResult {
            get { return BackingStore?.Get<SubmissionResultCategory?>("reviewResult"); }
            set { BackingStore?.Set("reviewResult", value); }
        }
        /// <summary>
        /// Instantiates a new submissionAdminReview and sets the default values.
        /// </summary>
        public SubmissionAdminReview() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SubmissionAdminReview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubmissionAdminReview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"reviewBy", n => { ReviewBy = n.GetStringValue(); } },
                {"reviewDateTime", n => { ReviewDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewResult", n => { ReviewResult = n.GetEnumValue<SubmissionResultCategory>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("reviewBy", ReviewBy);
            writer.WriteDateTimeOffsetValue("reviewDateTime", ReviewDateTime);
            writer.WriteEnumValue<SubmissionResultCategory>("reviewResult", ReviewResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

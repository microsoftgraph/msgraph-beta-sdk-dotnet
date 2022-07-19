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
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Specifies who reviewed the email. The identification is an email ID or other identity strings.</summary>
        public string ReviewBy {
            get { return BackingStore?.Get<string>("reviewBy"); }
            set { BackingStore?.Set("reviewBy", value); }
        }
        /// <summary>Specifies the date time when the review occurred.</summary>
        public DateTimeOffset? ReviewDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewDateTime"); }
            set { BackingStore?.Set("reviewDateTime", value); }
        }
        /// <summary>Specifies what the review result was. The possible values are: notJunk, spam, phishing, malware, allowedByPolicy, blockedByPolicy, spoof, unknown, noResultAvailable, and unknownFutureValue.</summary>
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
            OdataType = "#microsoft.graph.security.submissionAdminReview";
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("reviewBy", ReviewBy);
            writer.WriteDateTimeOffsetValue("reviewDateTime", ReviewDateTime);
            writer.WriteEnumValue<SubmissionResultCategory>("reviewResult", ReviewResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

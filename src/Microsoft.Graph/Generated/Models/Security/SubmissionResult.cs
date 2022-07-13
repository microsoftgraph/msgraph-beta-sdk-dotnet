using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class SubmissionResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The category property</summary>
        public SubmissionResultCategory? Category {
            get { return BackingStore?.Get<SubmissionResultCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The detail property</summary>
        public SubmissionResultDetail? Detail {
            get { return BackingStore?.Get<SubmissionResultDetail?>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
        /// <summary>The detectedFiles property</summary>
        public List<SubmissionDetectedFile> DetectedFiles {
            get { return BackingStore?.Get<List<SubmissionDetectedFile>>("detectedFiles"); }
            set { BackingStore?.Set("detectedFiles", value); }
        }
        /// <summary>The detectedUrls property</summary>
        public List<string> DetectedUrls {
            get { return BackingStore?.Get<List<string>>("detectedUrls"); }
            set { BackingStore?.Set("detectedUrls", value); }
        }
        /// <summary>The userMailboxSetting property</summary>
        public Microsoft.Graph.Beta.Models.Security.UserMailboxSetting? UserMailboxSetting {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.UserMailboxSetting?>("userMailboxSetting"); }
            set { BackingStore?.Set("userMailboxSetting", value); }
        }
        /// <summary>
        /// Instantiates a new submissionResult and sets the default values.
        /// </summary>
        public SubmissionResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SubmissionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubmissionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"category", n => { Category = n.GetEnumValue<SubmissionResultCategory>(); } },
                {"detail", n => { Detail = n.GetEnumValue<SubmissionResultDetail>(); } },
                {"detectedFiles", n => { DetectedFiles = n.GetCollectionOfObjectValues<SubmissionDetectedFile>(SubmissionDetectedFile.CreateFromDiscriminatorValue).ToList(); } },
                {"detectedUrls", n => { DetectedUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userMailboxSetting", n => { UserMailboxSetting = n.GetEnumValue<UserMailboxSetting>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SubmissionResultCategory>("category", Category);
            writer.WriteEnumValue<SubmissionResultDetail>("detail", Detail);
            writer.WriteCollectionOfObjectValues<SubmissionDetectedFile>("detectedFiles", DetectedFiles);
            writer.WriteCollectionOfPrimitiveValues<string>("detectedUrls", DetectedUrls);
            writer.WriteEnumValue<UserMailboxSetting>("userMailboxSetting", UserMailboxSetting);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.UpdateAudienceById {
    /// <summary>Provides operations to call the updateAudienceById method.</summary>
    public class UpdateAudienceByIdPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The addExclusions property</summary>
        public List<string> AddExclusions {
            get { return BackingStore?.Get<List<string>>("addExclusions"); }
            set { BackingStore?.Set("addExclusions", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The addMembers property</summary>
        public List<string> AddMembers {
            get { return BackingStore?.Get<List<string>>("addMembers"); }
            set { BackingStore?.Set("addMembers", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The memberEntityType property</summary>
        public string MemberEntityType {
            get { return BackingStore?.Get<string>("memberEntityType"); }
            set { BackingStore?.Set("memberEntityType", value); }
        }
        /// <summary>The removeExclusions property</summary>
        public List<string> RemoveExclusions {
            get { return BackingStore?.Get<List<string>>("removeExclusions"); }
            set { BackingStore?.Set("removeExclusions", value); }
        }
        /// <summary>The removeMembers property</summary>
        public List<string> RemoveMembers {
            get { return BackingStore?.Get<List<string>>("removeMembers"); }
            set { BackingStore?.Set("removeMembers", value); }
        }
        /// <summary>
        /// Instantiates a new updateAudienceByIdPostRequestBody and sets the default values.
        /// </summary>
        public UpdateAudienceByIdPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateAudienceByIdPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAudienceByIdPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addExclusions", n => { AddExclusions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"addMembers", n => { AddMembers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"memberEntityType", n => { MemberEntityType = n.GetStringValue(); } },
                {"removeExclusions", n => { RemoveExclusions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"removeMembers", n => { RemoveMembers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("addExclusions", AddExclusions);
            writer.WriteCollectionOfPrimitiveValues<string>("addMembers", AddMembers);
            writer.WriteStringValue("memberEntityType", MemberEntityType);
            writer.WriteCollectionOfPrimitiveValues<string>("removeExclusions", RemoveExclusions);
            writer.WriteCollectionOfPrimitiveValues<string>("removeMembers", RemoveMembers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

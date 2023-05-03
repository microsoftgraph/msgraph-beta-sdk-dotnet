using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.MicrosoftGraphWindowsUpdatesUpdateAudienceById {
    public class UpdateAudienceByIdPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The addExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AddExclusions {
            get { return BackingStore?.Get<List<string>?>("addExclusions"); }
            set { BackingStore?.Set("addExclusions", value); }
        }
#nullable restore
#else
        public List<string> AddExclusions {
            get { return BackingStore?.Get<List<string>>("addExclusions"); }
            set { BackingStore?.Set("addExclusions", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The addMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AddMembers {
            get { return BackingStore?.Get<List<string>?>("addMembers"); }
            set { BackingStore?.Set("addMembers", value); }
        }
#nullable restore
#else
        public List<string> AddMembers {
            get { return BackingStore?.Get<List<string>>("addMembers"); }
            set { BackingStore?.Set("addMembers", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The memberEntityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberEntityType {
            get { return BackingStore?.Get<string?>("memberEntityType"); }
            set { BackingStore?.Set("memberEntityType", value); }
        }
#nullable restore
#else
        public string MemberEntityType {
            get { return BackingStore?.Get<string>("memberEntityType"); }
            set { BackingStore?.Set("memberEntityType", value); }
        }
#endif
        /// <summary>The removeExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemoveExclusions {
            get { return BackingStore?.Get<List<string>?>("removeExclusions"); }
            set { BackingStore?.Set("removeExclusions", value); }
        }
#nullable restore
#else
        public List<string> RemoveExclusions {
            get { return BackingStore?.Get<List<string>>("removeExclusions"); }
            set { BackingStore?.Set("removeExclusions", value); }
        }
#endif
        /// <summary>The removeMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemoveMembers {
            get { return BackingStore?.Get<List<string>?>("removeMembers"); }
            set { BackingStore?.Set("removeMembers", value); }
        }
#nullable restore
#else
        public List<string> RemoveMembers {
            get { return BackingStore?.Get<List<string>>("removeMembers"); }
            set { BackingStore?.Set("removeMembers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new updateAudienceByIdPostRequestBody and sets the default values.
        /// </summary>
        public UpdateAudienceByIdPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.UpdateAudience {
    public class UpdateAudiencePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The addExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<UpdatableAsset>? AddExclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("addExclusions"); }
            set { BackingStore?.Set("addExclusions", value); }
        }
#else
        public List<UpdatableAsset> AddExclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>>("addExclusions"); }
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
        public List<UpdatableAsset>? AddMembers {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("addMembers"); }
            set { BackingStore?.Set("addMembers", value); }
        }
#else
        public List<UpdatableAsset> AddMembers {
            get { return BackingStore?.Get<List<UpdatableAsset>>("addMembers"); }
            set { BackingStore?.Set("addMembers", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The removeExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<UpdatableAsset>? RemoveExclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("removeExclusions"); }
            set { BackingStore?.Set("removeExclusions", value); }
        }
#else
        public List<UpdatableAsset> RemoveExclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>>("removeExclusions"); }
            set { BackingStore?.Set("removeExclusions", value); }
        }
#endif
        /// <summary>The removeMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<UpdatableAsset>? RemoveMembers {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("removeMembers"); }
            set { BackingStore?.Set("removeMembers", value); }
        }
#else
        public List<UpdatableAsset> RemoveMembers {
            get { return BackingStore?.Get<List<UpdatableAsset>>("removeMembers"); }
            set { BackingStore?.Set("removeMembers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new updateAudiencePostRequestBody and sets the default values.
        /// </summary>
        public UpdateAudiencePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateAudiencePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAudiencePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addExclusions", n => { AddExclusions = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                {"addMembers", n => { AddMembers = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                {"removeExclusions", n => { RemoveExclusions = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                {"removeMembers", n => { RemoveMembers = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("addExclusions", AddExclusions);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("addMembers", AddMembers);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("removeExclusions", RemoveExclusions);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("removeMembers", RemoveMembers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

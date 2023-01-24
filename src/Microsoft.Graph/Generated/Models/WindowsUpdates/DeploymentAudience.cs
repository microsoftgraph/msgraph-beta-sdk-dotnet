using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class DeploymentAudience : Entity, IParsable {
        /// <summary>Specifies the assets to exclude from the audience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UpdatableAsset>? Exclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("exclusions"); }
            set { BackingStore?.Set("exclusions", value); }
        }
#nullable restore
#else
        public List<UpdatableAsset> Exclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>>("exclusions"); }
            set { BackingStore?.Set("exclusions", value); }
        }
#endif
        /// <summary>Specifies the assets to include in the audience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UpdatableAsset>? Members {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<UpdatableAsset> Members {
            get { return BackingStore?.Get<List<UpdatableAsset>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeploymentAudience CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentAudience();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exclusions", n => { Exclusions = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("exclusions", Exclusions);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("members", Members);
        }
    }
}

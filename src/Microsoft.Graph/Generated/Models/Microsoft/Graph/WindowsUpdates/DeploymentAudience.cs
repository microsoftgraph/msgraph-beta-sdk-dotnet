using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class DeploymentAudience : Entity, IParsable {
        /// <summary>Specifies the assets to exclude from the audience.</summary>
        public List<UpdatableAsset> Exclusions { get; set; }
        /// <summary>Specifies the assets to include in the audience.</summary>
        public List<UpdatableAsset> Members { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeploymentAudience CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentAudience();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exclusions", (o,n) => { (o as DeploymentAudience).Exclusions = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
                {"members", (o,n) => { (o as DeploymentAudience).Members = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("exclusions", Exclusions);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("members", Members);
        }
    }
}

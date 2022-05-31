using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class TeamsAppInstallation : Entity, IParsable {
        /// <summary>The app that is installed.</summary>
        public Microsoft.Graph.Beta.Models.TeamsApp TeamsApp {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsApp>(nameof(TeamsApp)); }
            set { BackingStore?.Set(nameof(TeamsApp), value); }
        }
        /// <summary>The details of this version of the app.</summary>
        public Microsoft.Graph.Beta.Models.TeamsAppDefinition TeamsAppDefinition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppDefinition>(nameof(TeamsAppDefinition)); }
            set { BackingStore?.Set(nameof(TeamsAppDefinition), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAppInstallation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.teamsAppInstallation" => new TeamsAppInstallation(),
                _ => new TeamsAppInstallation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"teamsApp", n => { TeamsApp = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsApp>(Microsoft.Graph.Beta.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppDefinition", n => { TeamsAppDefinition = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDefinition>(Microsoft.Graph.Beta.Models.TeamsAppDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsAppDefinition>("teamsAppDefinition", TeamsAppDefinition);
        }
    }
}

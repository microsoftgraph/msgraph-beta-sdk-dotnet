using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class WindowsDeploymentSettings : DeploymentSettings, IParsable {
        /// <summary>Settings governing the user&apos;s update experience on a device.</summary>
        public UserExperienceSettings UserExperience {
            get { return BackingStore?.Get<UserExperienceSettings>("userExperience"); }
            set { BackingStore?.Set("userExperience", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsDeploymentSettings and sets the default values.
        /// </summary>
        public WindowsDeploymentSettings() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.windowsDeploymentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDeploymentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDeploymentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userExperience", n => { UserExperience = n.GetObjectValue<UserExperienceSettings>(UserExperienceSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserExperienceSettings>("userExperience", UserExperience);
        }
    }
}

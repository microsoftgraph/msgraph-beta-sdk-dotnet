using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsManagementApp : Entity, IParsable {
        /// <summary>Windows management app available version.</summary>
        public string AvailableVersion { get; set; }
        /// <summary>The list of health states for installed Windows management app.</summary>
        public List<WindowsManagementAppHealthState> HealthStates { get; set; }
        /// <summary>Managed Installer Status. Possible values are: disabled, enabled.</summary>
        public ManagedInstallerStatus? ManagedInstaller { get; set; }
        /// <summary>Managed Installer Configured Date Time</summary>
        public string ManagedInstallerConfiguredDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsManagementApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsManagementApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"availableVersion", n => { AvailableVersion = n.GetStringValue(); } },
                {"healthStates", n => { HealthStates = n.GetCollectionOfObjectValues<WindowsManagementAppHealthState>(WindowsManagementAppHealthState.CreateFromDiscriminatorValue).ToList(); } },
                {"managedInstaller", n => { ManagedInstaller = n.GetEnumValue<ManagedInstallerStatus>(); } },
                {"managedInstallerConfiguredDateTime", n => { ManagedInstallerConfiguredDateTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("availableVersion", AvailableVersion);
            writer.WriteCollectionOfObjectValues<WindowsManagementAppHealthState>("healthStates", HealthStates);
            writer.WriteEnumValue<ManagedInstallerStatus>("managedInstaller", ManagedInstaller);
            writer.WriteStringValue("managedInstallerConfiguredDateTime", ManagedInstallerConfiguredDateTime);
        }
    }
}

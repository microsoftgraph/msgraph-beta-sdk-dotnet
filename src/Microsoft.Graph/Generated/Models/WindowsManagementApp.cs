using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows management app entity.</summary>
    public class WindowsManagementApp : Entity, IParsable {
        /// <summary>Windows management app available version.</summary>
        public string AvailableVersion {
            get { return BackingStore?.Get<string>(nameof(AvailableVersion)); }
            set { BackingStore?.Set(nameof(AvailableVersion), value); }
        }
        /// <summary>The list of health states for installed Windows management app.</summary>
        public List<WindowsManagementAppHealthState> HealthStates {
            get { return BackingStore?.Get<List<WindowsManagementAppHealthState>>(nameof(HealthStates)); }
            set { BackingStore?.Set(nameof(HealthStates), value); }
        }
        /// <summary>Managed Installer Status. Possible values are: disabled, enabled.</summary>
        public ManagedInstallerStatus? ManagedInstaller {
            get { return BackingStore?.Get<ManagedInstallerStatus?>(nameof(ManagedInstaller)); }
            set { BackingStore?.Set(nameof(ManagedInstaller), value); }
        }
        /// <summary>Managed Installer Configured Date Time</summary>
        public string ManagedInstallerConfiguredDateTime {
            get { return BackingStore?.Get<string>(nameof(ManagedInstallerConfiguredDateTime)); }
            set { BackingStore?.Set(nameof(ManagedInstallerConfiguredDateTime), value); }
        }
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

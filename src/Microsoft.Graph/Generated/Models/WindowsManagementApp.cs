using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows management app entity.
    /// </summary>
    public class WindowsManagementApp : Entity, IParsable {
        /// <summary>Windows management app available version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvailableVersion {
            get { return BackingStore?.Get<string?>("availableVersion"); }
            set { BackingStore?.Set("availableVersion", value); }
        }
#nullable restore
#else
        public string AvailableVersion {
            get { return BackingStore?.Get<string>("availableVersion"); }
            set { BackingStore?.Set("availableVersion", value); }
        }
#endif
        /// <summary>The list of health states for installed Windows management app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsManagementAppHealthState>? HealthStates {
            get { return BackingStore?.Get<List<WindowsManagementAppHealthState>?>("healthStates"); }
            set { BackingStore?.Set("healthStates", value); }
        }
#nullable restore
#else
        public List<WindowsManagementAppHealthState> HealthStates {
            get { return BackingStore?.Get<List<WindowsManagementAppHealthState>>("healthStates"); }
            set { BackingStore?.Set("healthStates", value); }
        }
#endif
        /// <summary>ManagedInstallerStatus</summary>
        public ManagedInstallerStatus? ManagedInstaller {
            get { return BackingStore?.Get<ManagedInstallerStatus?>("managedInstaller"); }
            set { BackingStore?.Set("managedInstaller", value); }
        }
        /// <summary>Managed Installer Configured Date Time</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedInstallerConfiguredDateTime {
            get { return BackingStore?.Get<string?>("managedInstallerConfiguredDateTime"); }
            set { BackingStore?.Set("managedInstallerConfiguredDateTime", value); }
        }
#nullable restore
#else
        public string ManagedInstallerConfiguredDateTime {
            get { return BackingStore?.Get<string>("managedInstallerConfiguredDateTime"); }
            set { BackingStore?.Set("managedInstallerConfiguredDateTime", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"healthStates", n => { HealthStates = n.GetCollectionOfObjectValues<WindowsManagementAppHealthState>(WindowsManagementAppHealthState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedInstaller", n => { ManagedInstaller = n.GetEnumValue<ManagedInstallerStatus>(); } },
                {"managedInstallerConfiguredDateTime", n => { ManagedInstallerConfiguredDateTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

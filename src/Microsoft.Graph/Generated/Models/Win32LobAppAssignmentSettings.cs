// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties used to assign an Win32 LOB mobile app to a group.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Win32LobAppAssignmentSettings : global::Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings, IParsable
    {
        /// <summary>The auto-update settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Win32LobAppAutoUpdateSettings? AutoUpdateSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppAutoUpdateSettings?>("autoUpdateSettings"); }
            set { BackingStore?.Set("autoUpdateSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Win32LobAppAutoUpdateSettings AutoUpdateSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppAutoUpdateSettings>("autoUpdateSettings"); }
            set { BackingStore?.Set("autoUpdateSettings", value); }
        }
#endif
        /// <summary>Contains value for delivery optimization priority.</summary>
        public global::Microsoft.Graph.Beta.Models.Win32LobAppDeliveryOptimizationPriority? DeliveryOptimizationPriority
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppDeliveryOptimizationPriority?>("deliveryOptimizationPriority"); }
            set { BackingStore?.Set("deliveryOptimizationPriority", value); }
        }
        /// <summary>The install time settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MobileAppInstallTimeSettings? InstallTimeSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppInstallTimeSettings?>("installTimeSettings"); }
            set { BackingStore?.Set("installTimeSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MobileAppInstallTimeSettings InstallTimeSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppInstallTimeSettings>("installTimeSettings"); }
            set { BackingStore?.Set("installTimeSettings", value); }
        }
#endif
        /// <summary>Contains value for notification status.</summary>
        public global::Microsoft.Graph.Beta.Models.Win32LobAppNotification? Notifications
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppNotification?>("notifications"); }
            set { BackingStore?.Set("notifications", value); }
        }
        /// <summary>The reboot settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Win32LobAppRestartSettings? RestartSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppRestartSettings?>("restartSettings"); }
            set { BackingStore?.Set("restartSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Win32LobAppRestartSettings RestartSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppRestartSettings>("restartSettings"); }
            set { BackingStore?.Set("restartSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Win32LobAppAssignmentSettings"/> and sets the default values.
        /// </summary>
        public Win32LobAppAssignmentSettings() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Win32LobAppAssignmentSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Win32LobAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.win32CatalogAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.Win32CatalogAppAssignmentSettings(),
                _ => new global::Microsoft.Graph.Beta.Models.Win32LobAppAssignmentSettings(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "autoUpdateSettings", n => { AutoUpdateSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Win32LobAppAutoUpdateSettings>(global::Microsoft.Graph.Beta.Models.Win32LobAppAutoUpdateSettings.CreateFromDiscriminatorValue); } },
                { "deliveryOptimizationPriority", n => { DeliveryOptimizationPriority = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppDeliveryOptimizationPriority>(); } },
                { "installTimeSettings", n => { InstallTimeSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppInstallTimeSettings>(global::Microsoft.Graph.Beta.Models.MobileAppInstallTimeSettings.CreateFromDiscriminatorValue); } },
                { "notifications", n => { Notifications = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppNotification>(); } },
                { "restartSettings", n => { RestartSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Win32LobAppRestartSettings>(global::Microsoft.Graph.Beta.Models.Win32LobAppRestartSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Win32LobAppAutoUpdateSettings>("autoUpdateSettings", AutoUpdateSettings);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppDeliveryOptimizationPriority>("deliveryOptimizationPriority", DeliveryOptimizationPriority);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppInstallTimeSettings>("installTimeSettings", InstallTimeSettings);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppNotification>("notifications", Notifications);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Win32LobAppRestartSettings>("restartSettings", RestartSettings);
        }
    }
}
#pragma warning restore CS0618

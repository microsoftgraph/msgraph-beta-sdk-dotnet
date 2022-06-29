using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The base class for a type of apps</summary>
    public class WindowsKioskAppBase : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The app type. Possible values are: unknown, store, desktop, aumId.</summary>
        public WindowsKioskAppType? AppType {
            get { return BackingStore?.Get<WindowsKioskAppType?>(nameof(AppType)); }
            set { BackingStore?.Set(nameof(AppType), value); }
        }
        /// <summary>Allow the app to be auto-launched in multi-app kiosk mode</summary>
        public bool? AutoLaunch {
            get { return BackingStore?.Get<bool?>(nameof(AutoLaunch)); }
            set { BackingStore?.Set(nameof(AutoLaunch), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the friendly name of an app</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The app tile size for the start layout. Possible values are: hidden, small, medium, wide, large.</summary>
        public WindowsAppStartLayoutTileSize? StartLayoutTileSize {
            get { return BackingStore?.Get<WindowsAppStartLayoutTileSize?>(nameof(StartLayoutTileSize)); }
            set { BackingStore?.Set(nameof(StartLayoutTileSize), value); }
        }
        /// <summary>
        /// Instantiates a new windowsKioskAppBase and sets the default values.
        /// </summary>
        public WindowsKioskAppBase() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsKioskAppBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsKioskDesktopApp" => new WindowsKioskDesktopApp(),
                "#microsoft.graph.windowsKioskUWPApp" => new WindowsKioskUWPApp(),
                "#microsoft.graph.windowsKioskWin32App" => new WindowsKioskWin32App(),
                _ => new WindowsKioskAppBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appType", n => { AppType = n.GetEnumValue<WindowsKioskAppType>(); } },
                {"autoLaunch", n => { AutoLaunch = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"startLayoutTileSize", n => { StartLayoutTileSize = n.GetEnumValue<WindowsAppStartLayoutTileSize>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WindowsKioskAppType>("appType", AppType);
            writer.WriteBoolValue("autoLaunch", AutoLaunch);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<WindowsAppStartLayoutTileSize>("startLayoutTileSize", StartLayoutTileSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

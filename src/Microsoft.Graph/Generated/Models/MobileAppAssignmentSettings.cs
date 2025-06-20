// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Abstract class to contain properties used to assign a mobile app to a group.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MobileAppAssignmentSettings : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings"/> and sets the default values.
        /// </summary>
        public MobileAppAssignmentSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedStoreAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.AndroidManagedStoreAppAssignmentSettings(),
                "#microsoft.graph.iosDdmLobAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.IosDdmLobAppAssignmentSettings(),
                "#microsoft.graph.iosLobAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.IosLobAppAssignmentSettings(),
                "#microsoft.graph.iosStoreAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.IosStoreAppAssignmentSettings(),
                "#microsoft.graph.iosVppAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.IosVppAppAssignmentSettings(),
                "#microsoft.graph.macOsLobAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.MacOsLobAppAssignmentSettings(),
                "#microsoft.graph.macOsVppAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.MacOsVppAppAssignmentSettings(),
                "#microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessAppAssignmentSettings(),
                "#microsoft.graph.win32CatalogAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.Win32CatalogAppAssignmentSettings(),
                "#microsoft.graph.win32LobAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.Win32LobAppAssignmentSettings(),
                "#microsoft.graph.windowsAppXAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.WindowsAppXAppAssignmentSettings(),
                "#microsoft.graph.windowsUniversalAppXAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.WindowsUniversalAppXAppAssignmentSettings(),
                "#microsoft.graph.winGetAppAssignmentSettings" => new global::Microsoft.Graph.Beta.Models.WinGetAppAssignmentSettings(),
                _ => new global::Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

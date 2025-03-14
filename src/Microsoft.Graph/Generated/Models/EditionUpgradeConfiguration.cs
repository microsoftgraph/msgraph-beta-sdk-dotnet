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
    /// Windows 10 Edition Upgrade configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EditionUpgradeConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Edition Upgrade License File Content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? License
        {
            get { return BackingStore?.Get<string?>("license"); }
            set { BackingStore?.Set("license", value); }
        }
#nullable restore
#else
        public string License
        {
            get { return BackingStore?.Get<string>("license"); }
            set { BackingStore?.Set("license", value); }
        }
#endif
        /// <summary>Edition Upgrade License type</summary>
        public global::Microsoft.Graph.Beta.Models.EditionUpgradeLicenseType? LicenseType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EditionUpgradeLicenseType?>("licenseType"); }
            set { BackingStore?.Set("licenseType", value); }
        }
        /// <summary>Edition Upgrade Product Key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductKey
        {
            get { return BackingStore?.Get<string?>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#nullable restore
#else
        public string ProductKey
        {
            get { return BackingStore?.Get<string>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#endif
        /// <summary>Windows 10 Edition type.</summary>
        public global::Microsoft.Graph.Beta.Models.Windows10EditionType? TargetEdition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Windows10EditionType?>("targetEdition"); }
            set { BackingStore?.Set("targetEdition", value); }
        }
        /// <summary>The possible options to configure S mode unlock</summary>
        public global::Microsoft.Graph.Beta.Models.WindowsSModeConfiguration? WindowsSMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsSModeConfiguration?>("windowsSMode"); }
            set { BackingStore?.Set("windowsSMode", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.EditionUpgradeConfiguration"/> and sets the default values.
        /// </summary>
        public EditionUpgradeConfiguration() : base()
        {
            OdataType = "#microsoft.graph.editionUpgradeConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EditionUpgradeConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.EditionUpgradeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EditionUpgradeConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "license", n => { License = n.GetStringValue(); } },
                { "licenseType", n => { LicenseType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.EditionUpgradeLicenseType>(); } },
                { "productKey", n => { ProductKey = n.GetStringValue(); } },
                { "targetEdition", n => { TargetEdition = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Windows10EditionType>(); } },
                { "windowsSMode", n => { WindowsSMode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.WindowsSModeConfiguration>(); } },
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
            writer.WriteStringValue("license", License);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.EditionUpgradeLicenseType>("licenseType", LicenseType);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Windows10EditionType>("targetEdition", TargetEdition);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.WindowsSModeConfiguration>("windowsSMode", WindowsSMode);
        }
    }
}
#pragma warning restore CS0618

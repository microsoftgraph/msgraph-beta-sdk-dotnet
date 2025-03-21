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
    /// Microsoft Store for Business Apps. This class does not support Create, Delete, or Update.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MicrosoftStoreForBusinessApp : global::Microsoft.Graph.Beta.Models.MobileApp, IParsable
    {
        /// <summary>The collection of contained apps in a mobileApp acting as a package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MobileContainedApp>? ContainedApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileContainedApp>?>("containedApps"); }
            set { BackingStore?.Set("containedApps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MobileContainedApp> ContainedApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileContainedApp>>("containedApps"); }
            set { BackingStore?.Set("containedApps", value); }
        }
#endif
        /// <summary>The licenseType property</summary>
        public global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessLicenseType? LicenseType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessLicenseType?>("licenseType"); }
            set { BackingStore?.Set("licenseType", value); }
        }
        /// <summary>The supported License Type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.VppLicensingType? LicensingType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VppLicensingType?>("licensingType"); }
            set { BackingStore?.Set("licensingType", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.VppLicensingType LicensingType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VppLicensingType>("licensingType"); }
            set { BackingStore?.Set("licensingType", value); }
        }
#endif
        /// <summary>The app package identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageIdentityName
        {
            get { return BackingStore?.Get<string?>("packageIdentityName"); }
            set { BackingStore?.Set("packageIdentityName", value); }
        }
#nullable restore
#else
        public string PackageIdentityName
        {
            get { return BackingStore?.Get<string>("packageIdentityName"); }
            set { BackingStore?.Set("packageIdentityName", value); }
        }
#endif
        /// <summary>The app product key</summary>
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
        /// <summary>The total number of Microsoft Store for Business licenses.</summary>
        public int? TotalLicenseCount
        {
            get { return BackingStore?.Get<int?>("totalLicenseCount"); }
            set { BackingStore?.Set("totalLicenseCount", value); }
        }
        /// <summary>The number of Microsoft Store for Business licenses in use.</summary>
        public int? UsedLicenseCount
        {
            get { return BackingStore?.Get<int?>("usedLicenseCount"); }
            set { BackingStore?.Set("usedLicenseCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessApp"/> and sets the default values.
        /// </summary>
        public MicrosoftStoreForBusinessApp() : base()
        {
            OdataType = "#microsoft.graph.microsoftStoreForBusinessApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "containedApps", n => { ContainedApps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileContainedApp>(global::Microsoft.Graph.Beta.Models.MobileContainedApp.CreateFromDiscriminatorValue)?.AsList(); } },
                { "licenseType", n => { LicenseType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessLicenseType>(); } },
                { "licensingType", n => { LicensingType = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.VppLicensingType>(global::Microsoft.Graph.Beta.Models.VppLicensingType.CreateFromDiscriminatorValue); } },
                { "packageIdentityName", n => { PackageIdentityName = n.GetStringValue(); } },
                { "productKey", n => { ProductKey = n.GetStringValue(); } },
                { "totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                { "usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileContainedApp>("containedApps", ContainedApps);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessLicenseType>("licenseType", LicenseType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.VppLicensingType>("licensingType", LicensingType);
            writer.WriteStringValue("packageIdentityName", PackageIdentityName);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
        }
    }
}
#pragma warning restore CS0618

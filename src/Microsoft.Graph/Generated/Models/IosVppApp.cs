using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosVppApp : MobileApp, IParsable {
        /// <summary>The applicable iOS Device Type.</summary>
        public IosDeviceType ApplicableDeviceType {
            get { return BackingStore?.Get<IosDeviceType>(nameof(ApplicableDeviceType)); }
            set { BackingStore?.Set(nameof(ApplicableDeviceType), value); }
        }
        /// <summary>The store URL.</summary>
        public string AppStoreUrl {
            get { return BackingStore?.Get<string>(nameof(AppStoreUrl)); }
            set { BackingStore?.Set(nameof(AppStoreUrl), value); }
        }
        /// <summary>The licenses assigned to this app.</summary>
        public List<IosVppAppAssignedLicense> AssignedLicenses {
            get { return BackingStore?.Get<List<IosVppAppAssignedLicense>>(nameof(AssignedLicenses)); }
            set { BackingStore?.Set(nameof(AssignedLicenses), value); }
        }
        /// <summary>The Identity Name.</summary>
        public string BundleId {
            get { return BackingStore?.Get<string>(nameof(BundleId)); }
            set { BackingStore?.Set(nameof(BundleId), value); }
        }
        /// <summary>The supported License Type.</summary>
        public VppLicensingType LicensingType {
            get { return BackingStore?.Get<VppLicensingType>(nameof(LicensingType)); }
            set { BackingStore?.Set(nameof(LicensingType), value); }
        }
        /// <summary>The VPP application release date and time.</summary>
        public DateTimeOffset? ReleaseDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReleaseDateTime)); }
            set { BackingStore?.Set(nameof(ReleaseDateTime), value); }
        }
        /// <summary>Results of revoke license actions on this app.</summary>
        public List<IosVppAppRevokeLicensesActionResult> RevokeLicenseActionResults {
            get { return BackingStore?.Get<List<IosVppAppRevokeLicensesActionResult>>(nameof(RevokeLicenseActionResults)); }
            set { BackingStore?.Set(nameof(RevokeLicenseActionResults), value); }
        }
        /// <summary>The total number of VPP licenses.</summary>
        public int? TotalLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(TotalLicenseCount)); }
            set { BackingStore?.Set(nameof(TotalLicenseCount), value); }
        }
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(UsedLicenseCount)); }
            set { BackingStore?.Set(nameof(UsedLicenseCount), value); }
        }
        /// <summary>The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.</summary>
        public Microsoft.Graph.Beta.Models.VppTokenAccountType? VppTokenAccountType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VppTokenAccountType?>(nameof(VppTokenAccountType)); }
            set { BackingStore?.Set(nameof(VppTokenAccountType), value); }
        }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
        public string VppTokenAppleId {
            get { return BackingStore?.Get<string>(nameof(VppTokenAppleId)); }
            set { BackingStore?.Set(nameof(VppTokenAppleId), value); }
        }
        /// <summary>Identifier of the VPP token associated with this app.</summary>
        public string VppTokenId {
            get { return BackingStore?.Get<string>(nameof(VppTokenId)); }
            set { BackingStore?.Set(nameof(VppTokenId), value); }
        }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
        public string VppTokenOrganizationName {
            get { return BackingStore?.Get<string>(nameof(VppTokenOrganizationName)); }
            set { BackingStore?.Set(nameof(VppTokenOrganizationName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosVppApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableDeviceType", n => { ApplicableDeviceType = n.GetObjectValue<IosDeviceType>(IosDeviceType.CreateFromDiscriminatorValue); } },
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<IosVppAppAssignedLicense>(IosVppAppAssignedLicense.CreateFromDiscriminatorValue).ToList(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"licensingType", n => { LicensingType = n.GetObjectValue<VppLicensingType>(VppLicensingType.CreateFromDiscriminatorValue); } },
                {"releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                {"revokeLicenseActionResults", n => { RevokeLicenseActionResults = n.GetCollectionOfObjectValues<IosVppAppRevokeLicensesActionResult>(IosVppAppRevokeLicensesActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
                {"vppTokenAppleId", n => { VppTokenAppleId = n.GetStringValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetStringValue(); } },
                {"vppTokenOrganizationName", n => { VppTokenOrganizationName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IosDeviceType>("applicableDeviceType", ApplicableDeviceType);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteCollectionOfObjectValues<IosVppAppAssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteObjectValue<VppLicensingType>("licensingType", LicensingType);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteCollectionOfObjectValues<IosVppAppRevokeLicensesActionResult>("revokeLicenseActionResults", RevokeLicenseActionResults);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
            writer.WriteStringValue("vppTokenAppleId", VppTokenAppleId);
            writer.WriteStringValue("vppTokenId", VppTokenId);
            writer.WriteStringValue("vppTokenOrganizationName", VppTokenOrganizationName);
        }
    }
}

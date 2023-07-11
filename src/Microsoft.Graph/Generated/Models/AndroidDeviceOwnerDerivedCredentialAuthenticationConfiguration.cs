using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Android COBO Derived Credential profile.
    /// </summary>
    public class AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Certificate access type. Possible values are: userApproval, specificApps, unknownFutureValue.</summary>
        public AndroidDeviceOwnerCertificateAccessType? CertificateAccessType {
            get { return BackingStore?.Get<AndroidDeviceOwnerCertificateAccessType?>("certificateAccessType"); }
            set { BackingStore?.Set("certificateAccessType", value); }
        }
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementDerivedCredentialSettings? DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings?>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#nullable restore
#else
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#endif
        /// <summary>Certificate access information. This collection can contain a maximum of 50 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerSilentCertificateAccess>? SilentCertificateAccessDetails {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerSilentCertificateAccess>?>("silentCertificateAccessDetails"); }
            set { BackingStore?.Set("silentCertificateAccessDetails", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerSilentCertificateAccess> SilentCertificateAccessDetails {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerSilentCertificateAccess>>("silentCertificateAccessDetails"); }
            set { BackingStore?.Set("silentCertificateAccessDetails", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new androidDeviceOwnerDerivedCredentialAuthenticationConfiguration and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerDerivedCredentialAuthenticationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateAccessType", n => { CertificateAccessType = n.GetEnumValue<AndroidDeviceOwnerCertificateAccessType>(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"silentCertificateAccessDetails", n => { SilentCertificateAccessDetails = n.GetCollectionOfObjectValues<AndroidDeviceOwnerSilentCertificateAccess>(AndroidDeviceOwnerSilentCertificateAccess.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AndroidDeviceOwnerCertificateAccessType>("certificateAccessType", CertificateAccessType);
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerSilentCertificateAccess>("silentCertificateAccessDetails", SilentCertificateAccessDetails);
        }
    }
}

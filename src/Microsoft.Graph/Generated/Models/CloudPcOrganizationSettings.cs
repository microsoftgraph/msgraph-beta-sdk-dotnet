using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcOrganizationSettings : Entity, IParsable {
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. The possible values are: windows10, windows11, unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion {
            get { return BackingStore?.Get<CloudPcOperatingSystem?>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>The account type of the user on provisioned Cloud PCs. The possible values are: standardUser, administrator, unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType {
            get { return BackingStore?.Get<CloudPcUserAccountType?>(nameof(UserAccountType)); }
            set { BackingStore?.Set(nameof(UserAccountType), value); }
        }
        /// <summary>Represents the Cloud PC organization settings for a tenant. A tenant has only one cloudPcOrganizationSettings object. The default language value en-US.</summary>
        public CloudPcWindowsSettings WindowsSettings {
            get { return BackingStore?.Get<CloudPcWindowsSettings>(nameof(WindowsSettings)); }
            set { BackingStore?.Set(nameof(WindowsSettings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcOrganizationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOrganizationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"osVersion", n => { OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
                {"windowsSettings", n => { WindowsSettings = n.GetObjectValue<CloudPcWindowsSettings>(CloudPcWindowsSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CloudPcOperatingSystem>("osVersion", OsVersion);
            writer.WriteEnumValue<CloudPcUserAccountType>("userAccountType", UserAccountType);
            writer.WriteObjectValue<CloudPcWindowsSettings>("windowsSettings", WindowsSettings);
        }
    }
}

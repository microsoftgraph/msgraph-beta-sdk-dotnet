using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EasEmailProfileConfigurationBase : DeviceConfiguration, IParsable {
        /// <summary>Custom domain name value used while generating an email profile before installing on the device.</summary>
        public string CustomDomainName {
            get { return BackingStore?.Get<string>("customDomainName"); }
            set { BackingStore?.Set("customDomainName", value); }
        }
        /// <summary>UserDomainname attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: fullDomainName, netBiosDomainName.</summary>
        public DomainNameSource? UserDomainNameSource {
            get { return BackingStore?.Get<DomainNameSource?>("userDomainNameSource"); }
            set { BackingStore?.Set("userDomainNameSource", value); }
        }
        /// <summary>Name of the AAD field, that will be used to retrieve UserName for email profile. Possible values are: userPrincipalName, primarySmtpAddress, samAccountName.</summary>
        public Microsoft.Graph.Beta.Models.UsernameSource? UsernameAADSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UsernameSource?>("usernameAADSource"); }
            set { BackingStore?.Set("usernameAADSource", value); }
        }
        /// <summary>Possible values for username source or email source.</summary>
        public UserEmailSource? UsernameSource {
            get { return BackingStore?.Get<UserEmailSource?>("usernameSource"); }
            set { BackingStore?.Set("usernameSource", value); }
        }
        /// <summary>
        /// Instantiates a new EasEmailProfileConfigurationBase and sets the default values.
        /// </summary>
        public EasEmailProfileConfigurationBase() : base() {
            OdataType = "#microsoft.graph.easEmailProfileConfigurationBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EasEmailProfileConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosEasEmailProfileConfiguration" => new IosEasEmailProfileConfiguration(),
                "#microsoft.graph.windows10EasEmailProfileConfiguration" => new Windows10EasEmailProfileConfiguration(),
                "#microsoft.graph.windowsPhoneEASEmailProfileConfiguration" => new WindowsPhoneEASEmailProfileConfiguration(),
                _ => new EasEmailProfileConfigurationBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customDomainName", n => { CustomDomainName = n.GetStringValue(); } },
                {"userDomainNameSource", n => { UserDomainNameSource = n.GetEnumValue<DomainNameSource>(); } },
                {"usernameAADSource", n => { UsernameAADSource = n.GetEnumValue<UsernameSource>(); } },
                {"usernameSource", n => { UsernameSource = n.GetEnumValue<UserEmailSource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("customDomainName", CustomDomainName);
            writer.WriteEnumValue<DomainNameSource>("userDomainNameSource", UserDomainNameSource);
            writer.WriteEnumValue<UsernameSource>("usernameAADSource", UsernameAADSource);
            writer.WriteEnumValue<UserEmailSource>("usernameSource", UsernameSource);
        }
    }
}

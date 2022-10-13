using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsDomainJoinConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Active Directory domain name to join.</summary>
        public string ActiveDirectoryDomainName {
            get { return BackingStore?.Get<string>("activeDirectoryDomainName"); }
            set { BackingStore?.Set("activeDirectoryDomainName", value); }
        }
        /// <summary>Fixed prefix to be used for computer name.</summary>
        public string ComputerNameStaticPrefix {
            get { return BackingStore?.Get<string>("computerNameStaticPrefix"); }
            set { BackingStore?.Set("computerNameStaticPrefix", value); }
        }
        /// <summary>Dynamically generated characters used as suffix for computer name. Valid values 3 to 14</summary>
        public int? ComputerNameSuffixRandomCharCount {
            get { return BackingStore?.Get<int?>("computerNameSuffixRandomCharCount"); }
            set { BackingStore?.Set("computerNameSuffixRandomCharCount", value); }
        }
        /// <summary>Reference to device configurations required for network connectivity</summary>
        public List<DeviceConfiguration> NetworkAccessConfigurations {
            get { return BackingStore?.Get<List<DeviceConfiguration>>("networkAccessConfigurations"); }
            set { BackingStore?.Set("networkAccessConfigurations", value); }
        }
        /// <summary>Organizational unit (OU) where the computer account will be created. If this parameter is NULL, the well known computer object container will be used as published in the domain.</summary>
        public string OrganizationalUnit {
            get { return BackingStore?.Get<string>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsDomainJoinConfiguration and sets the default values.
        /// </summary>
        public WindowsDomainJoinConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsDomainJoinConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDomainJoinConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDomainJoinConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDirectoryDomainName", n => { ActiveDirectoryDomainName = n.GetStringValue(); } },
                {"computerNameStaticPrefix", n => { ComputerNameStaticPrefix = n.GetStringValue(); } },
                {"computerNameSuffixRandomCharCount", n => { ComputerNameSuffixRandomCharCount = n.GetIntValue(); } },
                {"networkAccessConfigurations", n => { NetworkAccessConfigurations = n.GetCollectionOfObjectValues<DeviceConfiguration>(DeviceConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"organizationalUnit", n => { OrganizationalUnit = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activeDirectoryDomainName", ActiveDirectoryDomainName);
            writer.WriteStringValue("computerNameStaticPrefix", ComputerNameStaticPrefix);
            writer.WriteIntValue("computerNameSuffixRandomCharCount", ComputerNameSuffixRandomCharCount);
            writer.WriteCollectionOfObjectValues<DeviceConfiguration>("networkAccessConfigurations", NetworkAccessConfigurations);
            writer.WriteStringValue("organizationalUnit", OrganizationalUnit);
        }
    }
}

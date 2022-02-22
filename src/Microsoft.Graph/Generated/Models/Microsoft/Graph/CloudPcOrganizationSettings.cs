using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CloudPcOrganizationSettings : Entity, IParsable {
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. The possible values are: windows10, windows11, unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion { get; set; }
        /// <summary>The account type of the user on provisioned Cloud PCs. The possible values are: standardUser, administrator, unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"osVersion", (o,n) => { (o as CloudPcOrganizationSettings).OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"userAccountType", (o,n) => { (o as CloudPcOrganizationSettings).UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
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
        }
    }
}

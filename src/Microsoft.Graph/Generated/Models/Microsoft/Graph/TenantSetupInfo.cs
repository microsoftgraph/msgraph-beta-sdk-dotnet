using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TenantSetupInfo : Entity, IParsable {
        public PrivilegedRoleSettings DefaultRolesSettings { get; set; }
        public bool? FirstTimeSetup { get; set; }
        public List<string> RelevantRolesSettings { get; set; }
        public SetupStatus? SetupStatus { get; set; }
        public bool? SkipSetup { get; set; }
        public string UserRolesActions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"defaultRolesSettings", (o,n) => { (o as TenantSetupInfo).DefaultRolesSettings = n.GetObjectValue<PrivilegedRoleSettings>(); } },
                {"firstTimeSetup", (o,n) => { (o as TenantSetupInfo).FirstTimeSetup = n.GetBoolValue(); } },
                {"relevantRolesSettings", (o,n) => { (o as TenantSetupInfo).RelevantRolesSettings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"setupStatus", (o,n) => { (o as TenantSetupInfo).SetupStatus = n.GetEnumValue<SetupStatus>(); } },
                {"skipSetup", (o,n) => { (o as TenantSetupInfo).SkipSetup = n.GetBoolValue(); } },
                {"userRolesActions", (o,n) => { (o as TenantSetupInfo).UserRolesActions = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrivilegedRoleSettings>("defaultRolesSettings", DefaultRolesSettings);
            writer.WriteBoolValue("firstTimeSetup", FirstTimeSetup);
            writer.WriteCollectionOfPrimitiveValues<string>("relevantRolesSettings", RelevantRolesSettings);
            writer.WriteEnumValue<SetupStatus>("setupStatus", SetupStatus);
            writer.WriteBoolValue("skipSetup", SkipSetup);
            writer.WriteStringValue("userRolesActions", UserRolesActions);
        }
    }
}

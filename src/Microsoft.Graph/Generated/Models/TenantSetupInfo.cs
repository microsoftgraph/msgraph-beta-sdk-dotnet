using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TenantSetupInfo : Entity, IParsable {
        /// <summary>The defaultRolesSettings property</summary>
        public PrivilegedRoleSettings DefaultRolesSettings { get; set; }
        /// <summary>The firstTimeSetup property</summary>
        public bool? FirstTimeSetup { get; set; }
        /// <summary>The relevantRolesSettings property</summary>
        public List<string> RelevantRolesSettings { get; set; }
        /// <summary>The setupStatus property</summary>
        public Microsoft.Graph.Beta.Models.SetupStatus? SetupStatus { get; set; }
        /// <summary>The skipSetup property</summary>
        public bool? SkipSetup { get; set; }
        /// <summary>The userRolesActions property</summary>
        public string UserRolesActions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TenantSetupInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantSetupInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultRolesSettings", n => { DefaultRolesSettings = n.GetObjectValue<PrivilegedRoleSettings>(PrivilegedRoleSettings.CreateFromDiscriminatorValue); } },
                {"firstTimeSetup", n => { FirstTimeSetup = n.GetBoolValue(); } },
                {"relevantRolesSettings", n => { RelevantRolesSettings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"setupStatus", n => { SetupStatus = n.GetEnumValue<SetupStatus>(); } },
                {"skipSetup", n => { SkipSetup = n.GetBoolValue(); } },
                {"userRolesActions", n => { UserRolesActions = n.GetStringValue(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsAssignedAccessProfile : Entity, IParsable {
        /// <summary>These are the only Windows Store Apps that will be available to launch from the Start menu.</summary>
        public List<string> AppUserModelIds { get; set; }
        /// <summary>These are the paths of the Desktop Apps that will be available on the Start menu and the only apps the user will be able to launch.</summary>
        public List<string> DesktopAppPaths { get; set; }
        /// <summary>This is a friendly name used to identify a group of applications, the layout of these apps on the start menu and the users to whom this kiosk configuration is assigned.</summary>
        public string ProfileName { get; set; }
        /// <summary>This setting allows the admin to specify whether the Task Bar is shown or not.</summary>
        public bool? ShowTaskBar { get; set; }
        /// <summary>Allows admins to override the default Start layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.</summary>
        public byte[] StartMenuLayoutXml { get; set; }
        /// <summary>The user accounts that will be locked to this kiosk configuration.</summary>
        public List<string> UserAccounts { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsAssignedAccessProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAssignedAccessProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appUserModelIds", (o,n) => { (o as WindowsAssignedAccessProfile).AppUserModelIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"desktopAppPaths", (o,n) => { (o as WindowsAssignedAccessProfile).DesktopAppPaths = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"profileName", (o,n) => { (o as WindowsAssignedAccessProfile).ProfileName = n.GetStringValue(); } },
                {"showTaskBar", (o,n) => { (o as WindowsAssignedAccessProfile).ShowTaskBar = n.GetBoolValue(); } },
                {"startMenuLayoutXml", (o,n) => { (o as WindowsAssignedAccessProfile).StartMenuLayoutXml = n.GetByteArrayValue(); } },
                {"userAccounts", (o,n) => { (o as WindowsAssignedAccessProfile).UserAccounts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("appUserModelIds", AppUserModelIds);
            writer.WriteCollectionOfPrimitiveValues<string>("desktopAppPaths", DesktopAppPaths);
            writer.WriteStringValue("profileName", ProfileName);
            writer.WriteBoolValue("showTaskBar", ShowTaskBar);
            writer.WriteByteArrayValue("startMenuLayoutXml", StartMenuLayoutXml);
            writer.WriteCollectionOfPrimitiveValues<string>("userAccounts", UserAccounts);
        }
    }
}

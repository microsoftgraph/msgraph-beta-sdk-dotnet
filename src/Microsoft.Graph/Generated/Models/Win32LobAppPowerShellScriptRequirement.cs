using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Win32LobAppPowerShellScriptRequirement : Win32LobAppRequirement, IParsable {
        /// <summary>Contains all supported Powershell Script output detection type.</summary>
        public Win32LobAppPowerShellScriptDetectionType? DetectionType {
            get { return BackingStore?.Get<Win32LobAppPowerShellScriptDetectionType?>("detectionType"); }
            set { BackingStore?.Set("detectionType", value); }
        }
        /// <summary>The unique display name for this rule</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>A value indicating whether signature check is enforced</summary>
        public bool? EnforceSignatureCheck {
            get { return BackingStore?.Get<bool?>("enforceSignatureCheck"); }
            set { BackingStore?.Set("enforceSignatureCheck", value); }
        }
        /// <summary>A value indicating whether this script should run as 32-bit</summary>
        public bool? RunAs32Bit {
            get { return BackingStore?.Get<bool?>("runAs32Bit"); }
            set { BackingStore?.Set("runAs32Bit", value); }
        }
        /// <summary>Indicates the type of execution context the app runs in.</summary>
        public RunAsAccountType? RunAsAccount {
            get { return BackingStore?.Get<RunAsAccountType?>("runAsAccount"); }
            set { BackingStore?.Set("runAsAccount", value); }
        }
        /// <summary>The base64 encoded script content to detect Win32 Line of Business (LoB) app</summary>
        public string ScriptContent {
            get { return BackingStore?.Get<string>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
        /// <summary>
        /// Instantiates a new Win32LobAppPowerShellScriptRequirement and sets the default values.
        /// </summary>
        public Win32LobAppPowerShellScriptRequirement() : base() {
            OdataType = "#microsoft.graph.win32LobAppPowerShellScriptRequirement";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppPowerShellScriptRequirement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppPowerShellScriptRequirement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionType", n => { DetectionType = n.GetEnumValue<Win32LobAppPowerShellScriptDetectionType>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                {"runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"scriptContent", n => { ScriptContent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Win32LobAppPowerShellScriptDetectionType>("detectionType", DetectionType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteStringValue("scriptContent", ScriptContent);
        }
    }
}

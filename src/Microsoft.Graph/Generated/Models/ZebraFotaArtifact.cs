using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes a single artifact for a specific device model.</summary>
    public class ZebraFotaArtifact : Entity, IParsable {
        /// <summary>The version of the Board Support Package.</summary>
        public string BoardSupportPackageVersion {
            get { return BackingStore?.Get<string>(nameof(BoardSupportPackageVersion)); }
            set { BackingStore?.Set(nameof(BoardSupportPackageVersion), value); }
        }
        /// <summary>Artifact device model.</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>(nameof(DeviceModel)); }
            set { BackingStore?.Set(nameof(DeviceModel), value); }
        }
        /// <summary>Artifact OS version.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>Artifact patch version.</summary>
        public string PatchVersion {
            get { return BackingStore?.Get<string>(nameof(PatchVersion)); }
            set { BackingStore?.Set(nameof(PatchVersion), value); }
        }
        /// <summary>Artifact release notes URL.</summary>
        public string ReleaseNotesUrl {
            get { return BackingStore?.Get<string>(nameof(ReleaseNotesUrl)); }
            set { BackingStore?.Set(nameof(ReleaseNotesUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ZebraFotaArtifact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZebraFotaArtifact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"boardSupportPackageVersion", n => { BoardSupportPackageVersion = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"patchVersion", n => { PatchVersion = n.GetStringValue(); } },
                {"releaseNotesUrl", n => { ReleaseNotesUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("boardSupportPackageVersion", BoardSupportPackageVersion);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("patchVersion", PatchVersion);
            writer.WriteStringValue("releaseNotesUrl", ReleaseNotesUrl);
        }
    }
}

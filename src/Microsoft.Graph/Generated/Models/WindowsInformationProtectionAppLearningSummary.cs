// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Windows Information Protection AppLearning Summary entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsInformationProtectionAppLearningSummary : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Application Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationName
        {
            get { return BackingStore?.Get<string?>("applicationName"); }
            set { BackingStore?.Set("applicationName", value); }
        }
#nullable restore
#else
        public string ApplicationName
        {
            get { return BackingStore?.Get<string>("applicationName"); }
            set { BackingStore?.Set("applicationName", value); }
        }
#endif
        /// <summary>Possible types of Application</summary>
        public global::Microsoft.Graph.Beta.Models.ApplicationType? ApplicationType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ApplicationType?>("applicationType"); }
            set { BackingStore?.Set("applicationType", value); }
        }
        /// <summary>Device Count</summary>
        public int? DeviceCount
        {
            get { return BackingStore?.Get<int?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicationName", n => { ApplicationName = n.GetStringValue(); } },
                { "applicationType", n => { ApplicationType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ApplicationType>(); } },
                { "deviceCount", n => { DeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ApplicationType>("applicationType", ApplicationType);
            writer.WriteIntValue("deviceCount", DeviceCount);
        }
    }
}
#pragma warning restore CS0618

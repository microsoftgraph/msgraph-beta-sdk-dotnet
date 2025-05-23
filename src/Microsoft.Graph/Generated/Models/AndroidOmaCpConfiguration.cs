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
    /// By providing a configuration in this profile you can configure Android devices that support OMA-CP.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidOmaCpConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Configuration XML that will be applied to the device. When it is read, it only provides a placeholder string since the original data is encrypted and stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ConfigurationXml
        {
            get { return BackingStore?.Get<byte[]?>("configurationXml"); }
            set { BackingStore?.Set("configurationXml", value); }
        }
#nullable restore
#else
        public byte[] ConfigurationXml
        {
            get { return BackingStore?.Get<byte[]>("configurationXml"); }
            set { BackingStore?.Set("configurationXml", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AndroidOmaCpConfiguration"/> and sets the default values.
        /// </summary>
        public AndroidOmaCpConfiguration() : base()
        {
            OdataType = "#microsoft.graph.androidOmaCpConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidOmaCpConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AndroidOmaCpConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AndroidOmaCpConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configurationXml", n => { ConfigurationXml = n.GetByteArrayValue(); } },
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
            writer.WriteByteArrayValue("configurationXml", ConfigurationXml);
        }
    }
}
#pragma warning restore CS0618

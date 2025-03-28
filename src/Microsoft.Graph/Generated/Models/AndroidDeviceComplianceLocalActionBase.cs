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
    /// Local Action Configuration
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidDeviceComplianceLocalActionBase : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Number of minutes to wait till a local action is enforced. Valid values 0 to 2147483647</summary>
        public int? GracePeriodInMinutes
        {
            get { return BackingStore?.Get<int?>("gracePeriodInMinutes"); }
            set { BackingStore?.Set("gracePeriodInMinutes", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceComplianceLocalActionBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AndroidDeviceComplianceLocalActionBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidDeviceComplianceLocalActionLockDevice" => new global::Microsoft.Graph.Beta.Models.AndroidDeviceComplianceLocalActionLockDevice(),
                "#microsoft.graph.androidDeviceComplianceLocalActionLockDeviceWithPasscode" => new global::Microsoft.Graph.Beta.Models.AndroidDeviceComplianceLocalActionLockDeviceWithPasscode(),
                _ => new global::Microsoft.Graph.Beta.Models.AndroidDeviceComplianceLocalActionBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "gracePeriodInMinutes", n => { GracePeriodInMinutes = n.GetIntValue(); } },
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
            writer.WriteIntValue("gracePeriodInMinutes", GracePeriodInMinutes);
        }
    }
}
#pragma warning restore CS0618

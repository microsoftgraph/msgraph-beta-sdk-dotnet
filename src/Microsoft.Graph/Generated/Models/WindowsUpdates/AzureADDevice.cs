using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class AzureADDevice : UpdatableAsset, IParsable {
        /// <summary>Specifies areas of the service in which the device is enrolled. Read-only. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UpdatableAssetEnrollment>? Enrollments {
            get { return BackingStore?.Get<List<UpdatableAssetEnrollment>?>("enrollments"); }
            set { BackingStore?.Set("enrollments", value); }
        }
#nullable restore
#else
        public List<UpdatableAssetEnrollment> Enrollments {
            get { return BackingStore?.Get<List<UpdatableAssetEnrollment>>("enrollments"); }
            set { BackingStore?.Set("enrollments", value); }
        }
#endif
        /// <summary>Specifies any errors that prevent the device from being enrolled in update management or receving deployed content. Read-only. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UpdatableAssetError>? Errors {
            get { return BackingStore?.Get<List<UpdatableAssetError>?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#nullable restore
#else
        public List<UpdatableAssetError> Errors {
            get { return BackingStore?.Get<List<UpdatableAssetError>>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AzureADDevice and sets the default values.
        /// </summary>
        public AzureADDevice() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.azureADDevice";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AzureADDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureADDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enrollments", n => { Enrollments = n.GetCollectionOfObjectValues<UpdatableAssetEnrollment>(UpdatableAssetEnrollment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<UpdatableAssetError>(UpdatableAssetError.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UpdatableAssetEnrollment>("enrollments", Enrollments);
            writer.WriteCollectionOfObjectValues<UpdatableAssetError>("errors", Errors);
        }
    }
}

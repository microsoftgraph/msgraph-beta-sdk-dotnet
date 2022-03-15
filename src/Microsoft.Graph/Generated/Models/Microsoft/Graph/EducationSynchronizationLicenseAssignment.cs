using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the educationRoot singleton.</summary>
    public class EducationSynchronizationLicenseAssignment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The user role type to assign to license. Possible values are: student, teacher, faculty.</summary>
        public EducationUserRole? AppliesTo { get; set; }
        /// <summary>Represents the SKU identifiers of the licenses to assign.</summary>
        public List<string> SkuIds { get; set; }
        /// <summary>
        /// Instantiates a new educationSynchronizationLicenseAssignment and sets the default values.
        /// </summary>
        public EducationSynchronizationLicenseAssignment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EducationSynchronizationLicenseAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationLicenseAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appliesTo", (o,n) => { (o as EducationSynchronizationLicenseAssignment).AppliesTo = n.GetEnumValue<EducationUserRole>(); } },
                {"skuIds", (o,n) => { (o as EducationSynchronizationLicenseAssignment).SkuIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EducationUserRole>("appliesTo", AppliesTo);
            writer.WriteCollectionOfPrimitiveValues<string>("skuIds", SkuIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

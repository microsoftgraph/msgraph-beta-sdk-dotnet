using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationRoot : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The classes property</summary>
        public List<EducationClass> Classes {
            get { return BackingStore?.Get<List<EducationClass>>("classes"); }
            set { BackingStore?.Set("classes", value); }
        }
        /// <summary>The me property</summary>
        public EducationUser Me {
            get { return BackingStore?.Get<EducationUser>("me"); }
            set { BackingStore?.Set("me", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The schools property</summary>
        public List<EducationSchool> Schools {
            get { return BackingStore?.Get<List<EducationSchool>>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
        /// <summary>The synchronizationProfiles property</summary>
        public List<EducationSynchronizationProfile> SynchronizationProfiles {
            get { return BackingStore?.Get<List<EducationSynchronizationProfile>>("synchronizationProfiles"); }
            set { BackingStore?.Set("synchronizationProfiles", value); }
        }
        /// <summary>The users property</summary>
        public List<EducationUser> Users {
            get { return BackingStore?.Get<List<EducationUser>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
        /// <summary>
        /// Instantiates a new EducationRoot and sets the default values.
        /// </summary>
        public EducationRoot() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EducationRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"classes", n => { Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue)?.ToList(); } },
                {"me", n => { Me = n.GetObjectValue<EducationUser>(EducationUser.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"schools", n => { Schools = n.GetCollectionOfObjectValues<EducationSchool>(EducationSchool.CreateFromDiscriminatorValue)?.ToList(); } },
                {"synchronizationProfiles", n => { SynchronizationProfiles = n.GetCollectionOfObjectValues<EducationSynchronizationProfile>(EducationSynchronizationProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<EducationUser>("me", Me);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<EducationSynchronizationProfile>("synchronizationProfiles", SynchronizationProfiles);
            writer.WriteCollectionOfObjectValues<EducationUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

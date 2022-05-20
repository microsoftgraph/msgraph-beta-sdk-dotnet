using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TrustFrameworkKey : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>RSA Key - private exponent. Field cannot be read back.</summary>
        public string D {
            get { return BackingStore?.Get<string>(nameof(D)); }
            set { BackingStore?.Set(nameof(D), value); }
        }
        /// <summary>RSA Key - first exponent. Field cannot be read back.</summary>
        public string Dp {
            get { return BackingStore?.Get<string>(nameof(Dp)); }
            set { BackingStore?.Set(nameof(Dp), value); }
        }
        /// <summary>RSA Key - second exponent. Field cannot be read back.</summary>
        public string Dq {
            get { return BackingStore?.Get<string>(nameof(Dq)); }
            set { BackingStore?.Set(nameof(Dq), value); }
        }
        /// <summary>RSA Key - public exponent</summary>
        public string E {
            get { return BackingStore?.Get<string>(nameof(E)); }
            set { BackingStore?.Set(nameof(E), value); }
        }
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Exp {
            get { return BackingStore?.Get<long?>(nameof(Exp)); }
            set { BackingStore?.Set(nameof(Exp), value); }
        }
        /// <summary>Symmetric Key for oct key type. Field cannot be read back.</summary>
        public string K {
            get { return BackingStore?.Get<string>(nameof(K)); }
            set { BackingStore?.Set(nameof(K), value); }
        }
        /// <summary>The unique identifier for the key.</summary>
        public string Kid {
            get { return BackingStore?.Get<string>(nameof(Kid)); }
            set { BackingStore?.Set(nameof(Kid), value); }
        }
        /// <summary>The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.</summary>
        public string Kty {
            get { return BackingStore?.Get<string>(nameof(Kty)); }
            set { BackingStore?.Set(nameof(Kty), value); }
        }
        /// <summary>RSA Key - modulus</summary>
        public string N {
            get { return BackingStore?.Get<string>(nameof(N)); }
            set { BackingStore?.Set(nameof(N), value); }
        }
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Nbf {
            get { return BackingStore?.Get<long?>(nameof(Nbf)); }
            set { BackingStore?.Set(nameof(Nbf), value); }
        }
        /// <summary>RSA Key - first prime. Field cannot be read back.</summary>
        public string P {
            get { return BackingStore?.Get<string>(nameof(P)); }
            set { BackingStore?.Set(nameof(P), value); }
        }
        /// <summary>RSA Key - second prime. Field cannot be read back.</summary>
        public string Q {
            get { return BackingStore?.Get<string>(nameof(Q)); }
            set { BackingStore?.Set(nameof(Q), value); }
        }
        /// <summary>RSA Key - Coefficient. Field cannot be read back.</summary>
        public string Qi {
            get { return BackingStore?.Get<string>(nameof(Qi)); }
            set { BackingStore?.Set(nameof(Qi), value); }
        }
        /// <summary>The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)</summary>
        public string Use {
            get { return BackingStore?.Get<string>(nameof(Use)); }
            set { BackingStore?.Set(nameof(Use), value); }
        }
        /// <summary>The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.</summary>
        public List<string> X5c {
            get { return BackingStore?.Get<List<string>>(nameof(X5c)); }
            set { BackingStore?.Set(nameof(X5c), value); }
        }
        /// <summary>The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (a.k.a. digest) of the DER encoding of an X.509 certificate RFC 5280.</summary>
        public string X5t {
            get { return BackingStore?.Get<string>(nameof(X5t)); }
            set { BackingStore?.Set(nameof(X5t), value); }
        }
        /// <summary>
        /// Instantiates a new trustFrameworkKey and sets the default values.
        /// </summary>
        public TrustFrameworkKey() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TrustFrameworkKey CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrustFrameworkKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"d", n => { D = n.GetStringValue(); } },
                {"dp", n => { Dp = n.GetStringValue(); } },
                {"dq", n => { Dq = n.GetStringValue(); } },
                {"e", n => { E = n.GetStringValue(); } },
                {"exp", n => { Exp = n.GetLongValue(); } },
                {"k", n => { K = n.GetStringValue(); } },
                {"kid", n => { Kid = n.GetStringValue(); } },
                {"kty", n => { Kty = n.GetStringValue(); } },
                {"n", n => { N = n.GetStringValue(); } },
                {"nbf", n => { Nbf = n.GetLongValue(); } },
                {"p", n => { P = n.GetStringValue(); } },
                {"q", n => { Q = n.GetStringValue(); } },
                {"qi", n => { Qi = n.GetStringValue(); } },
                {"use", n => { Use = n.GetStringValue(); } },
                {"x5c", n => { X5c = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"x5t", n => { X5t = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("d", D);
            writer.WriteStringValue("dp", Dp);
            writer.WriteStringValue("dq", Dq);
            writer.WriteStringValue("e", E);
            writer.WriteLongValue("exp", Exp);
            writer.WriteStringValue("k", K);
            writer.WriteStringValue("kid", Kid);
            writer.WriteStringValue("kty", Kty);
            writer.WriteStringValue("n", N);
            writer.WriteLongValue("nbf", Nbf);
            writer.WriteStringValue("p", P);
            writer.WriteStringValue("q", Q);
            writer.WriteStringValue("qi", Qi);
            writer.WriteStringValue("use", Use);
            writer.WriteCollectionOfPrimitiveValues<string>("x5c", X5c);
            writer.WriteStringValue("x5t", X5t);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

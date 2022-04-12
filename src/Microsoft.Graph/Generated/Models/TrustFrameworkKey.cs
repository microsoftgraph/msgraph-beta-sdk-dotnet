using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TrustFrameworkKey : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>RSA Key - private exponent. Field cannot be read back.</summary>
        public string D { get; set; }
        /// <summary>RSA Key - first exponent. Field cannot be read back.</summary>
        public string Dp { get; set; }
        /// <summary>RSA Key - second exponent. Field cannot be read back.</summary>
        public string Dq { get; set; }
        /// <summary>RSA Key - public exponent</summary>
        public string E { get; set; }
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Exp { get; set; }
        /// <summary>Symmetric Key for oct key type. Field cannot be read back.</summary>
        public string K { get; set; }
        /// <summary>The unique identifier for the key.</summary>
        public string Kid { get; set; }
        /// <summary>The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.</summary>
        public string Kty { get; set; }
        /// <summary>RSA Key - modulus</summary>
        public string N { get; set; }
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Nbf { get; set; }
        /// <summary>RSA Key - first prime. Field cannot be read back.</summary>
        public string P { get; set; }
        /// <summary>RSA Key - second prime. Field cannot be read back.</summary>
        public string Q { get; set; }
        /// <summary>RSA Key - Coefficient. Field cannot be read back.</summary>
        public string Qi { get; set; }
        /// <summary>The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)</summary>
        public string Use { get; set; }
        /// <summary>The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.</summary>
        public List<string> X5c { get; set; }
        /// <summary>The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (a.k.a. digest) of the DER encoding of an X.509 certificate RFC 5280.</summary>
        public string X5t { get; set; }
        /// <summary>
        /// Instantiates a new trustFrameworkKey and sets the default values.
        /// </summary>
        public TrustFrameworkKey() {
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

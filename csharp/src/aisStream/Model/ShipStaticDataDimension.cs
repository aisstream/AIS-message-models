/*
 * Ais-Stream WebsocketObjects
 *
 * OpenAPI 3.0 definitions for the data models used by aisstream.io.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace aisStream.Model
{
    /// <summary>
    /// ShipStaticDataDimension
    /// </summary>
    [DataContract(Name = "ShipStaticData_Dimension")]
    public partial class ShipStaticDataDimension : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipStaticDataDimension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipStaticDataDimension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipStaticDataDimension" /> class.
        /// </summary>
        /// <param name="a">a (required).</param>
        /// <param name="b">b (required).</param>
        /// <param name="c">c (required).</param>
        /// <param name="d">d (required).</param>
        public ShipStaticDataDimension(int a = default(int), int b = default(int), int c = default(int), int d = default(int))
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }

        /// <summary>
        /// Gets or Sets A
        /// </summary>
        [DataMember(Name = "A", IsRequired = true, EmitDefaultValue = true)]
        public int A { get; set; }

        /// <summary>
        /// Gets or Sets B
        /// </summary>
        [DataMember(Name = "B", IsRequired = true, EmitDefaultValue = true)]
        public int B { get; set; }

        /// <summary>
        /// Gets or Sets C
        /// </summary>
        [DataMember(Name = "C", IsRequired = true, EmitDefaultValue = true)]
        public int C { get; set; }

        /// <summary>
        /// Gets or Sets D
        /// </summary>
        [DataMember(Name = "D", IsRequired = true, EmitDefaultValue = true)]
        public int D { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipStaticDataDimension {\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
            sb.Append("  D: ").Append(D).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

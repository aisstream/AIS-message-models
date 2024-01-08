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
    /// InterrogationStation1Msg2
    /// </summary>
    [DataContract(Name = "Interrogation_Station1Msg2")]
    public partial class InterrogationStation1Msg2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterrogationStation1Msg2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InterrogationStation1Msg2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterrogationStation1Msg2" /> class.
        /// </summary>
        /// <param name="valid">valid (required).</param>
        /// <param name="spare">spare (required).</param>
        /// <param name="messageID">messageID (required).</param>
        /// <param name="slotOffset">slotOffset (required).</param>
        public InterrogationStation1Msg2(bool valid = default(bool), int spare = default(int), int messageID = default(int), int slotOffset = default(int))
        {
            this.Valid = valid;
            this.Spare = spare;
            this.MessageID = messageID;
            this.SlotOffset = slotOffset;
        }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name = "Valid", IsRequired = true, EmitDefaultValue = true)]
        public bool Valid { get; set; }

        /// <summary>
        /// Gets or Sets Spare
        /// </summary>
        [DataMember(Name = "Spare", IsRequired = true, EmitDefaultValue = true)]
        public int Spare { get; set; }

        /// <summary>
        /// Gets or Sets MessageID
        /// </summary>
        [DataMember(Name = "MessageID", IsRequired = true, EmitDefaultValue = true)]
        public int MessageID { get; set; }

        /// <summary>
        /// Gets or Sets SlotOffset
        /// </summary>
        [DataMember(Name = "SlotOffset", IsRequired = true, EmitDefaultValue = true)]
        public int SlotOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterrogationStation1Msg2 {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Spare: ").Append(Spare).Append("\n");
            sb.Append("  MessageID: ").Append(MessageID).Append("\n");
            sb.Append("  SlotOffset: ").Append(SlotOffset).Append("\n");
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

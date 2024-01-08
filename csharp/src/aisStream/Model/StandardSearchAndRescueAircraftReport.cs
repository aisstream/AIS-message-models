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
    /// StandardSearchAndRescueAircraftReport
    /// </summary>
    [DataContract(Name = "StandardSearchAndRescueAircraftReport")]
    public partial class StandardSearchAndRescueAircraftReport : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardSearchAndRescueAircraftReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StandardSearchAndRescueAircraftReport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardSearchAndRescueAircraftReport" /> class.
        /// </summary>
        /// <param name="messageID">messageID (required).</param>
        /// <param name="repeatIndicator">repeatIndicator (required).</param>
        /// <param name="userID">userID (required).</param>
        /// <param name="valid">valid (required).</param>
        /// <param name="altitude">altitude (required).</param>
        /// <param name="sog">sog (required).</param>
        /// <param name="positionAccuracy">positionAccuracy (required).</param>
        /// <param name="longitude">longitude (required).</param>
        /// <param name="latitude">latitude (required).</param>
        /// <param name="cog">cog (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="altFromBaro">altFromBaro (required).</param>
        /// <param name="spare1">spare1 (required).</param>
        /// <param name="dte">dte (required).</param>
        /// <param name="spare2">spare2 (required).</param>
        /// <param name="assignedMode">assignedMode (required).</param>
        /// <param name="raim">raim (required).</param>
        /// <param name="communicationStateIsItdma">communicationStateIsItdma (required).</param>
        /// <param name="communicationState">communicationState (required).</param>
        public StandardSearchAndRescueAircraftReport(int messageID = default(int), int repeatIndicator = default(int), int userID = default(int), bool valid = default(bool), int altitude = default(int), double sog = default(double), bool positionAccuracy = default(bool), double longitude = default(double), double latitude = default(double), double cog = default(double), int timestamp = default(int), bool altFromBaro = default(bool), int spare1 = default(int), bool dte = default(bool), int spare2 = default(int), bool assignedMode = default(bool), bool raim = default(bool), bool communicationStateIsItdma = default(bool), int communicationState = default(int))
        {
            this.MessageID = messageID;
            this.RepeatIndicator = repeatIndicator;
            this.UserID = userID;
            this.Valid = valid;
            this.Altitude = altitude;
            this.Sog = sog;
            this.PositionAccuracy = positionAccuracy;
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Cog = cog;
            this.Timestamp = timestamp;
            this.AltFromBaro = altFromBaro;
            this.Spare1 = spare1;
            this.Dte = dte;
            this.Spare2 = spare2;
            this.AssignedMode = assignedMode;
            this.Raim = raim;
            this.CommunicationStateIsItdma = communicationStateIsItdma;
            this.CommunicationState = communicationState;
        }

        /// <summary>
        /// Gets or Sets MessageID
        /// </summary>
        [DataMember(Name = "MessageID", IsRequired = true, EmitDefaultValue = true)]
        public int MessageID { get; set; }

        /// <summary>
        /// Gets or Sets RepeatIndicator
        /// </summary>
        [DataMember(Name = "RepeatIndicator", IsRequired = true, EmitDefaultValue = true)]
        public int RepeatIndicator { get; set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [DataMember(Name = "UserID", IsRequired = true, EmitDefaultValue = true)]
        public int UserID { get; set; }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name = "Valid", IsRequired = true, EmitDefaultValue = true)]
        public bool Valid { get; set; }

        /// <summary>
        /// Gets or Sets Altitude
        /// </summary>
        [DataMember(Name = "Altitude", IsRequired = true, EmitDefaultValue = true)]
        public int Altitude { get; set; }

        /// <summary>
        /// Gets or Sets Sog
        /// </summary>
        [DataMember(Name = "Sog", IsRequired = true, EmitDefaultValue = true)]
        public double Sog { get; set; }

        /// <summary>
        /// Gets or Sets PositionAccuracy
        /// </summary>
        [DataMember(Name = "PositionAccuracy", IsRequired = true, EmitDefaultValue = true)]
        public bool PositionAccuracy { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "Longitude", IsRequired = true, EmitDefaultValue = true)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "Latitude", IsRequired = true, EmitDefaultValue = true)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Cog
        /// </summary>
        [DataMember(Name = "Cog", IsRequired = true, EmitDefaultValue = true)]
        public double Cog { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "Timestamp", IsRequired = true, EmitDefaultValue = true)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets AltFromBaro
        /// </summary>
        [DataMember(Name = "AltFromBaro", IsRequired = true, EmitDefaultValue = true)]
        public bool AltFromBaro { get; set; }

        /// <summary>
        /// Gets or Sets Spare1
        /// </summary>
        [DataMember(Name = "Spare1", IsRequired = true, EmitDefaultValue = true)]
        public int Spare1 { get; set; }

        /// <summary>
        /// Gets or Sets Dte
        /// </summary>
        [DataMember(Name = "Dte", IsRequired = true, EmitDefaultValue = true)]
        public bool Dte { get; set; }

        /// <summary>
        /// Gets or Sets Spare2
        /// </summary>
        [DataMember(Name = "Spare2", IsRequired = true, EmitDefaultValue = true)]
        public int Spare2 { get; set; }

        /// <summary>
        /// Gets or Sets AssignedMode
        /// </summary>
        [DataMember(Name = "AssignedMode", IsRequired = true, EmitDefaultValue = true)]
        public bool AssignedMode { get; set; }

        /// <summary>
        /// Gets or Sets Raim
        /// </summary>
        [DataMember(Name = "Raim", IsRequired = true, EmitDefaultValue = true)]
        public bool Raim { get; set; }

        /// <summary>
        /// Gets or Sets CommunicationStateIsItdma
        /// </summary>
        [DataMember(Name = "CommunicationStateIsItdma", IsRequired = true, EmitDefaultValue = true)]
        public bool CommunicationStateIsItdma { get; set; }

        /// <summary>
        /// Gets or Sets CommunicationState
        /// </summary>
        [DataMember(Name = "CommunicationState", IsRequired = true, EmitDefaultValue = true)]
        public int CommunicationState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StandardSearchAndRescueAircraftReport {\n");
            sb.Append("  MessageID: ").Append(MessageID).Append("\n");
            sb.Append("  RepeatIndicator: ").Append(RepeatIndicator).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Altitude: ").Append(Altitude).Append("\n");
            sb.Append("  Sog: ").Append(Sog).Append("\n");
            sb.Append("  PositionAccuracy: ").Append(PositionAccuracy).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Cog: ").Append(Cog).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  AltFromBaro: ").Append(AltFromBaro).Append("\n");
            sb.Append("  Spare1: ").Append(Spare1).Append("\n");
            sb.Append("  Dte: ").Append(Dte).Append("\n");
            sb.Append("  Spare2: ").Append(Spare2).Append("\n");
            sb.Append("  AssignedMode: ").Append(AssignedMode).Append("\n");
            sb.Append("  Raim: ").Append(Raim).Append("\n");
            sb.Append("  CommunicationStateIsItdma: ").Append(CommunicationStateIsItdma).Append("\n");
            sb.Append("  CommunicationState: ").Append(CommunicationState).Append("\n");
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

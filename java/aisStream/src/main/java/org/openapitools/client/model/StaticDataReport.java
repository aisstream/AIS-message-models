/*
 * Ais-Stream WebsocketObjects
 * OpenAPI 3.0 definitions for the data models used by aisstream.io.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import org.openapitools.client.model.StaticDataReportReportA;
import org.openapitools.client.model.StaticDataReportReportB;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import org.openapitools.client.JSON;

/**
 * StaticDataReport
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-06-27T20:57:25.293422-07:00[America/Vancouver]")
public class StaticDataReport {
  public static final String SERIALIZED_NAME_MESSAGE_I_D = "MessageID";
  @SerializedName(SERIALIZED_NAME_MESSAGE_I_D)
  private Integer messageID;

  public static final String SERIALIZED_NAME_REPEAT_INDICATOR = "RepeatIndicator";
  @SerializedName(SERIALIZED_NAME_REPEAT_INDICATOR)
  private Integer repeatIndicator;

  public static final String SERIALIZED_NAME_USER_I_D = "UserID";
  @SerializedName(SERIALIZED_NAME_USER_I_D)
  private Integer userID;

  public static final String SERIALIZED_NAME_VALID = "Valid";
  @SerializedName(SERIALIZED_NAME_VALID)
  private Boolean valid;

  public static final String SERIALIZED_NAME_RESERVED = "Reserved";
  @SerializedName(SERIALIZED_NAME_RESERVED)
  private Integer reserved;

  public static final String SERIALIZED_NAME_PART_NUMBER = "PartNumber";
  @SerializedName(SERIALIZED_NAME_PART_NUMBER)
  private Boolean partNumber;

  public static final String SERIALIZED_NAME_REPORT_A = "ReportA";
  @SerializedName(SERIALIZED_NAME_REPORT_A)
  private StaticDataReportReportA reportA;

  public static final String SERIALIZED_NAME_REPORT_B = "ReportB";
  @SerializedName(SERIALIZED_NAME_REPORT_B)
  private StaticDataReportReportB reportB;

  public StaticDataReport() { 
  }

  public StaticDataReport messageID(Integer messageID) {
    
    this.messageID = messageID;
    return this;
  }

   /**
   * Get messageID
   * @return messageID
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getMessageID() {
    return messageID;
  }


  public void setMessageID(Integer messageID) {
    this.messageID = messageID;
  }


  public StaticDataReport repeatIndicator(Integer repeatIndicator) {
    
    this.repeatIndicator = repeatIndicator;
    return this;
  }

   /**
   * Get repeatIndicator
   * @return repeatIndicator
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getRepeatIndicator() {
    return repeatIndicator;
  }


  public void setRepeatIndicator(Integer repeatIndicator) {
    this.repeatIndicator = repeatIndicator;
  }


  public StaticDataReport userID(Integer userID) {
    
    this.userID = userID;
    return this;
  }

   /**
   * Get userID
   * @return userID
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getUserID() {
    return userID;
  }


  public void setUserID(Integer userID) {
    this.userID = userID;
  }


  public StaticDataReport valid(Boolean valid) {
    
    this.valid = valid;
    return this;
  }

   /**
   * Get valid
   * @return valid
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Boolean getValid() {
    return valid;
  }


  public void setValid(Boolean valid) {
    this.valid = valid;
  }


  public StaticDataReport reserved(Integer reserved) {
    
    this.reserved = reserved;
    return this;
  }

   /**
   * Get reserved
   * @return reserved
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getReserved() {
    return reserved;
  }


  public void setReserved(Integer reserved) {
    this.reserved = reserved;
  }


  public StaticDataReport partNumber(Boolean partNumber) {
    
    this.partNumber = partNumber;
    return this;
  }

   /**
   * Get partNumber
   * @return partNumber
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Boolean getPartNumber() {
    return partNumber;
  }


  public void setPartNumber(Boolean partNumber) {
    this.partNumber = partNumber;
  }


  public StaticDataReport reportA(StaticDataReportReportA reportA) {
    
    this.reportA = reportA;
    return this;
  }

   /**
   * Get reportA
   * @return reportA
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public StaticDataReportReportA getReportA() {
    return reportA;
  }


  public void setReportA(StaticDataReportReportA reportA) {
    this.reportA = reportA;
  }


  public StaticDataReport reportB(StaticDataReportReportB reportB) {
    
    this.reportB = reportB;
    return this;
  }

   /**
   * Get reportB
   * @return reportB
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public StaticDataReportReportB getReportB() {
    return reportB;
  }


  public void setReportB(StaticDataReportReportB reportB) {
    this.reportB = reportB;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StaticDataReport staticDataReport = (StaticDataReport) o;
    return Objects.equals(this.messageID, staticDataReport.messageID) &&
        Objects.equals(this.repeatIndicator, staticDataReport.repeatIndicator) &&
        Objects.equals(this.userID, staticDataReport.userID) &&
        Objects.equals(this.valid, staticDataReport.valid) &&
        Objects.equals(this.reserved, staticDataReport.reserved) &&
        Objects.equals(this.partNumber, staticDataReport.partNumber) &&
        Objects.equals(this.reportA, staticDataReport.reportA) &&
        Objects.equals(this.reportB, staticDataReport.reportB);
  }

  @Override
  public int hashCode() {
    return Objects.hash(messageID, repeatIndicator, userID, valid, reserved, partNumber, reportA, reportB);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StaticDataReport {\n");
    sb.append("    messageID: ").append(toIndentedString(messageID)).append("\n");
    sb.append("    repeatIndicator: ").append(toIndentedString(repeatIndicator)).append("\n");
    sb.append("    userID: ").append(toIndentedString(userID)).append("\n");
    sb.append("    valid: ").append(toIndentedString(valid)).append("\n");
    sb.append("    reserved: ").append(toIndentedString(reserved)).append("\n");
    sb.append("    partNumber: ").append(toIndentedString(partNumber)).append("\n");
    sb.append("    reportA: ").append(toIndentedString(reportA)).append("\n");
    sb.append("    reportB: ").append(toIndentedString(reportB)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("MessageID");
    openapiFields.add("RepeatIndicator");
    openapiFields.add("UserID");
    openapiFields.add("Valid");
    openapiFields.add("Reserved");
    openapiFields.add("PartNumber");
    openapiFields.add("ReportA");
    openapiFields.add("ReportB");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("MessageID");
    openapiRequiredFields.add("RepeatIndicator");
    openapiRequiredFields.add("UserID");
    openapiRequiredFields.add("Valid");
    openapiRequiredFields.add("Reserved");
    openapiRequiredFields.add("PartNumber");
    openapiRequiredFields.add("ReportA");
    openapiRequiredFields.add("ReportB");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to StaticDataReport
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (StaticDataReport.openapiRequiredFields.isEmpty()) {
          return;
        } else { // has required fields
          throw new IllegalArgumentException(String.format("The required field(s) %s in StaticDataReport is not found in the empty JSON string", StaticDataReport.openapiRequiredFields.toString()));
        }
      }

      Set<Entry<String, JsonElement>> entries = jsonObj.entrySet();
      // check to see if the JSON string contains additional fields
      for (Entry<String, JsonElement> entry : entries) {
        if (!StaticDataReport.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `StaticDataReport` properties. JSON: %s", entry.getKey(), jsonObj.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : StaticDataReport.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      // validate the optional field `ReportA`
      if (jsonObj.getAsJsonObject("ReportA") != null) {
        StaticDataReportReportA.validateJsonObject(jsonObj.getAsJsonObject("ReportA"));
      }
      // validate the optional field `ReportB`
      if (jsonObj.getAsJsonObject("ReportB") != null) {
        StaticDataReportReportB.validateJsonObject(jsonObj.getAsJsonObject("ReportB"));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!StaticDataReport.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'StaticDataReport' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<StaticDataReport> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(StaticDataReport.class));

       return (TypeAdapter<T>) new TypeAdapter<StaticDataReport>() {
           @Override
           public void write(JsonWriter out, StaticDataReport value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public StaticDataReport read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             return thisAdapter.fromJsonTree(jsonObj);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of StaticDataReport given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of StaticDataReport
  * @throws IOException if the JSON string is invalid with respect to StaticDataReport
  */
  public static StaticDataReport fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, StaticDataReport.class);
  }

 /**
  * Convert an instance of StaticDataReport to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


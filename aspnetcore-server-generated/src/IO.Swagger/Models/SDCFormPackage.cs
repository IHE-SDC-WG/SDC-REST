/*
 * IHE Structured Data Capture API
 *
 * This is the test of the SDC REST API   [SDC REST API Doc](https://goo.gl/YLo7Fq) and more on SDC at  [http://wiki.ihe.net/index.php/Structured_Data_Capture](http://wiki.ihe.net/index.php/Structured_Data_Capture). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: sdcworkgroup@ihe.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class SDCFormPackage :  IEquatable<SDCFormPackage>
    { 
        /// <summary>
        /// Gets or Sets BaseURI
        /// </summary>
        [Required]
        [DataMember(Name="baseURI")]
        public string BaseURI { get; set; }

        /// <summary>
        /// Gets or Sets ContentDomain
        /// </summary>
        [Required]
        [DataMember(Name="contentDomain")]
        public string ContentDomain { get; set; }

        /// <summary>
        /// Gets or Sets SdcSchemaVersion
        /// </summary>
        [Required]
        [DataMember(Name="sdcSchemaVersion")]
        public string SdcSchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets PkgLineage
        /// </summary>
        [Required]
        [DataMember(Name="pkgLineage")]
        public string PkgLineage { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [Required]
        [DataMember(Name="version")]
        public List<string> Version { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [Required]
        [DataMember(Name="offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDCFormPackage {\n");
            sb.Append("  BaseURI: ").Append(BaseURI).Append("\n");
            sb.Append("  ContentDomain: ").Append(ContentDomain).Append("\n");
            sb.Append("  SdcSchemaVersion: ").Append(SdcSchemaVersion).Append("\n");
            sb.Append("  PkgLineage: ").Append(PkgLineage).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SDCFormPackage)obj);
        }

        /// <summary>
        /// Returns true if SDCFormPackage instances are equal
        /// </summary>
        /// <param name="other">Instance of SDCFormPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDCFormPackage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BaseURI == other.BaseURI ||
                    BaseURI != null &&
                    BaseURI.Equals(other.BaseURI)
                ) && 
                (
                    ContentDomain == other.ContentDomain ||
                    ContentDomain != null &&
                    ContentDomain.Equals(other.ContentDomain)
                ) && 
                (
                    SdcSchemaVersion == other.SdcSchemaVersion ||
                    SdcSchemaVersion != null &&
                    SdcSchemaVersion.Equals(other.SdcSchemaVersion)
                ) && 
                (
                    PkgLineage == other.PkgLineage ||
                    PkgLineage != null &&
                    PkgLineage.Equals(other.PkgLineage)
                ) && 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.SequenceEqual(other.Version)
                ) && 
                (
                    Offset == other.Offset ||
                    Offset != null &&
                    Offset.Equals(other.Offset)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (BaseURI != null)
                    hashCode = hashCode * 59 + BaseURI.GetHashCode();
                    if (ContentDomain != null)
                    hashCode = hashCode * 59 + ContentDomain.GetHashCode();
                    if (SdcSchemaVersion != null)
                    hashCode = hashCode * 59 + SdcSchemaVersion.GetHashCode();
                    if (PkgLineage != null)
                    hashCode = hashCode * 59 + PkgLineage.GetHashCode();
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                    if (Offset != null)
                    hashCode = hashCode * 59 + Offset.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SDCFormPackage left, SDCFormPackage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SDCFormPackage left, SDCFormPackage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

/* 
 * Gestão de Contratos
 *
 * API de Gestão de Contratos.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Entidade representando uma parcela de um contrato na saida da operação de recuperação de parcelas de um contrato.
    /// </summary>
    [DataContract]
    public partial class GetParcelasResponse :  IEquatable<GetParcelasResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetParcelasResponse" /> class.
        /// </summary>
        /// <param name="Parcelas">Parcelas.</param>
        public GetParcelasResponse(List<GetParcelasParcelaResponse> Parcelas = default(List<GetParcelasParcelaResponse>))
        {
            this.Parcelas = Parcelas;
        }
        
        /// <summary>
        /// Gets or Sets Parcelas
        /// </summary>
        [DataMember(Name="parcelas", EmitDefaultValue=false)]
        public List<GetParcelasParcelaResponse> Parcelas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetParcelasResponse {\n");
            sb.Append("  Parcelas: ").Append(Parcelas).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetParcelasResponse);
        }

        /// <summary>
        /// Returns true if GetParcelasResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetParcelasResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetParcelasResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parcelas == input.Parcelas ||
                    this.Parcelas != null &&
                    this.Parcelas.SequenceEqual(input.Parcelas)
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
                int hashCode = 41;
                if (this.Parcelas != null)
                    hashCode = hashCode * 59 + this.Parcelas.GetHashCode();
                return hashCode;
            }
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

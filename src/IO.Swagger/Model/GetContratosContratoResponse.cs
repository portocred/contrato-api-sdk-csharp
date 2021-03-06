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
    /// Entidade representando um contrato.
    /// </summary>
    [DataContract]
    public partial class GetContratosContratoResponse :  IEquatable<GetContratosContratoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContratosContratoResponse" /> class.
        /// </summary>
        /// <param name="CodigoContrato">Código do contrato..</param>
        /// <param name="Parcelas">Parcelas.</param>
        public GetContratosContratoResponse(string CodigoContrato = default(string), List<GetContratosParcelaResponse> Parcelas = default(List<GetContratosParcelaResponse>))
        {
            this.CodigoContrato = CodigoContrato;
            this.Parcelas = Parcelas;
        }
        
        /// <summary>
        /// Código do contrato.
        /// </summary>
        /// <value>Código do contrato.</value>
        [DataMember(Name="codigoContrato", EmitDefaultValue=false)]
        public string CodigoContrato { get; set; }

        /// <summary>
        /// Gets or Sets Parcelas
        /// </summary>
        [DataMember(Name="parcelas", EmitDefaultValue=false)]
        public List<GetContratosParcelaResponse> Parcelas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetContratosContratoResponse {\n");
            sb.Append("  CodigoContrato: ").Append(CodigoContrato).Append("\n");
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
            return this.Equals(input as GetContratosContratoResponse);
        }

        /// <summary>
        /// Returns true if GetContratosContratoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContratosContratoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContratosContratoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodigoContrato == input.CodigoContrato ||
                    (this.CodigoContrato != null &&
                    this.CodigoContrato.Equals(input.CodigoContrato))
                ) && 
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
                if (this.CodigoContrato != null)
                    hashCode = hashCode * 59 + this.CodigoContrato.GetHashCode();
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

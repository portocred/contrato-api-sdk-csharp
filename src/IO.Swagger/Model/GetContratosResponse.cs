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
    /// Entidade representando a saída da operação de recuperação de contratos.
    /// </summary>
    [DataContract]
    public partial class GetContratosResponse :  IEquatable<GetContratosResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContratosResponse" /> class.
        /// </summary>
        /// <param name="CpfCliente">CPF do cliente..</param>
        /// <param name="NomeCliente">Nome do cliente..</param>
        /// <param name="Contratos">Contratos.</param>
        public GetContratosResponse(string CpfCliente = default(string), string NomeCliente = default(string), List<GetContratosContratoResponse> Contratos = default(List<GetContratosContratoResponse>))
        {
            this.CpfCliente = CpfCliente;
            this.NomeCliente = NomeCliente;
            this.Contratos = Contratos;
        }
        
        /// <summary>
        /// CPF do cliente.
        /// </summary>
        /// <value>CPF do cliente.</value>
        [DataMember(Name="cpfCliente", EmitDefaultValue=false)]
        public string CpfCliente { get; set; }

        /// <summary>
        /// Nome do cliente.
        /// </summary>
        /// <value>Nome do cliente.</value>
        [DataMember(Name="nomeCliente", EmitDefaultValue=false)]
        public string NomeCliente { get; set; }

        /// <summary>
        /// Gets or Sets Contratos
        /// </summary>
        [DataMember(Name="contratos", EmitDefaultValue=false)]
        public List<GetContratosContratoResponse> Contratos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetContratosResponse {\n");
            sb.Append("  CpfCliente: ").Append(CpfCliente).Append("\n");
            sb.Append("  NomeCliente: ").Append(NomeCliente).Append("\n");
            sb.Append("  Contratos: ").Append(Contratos).Append("\n");
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
            return this.Equals(input as GetContratosResponse);
        }

        /// <summary>
        /// Returns true if GetContratosResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContratosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContratosResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CpfCliente == input.CpfCliente ||
                    (this.CpfCliente != null &&
                    this.CpfCliente.Equals(input.CpfCliente))
                ) && 
                (
                    this.NomeCliente == input.NomeCliente ||
                    (this.NomeCliente != null &&
                    this.NomeCliente.Equals(input.NomeCliente))
                ) && 
                (
                    this.Contratos == input.Contratos ||
                    this.Contratos != null &&
                    this.Contratos.SequenceEqual(input.Contratos)
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
                if (this.CpfCliente != null)
                    hashCode = hashCode * 59 + this.CpfCliente.GetHashCode();
                if (this.NomeCliente != null)
                    hashCode = hashCode * 59 + this.NomeCliente.GetHashCode();
                if (this.Contratos != null)
                    hashCode = hashCode * 59 + this.Contratos.GetHashCode();
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

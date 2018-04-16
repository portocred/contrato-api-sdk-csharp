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
    /// Objeto de resposta para a eventos com erro.
    /// </summary>
    [DataContract]
    public partial class ErroResponse :  IEquatable<ErroResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErroResponse" /> class.
        /// </summary>
        /// <param name="Mensagem">Mensagem de retorno..</param>
        /// <param name="Complemento">Complemento da mensagem de retorno..</param>
        public ErroResponse(string Mensagem = default(string), string Complemento = default(string))
        {
            this.Mensagem = Mensagem;
            this.Complemento = Complemento;
        }
        
        /// <summary>
        /// Mensagem de retorno.
        /// </summary>
        /// <value>Mensagem de retorno.</value>
        [DataMember(Name="mensagem", EmitDefaultValue=false)]
        public string Mensagem { get; set; }

        /// <summary>
        /// Complemento da mensagem de retorno.
        /// </summary>
        /// <value>Complemento da mensagem de retorno.</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErroResponse {\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
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
            return this.Equals(input as ErroResponse);
        }

        /// <summary>
        /// Returns true if ErroResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ErroResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErroResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mensagem == input.Mensagem ||
                    (this.Mensagem != null &&
                    this.Mensagem.Equals(input.Mensagem))
                ) && 
                (
                    this.Complemento == input.Complemento ||
                    (this.Complemento != null &&
                    this.Complemento.Equals(input.Complemento))
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
                if (this.Mensagem != null)
                    hashCode = hashCode * 59 + this.Mensagem.GetHashCode();
                if (this.Complemento != null)
                    hashCode = hashCode * 59 + this.Complemento.GetHashCode();
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
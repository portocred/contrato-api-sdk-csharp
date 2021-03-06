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
    /// Entidade representando uma parcela de um contrato na saida da operação de solicitação de pagamentos.
    /// </summary>
    [DataContract]
    public partial class SolicitacaoPagamentoParcelaResponse :  IEquatable<SolicitacaoPagamentoParcelaResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Situacao
        /// </summary>
        [DataMember(Name="situacao", EmitDefaultValue=false)]
        public SituacaoParcela? Situacao { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitacaoPagamentoParcelaResponse" /> class.
        /// </summary>
        /// <param name="CodigoContrato">Código do contrato..</param>
        /// <param name="NumeroParcela">Número da parcela..</param>
        /// <param name="PMT">Código da parcela..</param>
        /// <param name="ValorPago">Valor pago..</param>
        /// <param name="DataVencimento">Data do vencimento..</param>
        /// <param name="Situacao">Situacao.</param>
        public SolicitacaoPagamentoParcelaResponse(string CodigoContrato = default(string), string NumeroParcela = default(string), double? PMT = default(double?), double? ValorPago = default(double?), string DataVencimento = default(string), SituacaoParcela? Situacao = default(SituacaoParcela?))
        {
            this.CodigoContrato = CodigoContrato;
            this.NumeroParcela = NumeroParcela;
            this.PMT = PMT;
            this.ValorPago = ValorPago;
            this.DataVencimento = DataVencimento;
            this.Situacao = Situacao;
        }
        
        /// <summary>
        /// Código do contrato.
        /// </summary>
        /// <value>Código do contrato.</value>
        [DataMember(Name="codigoContrato", EmitDefaultValue=false)]
        public string CodigoContrato { get; set; }

        /// <summary>
        /// Número da parcela.
        /// </summary>
        /// <value>Número da parcela.</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public string NumeroParcela { get; set; }

        /// <summary>
        /// Código da parcela.
        /// </summary>
        /// <value>Código da parcela.</value>
        [DataMember(Name="PMT", EmitDefaultValue=false)]
        public double? PMT { get; set; }

        /// <summary>
        /// Valor pago.
        /// </summary>
        /// <value>Valor pago.</value>
        [DataMember(Name="valorPago", EmitDefaultValue=false)]
        public double? ValorPago { get; set; }

        /// <summary>
        /// Data do vencimento.
        /// </summary>
        /// <value>Data do vencimento.</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolicitacaoPagamentoParcelaResponse {\n");
            sb.Append("  CodigoContrato: ").Append(CodigoContrato).Append("\n");
            sb.Append("  NumeroParcela: ").Append(NumeroParcela).Append("\n");
            sb.Append("  PMT: ").Append(PMT).Append("\n");
            sb.Append("  ValorPago: ").Append(ValorPago).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  Situacao: ").Append(Situacao).Append("\n");
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
            return this.Equals(input as SolicitacaoPagamentoParcelaResponse);
        }

        /// <summary>
        /// Returns true if SolicitacaoPagamentoParcelaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SolicitacaoPagamentoParcelaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolicitacaoPagamentoParcelaResponse input)
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
                    this.NumeroParcela == input.NumeroParcela ||
                    (this.NumeroParcela != null &&
                    this.NumeroParcela.Equals(input.NumeroParcela))
                ) && 
                (
                    this.PMT == input.PMT ||
                    (this.PMT != null &&
                    this.PMT.Equals(input.PMT))
                ) && 
                (
                    this.ValorPago == input.ValorPago ||
                    (this.ValorPago != null &&
                    this.ValorPago.Equals(input.ValorPago))
                ) && 
                (
                    this.DataVencimento == input.DataVencimento ||
                    (this.DataVencimento != null &&
                    this.DataVencimento.Equals(input.DataVencimento))
                ) && 
                (
                    this.Situacao == input.Situacao ||
                    (this.Situacao != null &&
                    this.Situacao.Equals(input.Situacao))
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
                if (this.NumeroParcela != null)
                    hashCode = hashCode * 59 + this.NumeroParcela.GetHashCode();
                if (this.PMT != null)
                    hashCode = hashCode * 59 + this.PMT.GetHashCode();
                if (this.ValorPago != null)
                    hashCode = hashCode * 59 + this.ValorPago.GetHashCode();
                if (this.DataVencimento != null)
                    hashCode = hashCode * 59 + this.DataVencimento.GetHashCode();
                if (this.Situacao != null)
                    hashCode = hashCode * 59 + this.Situacao.GetHashCode();
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

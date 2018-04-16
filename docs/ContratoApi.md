# IO.Swagger.Api.ContratoApi

All URIs are relative to *https://dev-api.portocred.com.br/gestao-contrato/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContratosGet**](ContratoApi.md#contratosget) | **GET** /contratos | 
[**ContratosIdCancelamentoPut**](ContratoApi.md#contratosidcancelamentoput) | **PUT** /contratos/{id}/cancelamento | 
[**ContratosIdExclusaoPagamentoDelete**](ContratoApi.md#contratosidexclusaopagamentodelete) | **DELETE** /contratos/{id}/exclusao-pagamento | 
[**ContratosIdGet**](ContratoApi.md#contratosidget) | **GET** /contratos/{id} | 
[**ContratosIdSolicitacaoPagamentosPost**](ContratoApi.md#contratosidsolicitacaopagamentospost) | **POST** /contratos/{id}/solicitacao-pagamentos | 
[**ContratosParcelasGet**](ContratoApi.md#contratosparcelasget) | **GET** /contratos/parcelas | 
[**ContratosStatusGet**](ContratoApi.md#contratosstatusget) | **GET** /contratos/status | 


<a name="contratosget"></a>
# **ContratosGet**
> GetContratosResponse ContratosGet (string clientId, string accessToken, string codigoLojista, string cpf)



Esta funcionalidade tem como objetivo recuperar as informações de um contrato vinculado a um determinado cliente. Como resultado, será possível averiguar o saldo total deste contrato, além da lista de parcelas que o compõe, de forma detalhada, com informações especificas por parcela. Nesta modalidade de chamada, a pesquisa será realizada a partir do CPF do cliente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContratosGetExample
    {
        public void main()
        {
            var apiInstance = new ContratoApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var cpf = cpf_example;  // string | Cpf do cliente que possui o contrato.

            try
            {
                GetContratosResponse result = apiInstance.ContratosGet(clientId, accessToken, codigoLojista, cpf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContratoApi.ContratosGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **cpf** | **string**| Cpf do cliente que possui o contrato. | 

### Return type

[**GetContratosResponse**](GetContratosResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contratosidcancelamentoput"></a>
# **ContratosIdCancelamentoPut**
> ExclusaoPagamentoResponse ContratosIdCancelamentoPut (string clientId, string accessToken, string id, byte[] xAuthorization, string codigoLojista, string cpf, string operador)



Esta funcionalidade tem como objetivo cancelar um contrato no periódo D0 a D7 de um determinado cliente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContratosIdCancelamentoPutExample
    {
        public void main()
        {
            var apiInstance = new ContratoApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var id = id_example;  // string | O número do contrado a ser cancelado.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var cpf = cpf_example;  // string | Cpf do cliente que possui o contrato.
            var operador = operador_example;  // string | Código do operador.

            try
            {
                ExclusaoPagamentoResponse result = apiInstance.ContratosIdCancelamentoPut(clientId, accessToken, id, xAuthorization, codigoLojista, cpf, operador);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContratoApi.ContratosIdCancelamentoPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **id** | **string**| O número do contrado a ser cancelado. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **cpf** | **string**| Cpf do cliente que possui o contrato. | 
 **operador** | **string**| Código do operador. | 

### Return type

[**ExclusaoPagamentoResponse**](ExclusaoPagamentoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contratosidexclusaopagamentodelete"></a>
# **ContratosIdExclusaoPagamentoDelete**
> ExclusaoPagamentoResponse ContratosIdExclusaoPagamentoDelete (string clientId, string accessToken, string id, byte[] xAuthorization, string codigoLojista, string cpf, string operador)



Permitir a exclusão, apenas em D0, do pagamento mais recente de um contrato. É importante observar que um pagamento pode englobar uma ou várias parcelas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContratosIdExclusaoPagamentoDeleteExample
    {
        public void main()
        {
            var apiInstance = new ContratoApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var id = id_example;  // string | O número do contrado a ser cancelado.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var cpf = cpf_example;  // string | Cpf do cliente que possui o contrato.
            var operador = operador_example;  // string | Código do operador.

            try
            {
                ExclusaoPagamentoResponse result = apiInstance.ContratosIdExclusaoPagamentoDelete(clientId, accessToken, id, xAuthorization, codigoLojista, cpf, operador);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContratoApi.ContratosIdExclusaoPagamentoDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **id** | **string**| O número do contrado a ser cancelado. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **cpf** | **string**| Cpf do cliente que possui o contrato. | 
 **operador** | **string**| Código do operador. | 

### Return type

[**ExclusaoPagamentoResponse**](ExclusaoPagamentoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contratosidget"></a>
# **ContratosIdGet**
> GetContratosResponse ContratosIdGet (string id, string clientId, string accessToken, string codigoLojista)



Esta funcionalidade tem como objetivo recuperar as informações de um contrato vinculado a um determinado cliente. Como resultado, será possível averiguar o saldo total deste contrato, além da lista de parcelas que o compõe, de forma detalhada, com informações especificas por parcela. Nesta modalidade de chamada, a pesquisa será realizada a partir do código do contrato.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContratosIdGetExample
    {
        public void main()
        {
            var apiInstance = new ContratoApi();
            var id = id_example;  // string | Identificador do contrato.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).

            try
            {
                GetContratosResponse result = apiInstance.ContratosIdGet(id, clientId, accessToken, codigoLojista);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContratoApi.ContratosIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador do contrato. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 

### Return type

[**GetContratosResponse**](GetContratosResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contratosidsolicitacaopagamentospost"></a>
# **ContratosIdSolicitacaoPagamentosPost**
> SolicitacaoPagamentoResponse ContratosIdSolicitacaoPagamentosPost (string id, string clientId, string accessToken, SolicitacaoPagamentoRequest solicitacaoPagamento)



Esta funcionalidade tem como objetivo realizar uma solicitação de pagamento de parcelas em aberto de determinado contrato. Como resultado da solicitação, são retornadas as informações das parcelas que foram pagas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContratosIdSolicitacaoPagamentosPostExample
    {
        public void main()
        {
            var apiInstance = new ContratoApi();
            var id = id_example;  // string | Identificador do contrato.
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var solicitacaoPagamento = new SolicitacaoPagamentoRequest(); // SolicitacaoPagamentoRequest | Informações sobre o pagamento a ser realizado em um contrato.

            try
            {
                SolicitacaoPagamentoResponse result = apiInstance.ContratosIdSolicitacaoPagamentosPost(id, clientId, accessToken, solicitacaoPagamento);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContratoApi.ContratosIdSolicitacaoPagamentosPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador do contrato. | 
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **solicitacaoPagamento** | [**SolicitacaoPagamentoRequest**](SolicitacaoPagamentoRequest.md)| Informações sobre o pagamento a ser realizado em um contrato. | 

### Return type

[**SolicitacaoPagamentoResponse**](SolicitacaoPagamentoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contratosparcelasget"></a>
# **ContratosParcelasGet**
> GetParcelasResponse ContratosParcelasGet (string clientId, string accessToken, string codigoLojista, string cpf, string dataInicio, string dataFim)



Esta funcionalidade tem como objetivo recuperar as informações de parcelas pagas sobre um contrato vinculado a um determinado cliente, dentro de um período.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContratosParcelasGetExample
    {
        public void main()
        {
            var apiInstance = new ContratoApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var cpf = cpf_example;  // string | Cpf do cliente que possui o contrato.
            var dataInicio = dataInicio_example;  // string | Data de início da busca. Limitada a 90 dias anteriores à data de movimento atual. (Formato yyyy-MM-dd)
            var dataFim = dataFim_example;  // string | Data de fim da busca. Pode variar entre a data de movimento atual e os 90 dias que a antecedem. (Formato yyyy-MM-dd)

            try
            {
                GetParcelasResponse result = apiInstance.ContratosParcelasGet(clientId, accessToken, codigoLojista, cpf, dataInicio, dataFim);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContratoApi.ContratosParcelasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **cpf** | **string**| Cpf do cliente que possui o contrato. | 
 **dataInicio** | **string**| Data de início da busca. Limitada a 90 dias anteriores à data de movimento atual. (Formato yyyy-MM-dd) | 
 **dataFim** | **string**| Data de fim da busca. Pode variar entre a data de movimento atual e os 90 dias que a antecedem. (Formato yyyy-MM-dd) | 

### Return type

[**GetParcelasResponse**](GetParcelasResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contratosstatusget"></a>
# **ContratosStatusGet**
> GetStatusContratoResponse ContratosStatusGet (string clientId, string accessToken, string cpf)



Esta funcionalidade tem como objetivo recuperar as informações de status de um contrato vinculado a um determinado cliente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContratosStatusGetExample
    {
        public void main()
        {
            var apiInstance = new ContratoApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var cpf = cpf_example;  // string | Cpf do cliente que possui o contrato.

            try
            {
                GetStatusContratoResponse result = apiInstance.ContratosStatusGet(clientId, accessToken, cpf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContratoApi.ContratosStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **cpf** | **string**| Cpf do cliente que possui o contrato. | 

### Return type

[**GetStatusContratoResponse**](GetStatusContratoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


---
title: "Get informationProtectionPolicySetting"
description: "Fetch users-specific Microsoft Purview Information Protection policy settings for a user."
author: "tommoser"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# Get informationProtectionPolicySetting

Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of an [informationProtectionPolicySetting](../resources/security-informationprotectionpolicysetting.md) object. The settings exposed by this API should be used in applications to populate the **moreInfoUrl** property for Microsoft Purview Information Protection help, and indicate whether labeling is mandatory for the user and whether justification must be provided on downgrade.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | InformationProtectionPolicy.Read            |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | InformationProtectionPolicy.Read.All        |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

To get policy settings available to the signed-in user (delegated permission) or a specified user (application permission):

``` http
GET /users/{usersId}/security/informationProtection/labelPolicySettings
GET /me/security/informationProtection/labelPolicySettings
```

To get policy settings available to the organization as a service principal (application permission):

```http
GET /security/informationProtection/labelPolicySettings
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name          | Description                                                                                                                                                                       |
| :------------ | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Authorization | Bearer {token}. Required.                                                                                                                                                         |
| User-Agent    | Describes the name and version of the calling application. Details will surface in Azure Information Protection Analytics. Suggested format is `ApplicationName/Version`. Optional. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [informationProtectionPolicySetting](../resources/security-informationprotectionpolicysetting.md) object in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_informationprotectionpolicysetting",
  "sampleKeys": ["bob@contoso.com"]
}
-->
``` http
GET https://graph.microsoft.com/beta/users/bob@contoso.com/security/informationProtection/labelPolicySettings
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var informationProtectionPolicySetting = await graphClient.Users["{user-id}"].Security.InformationProtection.LabelPolicySettings
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "name": "get_informationprotectionpolicysetting",
  "truncated": true,
  "@odata.type": "microsoft.graph.security.informationProtectionPolicySetting"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://canary.graph.microsoft.com/testprodbetamipdev/$metadata#users('bob%40contoso.com')/security/informationProtection/labelPolicySettings/$entity",
    "id": "BFB31DC0E2183F5872EEC3FEC1A254B8118DF1156CC19E783EA6D36304242B7FCFA4CF1DA3374481AA9919D8F3D63F7C",
    "moreInfoUrl": "https://contoso.com/MIPInfo",
    "isMandatory": false,
    "isDowngradeJustificationRequired": true
}
```


---
title: "List files (localized agreement files)"
description: "Retrieve all localized files related to an agreement."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "raprakasMSFT"
---

# List files (localized agreement files)
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve all localized files related to an agreement.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | Agreement.Read.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |


## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /agreements/{agreementsId}?$expand=files
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [agreementFileLocalization](../resources/agreementfilelocalization.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_agreementfilelocalization"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/termsOfUse/agreements/94410bbf-3d3e-4683-8149-f034e55c39dd?$expand=files
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var agreement = await graphClient.IdentityGovernance.TermsOfUse.Agreements["{agreement-id}"]
	.Request()
	.Expand("files")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.agreementFileLocalization"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#agreements(files())/$entity",
    "id": "94410bbf-3d3e-4683-8149-f034e55c39dd",
    "displayName": "Contoso ToU for guest users",
    "termsExpiration": null,
    "userReacceptRequiredFrequency": null,
    "isViewingBeforeAcceptanceRequired": true,
    "isPerDeviceAcceptanceRequired": false,
    "files": [
        {
            "id": "08033369-8972-42a3-8533-90bbd2757a01",
            "fileName": "TOU.pdf",
            "displayName": "Contoso ToU for guest users",
            "language": "en",
            "isDefault": true,
            "isMajorVersion": false,
            "createdDateTime": "2022-03-04T13:14:13.9361722Z",
            "fileData": null
        },
        {
            "id": "90d1723c-52c1-40e3-a51a-da99a82c0327",
            "fileName": "Contoso ToU for guest users (French)",
            "displayName": "Contoso ToU for guest users (French)",
            "language": "fr-FR",
            "isDefault": false,
            "isMajorVersion": false,
            "createdDateTime": "2022-03-04T14:38:22.8292386Z",
            "fileData": null
        }
    ]
}
```


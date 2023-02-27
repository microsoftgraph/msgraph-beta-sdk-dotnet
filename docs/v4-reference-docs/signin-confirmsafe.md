---
title: "signIn: confirmSafe"
description: "Allow admins to mark Azure AD sign in events as safe for Azure AD Identity Protection."
author: "besiler"
ms.localizationpriority: medium
ms.prod: "identity-and-access-reports"
doc_type: apiPageType
---

# signIn: confirmSafe
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Allow admins to mark an event in Azure AD sign in logs as safe. Admins can either mark the events flagged as risky by Azure AD Identity Protection as safe, or they can mark unflagged events as safe. For details about investigating Identity Protection risks, see [How to investigate risk](/azure/active-directory/identity-protection/howto-identity-protection-investigate-risk).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|IdentityRiskyUser.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|IdentityRiskEvent.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /auditLogs/signIns/confirmSafe
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|requestIds|String collection|The IDs of the sign in events that should be marked safe for Azure AD Identity Protection.|



## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "signinthis.confirmsafe"
}
-->
``` http
POST https://graph.microsoft.com/beta/auditLogs/signIns/confirmSafe
Content-Type: application/json

{
  "requestIds": [
    "5a0c76d2-cb57-4ece-9bc1-c323178f116a",
    "96609214-09ef-4f80-9d4a-ace5fceecaec",
    "05020696-4eb8-45a3-918f-8f8bb7ad6015"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var requestIds = new List<String>()
{
	"5a0c76d2-cb57-4ece-9bc1-c323178f116a",
	"96609214-09ef-4f80-9d4a-ace5fceecaec",
	"05020696-4eb8-45a3-918f-8f8bb7ad6015"
};

await graphClient.AuditLogs.SignIns
	.ConfirmSafe(requestIds)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```


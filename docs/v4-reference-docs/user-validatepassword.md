---
title: "user: validatePassword"
description: "Check a user's password against the organization's password validation policy and report whether the password is valid."
author: "yyuank"
ms.localizationpriority: medium
ms.prod: "users"
doc_type: apiPageType
---

# user: validatePassword
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Check a user's password against the organization's password validation policy and report whether the password is valid. Use this action to provide real-time feedback on password strength while the user types their password.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)| User.ReadWrite, User.ReadWrite.All |
|Delegated (personal Microsoft account)| Not supported. |
|Application| Not supported. |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /users/validatePassword
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply JSON representation of the parameters.

The following table shows the parameters that are required with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|password|String| The password to be validated by this action.|

## Response

If successful, this action returns a `200 OK` response code and a [passwordValidationInformation](../resources/passwordvalidationinformation.md) object in the response body.

## Examples 

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_validatepassword"
}
-->
``` http
POST https://graph.microsoft.com/beta/users/validatePassword
Content-Type: application/json

{
    "password": "1234567890"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var password = "1234567890";

await graphClient.Users
	.ValidatePassword(password)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.passwordValidationInformation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#users/$entity",
    "isValid": false,
    "validationResults": [
        {
            "ruleName": "password_not_meet_complexity",
            "validationPassed": false,
            "message": "Password does not meet complexity requirements."
        }
    ]
}
```


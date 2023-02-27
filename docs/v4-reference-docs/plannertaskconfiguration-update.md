---
title: "Update plannerTaskConfiguration"
description: "Update the properties of a plannerTaskConfiguration object."
author: "TarkanSevilmis"
ms.localizationpriority: medium
ms.prod: "business-scenarios"
doc_type: apiPageType
---

# Update plannerTaskConfiguration

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [plannerTaskConfiguration](../resources/plannertaskconfiguration.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BusinessScenarioConfig.ReadWrite.OwnedBy, BusinessScenarioConfig.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|BusinessScenarioConfig.ReadWrite.OwnedBy|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /solutions/businessScenarios/{businessScenarioId}/planner/taskConfiguration
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

|Property|Type|Description|
|:---|:---|:---|
|editPolicy|[plannerTaskPolicy](../resources/plannertaskpolicy.md)|Policy configuration for tasks created for a [businessScenario](../resources/businessscenario.md) when they are being changed outside of the scenario. Optional.|

## Response

If successful, this method returns a `200 OK` response code and an updated [plannerTaskConfiguration](../resources/plannertaskconfiguration.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_plannertaskconfiguration",
  "sampleKeys": ["c5d514e6c6864911ac46c720affb6e4d"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/solutions/businessScenarios/c5d514e6c6864911ac46c720affb6e4d/planner/taskConfiguration
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerTaskConfiguration",
  "editPolicy": {
    "rules": [
      {
        "defaultRule": "block",
        "role": {
          "@odata.type": "#microsoft.graph.plannerRelationshipBasedUserType",
          "roleKind": "relationship",
          "role": "defaultRules"
        },
        "propertyRule": {
          "percentComplete": ["allow"],
          "ruleKind": "taskRule",
          "assignments": {
            "defaultRules": ["addSelf"],
            "overrides": []
          }
        }
      },
      {
        "defaultRule": "block",
        "role": {
          "@odata.type": "#microsoft.graph.plannerRelationshipBasedUserType",
          "roleKind": "relationship",
          "role": "taskAssignees"
        },
        "propertyRule": {
          "startDate": ["allow"],
          "dueDate": ["allow"],
          "percentComplete": ["allow"],
          "order": ["allow"],
          "ruleKind": "taskRule",
          "references": {
            "defaultRules": ["allow"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["allow"]
              },
              {
                "name": "applicationCreated",
                "rules": ["block"]
              }
            ]
          },
          "checkLists": {
            "defaultRules": ["allow"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["allow"]
              },
              {
                "name": "applicationCreated",
                "rules": ["check"]
              }
            ]
          },
          "assignments": {
            "defaultRules": ["block"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["removeSelf"]
              },
              {
                "name": "applicationCreated",
                "rules": ["check"]
              }
            ]
          },
          "appliedCategories": {
            "defaultRules": [
              "allow"
            ],
            "overrides": []
          }
        }
      }
    ]
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerTaskConfiguration = new PlannerTaskConfiguration
{
	EditPolicy = new PlannerTaskPolicy
	{
		Rules = new List<PlannerTaskRoleBasedRule>()
		{
			new PlannerTaskRoleBasedRule
			{
				DefaultRule = "block",
				Role = new PlannerRelationshipBasedUserType
				{
					RoleKind = PlannerUserRoleKind.Relationship,
					Role = PlannerRelationshipUserRoles.DefaultRules
				},
				PropertyRule = new PlannerTaskPropertyRule
				{
					PercentComplete = new List<String>()
					{
						"allow"
					},
					RuleKind = PlannerRuleKind.TaskRule,
					Assignments = new PlannerFieldRules
					{
						DefaultRules = new List<String>()
						{
							"addSelf"
						},
						Overrides = new List<PlannerRuleOverride>()
						{
						}
					}
				}
			},
			new PlannerTaskRoleBasedRule
			{
				DefaultRule = "block",
				Role = new PlannerRelationshipBasedUserType
				{
					RoleKind = PlannerUserRoleKind.Relationship,
					Role = PlannerRelationshipUserRoles.TaskAssignees
				},
				PropertyRule = new PlannerTaskPropertyRule
				{
					StartDate = new List<String>()
					{
						"allow"
					},
					DueDate = new List<String>()
					{
						"allow"
					},
					PercentComplete = new List<String>()
					{
						"allow"
					},
					Order = new List<String>()
					{
						"allow"
					},
					RuleKind = PlannerRuleKind.TaskRule,
					References = new PlannerFieldRules
					{
						DefaultRules = new List<String>()
						{
							"allow"
						},
						Overrides = new List<PlannerRuleOverride>()
						{
							new PlannerRuleOverride
							{
								Name = "userCreated",
								Rules = new List<PlannerRuleOverride>()
								{
									"allow"
								}
							},
							new PlannerRuleOverride
							{
								Name = "applicationCreated",
								Rules = new List<PlannerRuleOverride>()
								{
									"block"
								}
							}
						}
					},
					CheckLists = new PlannerFieldRules
					{
						DefaultRules = new List<String>()
						{
							"allow"
						},
						Overrides = new List<PlannerRuleOverride>()
						{
							new PlannerRuleOverride
							{
								Name = "userCreated",
								Rules = new List<PlannerRuleOverride>()
								{
									"allow"
								}
							},
							new PlannerRuleOverride
							{
								Name = "applicationCreated",
								Rules = new List<PlannerRuleOverride>()
								{
									"check"
								}
							}
						}
					},
					Assignments = new PlannerFieldRules
					{
						DefaultRules = new List<String>()
						{
							"block"
						},
						Overrides = new List<PlannerRuleOverride>()
						{
							new PlannerRuleOverride
							{
								Name = "userCreated",
								Rules = new List<PlannerRuleOverride>()
								{
									"removeSelf"
								}
							},
							new PlannerRuleOverride
							{
								Name = "applicationCreated",
								Rules = new List<PlannerRuleOverride>()
								{
									"check"
								}
							}
						}
					},
					AppliedCategories = new PlannerFieldRules
					{
						DefaultRules = new List<String>()
						{
							"allow"
						},
						Overrides = new List<PlannerRuleOverride>()
						{
						}
					}
				}
			}
		}
	}
};

await graphClient.Solutions.BusinessScenarios["{businessScenario-id}"].Planner.TaskConfiguration
	.Request()
	.UpdateAsync(plannerTaskConfiguration);

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
  "@odata.type": "microsoft.graph.plannerTaskConfiguration"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerTaskConfiguration",
  "id": "52be01e6291f403aa49f2b9f5288ab48",
  "editPolicy": {
    "rules": [
      {
        "defaultRule": "block",
        "role": {
          "@odata.type": "#microsoft.graph.plannerRelationshipBasedUserType",
          "roleKind": "relationship",
          "role": "defaultRules"
        },
        "propertyRule": {
          "move": [],
          "delete": [],
          "title": [],
          "notes": [],
          "priority": [],
          "startDate": [],
          "dueDate": [],
          "percentComplete": ["allow"],
          "order": [],
          "previewType": [],
          "ruleKind": "taskRule",
          "references": null,
          "checkLists": null,
          "assignments": {
            "defaultRules": ["addSelf"],
            "overrides": []
          },
          "appliedCategories": null
        }
      },
      {
        "defaultRule": "block",
        "role": {
          "@odata.type": "#microsoft.graph.plannerRelationshipBasedUserType",
          "roleKind": "relationship",
          "role": "taskAssignees"
        },
        "propertyRule": {
          "move": [],
          "delete": [],
          "title": [],
          "notes": [],
          "priority": [],
          "startDate": ["allow"],
          "dueDate": ["allow"],
          "percentComplete": ["allow"],
          "order": ["allow"],
          "previewType": [],
          "ruleKind": "taskRule",
          "references": {
            "defaultRules": ["allow"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["allow"]
              },
              {
                "name": "applicationCreated",
                "rules": ["block"]
              }
            ]
          },
          "checkLists": {
            "defaultRules": ["allow"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["allow"]
              },
              {
                "name": "applicationCreated",
                "rules": ["check"]
              }
            ]
          },
          "assignments": {
            "defaultRules": ["block"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["removeSelf"]
              },
              {
                "name": "applicationCreated",
                "rules": ["check"]
              }
            ]
          },
          "appliedCategories": {
            "defaultRules": [
              "allow"
            ],
            "overrides": []
          }
        }
      }
    ]
  }
}
```

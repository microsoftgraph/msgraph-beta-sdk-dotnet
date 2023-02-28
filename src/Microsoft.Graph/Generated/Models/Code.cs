namespace Microsoft.Graph.Beta.Models {
    /// <summary>Error code for rule validation.</summary>
    public enum Code {
        /// <summary>None error.</summary>
        None,
        /// <summary>Json file invalid error.</summary>
        JsonFileInvalid,
        /// <summary>Json file missing error.</summary>
        JsonFileMissing,
        /// <summary>Json file too large error.</summary>
        JsonFileTooLarge,
        /// <summary>Rules missing error.</summary>
        RulesMissing,
        /// <summary>Duplicate rules error.</summary>
        DuplicateRules,
        /// <summary>Too many rules specified error.</summary>
        TooManyRulesSpecified,
        /// <summary>Operator missing error.</summary>
        OperatorMissing,
        /// <summary>Operator not supported error.</summary>
        OperatorNotSupported,
        /// <summary>Data type missing error.</summary>
        DatatypeMissing,
        /// <summary>Data type not supported error.</summary>
        DatatypeNotSupported,
        /// <summary>Operator data type combination not supported error.</summary>
        OperatorDataTypeCombinationNotSupported,
        /// <summary>More info urlmissing error.</summary>
        MoreInfoUriMissing,
        /// <summary>More info url invalid error.</summary>
        MoreInfoUriInvalid,
        /// <summary>More info ur ltoo large error.</summary>
        MoreInfoUriTooLarge,
        /// <summary>Description missing error.</summary>
        DescriptionMissing,
        /// <summary>Description invalid error.</summary>
        DescriptionInvalid,
        /// <summary>Description too large error.</summary>
        DescriptionTooLarge,
        /// <summary>Title missing error.</summary>
        TitleMissing,
        /// <summary>Title invalid error.</summary>
        TitleInvalid,
        /// <summary>Title too large error.</summary>
        TitleTooLarge,
        /// <summary>Operand missing error.</summary>
        OperandMissing,
        /// <summary>Operand invalid error.</summary>
        OperandInvalid,
        /// <summary>Operand too large error.</summary>
        OperandTooLarge,
        /// <summary>Setting name missing error.</summary>
        SettingNameMissing,
        /// <summary>Setting name invalid error.</summary>
        SettingNameInvalid,
        /// <summary>Setting name too large error.</summary>
        SettingNameTooLarge,
        /// <summary>English locale missing error.</summary>
        EnglishLocaleMissing,
        /// <summary>Duplicate locales error.</summary>
        DuplicateLocales,
        /// <summary>Unrecognized locale error.</summary>
        UnrecognizedLocale,
        /// <summary>Unknown error.</summary>
        Unknown,
        /// <summary>Remediation strings missing error.</summary>
        RemediationStringsMissing,
    }
}

namespace DeepSigma.AutoML.Enums.Data;

/// <summary>
/// Specifies the types of censoring that can occur in data, which can impact the analysis and interpretation of statistical models. 
/// Censoring occurs when the true value of an observation is only partially known or is subject to certain limitations, leading to incomplete information about the distribution and characteristics of the data.
/// </summary>
public enum CensorType
{
    /// <summary>
    /// Indicates that the data is left-censored, meaning that the true value of an observation is only known to be less than or equal to a certain threshold. 
    /// This type of censoring occurs when the measurement instrument or data collection process cannot detect values below a specific limit, resulting in incomplete information about the true distribution of the data.
    /// This can also refer to a situation where the “event of interest” has already occurred before the start of the “study.”
    /// </summary>
    LeftCensor,
    /// <summary>
    /// Indicates that the data is right-censored, meaning that the true value of an observation is only known to be greater than or equal to a certain threshold. 
    /// This type of censoring occurs when the measurement instrument or data collection process cannot detect values above a specific limit, resulting in incomplete information about the true distribution of the data.
    /// This can also refer to a situation where the “event of interest” has not yet occurred by the end of the “study.”
    /// </summary>
    RightCensor,
    /// <summary>
    /// Indicates that the data is interval-censored, meaning that the true value of an observation is only known to lie within a certain interval defined by two thresholds. This type of censoring occurs when the measurement instrument or data collection process can only detect values within a specific range, resulting in incomplete information about the true distribution of the data.
    /// </summary>
    IntervalCensor,
    /// <summary>
    /// Indicates that the data is uncensored, meaning that the true value of each observation is fully observed and not subject to any censoring. 
    /// In this case, all values are known and can be used for analysis without any adjustments for censoring, allowing for a complete understanding of the distribution and characteristics of the data.
    /// </summary>
    Uncensored
}

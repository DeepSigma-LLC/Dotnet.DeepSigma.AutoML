namespace DeepSigma.AutoML.Enums.TimeSeries;

/// <summary>
/// Specifies the types of issues that can occur in time series data, which may impact the accuracy and reliability of forecasting models.
/// </summary>
public enum TimeSeriesIssueType
{
    /// <summary>
    /// Indicates the presence of lookahead bias in the time series data, where future information is inadvertently used to inform past predictions, leading to overly optimistic forecasting results.
    /// </summary>
    Lookahead,
    /// <summary>
    /// Indicates the presence of structural changes in the time series data, such as shifts in trends, seasonality, or other underlying patterns, which can affect the performance and accuracy of forecasting models.
    /// </summary>
    StructualChange
}

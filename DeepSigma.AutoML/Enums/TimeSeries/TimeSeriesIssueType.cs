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
    StructualChange,
    /// <summary>
    /// Indicates the presence of dilution in the time series data, where the signal is weakened or obscured by noise, outliers, or irrelevant data points, making it more difficult for forecasting models to identify meaningful patterns and trends.
    /// It can occur when there is a high level of variability in the data, or when the data contains a large number of irrelevant features that do not contribute to the forecasting task, leading to reduced model performance and accuracy.
    /// </summary>
    /// <remarks>
    /// In some instances, dilution can be thought of as the opposite of lookahead bias, where instead of having too much information from the future, the model has too little relevant information from the past, making it challenging to make accurate predictions.
    /// </remarks>
    Dilution,
}

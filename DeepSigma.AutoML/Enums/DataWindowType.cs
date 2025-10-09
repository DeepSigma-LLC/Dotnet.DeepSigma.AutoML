
namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies the type of data windowing technique used for time series analysis or machine learning models.
/// </summary>
public enum DataWindowType
{
    /// <summary>
    /// RollingWindowSize indicates a fixed-size window that moves over the data, maintaining a constant number of observations as new data points are added and old ones are removed.
    /// </summary>
    RollingWindow,
    /// <summary>
    /// TiledWindow indicates a window that divides the data into non-overlapping segments or tiles, allowing for the analysis of distinct periods or intervals without overlap between them.
    /// </summary>
    TiledWindow,
    /// <summary>
    /// DynamicWindow indicates a window that can change its size based on certain criteria or conditions, allowing for more flexibility in capturing relevant data patterns over time.
    /// </summary>
    DynamicWindow,
    /// <summary>
    /// ExpandingWindow indicates a window that starts with a small size and gradually expands to include more data points over time, allowing for the incorporation of historical data as it becomes available.
    /// </summary>
    ExpandingWindow,
}

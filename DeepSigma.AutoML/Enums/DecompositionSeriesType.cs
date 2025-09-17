
namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the type of component in a time series decomposition.
    /// </summary>
    public enum DecompositionSeriesType
    {
        /// <summary>
        /// Trend component represents the long-term progression or direction of the time series data.
        /// </summary>
        Trend,
        /// <summary>
        /// Seasonal component represents periodic fluctuations that occur at regular intervals due to seasonal factors.
        /// </summary>
        Seasonal,
        /// <summary>
        /// Cyclical component captures long-term oscillations that do not have a fixed period and are often influenced by economic or business cycles.
        /// </summary>
        Cyclical,
        /// <summary>
        /// Residual component, also known as the irregular or noise component, represents random variations that cannot be attributed to trend, seasonal, or cyclical patterns.
        /// </summary>
        Residual
    }
}

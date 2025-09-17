

namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the type of self-correlation in a time series.
    /// </summary>
    public enum SelfCorrelationType
    {
        /// <summary>
        /// Serial autocorrelation, also known as lagged autocorrelation, refers to the correlation between a time series and a lagged version of itself over successive time intervals. 
        /// It measures the relationship between current values and past values of the same variable.
        /// </summary>
        SerialAutoCorrelation,
        /// <summary>
        /// Partial autocorrelation measures the correlation between a time series and its lagged values while controlling for the influence of intervening lags. 
        /// In other words, it quantifies the direct relationship between a variable and its past values, excluding the effects of other intermediate lags.
        /// </summary>
        PartialAutoCorrelation,
    }
}

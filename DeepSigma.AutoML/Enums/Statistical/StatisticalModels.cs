namespace DeepSigma.AutoML.Enums.Statistical;

/// <summary>
/// Specifies various statistical models used for time series analysis and forecasting.
/// </summary>
public enum StatisticalModels
{
    /// <summary>
    /// Autoregressive model is used for analyzing and forecasting time series data by modeling the current value of a variable as a linear combination of its past values.
    /// </summary>
    Autoregressive,
    /// <summary>
    /// Moving Average model is used for analyzing and forecasting time series data by modeling the current value of a variable as a linear combination of past error terms (shocks or innovations).
    /// </summary>
    MovingAverage,
    /// <summary>
    /// Autoregressive Moving Average model combines the features of Autoregressive (AR) and Moving Average (MA) models to analyze and forecast time series data by capturing both the influence of past values and past error terms on the current value.
    /// </summary>
    AutoregressiveMovingAverage,
    /// <summary>
    /// Autoregressive Integrated Moving Average model is used for analyzing and forecasting non-stationary time series data by incorporating differencing to achieve stationarity, along with the features of Autoregressive (AR) and Moving Average (MA) models.
    /// </summary>
    AutoregressiveIntegratedMovingAverage,
    /// <summary>
    /// Seasonal Autoregressive Integrated Moving Average model extends the Autoregressive Integrated Moving Average (ARIMA) model to account for seasonal patterns in time series data by incorporating seasonal differencing and seasonal autoregressive and moving average components.
    /// </summary>
    SeasonalAutoregressiveIntegratedMovingAverage,
    /// <summary>
    /// Vector Autoregression model is used for multivariate time series data to capture the linear interdependencies among multiple variables over time.
    /// </summary>
    VectorAutoregression,
    /// <summary>
    /// Vector Autoregressive Moving Average model combines the features of Vector Autoregression (VAR) and Moving Average (MA) models to analyze multivariate time series data, capturing both the linear interdependencies among multiple variables and the influence of past error terms on current values.
    /// </summary>
    VectorAutoregressiveMovingAverage,
    /// <summary>
    /// Vector Autoregressive Integrated Moving Average model is an extension of the Vector Autoregression (VAR) model that incorporates differencing to achieve stationarity in multivariate time series data, allowing for the analysis of long-term relationships and short-term dynamics among multiple interrelated variables.
    /// </summary>
    VectorAutoregressiveIntegratedMovingAverage,
    /// <summary>
    /// Autoregressive Conditional Heteroskedasticity model is used to model and forecast time series data with time-varying volatility, commonly applied in financial markets to analyze asset returns and their variances.
    /// </summary>
    ARCH,
    /// <summary>
    /// Generalized Autoregressive Conditional Heteroskedasticity model is used to model and forecast time series data with changing volatility over time, commonly applied in financial markets to analyze asset returns and their variances.
    /// </summary>
    GARCH,
    /// <summary>
    /// Cointegrated Vector Autoregression model (also known as Vector Error Correction Model - VECM) is used for multivariate time series data that are cointegrated, meaning they share a long-term equilibrium relationship despite being non-stationary individually. 
    /// VECM captures both short-term dynamics and long-term relationships among the variables.
    /// </summary>
    CointegratedVectorAutoregression,
}

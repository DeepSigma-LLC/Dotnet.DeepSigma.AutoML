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
    /// The SARIMA model shows more flexibility in how the amplitude of seasonality affects data over time compared to Dynamic Harmonic Regression, which models seasonality using fixed harmonic terms.
    /// Furthermore, SARIMA does a good job of caputuring seasonality for short seasonal patterns, but it can struggle to capture seasonality when the seasonal patterns are not consistent, when there are multiple seasonal periods, or when the seasons are long (think annual seasonaility). 
    /// In such cases, Dynamic Harmonic Regression can be a more effective approach for modeling complex and varying seasonal patterns in time series data.
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
    /// <summary>
    /// Hierarchical Models are statistical models that incorporate multiple levels of analysis or grouping structures, allowing for the modeling of complex relationships and dependencies within nested data.
    /// These models are particularly useful when data is organized at different levels. They enable the analysis of both individual-level and group-level effects simultaneously.
    /// </summary>
    HierarchicalModels,
    /// <summary>
    /// Dynamic Harmonic Regression model is used for analyzing and forecasting time series data with complex seasonal patterns by incorporating harmonic (sine and cosine) terms to capture the seasonal effects, allowing for more flexible modeling of seasonality compared to traditional seasonal models.
    /// This method uses Fourier series to represent the seasonal component of the time series, enabling it to capture a wide range of seasonal patterns, including those that are not strictly periodic or that change over time.
    /// SARIMA models typically use simple seasonal differencing to capture seasonality, while Dynamic Harmonic Regression can model more complex and varying seasonal patterns by including multiple harmonic terms, making it suitable for time series data with non-standard or changing seasonal behaviors.
    /// Although very unregular seasonal patterns can be difficult to capture with any model, Dynamic Harmonic Regression can often provide a more robust approach for forecasting time series data with intricate seasonal structures, especially when there are multiple seasonal periods, or when the seasons are long (think annual seasonaility).
    /// </summary>
    DynamicHarmonicRegression,
    /// <summary>
    /// Empirical Bayes model is a statistical approach that combines prior information with observed data to estimate parameters and make predictions, often used in situations where there is limited data or when the data is noisy, allowing for more robust inference and improved predictive performance by borrowing strength from related data or prior knowledge.
    /// </summary>
    EmpiricalBayes,
}

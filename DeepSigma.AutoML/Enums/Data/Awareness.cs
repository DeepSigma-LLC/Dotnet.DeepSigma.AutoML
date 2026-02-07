
namespace DeepSigma.AutoML.Enums.Data;

/// <summary>
/// Specifies the level of awareness of the data, which can be based on theoretical knowledge, empirical evidence, temporal dynamics, or contextual factors.
/// </summary>
public enum Awareness
{
    /// <summary>
    /// Data is based on human knowledge and understanding, which may be incomplete or biased, and may not capture the full complexity of the real world.
    /// Theoretical awareness can be achieved through techniques such as domain expertise, literature review, and theoretical modeling, which help to ensure that the data is based on sound principles and assumptions, improving the performance of machine learning models and other data-driven applications.
    /// </summary>
    TheoreticallyAware,
    /// <summary>
    /// Data is based on empirical evidence and observations, which may be more accurate and reliable than theoretical knowledge, but may still be limited by the quality and quantity of the data available.
    /// Empirical awareness can be achieved through techniques such as data collection, experimentation, and validation, which help to ensure that the data is representative and accurate, improving the performance of machine learning models and other data-driven applications.
    /// </summary>
    EmpiricallyAware,
    /// <summary>
    /// Data is dynamically aware, meaning data values or relationships may change (or be altered) over time with modelers' intervention, allowing for more flexible and responsive analysis and decision-making in dynamic environments.
    /// Note: you should think of this as offline learning with human intervention, where the model is updated periodically based on new data and insights, rather than continuously learning in real-time. 
    /// </summary>
    OfflineDyanmicallyAware,
    /// <summary>
    /// Data is temporally aware, meaning it takes into account the time dimension and how data may change over time, allowing for more accurate predictions and insights in dynamic environments.
    /// Dynamic time series analysis and forecasting models can help achieve temporal awareness by modeling the temporal dependencies and patterns in the data, improving performance in tasks like stock price prediction, weather forecasting, and demand forecasting.
    /// </summary>
    TemporallyAware,
    /// <summary>
    /// Data is contextually aware, meaning it considers the broader context and environment in which the data exists, allowing for more nuanced and accurate analysis and decision-making.
    /// Attention mechanisms in machine learning models, such as transformers, can help achieve contextual awareness by allowing the model to focus on relevant parts of the input data based on the context, improving performance in tasks like natural language processing and computer vision.
    /// </summary>
    ContextuallyAware,
    /// Data is adaptively aware, meaning it can adjust and learn from new information and changing conditions, allowing for more flexible and responsive analysis and decision-making.
    /// Adaptive learning algorithms, such as reinforcement learning and online learning, can help achieve adaptive awareness by allowing the model to learn and adapt in real-time based on feedback and changing conditions, improving performance in tasks like autonomous systems and personalized recommendations.
    AdaptiveAware
}

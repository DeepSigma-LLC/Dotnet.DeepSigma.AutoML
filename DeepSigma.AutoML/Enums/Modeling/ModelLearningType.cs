namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies the learning type of a model, indicating the approach used for training and making predictions.
/// </summary>
public enum ModelLearningType
{
    /// <summary>
    /// Statistical models rely on statistical methods and techniques to analyze data and make predictions based on patterns and relationships identified within the data.
    /// </summary>
    Statistical,
    /// <summary>
    /// Machine learning models utilize algorithms and computational techniques to learn from data, allowing them to improve their performance over time without being explicitly programmed for specific tasks.
    /// </summary>
    MachineLearning,
    /// <summary>
    /// Deep learning models are a subset of machine learning models that use artificial neural networks with multiple layers to learn and represent complex patterns and features in data, enabling them to perform tasks such as image recognition, natural language processing, and more.
    /// </summary>
    DeepLearning
}

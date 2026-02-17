namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies the primary objective or task that a machine learning model is designed to accomplish.
/// </summary>
public enum ModelObjectiveType
{
    /// <summary>
    /// Classification involves categorizing data points into predefined classes or labels based on their features.
    /// </summary>
    Classification,
    /// <summary>
    /// Regression involves predicting a continuous numerical value based on input features.
    /// </summary>
    Regression,
    /// <summary>
    /// Clustering involves grouping similar data points together based on their features without predefined labels.
    /// </summary>
    Clustering,
    /// <summary>
    /// AnomalyDetection involves identifying unusual patterns or outliers in data that deviate significantly from the norm.
    /// </summary>
    AnomalyDetection,
    /// <summary>
    /// DimensionalityReduction involves reducing the number of features or dimensions in a dataset while preserving important information.
    /// </summary>
    DimensionalityReduction,
    /// <summary>
    /// Forecasting involves predicting future values or trends based on historical data. 
    /// The difference between Forecasting and Regression is that Forecasting specifically focuses on time series data and temporal patterns, while Regression can be applied to a broader range of data types without a temporal component.
    /// </summary>
    Forecasting,
    /// <summary>
    /// ObjectDetection involves identifying and locating objects within images or videos.
    /// </summary>
    ObjectDetection,
    /// <summary>
    /// SemanticSearch involves retrieving relevant information from a large dataset based on the meaning and context of the query rather than just keyword matching.
    /// </summary>
    SemanticSearch,
    /// <summary>
    /// TopicModeling involves discovering abstract topics or themes within a collection of documents or text data, often using techniques like Latent Dirichlet Allocation (LDA) or Non-negative Matrix Factorization (NMF).
    /// </summary>
    TopicModeling,
}

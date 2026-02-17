
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Specifies the steps involved in a text clustering pipeline, which typically includes embedding generation, dimensionality reduction, and clustering algorithm application.
/// </summary>
public enum TextClusteringPipelineSteps
{
    /// <summary>
    /// EmbeddingGeneration refers to the process of converting text data into numerical vector representations (embeddings) that capture the semantic meaning of the text, often using techniques like word embeddings (e.g., Word2Vec, GloVe) or sentence embeddings (e.g., BERT, Sentence-BERT).
    /// </summary>
    EmbeddingGeneration,
    /// <summary>
    /// DimensionalityReduction refers to the process of reducing the number of features or dimensions in the embedding space while preserving important information, often using techniques like Principal Component Analysis (PCA), t-Distributed Stochastic Neighbor Embedding (t-SNE), or Uniform Manifold Approximation and Projection (UMAP) to facilitate clustering and visualization.
    /// </summary>
    DimensionalityReduction,
    /// <summary>
    /// ClusteringAlgorithm refers to the application of a clustering algorithm to group similar text data points together based on their embeddings, with common algorithms including K-Means, DBSCAN, Agglomerative Clustering, and Gaussian Mixture Models (GMM), which help identify natural groupings or clusters within the text data.
    /// </summary>
    ClusteringAlgorithm,
}

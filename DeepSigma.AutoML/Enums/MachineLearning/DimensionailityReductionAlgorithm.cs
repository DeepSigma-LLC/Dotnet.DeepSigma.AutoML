
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Specifies the algorithms used for dimensionality reduction in machine learning, which are techniques that reduce the number of features or dimensions in a dataset while preserving important information, often used for visualization, noise reduction, and improving model performance.
/// </summary>
public enum DimensionailityReductionAlgorithm
{
    /// <summary>
    /// Principal Component Analysis (PCA) is a linear dimensionality reduction technique that transforms the original features into a new set of uncorrelated features called principal components, which are ordered by the amount of variance they capture from the data. PCA is widely used for reducing the dimensionality of datasets while preserving as much variance as possible, making it useful for visualization, noise reduction, and improving the performance of machine learning algorithms.
    /// </summary>
    PrincipalComponentAnalysis,
    /// <summary>
    /// Uniform Manifold Approximation and Projection (UMAP) is a non-linear dimensionality reduction technique that preserves both local and global structure in the data. UMAP is particularly effective for visualizing high-dimensional data in lower dimensions (e.g., 2D or 3D) while maintaining the relationships between data points, making it a popular choice for tasks like clustering and visualization of complex datasets.
    /// </summary>
    UniformManifoldApproximationAndProjection,
}

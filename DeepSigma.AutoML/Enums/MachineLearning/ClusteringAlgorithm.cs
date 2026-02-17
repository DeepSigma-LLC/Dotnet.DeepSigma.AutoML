
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Specifies the clustering algorithms used for grouping similar data points together based on their features, which is a common task in unsupervised machine learning for discovering natural groupings or clusters within a dataset. 
/// Each algorithm has its own strengths and weaknesses, making them suitable for different types of data and clustering tasks.
/// </summary>
public enum ClusteringAlgorithm
{
    /// <summary>
    /// Density-Based Spatial Clustering of Applications with Noise (DBSCAN) is a clustering algorithm that groups together points that are closely packed together, marking as outliers points that lie alone in low-density regions. It is particularly effective for discovering clusters of arbitrary shape and handling noise in the data.
    /// </summary>
    DSCAN,
    /// <summary>
    /// K-Means is a popular clustering algorithm that partitions data into K distinct clusters based on feature similarity, where each data point belongs to the cluster with the nearest mean. It is efficient for large datasets but assumes clusters are spherical and of similar size, which may not always be the case.
    /// </summary>
    KMeans,
    /// <summary>
    /// Agglomerative Clustering is a hierarchical clustering algorithm that builds nested clusters by successively merging or splitting them based on a distance metric, allowing it to capture complex cluster structures and relationships in the data without requiring a predefined number of clusters.
    /// </summary>
    AgglomerativeClustering,
    /// <summary>
    /// Hierarchical Density-Based Spatial Clustering of Applications with Noise (HDBSCAN) is an extension of DBSCAN that builds a hierarchy of clusters based on varying density levels, allowing it to identify clusters of varying shapes and densities while effectively handling noise and outliers in the data.
    /// </summary>
    HDBSCAN,
    /// <summary>
    /// Gaussian Mixture Models (GMM) is a probabilistic clustering algorithm that models the data as a mixture of multiple Gaussian distributions, allowing for soft clustering where each data point can belong to multiple clusters with varying degrees of membership.
    /// GMM is particularly effective for modeling complex cluster shapes and handling overlapping clusters.
    /// </summary>
    GaussianMixtureModels,
    /// <summary>
    /// Spectral Clustering is a clustering algorithm that uses the eigenvalues of a similarity matrix to perform dimensionality reduction before applying a standard clustering algorithm like K-Means. It is effective for identifying clusters in data that is not well separated in the original feature space, making it suitable for complex datasets with non-convex cluster shapes.
    /// </summary>
    SpectralClustering,
    /// <summary>
    /// Mean Shift is a clustering algorithm that iteratively shifts data points towards the mode (highest density) of the data distribution, allowing it to discover clusters of arbitrary shape without requiring a predefined number of clusters. It is particularly effective for identifying clusters in data with varying densities and can handle noise and outliers effectively.
    /// </summary>
    MeanShift,
}

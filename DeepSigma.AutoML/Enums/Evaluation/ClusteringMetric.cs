
namespace DeepSigma.AutoML.Enums.Evaluation;

/// <summary>
/// ClusteringMetric specifies the various metrics used to evaluate the performance of clustering models, which are a type of unsupervised machine learning model that groups similar data points together based on their features or characteristics.
/// </summary>
public enum ClusteringMetric
{
    /// <summary>
    /// Silhouette Score is a metric used to evaluate the quality of clustering results by measuring how similar an object is to its own cluster compared to other clusters, with values ranging from -1 to 1, where a value close to 1 indicates that the object is well matched to its own cluster and poorly matched to neighboring clusters.
    /// On the other hand, a value close to -1 indicates that the object may have been assigned to the wrong cluster, and a value around 0 indicates that the object is on or very close to the decision boundary between two neighboring clusters.
    /// </summary>
    SilhouetteScore,
    /// <summary>
    /// Davies-Bouldin Index is a metric used to evaluate the quality of clustering results by measuring the average similarity between each cluster and its most similar cluster, with lower values indicating better clustering performance, as it indicates that the clusters are well separated and compact.
    /// On the other hand, higher values indicate that the clusters are less distinct and may have significant overlap.
    /// </summary>
    DaviesBouldinIndex,
    /// <summary>
    /// Homogeneity Score is a metric used to evaluate the quality of clustering results by measuring the extent to which each cluster contains only data points that belong to a single class, with values ranging from 0 to 1. 
    /// A value of 1 indicates that all clusters are perfectly homogeneous (i.e., each cluster contains only data points from a single class), while a value of 0 indicates that the clusters are completely heterogeneous (i.e., each cluster contains data points from multiple classes).
    /// </summary>
    HomogeneityScore,
    /// <summary>
    /// Completeness Score is a metric used to evaluate the quality of clustering results by measuring the extent to which all data points that belong to a single class are assigned to the same cluster, with values ranging from 0 to 1.
    /// A value of 1 indicates that all data points that belong to a single class are assigned to the same cluster (i.e., the clusters are complete), while a value of 0 indicates that the data points that belong to a single class are distributed across multiple clusters (i.e., the clusters are incomplete).
    /// </summary>
    CompletenessScore,
    /// <summary>
    /// V-Measure Score is a metric used to evaluate the quality of clustering results by measuring the harmonic mean of homogeneity and completeness scores, with values ranging from 0 to 1.
    /// A value of 1 indicates that the clusters are perfectly homogeneous and complete (i.e., each cluster contains only data points from a single class and all data points that belong to a single class are assigned to the same cluster), while a value of 0 indicates that the clusters are completely heterogeneous and incomplete (i.e., each cluster contains data points from multiple classes and the data points that belong to a single class are distributed across multiple clusters).
    /// </summary>
    VMeasureScore,
    /// <summary>
    /// Calinski-Harabasz Index, also known as the Variance Ratio Criterion, is a metric used to evaluate the quality of clustering results by measuring the ratio of the between-cluster variance to the within-cluster variance.
    /// Higher values indicating better clustering performance, as it indicates that the clusters are well separated and compact, while lower values indicate that the clusters are less distinct and may have significant overlap.
    /// </summary>
    CalinskiHarabaszIndex

}

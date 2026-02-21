
namespace DeepSigma.AutoML.Enums.Evaluation;

/// <summary>
/// DistanceMeasures is an enumeration that defines various distance measures used in machine learning and data analysis to quantify the similarity or dissimilarity between data points, which can be crucial for tasks such as clustering, classification, and regression, where the choice of distance measure can significantly impact the performance and accuracy of the models being developed.
/// </summary>
public enum DistanceMeasures
{
    EclideanDistance,
    ManhattanDistance,
    CosineSimilarity,
    PearsonCorrelationCoefficient,
    SpearmanRankCorrelationCoefficient
    MinkowskiDistance,
    ChebyshevDistance,
    HammingDistance,
    JaccardDistance,
}

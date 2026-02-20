namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// AdvancedLearningTechniques is an enumeration that defines various advanced learning techniques used in machine learning and deep learning models to enhance their performance, generalization, and ability to learn from data, particularly in scenarios where traditional learning methods may not be sufficient or effective.
/// </summary>
public enum AdvancedLearningTechniques
{


    /// <summary>
    /// Contrastive learning is a self-supervised learning technique that trains models to differentiate between similar and dissimilar data points by maximizing the agreement between positive pairs (similar data) and minimizing the agreement between negative pairs (dissimilar data), often used in tasks such as representation learning, clustering, and dimensionality reduction.
    /// For example, in image recognition, contrastive learning can be used to train a model to recognize that two different images of the same object (positive pair) are similar, while two images of different objects (negative pair) are dissimilar, without requiring explicit labels for the data.
    /// Learning is achieved by optimizing a contrastive loss function, which encourages the model to learn meaningful representations of the data that capture underlying similarities and differences, making it particularly effective for tasks where labeled data is scarce or unavailable.
    /// </summary>
    ContrastiveLearning,
}

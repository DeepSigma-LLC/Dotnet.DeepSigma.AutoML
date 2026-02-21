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
    /// <remarks>
    /// This technique is particularly useful in scenarios where labeled data is limited, as it allows models to learn from the inherent structure of the data itself, making it a powerful tool for unsupervised and self-supervised learning tasks across various domains, including computer vision, natural language processing, and recommendation systems.
    /// For example, rather than learning features from labeled data, a contrastive learning model can learn to group similar data points together and separate dissimilar ones, which can lead to improved performance in downstream tasks such as classification, clustering, and retrieval, even when the amount of labeled data is insufficient for traditional supervised learning methods.
    /// Essentially, the training process learns what makes data points similar and different, allowing the model to generalize better and capture more complex relationships in the data, which can lead to improved performance on a wide range of tasks, especially in scenarios where traditional supervised learning may struggle due to limited labeled data or complex data distributions.
    /// What makes a cat different from a dog? Contrastive learning helps the model learn these similarities (and more importantly dissimlarities) without needing explicit labels, making it a powerful technique for learning from data in a more flexible and efficient way.
    /// May be helpful in economic forecasting, where the model can learn to differentiate between similar economic indicators and dissimilar ones, improving its ability to make accurate predictions even when labeled data is scarce or noisy.
    /// </remarks>
    ContrastiveLearning,
}

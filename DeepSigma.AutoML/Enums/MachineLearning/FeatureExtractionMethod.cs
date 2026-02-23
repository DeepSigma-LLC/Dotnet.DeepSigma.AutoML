
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Specifies the methods used for feature extraction in machine learning, which is the process of transforming raw data into a format that can be effectively used by machine learning algorithms, often involving techniques such as manual feature engineering, automated feature selection, and hybrid approaches that combine both manual and automated methods to create a more robust and effective feature set for model training and prediction.
/// </summary>
public enum FeatureExtractionMethod
{
    /// <summary>
    /// Manual feature extraction involves the process of manually selecting and engineering features from raw data based on domain knowledge, intuition, and experience, which can be time-consuming and may require expertise in the specific domain, but can also lead to more interpretable and meaningful features that may improve model performance in certain cases.
    /// This is common in traditional machine learning approaches where domain experts identify relevant features based on their understanding of the data and the problem at hand, often involving techniques such as feature selection, feature transformation, and feature construction to create a more effective feature set for model training and prediction.
    /// </summary>
    Manual,
    /// <summary>
    /// Automated feature extraction involves the use of algorithms and techniques to automatically identify and extract relevant features from raw data without the need for manual intervention, which can save time and effort while also potentially discovering features that may not be immediately apparent to human experts.
    /// This approach is commonly used in modern machine learning and deep learning techniques, where algorithms such as principal component analysis (PCA), autoencoders, and convolutional neural networks (CNNs) can automatically learn and extract features from data, often leading to improved model performance and generalization on unseen data.
    /// </summary>
    Automated,
    /// <summary>
    /// Hybrid feature extraction combines both manual and automated approaches to leverage the strengths of both methods, allowing for a more comprehensive and effective feature set that can improve model performance while also maintaining interpretability and relevance to the specific domain and problem being addressed.
    /// This approach can often lead to better results by allowing domain experts to guide the feature extraction process while also utilizing automated techniques to discover additional features that may enhance model performance, making it a popular choice in many machine learning applications where both interpretability and performance are important considerations.
    /// </summary>
    Hybrid
}


namespace DeepSigma.AutoML.Enums.Data;

/// <summary>
/// SyntheticDataGenerationMethod is an enumeration that defines different methods for generating synthetic data, which can be used to augment existing datasets, address class imbalance, or create new data points for training machine learning models, where the choice of synthetic data generation method can significantly impact the quality and diversity of the generated data, as well as the performance of the models trained on that data in various applications such as classification, regression, and anomaly detection.
/// </summary>
public enum SyntheticDataGenerationMethod
{
    /// <summary>
    /// SMOTE (Synthetic Minority Over-sampling Technique) is a popular synthetic data generation method used to address class imbalance in machine learning datasets by creating synthetic samples of the minority class based on the existing samples, which can help improve the performance of machine learning models by providing more balanced training data and reducing bias towards the majority class.
    /// </summary>
    SMOTE,
    /// <summary>
    /// ADASYN (Adaptive Synthetic Sampling) is a synthetic data generation method that focuses on generating synthetic samples for the minority class in an adaptive manner, where more synthetic samples are generated for minority class samples that are harder to learn, which can help improve the performance of machine learning models by providing more informative and diverse training data for the minority class, especially in cases where there is a significant class imbalance.
    /// </summary>
    ADASYN,
    /// <summary>
    /// RandomOverSampling is a simple synthetic data generation method that involves randomly duplicating samples from the minority class to increase its representation in the dataset, which can help address class imbalance and improve the performance of machine learning models by providing more balanced training data, although it may not always be effective in cases where there is a significant imbalance or when the minority class has limited variability.
    /// </summary>
    RandomOverSampling,
    /// <summary>
    /// Augmentation is a synthetic data generation method that involves creating new samples by applying various transformations to existing data, such as rotation, scaling, flipping, or adding noise, which can help increase the diversity and variability of the training data, improve the generalization ability of machine learning models, and reduce overfitting, especially in cases where there is limited labeled data available for training.
    /// </summary>
    Augmentation,
    /// <summary>
    /// Distillation is a synthetic data generation method that involves training a smaller, simpler model (the student) to mimic the behavior of a larger, more complex model (the teacher) by using the teacher's predictions as soft labels for the student, which can help create synthetic data points that capture the knowledge and patterns learned by the teacher model, ultimately improving the performance of the student model on various tasks while reducing its computational complexity and resource requirements.
    /// </summary>
    Distallation,
    /// <summary>
    /// Simulation is a synthetic data generation method that involves creating synthetic data points by simulating the underlying processes or phenomena that generate the real data, which can help create realistic and diverse training data for machine learning models, especially in cases where collecting real data is difficult, expensive, or time-consuming, and can be particularly useful in domains such as healthcare, finance, and engineering where accurate modeling of complex systems is crucial for making informed decisions and improving predictive performance.
    /// </summary>
    Simulation,
    
}

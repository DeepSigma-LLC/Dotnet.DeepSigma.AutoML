
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Specifies the evaluation criteria used for assessing machine learning models.
/// </summary>
public enum ModelEvaluationCriterion
{
    /// <summary>
    /// Entropy criterion. Often used in decision trees for classification tasks.
    /// </summary>
    Entropy,
    /// <summary>
    /// Cross Entropy criterion. Commonly used for multi-class classification tasks.
    /// </summary>
    CrossEntropy,
    /// <summary>
    /// Log Loss criterion. Commonly used for evaluating the performance of classification models.
    /// </summary>
    LogLoss,
    /// <summary>
    /// Mean Squared Error criterion. Frequently used for regression tasks.
    /// </summary>
    MSE,
    /// <summary>
    /// Mean Absolute Error criterion. Another metric for regression tasks.
    /// </summary>
    MAE,
    /// <summary>
    /// Root Mean Squared Error criterion. Used for regression tasks, providing error in the same units as the target variable.
    /// </summary>
    RMSE,
}

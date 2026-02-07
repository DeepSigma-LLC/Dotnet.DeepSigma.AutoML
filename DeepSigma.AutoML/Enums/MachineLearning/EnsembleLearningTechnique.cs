
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Techniques for ensemble learning in machine learning.
/// </summary>
public enum EnsembleLearningTechnique
{
    /// <summary>
    /// Bagging (Bootstrap Aggregating) builds many models in parallel on random data subsets to reduce variance, like a diverse team voting (e.g., Random Forest).
    /// Bagging comes from "Bootstrap AGGregatING," which refers to the process of creating multiple datasets by sampling with replacement (bootstrap) and then aggregating the predictions from models trained on these datasets to improve overall performance and reduce variance.
    /// </summary>
    /// <remarks>
    /// The term "bagging" emphasizes the idea of combining multiple data sets (the "bags") to create a more robust and accurate overall model.
    /// </remarks>
    Bagging,
    /// <summary>
    /// Boosting builds models sequentially, with each new model correcting errors of the last, to reduce bias, making it powerful but prone to overfitting (e.g., AdaBoost, XGBoost).
    /// However, a penalty term can be added to the loss function to penalize complex models, helping to prevent overfitting.
    /// </summary>
    Boosting,
    /// <summary>
    /// Stacking combines multiple models by training a meta-model to learn how to best combine their predictions, leveraging the strengths of each base model for improved overall performance.
    /// </summary>
    Stacking,
}

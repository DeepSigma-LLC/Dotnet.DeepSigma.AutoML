namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies various techniques used to prevent overfitting in machine learning models, helping to improve their generalization and performance on unseen data.
/// </summary>
public enum ModelOverfittingPreventionTechniques
{
    /// <summary>
    /// EarlyStopping is a technique used to prevent overfitting in machine learning models by monitoring the model's performance on a validation set during training and stopping the training process when the performance starts to degrade.
    /// </summary>
    EarlyStopping,
    /// <summary>
    /// Dropout is a regularization technique used in neural networks to prevent overfitting by randomly "dropping out" (setting to zero) a fraction of the neurons during training, which helps to reduce reliance on specific neurons and encourages the network to learn more robust features.
    /// </summary>
    Dropout,
    /// <summary>
    /// Regularization involves adding a penalty term to the loss function during training to discourage complex models and reduce overfitting. Common types of regularization include L1 (Lasso) and L2 (Ridge) regularization.
    /// </summary>
    Regularization,
    /// <summary>
    /// CrossValidation is a technique used to assess the performance of a machine learning model by partitioning the data into multiple subsets (folds) and training and evaluating the model on different combinations of these subsets, which helps to ensure that the model generalizes well to unseen data and reduces the risk of overfitting.
    /// </summary>
    CrossValidation,
    /// <summary>
    /// DataAugmentation involves creating additional training data by applying various transformations (such as rotation, scaling, flipping, etc.) to the existing data, which helps to increase the diversity of the training set and reduce overfitting by exposing the model to a wider range of examples.
    /// </summary>
    DataAugmentation,
    /// <summary>
    /// EnsembleMethods involve combining multiple models (such as bagging, boosting, or stacking) to improve overall performance and reduce overfitting by leveraging the strengths of different models and averaging their predictions.
    /// </summary>
    EnsembleMethods
}

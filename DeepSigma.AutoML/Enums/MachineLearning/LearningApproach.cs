namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// MachineLearningModelType is an enumeration that defines the different types of machine learning models based on their learning approach and the nature of the data they are trained on.
/// </summary>
public enum LearningApproach
{
    /// <summary>
    /// Supervised learning is a type of machine learning where the model is trained on labeled data, meaning that each training example is paired with an output label. 
    /// The model learns to make predictions based on the input data and the corresponding labels, allowing it to generalize to new, unseen data. This approach is commonly used for tasks such as classification and regression.
    /// </summary>
    SupervisedLearning,
    /// <summary>
    /// Unsupervised learning is a type of machine learning where the model is trained on unlabeled data, meaning that the training examples do not have corresponding output labels. 
    /// The model learns to identify patterns and relationships in the data without any guidance, allowing it to discover hidden structures and insights. 
    /// This approach is commonly used for tasks such as clustering and dimensionality reduction.
    /// </summary>
    UnsupervisedLearning,
    /// <summary>
    /// Reinforcement learning is a type of machine learning where an agent learns to make decisions by interacting with an environment and receiving feedback in the form of rewards or penalties. 
    /// The agent learns to take actions that maximize cumulative rewards over time, allowing it to learn optimal strategies for achieving specific goals. 
    /// This approach is commonly used for tasks such as game playing, robotics, and autonomous systems.
    /// </summary>
    ReinforcementLearning,
    /// <summary>
    /// Self-supervised learning is a type of machine learning where the model learns to make predictions based on the input data itself, without relying on explicit labels or rewards. 
    /// The model generates its own labels or targets from the input data, allowing it to learn useful representations and features that can be used for downstream tasks.
    /// </summary>
    SelfSupervisedLearning,
}

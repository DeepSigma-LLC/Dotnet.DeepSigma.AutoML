
namespace DeepSigma.AutoML.Enums.LLM;

/// <summary>
/// Preference tuning techniques refer to the various methods and approaches used to optimize the performance of large language models (LLMs) based on user preferences or feedback.
/// </summary>
public enum PreferenceTuningTechnique
{
    /// <summary>
    /// Proximal policy optimization (PPO) is a reinforcement learning algorithm that is commonly used for training large language models (LLMs) to optimize their performance based on user preferences or feedback.
    /// Also known as "Reinforcement Learning from Human Feedback (RLHF)".
    /// PPO is a policy gradient method that uses a surrogate objective function to optimize the model's parameters while ensuring that the updates are not too large, which can help prevent overfitting and improve the stability of the training process.
    /// PPO is a popular reinforcement technique that optimizes the instruction-tuned LLM by making sure that the LLM does not deviate too much from the expected rewards.
    /// </summary>
    ProximalPolicyOptimization,
    /// <summary>
    /// Direct preference optimization (DPO) tuning is a technique that involves directly optimizing the model's parameters based on user preferences or feedback, rather than relying on a predefined reward function or objective.
    /// This approach can be more flexible and adaptable to individual user preferences, as it allows the model to learn directly from user feedback and adjust its behavior accordingly.
    /// </summary>
    DirectPreferenceOptimization,
    /// <summary>
    /// Odds ratio preference tuning is a technique that involves optimizing the model's parameters based on the odds ratio of user preferences or feedback, rather than directly optimizing the model's parameters based on user preferences or feedback.
    /// This approach can be useful for situations where user preferences are expressed in terms of relative comparisons or rankings, rather than absolute values, as it allows the model to learn from the relative preferences of users and adjust its behavior accordingly.
    /// This is a process that combines SFT and DPO into a single training process. 
    /// It removes the need to perform two separate training loops, further simplifying the training process while allowing for the use of QLoRA
    /// </summary>
    OddsRatioPreferenceTuning,

}

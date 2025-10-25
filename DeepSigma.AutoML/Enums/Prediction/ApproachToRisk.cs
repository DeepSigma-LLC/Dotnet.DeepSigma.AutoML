
namespace DeepSigma.AutoML.Enums.Prediction;

/// <summary>
/// Specifies the approach to risk in decision-making processes.
/// </summary>
public enum ApproachToRisk
{
    /// <summary>
    /// OverCautious indicates a risk-averse approach where decisions are made with a strong preference for minimizing potential losses, even if it means sacrificing potential gains.
    /// </summary>
    OverCautious,
    /// <summary>
    /// Balanced indicates a moderate approach to risk where decisions are made by carefully weighing potential gains against potential losses, aiming for an optimal balance between the two.
    /// </summary>
    Balanced,
    /// <summary>
    /// Decisive indicates a risk-taking approach where decisions are made with a willingness to accept higher potential losses in pursuit of greater potential gains.
    /// </summary>
    Decisive
}

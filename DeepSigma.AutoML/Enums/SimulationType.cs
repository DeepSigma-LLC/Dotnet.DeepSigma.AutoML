
namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies the type of simulation being performed, indicating the underlying approach or methodology used to model and analyze complex systems or phenomena.
/// </summary>
public enum SimulationType
{
    /// <summary>
    /// Heuristic simulations rely on practical, experience-based techniques and rules of thumb to model complex systems.
    /// </summary>
    Heuristic,
    /// <summary>
    /// Agent-based simulations model the interactions of autonomous agents to assess their effects on the system as a whole.
    /// </summary>
    AgentBased,
    /// <summary>
    /// Physics-based simulations use mathematical models based on physical laws to simulate real-world phenomena.
    /// </summary>
    PhysicsBased,
    /// <summary>
    /// Statistical simulations utilize statistical methods to analyze and predict the behavior of complex systems based on data.
    /// </summary>
    Statistical,
    /// <summary>
    /// Machine learning simulations employ algorithms that learn from data to make predictions or decisions without being explicitly programmed.
    /// Good when prior knowledge is limited, and patterns need to be discovered from data or when the system is too complex for traditional modeling approaches.
    /// Also, good when privacy concerns prevent the use of actual data.
    /// </summary>
    DeepLearning,
}

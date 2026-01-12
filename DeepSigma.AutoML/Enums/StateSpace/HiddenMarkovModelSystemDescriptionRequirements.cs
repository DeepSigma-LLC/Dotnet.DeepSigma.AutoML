
namespace DeepSigma.AutoML.Enums.StateSpace;

/// <summary>
/// Specifies the essential components required for defining a Hidden Markov Model (HMM) system description.
/// </summary>
public enum HiddenMarkovModelSystemDescriptionRequirements
{
    /// <summary>
    /// InitalState represents the initial state distribution of the Hidden Markov Model, specifying the probabilities of starting in each possible hidden state.
    /// </summary>
    InitalState,
    /// <summary>
    /// TransitionProbabilities represents the state transition probabilities of the Hidden Markov Model, defining the likelihood of transitioning from one hidden state to another.
    /// </summary>
    TransitionProbabilities,
    /// <summary>
    /// EmissionProbabilities represents the emission probabilities of the Hidden Markov Model, specifying the likelihood of observing a particular output given a specific hidden state.
    /// </summary>
    /// <remarks>
    /// This component is crucial for linking the hidden states to the observable data, allowing the model to generate predictions based on the underlying state dynamics.
    /// It is exceptionally important where states are not directly observable, and observations are used to infer the hidden states.
    /// </remarks>
    EmissionProbabilities
}

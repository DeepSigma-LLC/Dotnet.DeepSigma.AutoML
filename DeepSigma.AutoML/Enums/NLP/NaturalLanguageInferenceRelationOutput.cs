
namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// NaturalLanguageInferenceOutput is an enumeration that defines the possible output labels for natural language inference (NLI) tasks, which involve determining the relationship between a premise and a hypothesis in terms of entailment, contradiction, or neutrality.
/// Natural language inference is a fundamental task in natural language processing (NLP) that requires models to understand and reason about the relationships between different pieces of text, making it a crucial component for various applications such as question answering, information retrieval, and text understanding, where the ability to accurately classify the relationship between a premise and a hypothesis can significantly impact the performance and effectiveness of NLP systems in real-world scenarios.
/// Commonly used in contrastive learning and other advanced learning techniques, where the model learns to differentiate between similar and dissimilar data points by maximizing the agreement between positive pairs (similar data) and minimizing the agreement between negative pairs (dissimilar data), often used in tasks such as representation learning, clustering, and dimensionality reduction.
/// </summary>
public enum NaturalLanguageInferenceRelationOutput
{
    /// <summary>
    /// Entailment indicates that the hypothesis logically follows from the premise, meaning that if the premise is true, then the hypothesis must also be true.
    /// </summary>
    Entailment,
    /// <summary>
    /// Contradiction indicates that the hypothesis logically contradicts the premise, meaning that if the premise is true, then the hypothesis must be false.
    /// </summary>
    Contradiction,
    /// <summary>
    /// Neutral indicates that the relationship between the premise and hypothesis is neither entailment nor contradiction, meaning that the truth of the hypothesis cannot be determined solely based on the premise, and additional information may be needed to make a definitive judgment about their relationship.
    /// </summary>
    Neutral,
    
}

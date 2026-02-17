using System;
using System.Collections.Generic;
using System.Text;

namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// AttentionScope is an enumeration that defines the different scopes of attention mechanisms used in natural language processing (NLP) and machine learning models, particularly in transformer-based architectures.
/// </summary>
public enum AttentionScope
{
    /// <summary>
    /// Global attention allows the model to attend to all tokens in the input sequence, regardless of their position, enabling it to capture long-range dependencies and relationships between tokens that may be far apart in the sequence.
    /// This can be particularly beneficial for tasks that require understanding of the overall context or global structure of the input, such as machine translation or text summarization, where the relevant information may be distributed across the entire input sequence.
    /// However, global attention can be computationally expensive, especially for long input sequences, as it requires the model to compute interactions between all pairs of tokens, leading to increased memory and computational requirements.
    /// </summary>
    Globe,
    /// <summary>
    /// Local attention focuses on a specific region of the input sequence, allowing the model to attend to a limited context around each token.
    /// This can be particularly useful for tasks that require understanding of local dependencies, such as named entity recognition or part-of-speech tagging, where the relevant information is often found in a small window around the target token.
    /// It is also more computationally efficient than global attention, as it reduces the number of token interactions that need to be computed, making it suitable for longer input sequences where global attention may become computationally expensive.
    /// It is also known as "sparse attention" or "windowed attention" or "sliding window attention", as it allows the model to attend to a specific window of tokens around each target token, rather than attending to the entire input sequence as in global attention.
    /// </summary>
    Local,
}

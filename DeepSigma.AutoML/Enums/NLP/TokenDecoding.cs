
namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// TokenDecoding is an enumeration that defines different methods for decoding tokens in the context of natural language processing (NLP) and machine learning.
/// </summary>
public enum TokenDecoding
{
    /// <summary>
    /// GreedyDecoding is a token decoding method that selects the most probable token at each step of the decoding process, without considering the overall sequence of tokens or the context of the generated text.
    /// This method is simple and efficient but can lead to suboptimal results, as it may get stuck in local maxima and fail to explore alternative token sequences that could yield better results.
    /// This is equivalant to setting the temperature parameter to 0 in a language model, which makes the model deterministic and always selects the most likely token at each step, resulting in less diverse and more predictable output.
    /// </summary>
    GreedyDecoding,
    /// <summary>
    /// BeamSearch is a token decoding method that maintains a fixed number of candidate sequences (beams) at each step of the decoding process, allowing it to explore multiple token sequences simultaneously and select the most promising ones based on their cumulative probabilities.
    /// This method is more computationally expensive than greedy decoding but can yield better results by considering a wider range of possible token sequences and avoiding local maxima.
    /// </summary>
    BeamSearch,
    /// <summary>
    /// TopKSampling is a token decoding method that selects the next token from the top K most probable tokens at each step of the decoding process, where K is a predefined parameter.
    /// This method introduces randomness into the decoding process, allowing for more diverse and creative output while still maintaining a focus on the most likely tokens.
    /// </summary>
    TopKSampling,
    /// <summary>
    /// TopPSampling, also known as nucleus sampling, is a token decoding method that selects the next token from the smallest set of tokens whose cumulative probability exceeds a predefined threshold P.
    /// This method allows for more dynamic and adaptive token selection, as it considers the overall distribution of token probabilities rather than just the top K tokens, leading to more diverse and contextually relevant output while still maintaining a focus on the most likely tokens.
    /// This method is particularly effective in generating creative and coherent text, as it can adapt to the specific context of the generated text and avoid selecting low-probability tokens that may lead to incoherent or irrelevant output.
    /// </summary>
    TopPSampling,
}


namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// LanguageModelType is an enumeration that defines the different types of language models used in natural language processing (NLP) and machine learning.
/// </summary>
public enum LanguageModelType
{
    /// <summary>
    /// Representation models is a high-level category of language models that focuses representing text data in a way that captures its semantic meaning and contextual information.
    /// These models are usually encoder-only architectures that are designed to understand and represent the input text rather than generating new text.
    /// This category may refer to models that generate embeddings or vector representations of text or classification models that assign labels to text data based on its content and context.
    /// </summary>
    RepresentationModel,
    /// <summary>
    /// Generative models is a high-level category of language models that focuses on generating human-like text based on a given input or prompt.
    /// These models are usually decoder-only architectures that are designed to generate new text rather than just understanding and representing the input text.
    /// </summary>
    GenerationModel,
}

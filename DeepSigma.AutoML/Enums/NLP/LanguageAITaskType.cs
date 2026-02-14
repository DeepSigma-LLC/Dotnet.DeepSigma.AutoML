

namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// LanguageAITaskType is an enumeration that defines the different types of tasks that can be performed using language AI models. 
/// Each task type represents a specific application or use case for natural language processing (NLP) and machine learning techniques in the context of language understanding and generation.
/// </summary>
public enum LanguageAITaskType
{
    /// <summary>
    /// The task of generating vector representations (embeddings) for text data, is commonly used for tasks like semantic search, clustering, and similarity analysis. Embeddings capture the semantic meaning of text and can be used to compare and analyze textual data effectively.
    /// The embedding process involves converting text into dense vector representations that capture the contextual and semantic information of the text. These embeddings can then be used for various downstream tasks, such as classification, clustering, or as input features for machine learning models.
    /// </summary>
    Embedding,
    /// <summary>
    /// The task of classifying text data into predefined categories or labels.
    /// This is a common task in natural language processing (NLP) and is used in applications such as sentiment analysis, spam detection, topic categorization, and more. 
    /// In classification tasks, the model learns to assign a label to a given piece of text based on its content and context.
    /// </summary>
    Classification,
    /// <summary>
    /// The task of generating human-like text based on a given input or prompt. 
    /// This can include tasks such as text completion, summarization, translation, and more.
    /// </summary>
    Generation
}

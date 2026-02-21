
namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// SentencePairRelation is an enumeration that defines different types of relationships between pairs of sentences, which can be used in various natural language processing (NLP) tasks such as contrastive learning, sentence similarity, and information retrieval, where the model learns to differentiate between similar and dissimilar sentence pairs based on their content, context, or meaning, ultimately improving its ability to learn from a wider range of data and generalize better to new and unseen examples in real-world scenarios.
/// Used in contrastive learning and other advanced learning techniques, where the model learns to differentiate between similar and dissimilar data points by maximizing the agreement between positive pairs (similar data) and minimizing the agreement between negative pairs (dissimilar data), often used in tasks such as representation learning, clustering, and dimensionality reduction, where the choice of sentence pair relation can significantly impact the model's ability to learn meaningful representations of the data and improve its performance on various NLP tasks.
/// </summary>
public enum SentencePairRelation
{
    /// <summary>
    /// EasyNegative indicates that the relationship between the two sentences is clearly negative (and easy to generate), meaning that they are dissimilar or unrelated in terms of their content, context, or meaning, and the model should be able to easily distinguish between them based on their features and representations.
    /// These can be gathered by randomly pairing sentences from different contexts or topics, ensuring that they do not share any meaningful connections or similarities, which can help the model learn to identify and differentiate between truly negative examples in contrastive learning and other advanced learning techniques.
    /// </summary>
    EasyNegative,
    /// <summary>
    /// SemiHardNegative indicates that the relationship between the two sentences is somewhat negative, meaning that they may share some similarities or connections in terms of their content, context, or meaning, but they are still distinct enough to be considered negative examples for the model to learn from.
    /// These can be gathered by pairing sentences that share some common features or themes, but still have enough differences to be considered negative examples, which can help the model learn to identify and differentiate between more challenging negative examples in contrastive learning and other advanced learning techniques, ultimately improving its ability to learn from a wider range of data and generalize better to new and unseen examples.
    /// Systematically selecting semi-hard negatives can be achieved by using techniques such as nearest neighbor search / clustering / cosine similarity to identify sentences that are similar to the positive examples but still distinct enough to be considered negative, which can help the model learn to capture more nuanced relationships between sentences and improve its performance on various NLP tasks.
    /// </summary>
    SemiHardNegative,
    /// <summary>
    /// HardNegative indicates that the relationship between the two sentences is negative but challenging, meaning that they may share significant similarities or connections in terms of their content, context, or meaning, making it difficult for the model to distinguish between them based on their features and representations.
    /// These usually require more sophisticated techniques to identify and select, such as using a pre-trained model to evaluate the similarity between sentences and selecting those that are most similar to the positive examples but still considered negative, which can help the model learn to capture more complex relationships between sentences and improve its performance on various NLP tasks, especially in scenarios where the model needs to learn from challenging examples to generalize better to new and unseen data.
    /// </summary>
    HardNegative,

}

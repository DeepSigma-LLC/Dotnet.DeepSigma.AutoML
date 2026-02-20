
namespace DeepSigma.AutoML.Enums.LLM;

/// <summary>
/// Specifies the retrieval-augmented generation (RAG) technique to use for enhancing information retrieval in semantic search applications.
/// </summary>
public enum RAGTechnique
{
    /// <summary>
    /// QueryRewrite refers to a RAG technique where the original query is rewritten or reformulated to improve retrieval performance by making it more specific, clear, or relevant to the information being sought, often using techniques such as query expansion, synonym replacement, or paraphrasing to enhance the effectiveness of retrieval-based methods in semantic search applications.
    /// </summary>
    QueryRewrite,
    /// <summary>
    /// QueryAugmentation refers to a RAG technique where additional information or context is added to the original query to enhance retrieval performance by providing more relevant details or constraints, often using techniques such as adding related keywords, incorporating user preferences, or including contextual information to improve the relevance and accuracy of retrieval-based methods in semantic search applications.
    /// </summary>
    QueryAugmentation,
    /// <summary>
    /// MultiQuery refers to a RAG technique where multiple queries are generated from the original query to improve retrieval performance by capturing different aspects or interpretations of the information being sought, often using techniques such as query diversification, query expansion, or generating multiple paraphrases of the original query to enhance the effectiveness of retrieval-based methods in semantic search applications.
    /// </summary>
    MultiQuery,
    /// <summary>
    /// MultiHop refers to a RAG technique where the retrieval process involves multiple hops or steps to retrieve relevant information from different sources or documents, often using techniques such as chaining queries together, following links between documents, or iteratively refining the retrieval process to capture more complex relationships and dependencies in the information being sought, thereby improving the performance of retrieval-based methods in semantic search applications.
    /// </summary>
    MultiHop,
    /// <summary>
    /// QueryRouting refers to a RAG technique where the retrieval process involves routing the query to different retrieval models or systems based on the characteristics of the query or the information being sought, often using techniques such as query classification, query intent detection, or dynamic routing to direct the query to the most appropriate retrieval model or system, thereby improving the relevance and accuracy of retrieval-based methods in semantic search applications.
    /// </summary>
    QueryRouting,
    /// <summary>
    /// Agentic refers to a RAG technique where the retrieval process involves an agent that interacts with the user or the environment to gather additional information or context to improve retrieval performance, often using techniques such as active learning, interactive querying, or reinforcement learning to enable the agent to adapt its retrieval strategy based on user feedback or changing conditions, thereby enhancing the effectiveness of retrieval-based methods in semantic search applications.
    /// </summary>
    Agentic
}

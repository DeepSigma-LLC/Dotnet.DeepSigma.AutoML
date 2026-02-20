
namespace DeepSigma.AutoML.Enums.LLM;

/// <summary>
/// The ConversationMemorySystem enumeration defines different types of memory systems that can be used in conversational models, which are designed to store and manage the conversation history and context in order to generate more informed and contextually relevant responses. Each type of memory system has its own characteristics and advantages, allowing for different approaches to handling conversation history and context in conversational models.
/// </summary>
public enum ConversationMemorySystem
{
    /// <summary>
    /// ConversationBufferMemory is a type of memory system that stores the entire conversation history, allowing the model to have access to all previous interactions and context when generating responses. 
    /// This memory system is useful for maintaining a comprehensive understanding of the conversation and providing more informed and contextually relevant responses.
    /// </summary>
    ConversationBufferMemory,
    /// <summary>
    /// ConversationBufferWindowMemory is a type of memory system that stores a limited window of the conversation history, allowing the model to have access to only a certain number of recent interactions and context when generating responses. 
    /// This memory system is useful for maintaining a more focused and relevant understanding of the conversation while avoiding information overload and ensuring that the model can still generate timely and contextually appropriate responses.
    /// </summary>
    ConversationBufferWindowMemory,
    /// <summary>
    /// ConversationSummaryMemory is a type of memory system that stores a summarized version of the conversation history, allowing the model to have access to a condensed representation of previous interactions and context when generating responses. 
    /// This memory system is useful for maintaining a high-level understanding of the conversation while reducing the amount of information that the model needs to process, enabling it to generate more concise and relevant responses based on the key points and themes of the conversation.
    /// </summary>
    ConversationSummaryMemory,
    /// <summary>
    /// KnowledgeGraphMemory is a type of memory system that stores the conversation history in the form of a knowledge graph, allowing the model to have access to structured representations of previous interactions and context when generating responses. 
    /// This memory system is useful for maintaining a more organized and interconnected understanding of the conversation, enabling the model to generate responses that are informed by the relationships and connections between different pieces of information within the conversation history.
    /// </summary>
    KnowledgeGraphMemory,    
}

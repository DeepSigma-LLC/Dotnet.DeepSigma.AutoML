
namespace DeepSigma.AutoML.Enums.LLM;

/// <summary>
/// AgentComponent is an enumeration that defines different components of an agent, which can include various functionalities and resources that an agent can utilize to perform tasks, solve problems, or achieve specific goals in various applications such as natural language processing, robotics, and artificial intelligence systems, where the choice of agent components can significantly impact the agent's behavior and performance in interacting with its environment and accomplishing its objectives effectively.
/// </summary>
public enum AgentComponent
{
    /// <summary>
    /// Memory refers to the component of an agent that is responsible for storing and retrieving information, allowing the agent to retain knowledge and experiences over time, which can be crucial for learning, decision-making, and adapting to new situations in various applications such as natural language processing, reinforcement learning, and cognitive modeling.
    /// </summary>
    Memory,
    /// <summary>
    /// Tools refer to the various resources, capabilities, or functionalities that an agent can utilize to perform tasks, solve problems, or achieve specific goals, which can include a wide range of components such as APIs, databases, external services, or specialized algorithms that enhance the agent's ability to interact with its environment and accomplish its objectives effectively in various applications.
    /// </summary>
    Tools,
    /// <summary>
    /// PromptTemplate refers to the component of an agent that defines the structure and format of the prompts used to interact with the agent, which can include predefined templates, rules, or guidelines for generating prompts that effectively elicit the desired responses or actions from the agent, playing a crucial role in shaping the agent's behavior and performance in various applications.
    /// </summary>
    PromptTemplate,
    /// <summary>
    /// ExecutionFlow refers to the component of an agent that defines the sequence and logic of actions or operations that the agent performs to accomplish its tasks or achieve its goals, which can include decision-making processes, control flow mechanisms, and execution strategies that govern how the agent interacts with its environment and utilizes its resources effectively in various applications.
    /// </summary>
    ExecutionFlow,
}

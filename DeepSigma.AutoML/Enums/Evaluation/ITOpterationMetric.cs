namespace DeepSigma.AutoML.Enums.Evaluation;

/// <summary>
/// IT operation metrics refer to the various key performance indicators (KPIs) used to evaluate the efficiency, effectiveness, and overall performance of IT operations teams.
/// </summary>
public enum ITOpterationMetric
{
    /// <summary>
    /// Mean Time to Detect (MTTD) is a key performance indicator (KPI) used in IT operations to measure the average time taken to detect an incident or issue from the moment it occurs until it is identified, and is crucial for assessing the efficiency and effectiveness of IT teams in identifying and responding to incidents, as well as for identifying areas for improvement in incident detection processes and overall IT service delivery.
    /// </summary>
    MeanTimeToDetect,
    /// <summary>
    /// Mean Time to Acknowledge (MTTA) is a key performance indicator (KPI) used in IT operations to measure the average time taken to acknowledge an incident or issue from the moment it is detected until it is acknowledged by the IT team, and is crucial for assessing the efficiency and effectiveness of IT teams in responding to incidents, as well as for identifying areas for improvement in incident acknowledgment processes and overall IT service delivery.
    /// </summary>
    MeanTimeToAcknowledge,
    /// <summary>
    /// Mean Time to Resolve (MTTR) is a key performance indicator (KPI) used in IT operations to measure the average time taken to resolve an incident or issue from the moment it is detected until it is fully resolved, including the time taken for diagnosis, troubleshooting, and implementation of a solution, and is crucial for assessing the efficiency and effectiveness of IT teams in responding to and resolving incidents, as well as for identifying areas for improvement in incident management processes and overall IT service delivery.
    /// AKa "Mean Time to Repair", "Mean Time to Recovery", or "Mean Time to Restore Service".
    /// </summary>
    MeanTimeToResolve,
    /// <summary>
    /// Mean Time Between Failures (MTBF) is a key performance indicator (KPI) used in IT operations to measure the average time between the occurrence of one failure and the next failure in a system or service, and is crucial for assessing the reliability and stability of IT systems, as well as for identifying areas for improvement in system design, maintenance, and overall IT service delivery.
    /// </summary>
    MeanTimeBetweenFailures,
    /// <summary>
    /// Ticket to Incident Ratio is a key performance indicator (KPI) used in IT operations to measure the ratio of the number of tickets created to the number of incidents detected, and is crucial for assessing the efficiency and effectiveness of IT teams in managing and responding to incidents, as well as for identifying areas for improvement in incident management processes and overall IT service delivery.
    /// </summary>
    TicketToIncidentRatio,
    /// <summary>
    /// Service Availability is a key performance indicator (KPI) used in IT operations to measure the percentage of time that a service or system is available and operational, and is crucial for assessing the reliability and performance of IT services, as well as for identifying areas for improvement in service design, maintenance, and overall IT service delivery.
    /// </summary>
    ServiceAvailability,
    /// <summary>
    /// Automated Versus Manual Resolution Rate is a key performance indicator (KPI) used in IT operations to measure the ratio of incidents resolved through automated processes to those resolved through manual intervention, and is crucial for assessing the efficiency and effectiveness of IT teams in leveraging automation to improve incident resolution times and overall IT service delivery, as well as for identifying areas for improvement in automation strategies and implementation.
    /// </summary>
    AutomatedVersusManualResolutionRate,
    /// <summary>
    /// User-Reported Versus Automated Detection Ratio is a key performance indicator (KPI) used in IT operations to measure the ratio of incidents detected through user reports to those detected through automated monitoring and detection systems, and is crucial for assessing the effectiveness of IT teams in leveraging automation for incident detection, as well as for identifying areas for improvement in monitoring strategies, user engagement, and overall IT service delivery.
    /// </summary>
    UserReportedVersusAutomatedDetectionRatio,
}

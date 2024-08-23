namespace Data.Presto.Models
{
    enum PrestoState
    {
        Queued,
        Planning,
        Starting,
        Running,
        Finishing,
        Finished,
        Canceled,
        Failed,
        WaitingForPrerequisites,
        WaitingForResources,
        Dispatching,
    }
}

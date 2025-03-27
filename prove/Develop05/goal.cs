// Base Goal Class
public abstract class Goal
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public abstract void RecordProgress();
    public abstract string GetDisplayStatus();
    public abstract string GetStringRepresentation();
}
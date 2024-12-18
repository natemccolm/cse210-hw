public class SimpleGoal: Goal {

    private int target;
    private int currentProgress;

    public SimpleGoal(int target){
        this.target=target;
        currentProgress=0;
    }

    public void AddProgress(int progress){
        currentProgress += progress;
        CheckCompletion();
    }

    public override void CheckCompletion()
    {
        if (currentProgress>=target){
            MarkAsComplete();
        }
    }
}
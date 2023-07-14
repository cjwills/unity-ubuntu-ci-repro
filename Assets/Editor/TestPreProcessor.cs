using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public class TestPreprocessor : IPreprocessBuildWithReport
{
    public int callbackOrder => 1;

    public void OnPreprocessBuild(BuildReport report)
    {
        UnityEngine.Debug.Log($"{nameof(TestPreprocessor)} ({nameof(IPreprocessBuildWithReport)} running successfully");
    }
}

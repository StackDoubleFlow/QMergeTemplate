using System.Reflection;
using QMerge.Hooking;
using QMLogger = QMerge.Logging.Logger;

public class Plugin
{
    internal static readonly QMLogger Logger = new QMLogger("QMergeTemplate");
    
    public static void Init()
    {
        Logger.Info("Initializing QMergeTemplate");
        var hookManager = new HookManager();
        hookManager.HookAll(Assembly.GetExecutingAssembly());
    }
}
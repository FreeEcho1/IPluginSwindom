namespace Swindom.IPluginSwindom;

/// <summary>
/// イベント処理のデータ
/// </summary>
public class EventProcessingData
{
    /// <summary>
    /// イベント処理
    /// </summary>
    public event EventHandler<EventProcessingArgs> EventProcessing = delegate { };
    /// <summary>
    /// イベント処理を実行
    /// </summary>
    /// <param name="hwnd">ウィンドウハンドル</param>
    /// <param name="eventType">イベントの種類</param>
    public virtual void DoEventProcessing(
        IntPtr hwnd,
        uint eventType
        )
    {
        EventProcessing?.Invoke(this, new(hwnd, eventType));
    }
}

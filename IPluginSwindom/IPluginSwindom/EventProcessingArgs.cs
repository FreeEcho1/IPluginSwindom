namespace Swindom.IPluginSwindom;

/// <summary>
/// イベント処理の引数データ
/// </summary>
public class EventProcessingArgs
{
    /// <summary>
    /// ウィンドウハンドル
    /// </summary>
    public IntPtr Hwnd;
    /// <summary>
    /// イベントの種類
    /// </summary>
    public uint EventType;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EventProcessingArgs()
    {
        Hwnd = IntPtr.Zero;
        EventType = 0;
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="hwnd">ウィンドウハンドル</param>
    /// <param name="eventType">イベントの種類</param>
    public EventProcessingArgs(
        IntPtr hwnd,
        uint eventType
        )
    {
        Hwnd = hwnd;
        EventType = eventType;
    }
}

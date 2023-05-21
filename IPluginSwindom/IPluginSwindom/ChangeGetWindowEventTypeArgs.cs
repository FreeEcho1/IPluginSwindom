namespace Swindom.IPluginSwindom;

/// <summary>
/// 取得するウィンドウイベントの種類の変更イベントの引数データ
/// </summary>
public class ChangeGetWindowEventTypeArgs
{
    /// <summary>
    /// 取得するウィンドウイベントの種類 (なし「0」)
    /// </summary>
    public GetWindowEventType GetWindowEventType;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ChangeGetWindowEventTypeArgs()
    {
        GetWindowEventType = 0;
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="eventType">取得するウィンドウイベントの種類 (なし「0」)</param>
    public ChangeGetWindowEventTypeArgs(
        GetWindowEventType eventType
        )
    {
        GetWindowEventType = eventType;
    }
}

namespace Swindom.IPluginSwindom;

/// <summary>
/// 取得するウィンドウイベントの種類の変更イベントのデータ
/// </summary>
public class ChangeGetWindowEventTypeData
{
    /// <summary>
    /// 取得するウィンドウイベントの種類の変更イベント
    /// </summary>
    public event EventHandler<ChangeGetWindowEventTypeArgs> ChangeEventType = delegate { };
    /// <summary>
    /// 取得するウィンドウイベントの種類の変更イベントを実行
    /// </summary>
    /// <param name="eventType">取得するウィンドウイベントの種類 (なし「0」)</param>
    public virtual void DoChangeEventType(
        GetWindowEventType eventType
        )
    {
        ChangeEventType?.Invoke(this, new(eventType));
    }
}

namespace Swindom.IPluginSwindom;

/// <summary>
/// Plugin interface
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// プラグインの名前
    /// </summary>
    string PluginName
    {
        get;
    }
    /// <summary>
    /// ウィンドウが存在するかの値 (存在しない「false」/存在する「true」)
    /// </summary>
    bool IsWindowExist
    {
        get;
    }
    /// <summary>
    /// ウィンドウハンドルがウィンドウの場合のみイベント処理 (処理しない「false」/処理する「true」)
    /// </summary>
    bool IsWindowOnlyEventProcessing
    {
        get;
    }
    /// <summary>
    /// 取得するウィンドウイベントの種類 (なし「0」)
    /// </summary>
    GetWindowEventType GetWindowEventType
    {
        get;
    }
    /// <summary>
    /// 取得するウィンドウイベントの種類の変更イベントのデータ
    /// </summary>
    ChangeGetWindowEventTypeData ChangeGetWindowEventTypeData
    {
        get;
    }
    /// <summary>
    /// イベント処理のデータ
    /// </summary>
    EventProcessingData EventProcessingData
    {
        get;
    }

    /// <summary>
    /// 初期化
    /// </summary>
    /// <param name="settingDirectory">設定ファイルのディレクトリ</param>
    void Initialize(
        string settingDirectory
        );
    /// <summary>
    /// 破棄
    /// </summary>
    void Destruction();
    /// <summary>
    /// ウィンドウを表示
    /// </summary>
    void ShowWindow();
}

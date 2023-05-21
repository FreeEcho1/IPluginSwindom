namespace Swindom.IPluginSwindom;

/// <summary>
/// イベント定数
/// </summary>
public static class EVENT_CONSTANTS
{
    /// <summary>
    /// EVENT_MIN
    /// </summary>
    public const uint EVENT_MIN = 0x00000001;
    /// <summary>
    /// EVENT_SYSTEM_FOREGROUND
    /// </summary>
    public const uint EVENT_SYSTEM_FOREGROUND = 0x00000003;
    /// <summary>
    /// EVENT_SYSTEM_MOVESIZESTART
    /// </summary>
    public const uint EVENT_SYSTEM_MOVESIZESTART = 0x0000000a;
    /// <summary>
    /// EVENT_SYSTEM_MOVESIZEEND
    /// </summary>
    public const uint EVENT_SYSTEM_MOVESIZEEND = 0x0000000b;
    /// <summary>
    /// EVENT_SYSTEM_MINIMIZESTART
    /// </summary>
    public const uint EVENT_SYSTEM_MINIMIZESTART = 0x00000016;
    /// <summary>
    /// EVENT_SYSTEM_MINIMIZEEND
    /// </summary>
    public const uint EVENT_SYSTEM_MINIMIZEEND = 0x00000017;
    /// <summary>
    /// EVENT_OBJECT_CREATE
    /// </summary>
    public const uint EVENT_OBJECT_CREATE = 0x00008000;
    /// <summary>
    /// EVENT_OBJECT_DESTROY
    /// </summary>
    public const uint EVENT_OBJECT_DESTROY = 0x00008001;
    /// <summary>
    /// EVENT_OBJECT_SHOW
    /// </summary>
    public const uint EVENT_OBJECT_SHOW = 0x00008002;
    /// <summary>
    /// EVENT_OBJECT_HIDE
    /// </summary>
    public const uint EVENT_OBJECT_HIDE = 0x00008003;
    /// <summary>
    /// EVENT_OBJECT_LOCATIONCHANGE
    /// </summary>
    public const uint EVENT_OBJECT_LOCATIONCHANGE = 0x0000800b;
    /// <summary>
    /// EVENT_OBJECT_NAMECHANGE
    /// </summary>
    public const uint EVENT_OBJECT_NAMECHANGE = 0x0000800c;
    /// <summary>
    /// EVENT_MAX
    /// </summary>
    public const uint EVENT_MAX = 0x7fffffff;
}

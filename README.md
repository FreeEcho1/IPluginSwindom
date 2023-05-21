# IPluginSwindom

[説明]
ソフトウェア「Swindom」で使用するプラグイン用のインターフェースです。
これを基にプラグインを開発します。

[プラグイン開発の手順]
1. : プロジェクトに「IPluginSwindom」(IPluginSwindom.dll) を追加します。
2. : クラスを作成して「Swindom.IPluginSwindom.IPlugin」を継承します。
3. : オーバーライドして必要な処理を記述します。

[IPluginを継承したクラスの中身]
 - PluginName
プラグインの名前です。
名前がない場合はファイル名が使用されます。

 - IsWindowExist
プラグインにウィンドウが存在することを示します。
「true」は存在する、「false」は存在しない。
ユーザーがウィンドウを表示する操作をした場合に「ShowWindow」が呼ばれます。

 - IsWindowOnlyEventProcessing
 「GetWindowEventType」でイベントの種類を指定している場合に使用します。
ウィンドウハンドルがウィンドウの場合のみ「EventProcessingData.EventProcessing」の
イベントを発生させるかを示します。
イベントで取得したウィンドウハンドルはウィンドウではない場合があるので、
ウィンドウの場合のみイベントを発生させることができます。
「true」はウィンドウの場合のみ、「false」はウィンドウ以外の場合でもイベントを発生させます。
正確にウィンドウなのか判定できず、ウィンドウではなくても呼ばれる、ウィンドウなのに呼ばれない、
などの場合があります。

 - GetWindowEventType
「Swindom」側でイベントを取得してもらいたい場合に、イベントの種類を指定します。
取得してもらう必要がない場合は「0」にします。
複数指定する場合はビット演算を使用します。
例：GetWindowEventType.Foreground | GetWindowEventType.MoveSizeStart

 - ChangeGetWindowEventTypeData
「GetWindowEventType」でイベントの種類を指定している場合に使用します。
「Swindom」側で取得してもらいたいイベントを変更したい場合に、「DoChangeEventType」で
変更を伝えます。

 - Initialize(string settingDirectory)
初期化処理をします。
プラグインが読み込まれた時に呼ばれます。
settingDirectory - 設定ファイルのディレクトリ

 - Destruction()
「Swindom」が終了する時に呼ばれます。
終了に必要な処理をします。

 - ShowWindow()
プラグインのウィンドウを表示する時に呼ばれます。
設定などのウィンドウを表示する処理です。
「IsWindowExist」が「false」の場合は呼ばれません。

[GetWindowEventType]
 - Foreground : EVENT_SYSTEM_FOREGROUND
 - MoveSizeStart : EVENT_SYSTEM_MOVESIZESTART
 - MoveSizeEnd : EVENT_SYSTEM_MOVESIZEEND
 - MinimizeStart : EVENT_SYSTEM_MINIMIZESTART
 - MinimizeEnd : EVENT_SYSTEM_MINIMIZEEND
 - Create : EVENT_OBJECT_CREATE
 - Destroy : EVENT_OBJECT_DESTROY
 - Show : EVENT_OBJECT_SHOW
 - Hide : EVENT_OBJECT_HIDE
 - LocationChange : EVENT_OBJECT_LOCATIONCHANGE
 - NameChange : EVENT_OBJECT_NAMECHANGE

[EVENT_CONSTANTS]
イベントの定数です。

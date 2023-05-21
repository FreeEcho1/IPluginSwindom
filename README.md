# IPluginSwindom

[説明]<br>
ソフトウェア「Swindom」で使用するプラグイン用のインターフェースです。<br>
これを基にプラグインを開発します。<br>
<br>
[プラグイン開発の手順]<br>
1. : プロジェクトに「IPluginSwindom」(IPluginSwindom.dll) を追加します。
2. : クラスを作成して「Swindom.IPluginSwindom.IPlugin」を継承します。
3. : オーバーライドして必要な処理を記述します。
<br>
[IPluginを継承したクラスの中身]<br>
 - PluginName<br>
プラグインの名前です。<br>
名前がない場合はファイル名が使用されます。<br>
<br>
 - IsWindowExist<br>
プラグインにウィンドウが存在することを示します。<br>
「true」は存在する、「false」は存在しない。<br>
ユーザーがウィンドウを表示する操作をした場合に「ShowWindow」が呼ばれます。<br>
<br>
 - IsWindowOnlyEventProcessing<br>
 「GetWindowEventType」でイベントの種類を指定している場合に使用します。<br>
ウィンドウハンドルがウィンドウの場合のみ「EventProcessingData.EventProcessing」のイベントを発生させるかを示します。<br>
イベントで取得したウィンドウハンドルはウィンドウではない場合があるので、ウィンドウの場合のみイベントを発生させることができます。<br>
「true」はウィンドウの場合のみ、「false」はウィンドウ以外の場合でもイベントを発生させます。<br>
正確にウィンドウなのか判定できず、ウィンドウではなくても呼ばれる、ウィンドウなのに呼ばれない、などの場合があります。<br>
<br>
 - GetWindowEventType<br>
「Swindom」側でイベントを取得してもらいたい場合に、イベントの種類を指定します。<br>
取得してもらう必要がない場合は「0」にします。<br>
複数指定する場合はビット演算を使用します。<br>
例：GetWindowEventType.Foreground | GetWindowEventType.MoveSizeStart<br>
<br>
 - ChangeGetWindowEventTypeData<br>
「GetWindowEventType」でイベントの種類を指定している場合に使用します。<br>
「Swindom」側で取得してもらいたいイベントを変更したい場合に、「DoChangeEventType」で変更を伝えます。<br>
<br>
 - Initialize(string settingDirectory)<br>
初期化処理をします。<br>
プラグインが読み込まれた時に呼ばれます。<br>
settingDirectory - 設定ファイルのディレクトリ<br>
<br>
 - Destruction()<br>
「Swindom」が終了する時に呼ばれます。<br>
終了に必要な処理をします。<br>
<br>
 - ShowWindow()<br>
プラグインのウィンドウを表示する時に呼ばれます。<br>
設定などのウィンドウを表示する処理です。<br>
「IsWindowExist」が「false」の場合は呼ばれません。<br>
<br>
[GetWindowEventType]<br>
 - Foreground : EVENT_SYSTEM_FOREGROUND<br>
 - MoveSizeStart : EVENT_SYSTEM_MOVESIZESTART<br>
 - MoveSizeEnd : EVENT_SYSTEM_MOVESIZEEND<br>
 - MinimizeStart : EVENT_SYSTEM_MINIMIZESTART<br>
 - MinimizeEnd : EVENT_SYSTEM_MINIMIZEEND<br>
 - Create : EVENT_OBJECT_CREATE<br>
 - Destroy : EVENT_OBJECT_DESTROY<br>
 - Show : EVENT_OBJECT_SHOW<br>
 - Hide : EVENT_OBJECT_HIDE<br>
 - LocationChange : EVENT_OBJECT_LOCATIONCHANGE<br>
 - NameChange : EVENT_OBJECT_NAMECHANGE<br>
<br>
[EVENT_CONSTANTS]<br>
イベントの定数です。<br>

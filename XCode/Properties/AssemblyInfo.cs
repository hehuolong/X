﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 鏈夊叧绋嬪簭闆嗙殑甯歌淇℃伅閫氳繃涓嬪垪灞炴€ч泦
// 鎺у埗銆傛洿鏀硅繖浜涘睘鎬у€煎彲淇敼
// 涓庣▼搴忛泦鍏宠仈鐨勪俊鎭€?
[assembly: AssemblyTitle("鏂扮敓鍛芥暟鎹槧灏勬鏋?)]
[assembly: AssemblyDescription("鍖呮嫭骞跺ぇ浜嶰rm鐨勬暟鎹槧灏勬鏋?)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("XCode")]
[assembly: AssemblyCulture("")]

// 灏?ComVisible 璁剧疆涓?false 浣挎绋嬪簭闆嗕腑鐨勭被鍨?
// 瀵?COM 缁勪欢涓嶅彲瑙併€傚鏋滈渶瑕佷粠 COM 璁块棶姝ょ▼搴忛泦涓殑绫诲瀷锛?
// 鍒欏皢璇ョ被鍨嬩笂鐨?ComVisible 灞炴€ц缃负 true銆?
[assembly: ComVisible(false)]
//[assembly: CLSCompliant(true)]
[assembly: Dependency("NewLife.Core", LoadHint.Always)]

// 濡傛灉姝ら」鐩悜 COM 鍏紑锛屽垯涓嬪垪 GUID 鐢ㄤ簬绫诲瀷搴撶殑 ID
[assembly: Guid("fd577d2c-f8aa-4cc8-a697-d7990c264af3")]

// 绋嬪簭闆嗙殑鐗堟湰淇℃伅鐢变笅闈㈠洓涓€肩粍鎴?
//
//      涓荤増鏈?
//      娆＄増鏈?
//      鍐呴儴鐗堟湰鍙?
//      淇鍙?
//
// 鍙互鎸囧畾鎵€鏈夎繖浜涘€硷紝涔熷彲浠ヤ娇鐢ㄢ€滀慨璁㈠彿鈥濆拰鈥滃唴閮ㄧ増鏈彿鈥濈殑榛樿鍊硷紝
// 鏂规硶鏄寜濡備笅鎵€绀轰娇鐢ㄢ€?鈥?
[assembly: AssemblyVersion("8.20.*")]
[assembly: AssemblyFileVersion("8.20.2015.0717")]

/*
 * XCode鐨勯噸澶ф敼杩?
 * 
 * v8.0 鏍囧噯鍖栧紑鏀剧殑鎺ュ彛锛屽寮哄畾鍒惰兘鍔?
 * v7.0 澧炲己鏁版嵁搴撴灦鏋勭殑鏀寔锛屾敮鎸佹洿澶氭暟鎹簱
 * v6.0 澧炲己鐨勭紦瀛樺拰鎵╁睍灞炴€ф敮鎸?
 * v5.0 寮辩被鍨嬫敮鎸?
 * v4.0 瀹炰綋闆嗗悎鍜岀紦瀛?
 * v3.0 澧炲姞ORM鐨勫悇绉嶇粏鑺傛敮鎸?
 * v2.0 鏁版嵁鏋舵瀯鍔熻兘锛屽疄浣撳拰鏁版嵁缁撴瀯鍙屽悜鏄犲皠
 * v1.2 浣跨敤娉涘瀷鍩虹被
 * v1.0 鍒涘缓XCode
 * /

/*
 * v8.20.2015.0717  鏁版嵁浼氳瘽澧炲姞Truncate鐢ㄤ簬娓呯┖鏁版嵁琛紝鏍囪瘑褰掗浂锛屾柟渚挎祴璇?
 * 
 * v8.19.2015.0716  澧炲姞瀹炰綋澶勭悊妯″潡IEntityModule锛屾敮鎸佹嫤鎴狢reate/Valid鎿嶄綔
 * 
 * v8.18.2015.0522  澧炲姞鐢ㄦ埛鏃堕棿瀹炰綋鍩虹被UserTimeEntityBase锛屼究浜庢墿灞曞垱寤轰汉鍜屾洿鏂颁汉浠ュ強鏃堕棿绛変俊鎭?
 * 
 * v8.18.2015.0425  瀹炰綋绫绘敮鎸佸姩鎬佸鍔犲瓧娈礛eta.Table.Add锛屼韩鍙楄鍐欐暟鎹互鍙婂弽鍚戝伐绋嬬殑瀹屾暣鏀寔
 * 
 * v8.17.2015.0425  鍗囩骇瀹炰綋绫籗earchWhereByKeys鏂规硶锛屾敮鎸佹寚瀹氬鍝簺瀛楁杩涜妯＄硦鏌ヨ
 * 
 * v8.17.2015.0408  闆嗘垚鐢ㄦ埛鏉冮檺绠＄悊鏋舵瀯
 *                  鏀硅繘杩炴帴瀛楃涓茶缃紝褰撴煇杩炴帴瀛楃涓蹭笉瀛樺湪鏃讹紝涓嶅啀鎶涘嚭寮傚父锛岄粯璁ら噰鐢⊿QLite鏁版嵁搴擄紝骞跺湪鏃ュ織涓緭鍑?
 * 
 * v8.16.2015.0329  鐩存帴鏌ユ暟鎹簱寰楀埌鐨勫疄浣撳璞★紝鑷姩鍔犲叆姝ｅ湪浣跨敤鐨勫崟瀵硅薄缂撳瓨
 * 
 * v8.15.2015.0327  SQLite澧炲姞Backup锛屾敮鎸佹暟鎹儹澶?
 * 
 * v8.14.2015.0305  瀛楁鍚嶉泦鍚圡eta.FieldNames鍜屽疄浣撶储寮晅his[name]绛変笉鍐嶅尯鍒嗗ぇ灏忓啓姣旇緝锛岃姹傛暟鎹〃涓嶅緱浣跨敤鍚屽悕浣嗕笉鍚屽ぇ灏忓啓鐨勫瓧娈靛悕
 * 
 * v8.13.2015.0107  淇閮ㄥ垎瀹炰綋绫诲洜娌℃湁涓婚敭瀵艰嚧鍒犻櫎鏁版嵁閿欒鐨凚UG
 * 
 * v8.13.2014.0720  濡傛灉椤甸潰璁惧畾鏈塜Code_SQLList鍒楄〃锛屽垯寰€鍒楄〃鍐欏叆SQL璇彞
 * 
 * v8.13.2014.0707  鏀寔浣跨敤閿佹潵鎺у埗SQLite骞跺彂
 * 
 * v8.12.2014.0703  淇EntityList鍦ㄩ珮骞跺彂閬嶅巻鏁版嵁鏃跺瓨鍦ㄧ増鏈啿绐佺殑闂
 * 
 * v8.12.2014.0617  Entity澧炲姞FindMin/FindMax
 *                  FieldItem澧炲姞GroupBy/Count/Sum/Min/Max绛?
 *                  SQLite鐨凷elect Count闈炲父鎱紝鏁版嵁澶т簬闃€鍊兼椂锛屼娇鐢ㄦ渶澶D浣滀负琛ㄨ褰曟暟
 * 
 * v8.12.2014.0616  缂撳瓨妯″潡澧炲姞Alone鐙崰鏁版嵁搴撲互鍙婂疄浣撶紦瀛樿繃鏈熸椂闂寸瓑閰嶇疆锛岀嫭鍗犳暟鎹簱鏄姞澶х紦瀛樻潈閲嶄互鍙婅繃鏈熸椂闂?
 *                  EntitySession澧炲姞HoldCache锛屾寚绀哄湪鏇存柊鏁版嵁搴撲笉璁告竻绌虹紦瀛橈紙CURD鍙悓姝ユ洿鏂板疄浣撶紦瀛橈級锛岃€屽彧鑳借鍏惰繃鏈?
 * 
 * v8.11.2014.0616  浼樺寲MSSQL鐨凲ueryCountFast锛屾瘡娆℃煡璇㈡墍鏈夎〃琛屾暟锛屽苟缂撳瓨鐭椂闂?
 * 
 * v8.11.2014.0614  澧炲姞鍒嗚〃鍒嗗簱涓撳睘鏂规硶Meta.ProcessWithSplit/Meta.CreateSplit
 * 
 * v8.11.2014.0612  閲嶆柊鏁寸悊杩滅▼鏁版嵁搴撹闂椂鍒囨崲绯荤粺搴撶殑閫昏緫
 * 
 * v8.10.2014.0412  澧炲姞DAL.CacheExpiration鍏ㄥ眬璁剧疆涓€绾х紦瀛?
 * 
 * v8.10.2014.0311  涓篒EntityList鎺ュ彛澧炲姞Page鍒嗛〉鏂规硶
 * 
 * v8.10.2014.0310  SQLite杩炴帴瀛楃涓叉敮鎸乤uto_vacuum锛屾寚瀹氭槸鍚﹁嚜鍔ㄦ敹缂╂暟鎹簱
 * 
 * v8.10.2014.0228  淇DAL涓湪鍏抽棴涓€绾х紦瀛樼殑鎯呭喌涓嬩粛鐒朵娇鐢ㄤ竴绾х紦瀛樼殑闂
 * 
 * v8.10.2014.0221  淇CreateSession涓殑_sessions[tid] = session鎶ull寮傚父鐨勯棶棰橈紝淇敼DbBase.ConnectionString寮曞彂ReleaseSession浠庤€屽鑷確sessions = null
 * 
 * v8.10.2014.0215  淇EntitySession.WaitForInitData涓病鏈夐樆姝㈠绾跨▼杩涘叆鐨勯棶棰?
 * 
 * v8.10.2014.0107  澧炲姞Meta.CreateTrans/IEntityOperate.CreateTrans锛屾柟渚夸娇鐢╱sing鐨勪簨鍔?
 * 
 * v8.10.2013.1214  IDataTable澧炲姞GetAllColumns鏂规硶锛岀敤浜庤幏鍙栫户鎵块摼涓婄殑鎵€鏈夊瓧娈?
 * 
 * v8.10.2013.1213  澧炲己瀹炰綋绫绘墿灞旹ntityOperate锛屾敮鎸佺户鎵挎墿灞曪紝閫愭鏇夸唬Meta
 *                  濉厖鏁版嵁瀹屾垚鏃惰皟鐢ㄥ疄浣撶被OnLoad鏂规硶銆傞粯璁よ瀹氭爣璁癬IsFromDatabase
 *                  瀹炰綋鏍慐ntityTree璁剧疆鐙珛EntityTreeSettting
 *                  IDataTable澧炲姞BaseType锛屾柟渚垮叿鏈夌户鎵跨壒鎬х殑浠ｇ爜鐢熸垚浠ュ強澧炲己瀵瑰疄浣撶被缁ф壙鐨勬敮鎸?
 * 
 * v8.9.2013.1212   澧炲姞EntityList.Page鐢ㄤ簬瀹炰綋鍒楄〃鍒嗛〉锛屽悓鏃跺鍔犻厤濂楃殑鏋勯€犲嚱鏁?
 * 
 * v8.9.2013.1005   澧炲姞瀛楁鎵╁睍FieldExtension锛屾妸瀛楁鐨勬椂闂存墿灞曟搷浣滃垎绂诲嚭鏉ュ苟浼樺寲
 * 
 * v8.9.2013.0909   IEntity澧炲姞IEntityEntry鐨勬灇涓炬帴鍙ｏ紝鏀寔閬嶅巻瀹炰綋鐨勫瓧娈靛拰鍊?
 * 
 * v8.9.2013.0901   IDataTable鍜孖DataColumn鐨凞isplayName鐙珛锛屾敮鎸佹暟鎹〃鍜屾暟鎹瓧娈典腑鏄剧ず鍚嶅拰鎻忚堪鐨勫垎绂?
 * 
 * v8.9.2013.0815   SelectBuilder.Parse鏈夌己闄凤紝涓嶈兘鍒嗘瀽甯︽湁鍦嗘嫭鍙风殑SQL璇彞锛屽洜姝ょ粰DbBase.PageSplit甯︽潵椋庨櫓锛屽悇鏁版嵁搴撳叏閮ㄩ噸杞借鏂规硶浠ヨ閬胯椋庨櫓
 * 
 * v8.9.2013.0804   妯″瀷淇濆瓨IDataIndex鏃讹紝涓嶇敤淇濆瓨榛樿鐨凬ame
 * 
 * v8.9.2013.0803   淇SQLite鏃犳硶鍔犺浇SQLite.Interop.dll鐨凚UG锛屾牴鎹繘绋嬬増鏈紝璁惧畾x86鎴栬€厁64涓篋LL鐩綍
 * 
 * v8.9.2013.0708   淇敼鏁版嵁搴撻┍鍔ㄤ笅杞介€昏緫锛屽鍔燜x40鏀寔
 * 
 * v8.9.2013.0622   榛樿鏈嶅姟鍦板潃淇敼涓篘ewLifeX.com
 * 
 * v8.9.2013.0326   FieldItem澧炲姞IsTrue鍜孖sFalse锛屽疄鐜癟rue/False/Null鐨勫垎缁勬瀯閫犳潯浠?
 * 
 * v8.9.2013.0321   SearchWhereByKey鍜孲earchWhereByKeys鐩存帴杩斿洖WhereExpression
 * 
 * v8.9.2013.0320   澧炲姞TraceSQLTime锛岃窡韪猄QL鎵ц鏃堕棿锛屽ぇ浜庤闃€鍊煎皢杈撳嚭鏃ュ織锛岄粯璁?姣涓嶈窡韪€?
 * 
 * v8.9.2013.0310   淇鍔ㄦ€佷唬鐮佷腑瀛楁寮曠敤涓嶆纭殑BUG
 *                  IDbSession.Rollback澧炲姞鏄惁蹇界暐寮傚父鐨勫弬鏁帮紝榛樿蹇界暐
 * 
 * v8.9.2013.0307   涓篒DataTable/IDataColumn澧炲姞鎵╁睍灞炴€у瓧鍏窹roperties锛屾敮鎸佽〃鍜屽瓧娈典娇鐢ㄦ墿灞曞睘鎬?
 * 
 * v8.9.2013.0306   涓篛racle椹卞姩澧炲姞閰嶇疆椤筙Code.Oracle.IgnoreCase锛屾槸鍚﹀拷鐣ュぇ灏忓啓锛屽鏋滀笉蹇界暐鍒欏湪琛ㄥ悕瀛楁鍚嶅闈㈠姞涓婂弻寮曞彿锛岄粯璁rue
 * 
 * v8.9.2012.1225   妯″瀷瀵煎叆瀵煎嚭杩涜榛樿鍊肩簿绠€锛屼富瑕佷娇鐢ㄥ悕绉扮被鍨嬪拰闀垮害
 * 
 * v8.9.2012.1220   瀹炰綋鏍戝熀绫籈ntityTree澧炲姞鐖剁骇鑺傜偣鍚峆arentNodeName
 *                  瀹炰綋鏍戝熀绫籈ntityTree鏀寔鏈€澶ф繁搴axDepth闄愬埗
 * 
 * v8.9.2012.1216   鏁寸悊EntityAssembly浠ｇ爜锛屽鍔犺嫢骞蹭簨浠讹紝鍏佽鎺у埗鍔ㄦ€佸疄浣撶被鐨勫熀绫荤瓑淇℃伅
 * 
 * v8.9.2012.1122   Oracle椹卞姩澧炲姞瀵圭幆澧冨彉閲忓拰娉ㄥ唽琛ㄧ殑妫€娴?
 * 
 * v8.9.2012.1114   瀹炰綋鏍慐ntityTree澧炲姞BigSort寮€鍏筹紝鐢ㄤ簬鎸囧畾鎺掑簭鏃舵槸鍚﹁緝澶ф暟瀛楁帓鍓嶉潰
 * 
 * v8.9.2012.1113   鐗规畩澶勭悊瀹炰綋鍒楄〃鏌ユ壘涓殑鏁存暟绫诲瀷锛岄伩鍏嶅嚭鐜扮浉鍚屽€间笉鍚屾暣鍨嬭€屽鑷寸粨鏋滀笉鍚?
 * 
 * v8.9.2012.1111   鏁版嵁妯″瀷璋冩暣锛孨ame=>TableName/ColumnName锛孉lias=>Name
 * 
 * v8.8.2012.0828   DAL涓紝鎶婂弽鍚戝伐绋嬫鏌ュ欢杩熷埌绗竴娆℃暟鎹簱鎿嶄綔涔嬪墠涓€鍒?
 *                  FieldItem鐨勭瓑浜庝笉绛変簬澶т簬灏忎簬绛夋搷浣滐紝鏀寔涓や釜鎿嶄綔鏁伴兘鏄湰琛ㄥ瓧娈电殑鎯呭喌
 * 
 * v8.8.2012.0821   鏃犳潯浠禙indCount鏃讹紝濡傛灉鎬昏褰曟暟瓒呰繃涓€涓囷紝涓轰簡鎻愰珮鎬ц兘锛岃繑鍥炲揩閫熸煡鎵句笖甯︽湁缂撳瓨鐨勬€昏褰曟暟
 * 
 * v8.8.2012.0803   涓嬭浇鏁版嵁搴撻┍鍔ㄦ椂锛屽鍔犳湰鍦扮紦瀛橈紙绯荤粺鐩榅鐩綍锛夛紝鏈夋晥鏈熶竴涓湀
 * 
 * v8.8.2012.0727   濡傛灉瀹炰綋鏉ヨ嚜鏁版嵁搴擄紝鍦ㄧ粰鏁版嵁灞炴€ц祴鐩稿悓鍊兼椂锛屼笉鏀瑰彉鑴忔暟鎹紝鍏跺畠鎯呭喌鍧囨敼鍙樿剰鏁版嵁
 * 
 * v8.8.2012.0722   澧炲姞妯″瀷瀛楁鎺掑簭鐗规€odelSortModeAttribute锛岄粯璁ゆ寚瀹氬熀绫绘暟鎹瓧娈典紭鍏堬紝褰卞搷鐢熸垚鏁版嵁琛ㄥ瓧娈甸『搴?
 * 
 * v8.8.2012.0718   澧炲姞瀹炰綋浜嬪姟鍖哄煙EntityTransaction
 * 
 * v8.8.2012.0715   淇鍙嶅悜宸ョ▼涓洜涓鸿法鏁版嵁搴撳鐞嗛粯璁ゅ€艰€屽鑷村瓧绗︿覆榛樿鍊煎嚭閿欑殑BUG
 *                  淇MSSQL涓噰鐢–ONVERT([datetime],'1753-1-1',(0))浣滀负鏃堕棿鏈€灏忓€艰€屾棤娉曞疄鐜拌法鏁版嵁搴撳鐞嗙殑BUG
 *                  濡傛灉绱㈠紩鍏ㄩ儴灏辨槸涓婚敭锛屾棤闇€鍒涘缓绱㈠紩
 *                  SQLite涓笉鍚岃〃鐨勭储寮曞悕涔熶笉鑳界浉鍚?
 * 
 * v8.8.2012.0625   澧炲姞瀛楁绱姞鍔熻兘锛屾敮鎸佺偣鍑绘暟绱姞鍜岃揣甯佺疮鍔犵瓑锛屽Update xxx Set Price=Price+100
 *                  绱姞瀛楁鐢ㄦ硶锛氬疄浣撶被闈欐€佹瀯閫犲嚱鏁颁腑閫氳繃AdditionalFields鎸囧畾闇€瑕佺疮鍔犵殑瀛楁锛屽叾瀹冩搷浣滀笉鍙?
 *                  濡傛灉绱㈠紩鐨勫敮涓€瀛楁鏄富閿紝鍒欏弽鍚戝伐绋嬫椂鏃犻渶寤虹珛绱㈠紩
 * 
 * v8.7.2012.0620   淇Entity<>.CopyFrom涓鍒舵墿灞曞睘鎬ф椂锛岃缃剰鏁版嵁鍑洪敊鐨凚UG锛岃€?.7鐨勫疄浣撶紦瀛極nUpdate鍒氬ソ鐢ㄥ埌
 *                  XCode瀵逛簬榛樿鎺掑簭鐨勮鍒欙細鑷涓婚敭闄嶅簭锛屽叾瀹冩儏鍐甸粯璁?
 * 
 * v8.7.2012.0614   IEntity鎺ュ彛澧炲姞CloneEntity鍜孋opyFrom鏂规硶锛屽寮哄瀹炰綋鍏嬮殕鐨勬敮鎸?
 *                  鍦ㄤ簨鍔′繚鎶や腑锛屼负浜嗛伩鍏嶆€ц兘鎹熻€楋紝涓嶄細瀹炴椂鏇存柊瀹炰綋缂撳瓨锛岀洿鍒版彁浜ゆ垨鍥炴粴浜嬪姟锛屾彃鍏ユ垨鍒犻櫎瀹炰綋鏃剁洿鎺ユ搷浣滃疄浣撶紦瀛?
 *                  DbSession.GetSchema缂撳瓨10绉掞紝鏃㈡彁鍗囦簡姝ｅ悜鍙嶅悜宸ョ▼鐨勬€ц兘锛屽張閬垮厤浜嗕慨鏀硅〃缁撴瀯鍚庢棤娉曞強鏃跺緱鍒版洿鏂?
 *                  Entity.Exist閫夋嫨閲囩敤瀹炰綋缂撳瓨杩涜楠岃瘉锛屾彁楂樻€ц兘
 *                  淇EntityList.ToDataTable缁戝畾DataGridView鏃舵棤娉曟洿鏂版暟鎹殑BUG锛屽洜涓鸿剰鏁版嵁
 * 
 * v8.7.2012.0607   淇TableItem涓繛鎺ュ悕鏄犲皠ConnMaps鍙兘鍥犱负澶氱嚎绋嬪啿绐佽€屽鑷村皬鍑犵巼澶辫触鐨勯棶棰?
 *                  鎻掑叆鏁版嵁鏃讹紝濡傛灉娌℃湁鑷瀛楁锛屽垯鏃犺鍏佽鎻掑叆鑷瀛楁鐨勮缃?
 *                  涓轰簡鏈€澶х▼搴︿繚璇佸吋瀹规€э紝鍙嶅悜鏃舵墍鏈夋暟鎹簱鐨凞ecimal鍜孌ateTime绫诲瀷涓嶆寚瀹氱簿搴︼紝鍧囬噰鐢ㄦ暟鎹簱榛樿鍊?
 *                  淇EntityTransform涓竴涓娇鐢ㄤ簨鍔′繚鎶ょ殑閿欒
 *                  淇Entity.Meta.ClearCountCache澶勭悊璁板綍鏁扮紦瀛樼殑閿欒锛屽鍔犳敮鎸佸垏鎹㈣繛鎺ユ垨琛ㄥ悕鏃舵竻闄よ褰曟暟缂撳瓨
 * 
 * v8.7.2012.0605   瀹炰綋绫诲鍔燜indSQL鏂规硶锛岃幏鍙栨煡璇QL锛屼富瑕佺敤浜庢瀯閫犲瓙鏌ヨ
 * 
 * v8.6.2012.0604   淇XCode涓細瀵艰嚧IEntityOperate.FindAllWithCache姝诲惊鐜殑BUG
 *                  涓篠QL鏍煎紡鍖栨暟鍊兼椂锛屽鏋滃瓧绗︿覆鏄疎mpty锛屽皢涓嶅啀鏍煎紡鍖栦负null
 * 
 * v8.6.2012.0529   閲嶆瀯鍙嶅悜宸ョ▼璁剧疆椤圭殑璁捐锛屼互鍙傛暟鐨勬柟寮忔帴鍙楀弽鍚戣缃紝鎽嗚劚鍙楅厤缃」鐨勯檺鍒?
 * 
 * v8.6.2012.0526   鐢?@Goon(12600112) 娴嬭瘯骞跺畬鍠凷qlCe鐨勬鍚戝弽鍚戝伐绋?
 * 
 * v8.6.2012.0525   瀹炰綋绫绘妸鍥涘弬鏁扮殑FindAll鍜孎indCount鏍囦负宸茶繃鏈燂紝IEntityOperate涓洿鎺ユ敞閲?
 * 
 * v8.6.2012.0523   鏁版嵁杩佺ЩEntityTransform寮曠敤灞€閮ㄨ縼绉伙紝鍏佽鏌愪簺琛ㄥ彧杩佺Щ寮€澶存垨缁撳熬鐨勬寚瀹氭暟閲忕殑鏁版嵁
 * 
 * v8.6.2012.0521   鏀硅繘EntityList锛屽鍔燭oList鏂规硶锛岃繑鍥濴ist<T>褰㈠紡鐨勫垪琛紝鏂逛究浣跨敤Linq
 * 
 * v8.6.2012.0515   澧炲姞妯″瀷瑙ｆ瀽鎺ュ彛锛岀敤浜庢牸寮忓寲鏁版嵁妯″瀷琛ㄥ悕瀛楁鍚嶇瓑锛屽舰鎴愭洿浼樼殑鍒悕锛堢被鍚嶅拰灞炴€у悕锛?
 * 
 * v8.5.2012.0508   澧炲姞鏁版嵁杞崲鍔熻兘锛屾敮鎸佸湪涓嶅悓閾炬帴闂翠簰瀵兼暟鎹?
 * 
 * v8.5.2012.0507   淇敼IEntityPersistence鎺ュ彛锛屽鍔犱袱涓簨浠剁敤浜庢槸鍚﹁嚜鍔ㄨ缃瓽uid鍜屾槸鍚﹀厑璁稿悜鑷鍒楁彃鍏ュ€?
 *                  榛樿涓嶅啀鑷姩璁剧疆Guid
 *                  鍙€氳繃璁剧疆鍏佽鍚戣嚜澧炲垪鎻掑叆鍊硷紝鍙敤浜庢暟鎹鍒?
 * 
 * v8.5.2012.0422   淇鏇存敼瀹炰綋绫荤殑杩炴帴鍚嶅拰琛ㄥ悕鏃舵病鏈夋纭鐞嗘灦鏋勬鏌ワ紝瀵艰嚧鎬ц兘浣庝笅鐨凚UG
 * 
 * v8.5.2012.0401   IEntityList鎺ュ彛澧炲姞ToDataTable绛夋柟娉?
 * 
 * v8.5.2012.0323   Insert鍜孶pdate鏃讹紝澶у瓧娈典娇鐢ㄥ弬鏁颁紶閫掞紝鑷虫锛孹Code瀹屾暣鏀寔鎵€鏈夋暟鎹被鍨嬨€傛劅璋鑰佸緪锛坓regorius 279504479锛?
 *                  淇瀵归粯璁ゅ€肩殑澶勭悊鐨勯敊璇紝璇ラ敊璇鑷村垱寤鸿〃鏃舵棤娉曚娇鐢ㄥ瓧绗︿覆榛樿鍊?
 *                  
 * v8.4.2012.0322   Entity.Save涓紝瀵逛簬闈炶嚜澧炰富閿紝濡傛灉鍞竴涓婚敭涓嶄负绌猴紝搴旇閫氳繃鍚庨潰鍒ゆ柇锛岃€屼笉鏄洿鎺pdate
 * 
 * v8.4.2012.0320   FieldItem澧炲姞IsNullOrEmpty鍜孨otIsNullOrEmpty鏂规硶
 * 
 * v8.4.2012.0316   鎰熻阿@鏅村ぉ锛?12684802锛夊拰@鑰佸緪锛坓regorius 279504479锛夛紝杩欓噷鐨勬渶灏忓拰寮€濮嬪繀椤绘槸0锛屾彃鍏ョ殑鏃跺€欐湁++i鐨勬晥鏋滐紝鎵嶄細寰楀埌浠?寮€濮嬬殑缂栧彿
 * 
 * v8.4.2012.0309   IDatabase鎺ュ彛澧炲姞琛ㄧずGuid鑾峰彇鍑芥暟鐨勫睘鎬ewGuid
 *                  鏁版嵁灞傚鍔犲Guid榛樿鍊肩殑鏀寔锛岀敤浜嶥DL鎿嶄綔
 *                  鎻掑叆鏁版嵁鏃讹紝閽堝娌℃湁璧嬪€肩殑Guid瀛楁鎴栬缃簡Guid榛樿鍊肩殑瀛楃涓插瓧娈碉紝榛樿璁剧疆涓€涓狦uid锛岀敱EntityPersistence瀹炵幇
 * 
 * v8.4.2012.0224   淇DbSession.InsertAndGetIdentity姘歌繙杩斿洖0鐨勯敊璇紝璇ラ敊璇簬20110224浜х敓锛屽奖鍝峅racle鍜孎irebird锛屾劅璋?@鑰佸緪锛?79504479锛?
 *                  閽堝鎬т紭鍖栧厓鏁版嵁鏋舵瀯锛屼紭鍖栨鍚戝伐绋嬨€佸弽鍚戝伐绋嬬殑鎬ц兘锛岃幏鍙栧崟琛ㄦā鍨嬩俊鎭椂锛屼粎鑾峰彇璇ヨ〃鏋舵瀯淇℃伅锛屽Oracle鍙嶅悜宸ョ▼鎬ц兘鎻愬崌杈冨ぇ
 * 
 * v8.4.2012.0221   澧炲姞鎺掑簭琛ㄨ揪寮廜rderExpression锛屽瓧娈礔ieldItem澧炲姞鎺掑簭鐨凙sc鍜孌esc
 * 
 * v8.4.2012.0218   鏀硅繘XCode.Code锛屽鍔犲崟鐙殑璋冭瘯寮€鍏砐Code.Code.Debug
 * 
 * v8.4.2012.0216   淇SelectBuilder涓竴涓鑷碙imit寮廠QL鍑洪敊鐨凚UG
 * 
 * v8.4.2012.0215   淇EntityTree.FindByPath涓殑涓€涓狟UG锛屾煡鎵惧绾ц矾寰勬椂锛屾棤娉曟妸keys鍙傛暟浼犲叆鍐呴儴锛屽鑷存湁浜涙椂鍊欐煡鎵惧け璐?
 * 
 * v8.4.2012.0113   淇DbFactory涓幏鍙栭粯璁ゆ彁渚涜€呮椂鐨凚UG
 *                  DbMetaData涓紝鏃犳硶璇嗗埆瀛楁绫诲瀷鏃讹紝杈撳嚭鏃ュ織
 *                  淇娌℃湁璁剧疆builder.IsInt瀵艰嚧鍒嗛〉娌℃湁閫夋嫨鏈€浣崇殑MaxMin鐨凚UG锛屾劅璋?@RICH(20371423)
 * 
 * v8.4.2011.1223   鏁版嵁灞傛敮鎸佸瓨鍌ㄨ繃绋嬪強鍙傛暟鍖栨煡璇?
 * 
 * v8.3.2011.1222   淇SQLite浼氬鍐呭瓨鏁版嵁搴撹皟鐢ㄥ垱寤烘暟鎹簱鐨凚UG
 *                  淇敼EntityAssembly鎵€闇€瑕佺殑鍙傛暟锛屾敮鎸佷紶鍏DataTable闆嗗悎鏉ョ敓鎴愬疄浣?
 * 
 * v8.3.2011.1208   EntityList澧炲姞鎺掑簭鏂规硶Up/Down锛屾敮鎸佽皟鏁存煇涓疄浣撳璞″湪鍒楄〃涓殑鎺掑簭
 *                  IEntity澧炲姞EqualTo锛岀敤浜庡垽鏂袱涓疄浣撳璞″湪涓婚敭涓婃槸鍚︾浉绛?
 *                  IEntity澧炲姞SetNullKey锛岀敤浜庢妸瀹炰綋瀵硅薄鐨勪富閿暟鎹缃负绌?
 *                  IDatabase澧炲姞StringConcat鏂规硶锛岃〃绀烘暟鎹簱涓繛鎺ヤ袱涓瓧绗︿覆
 *                  淇鍙嶅悜宸ョ▼涓璕eBuildTable鐨凚UG锛孲QLite涓瓧绗︿覆杩炴帴浣跨敤||鑰屼笉鏄?
 * 
 * v8.3.2011.1207   淇MSPageSplit.DoubleTop鍒嗛〉鏈€鍚庝竴椤靛彲鑳芥湁閿欒鐨勯棶棰橈紝姣忔璁＄畻鍒嗛〉閮芥煡璇㈡€昏褰曟暟鍒ゆ柇澶勭悊
 *                  淇鍙嶅悜宸ョ▼涓璖QLite鏃犳硶鍒犻櫎瀛楁鐨凚UG
 * 
 * v8.3.2011.1204   瀹炰綋璁块棶鍣ㄦ帴鍙ｅ鍔燨nError浜嬩欢锛屽厑璁稿閮ㄦ帶鍒跺紓甯革紝榛樿鍚戝鎶涘嚭銆?
 *                  Entity<>.Delete鍒犻櫎瀹炰綋鏃讹紝濡傛灉瀹炰綋鏈変笖浠呮湁涓婚敭鏈夎剰鏁版嵁锛屽垯鍏堟煡璇竴娆″啀璋冪敤OnDelete鍒犻櫎锛岄伩鍏嶆墿灞曞垹闄ゅけ璐?
 * 
 * v8.3.2011.1201   涓嶅啀鏀寔寮傛鍒濆鍖栨暟鎹甀nitData锛屽洜涓哄畠瀹炲湪瀹规槗鍑洪棶棰樸€傚鑻ラ渶瑕佸紓姝ュ垵濮嬪寲锛屽彲鍦↖nitData涓嚜宸卞疄鐜般€?
 * 
 * v8.3.2011.1126   HttpEntityAccessor妫€鏌ユ暟鎹被鍨嬫槸鍚︽弧瓒崇洰鏍囩被鍨嬶紝濡傛灉涓嶆弧瓒冲垯璺宠繃锛屼互鍏嶅唴閮ㄨ祴鍊煎紓甯稿鑷寸▼搴忓鐞嗗嚭閿?
 * 
 * v8.3.2011.1124   Entity澧炲姞SaveWithoutValid鏂规硶锛屼笉闇€瑕侀獙璇佺殑淇濆瓨锛屼笉鎵цValid锛屼竴鑸敤浜庡揩閫熷鍏ユ暟鎹?
 * 
 * v8.3.2011.1123   淇鍙嶅悜宸ョ▼妫€鏌ュ疄浣撶被琛ㄦ灦鏋勬椂锛屾湁浜涘疄浣撶被鎵€鍦ㄧ▼搴忛泦灏氭湭鍔犺浇锛屽鑷存湭鑳芥鏌ョ殑闂锛屾敼涓洪娆′娇鐢ㄦ椂妫€鏌?
 *                  閽堝缂撳瓨銆佹暟鎹垵濮嬪寲銆佹鏌ヨ〃鏋舵瀯锛屾坊鍔犲悇绉嶈皟璇曟棩蹇楋紝鏂逛究妫€鏌ヨ皟璇曠▼搴?
 *                  淇ModelHelper.GetIndex鐨勯敊璇紝璇ラ敊璇鑷翠簡鍙嶅悜宸ョ▼棰戠箒鐨勫垹闄ゅ苟鍒涘缓绱㈠紩
 * 
 * v8.3.2011.1122   澶嶅涓€绾х紦瀛樸€佸疄浣撶紦瀛樸€佸崟瀵硅薄缂撳瓨浠ｇ爜锛屽鍔犲叧閿偣鍐欐棩蹇楀姛鑳斤紝鏂逛究璋冭瘯鍙兘鍥犵紦瀛樿€屽紩璧风殑鍚勭闂
 * 
 * v8.3.2011.1121   EntityTree澧炲姞EnableCaching灞炴€э紝鎸囧畾鏄惁缂撳瓨Childs銆丄llChilds銆丳arent绛夛紝榛樿涓簍rue
 * 
 * v8.3.2011.1120   澧炲姞瀹炰綋渚濊禆绫籈ntityDependency銆傜敤浜嶩ttpRuntime.Cache锛屼竴鏃︽寚瀹氱殑瀹炰綋绫绘暟鎹敼鍙橈紝椹笂璁╃紦瀛樿繃鏈熴€?
 * 
 * v8.3.2011.1118   淇SelectBuilder.SelectCount鏂规硶涓殑BUG锛屽綋鏉′欢瀛楀彞鍖呭惈GroupBy鏃讹紝澶勭悊涓嶆纭€傝BUG鐢盄琛岃蛋姹熸箹锛?34163320锛夊彂鐜?
 *                  鏂板瀛楁淇℃伅绫籉ield锛岀户鎵胯嚜FieldItem锛屼粎浠呬负浜嗛噸杞界瓑鍙疯繍绠楃锛岀敤浜庡疄浣撴暟鎹被鍐呯疆鐨勫瓧娈典俊鎭被
 *                  WhereExpression澧炲姞宸﹀彸灏忔嫭鍙锋敮鎸侊紝And杩愮畻鑷姩妫€娴嬪乏鍙冲瓧鍙ュ苟鍔犱笂灏忔嫭鍙凤紙淇濆畧鍋氭硶锛屽彧瑕佹湁Or灏卞姞锛?
 * 
 * v8.3.2011.1117   淇敼EntityTree锛屽鍔燜ullPath銆丗ullParentPath銆乀reeNodeName绛夊睘鎬?
 *                  閲嶆瀯IEntityTree鎺ュ彛
 * 
 * v8.3.2011.1115   IDataTable鍜孖DataColumn澧炲姞鍙灞炴€isplayName锛屼紭鍏堣繑鍥濪escription锛岀劧鍚庢墠鏄疦ame
 *                  淇MSPageSplit涓叧浜嶳owNumber鍜孌oubleTop鍒嗛〉鐨勯敊璇?
 * 
 * v8.3.2011.1114   淇敼Entity<>.Meta.CheckModel锛屽姞涓婇攣锛岃澶氫釜绾跨▼鍚屾椂璁块棶鍚屼竴涓疄浣撹〃鐨勬搷浣滐紝鍏ㄩ儴鍗″湪妫€鏌ユā鍨嬩箣鍚庯紝閬垮厤鏈垱寤哄疄浣撹〃鑰屾姤閿?
 * 
 * v8.3.2011.1111   濡傛灉鍚敤浜嗕簨鍔′繚鎶わ紝GetSchema瑕佹柊寮€涓€涓繛鎺ワ紝鍚﹀垯MSSQL閲岄潰鎶ラ敊锛孲QLite涓嶆姤閿欙紝鍏跺畠鏁版嵁搴撴湭娴嬭瘯
 * 
 * v8.3.2011.1109   澧炲姞瀹炰綋鎸佷箙鍖栨帴鍙EntityPersistence锛屽疄浣撶被涓殑Insert/Update/Delete鐢辫鎺ュ彛瀹炵幇锛屽彲閫氳繃璇ユ帴鍙ｅ疄鐜板弬鏁板寲DbCommand
 *                  IEntityOperate澧炲姞Execute绛夋暟鎹簱鎿嶄綔锛岀浉姣斾簬DAL鐨勬暟鎹簱鎿嶄綔锛岃繖閲岀殑鎿嶄綔浼氳Е鍙戝疄浣撶被瀹炰綋缂撳瓨鏇存柊
 *                  瀹炰綋绫讳腑锛岄獙璇佹暟鎹槸鍚﹀凡瀛樺湪鏃讹紝蹇界暐鑷
 * 
 * v8.2.2011.1108   IEntityOperate澧炲姞缂撳瓨鏌ヨ
 * 
 * v8.2.2011.1107   缁橧EntityOperate.Create鍜孍ntity.CreateInstance鍔犱笂榛樿鍙傛暟forEdit锛岃〃绀烘槸鍚︿负浜嗙紪杈?FindByKeyForEdit)鑰屽垱寤猴紝榛樿涓篺alse
 *                  瀹炰綋绫诲彲閲嶅啓Entity.CreateInstance锛屾牴鎹弬鏁癴orEdit锛屽涓轰簡鍦ㄧ晫闈笂鏂板鑰屽垱寤虹殑瀹炰綋杩涜鍒濆鍖?
 * 
 * v8.2.2011.1103   閲嶆瀯MS鍒嗛〉绠楁硶锛屽垎涓篗axMin鍒嗛〉锛堟暟瀛椾富閿紭鍏堥€夋嫨锛夈€丯otIn鍒嗛〉锛堝熀鏈簾寮冿級銆佸弻Top鍒嗛〉锛堟浛浠otIn锛夈€丷owNumber鍒嗛〉锛堥珮鐗堟湰閫夋嫨锛?
 * 
 * v8.2.2011.1101   SqlServer澧炲姞杩炴帴瀛楃涓茶缃瓺ataPath锛岀敤浜庢寚瀹氬弽鍚戝伐绋嬪垱寤烘暟鎹簱鏃舵墍浣跨敤鐨勬暟鎹洰褰?
 *                  Oracle澧炲姞杩炴帴瀛楃涓茶缃瓺llPath锛岀敤浜庢寚瀹歄CI鐩綍锛屽悓鏃跺熀浜庤鐩綍鑷姩璁＄畻ORACLE_HOME鐩綍
 *                  Oracle澧炲姞璁剧疆椤筙Code.Oracle.IsUseOwner锛屾寚瀹氭鍚戝伐绋嬫椂鏄惁浣跨敤Owner绾︽潫鎵€鏌ヨ鐨勮〃
 *                  鏀寔杩炴帴瀛楃涓茬紪鐮佸姞瀵嗭紝閬垮厤鏄庢枃锛屾槑鏂?>UTF8瀛楄妭=>Base64锛屽彲璋冪敤DAL.EncodeConnStr瀹炵幇
 *                  濡傛灉闇€瑕侀珮绾у姞瀵嗭紝鍒欎笉瑕佸湪閰嶇疆鏂囦欢涓缃繛鎺ュ瓧绗︿覆锛岃€屾敼涓虹紪鐮侀€氳繃DAL.AddConnStr娣诲姞
 *                  **浣跨敤瀵硅薄瀹瑰櫒鍚庯紝瀹為檯椤圭洰绋冲畾杩愯鍗婁釜鏈堬紝鐗堟湰鍙崌绾у埌8.2
 * 
 * v8.1.2011.1020   瀹炰綋缂撳瓨EntityCache鍙婃帴鍙ｅ鍔犱竴涓娇鐢ㄥ鎵樿繘琛屾煡璇㈢殑FindAll
 * 
 * v8.1.2011.1019   淇娉ㄩ噴鍙嶅悜宸ョ▼璁剧疆椤瑰悗锛屽崟琛ㄤ娇鐢ㄧ殑鍙嶅悜宸ョ▼浠嶇劧妫€鏌ョ殑闂
 *                  FieldItem澧炲姞NotIn鏀寔
 * 
 * v8.1.2011.1018   鏀瑰杽瀹炰綋鍩虹被Entity锛屽浜嶧indAll鍜孎indCount锛屽鏋滄煡璇㈢殑鏉′欢鏄崟涓€涓婚敭鎴栬€呰嚜澧烇紝骞朵笖涓虹┖锛屽垯鍙栨秷鏌ヨ
 * 
 * v8.1.2011.1017   鏀瑰杽Oracle鏀寔涓婄殑涓€浜涢棶棰?
 *                  瀹屽杽瀵硅薄瀹瑰櫒鐨勪娇鐢?
 * 
 * v8.1.2011.1016   涓㈠け涓婚敭鐨勯棶棰樼粡甯稿彂鐢燂紝鐜板湪淇敼DefaultCondition锛屽鏋滄病鏈変富閿紝鐩存帴鎶涘嚭寮傚父
 * 
 * v8.1.2011.1014   浣跨敤瀵硅薄瀹瑰櫒閲嶆瀯XCode涓殑鍚勪釜鎺ュ彛浣跨敤
 * 
 * v8.1.2011.1013   淇Entity鍜孍ntityList涓紝鍥犱负鎵归噺鏌ヨ涓嶅啀杩斿洖null鑰屽甫鏉ョ殑闂锛岀壒鍒槸Exist
 *                  SQLite寤鸿〃璇彞锛屽浜庡瓧绗︿覆绫诲瀷锛屽垱寤哄拷鐣ュぇ灏忓啓鐨勫瓧娈?
 * 
 * v8.1.2011.1012   淇缁欓潪涓婚敭鐨勮嚜澧炲瓧娈靛缓绔嬪敮涓€绱㈠紩涓殑缂栫爜閿欒
 * 
 * v8.1.2011.1010   FieldItem澧炲姞瀵笽n鎿嶄綔绗︾殑鏀寔
 * 
 * v8.1.2011.1008   IEntityOperate涓繑鍥濫ntityList<IEntity>鏀逛负杩斿洖IEntityList锛岀洿鎺ヨ繑鍥炲師濮嬬殑瀹炰綋绫诲垪琛?
 * 
 * v8.0.2011.0929   淇IDataTable.Fix涓涓€瀵逛竴鍏崇郴澶勭悊鐨勪笉瓒?
 *                  淇敼Entity锛屾牴鎹敮涓€绱㈠紩鏌ヨ鍗曞璞℃椂涓嶅姞鍒嗛〉鍜屾帓搴忥紝杩欎娇寰楀湪SQLite涓婄壒鍒槸MySql涓婃湁鎬ц兘鎻愬崌
 * 
 * v8.0.2011.0917   缁欑储寮曞拰鍏崇郴妯″瀷澧炲姞Computed灞炴€э紝鏍囪瘑鏄绠楀嚭鏉ヨ繕鏄暟鎹簱鍐呯疆鐨?
 * 
 * v8.0.2011.0912   閲嶆瀯鍙嶅悜宸ョ▼锛屽簾闄atabaseSchema绫伙紙鏃х増鏈殑鍙嶅悜宸ョ▼鏍稿績锛夛紝灏嗗叾鍔熻兘鍚堢悊鍒嗛厤鍒板悇涓湴鏂癸紝鍏煎鍚勭鏁版嵁搴撳湪鍙嶅悜鏃剁殑宸紓
 *                  澧炲姞ModelCheckModeAttribute鐗规€э紝鍙敤浜庢帶鍒跺疄浣撶被鏄湪鍒濆鍖栬繛鎺ユ椂杩樻槸绗竴娆′娇鐢ㄨ瀹炰綋绫荤殑鏁版嵁琛ㄦ椂妫€鏌ユā鍨嬶紙鍙嶅悜宸ョ▼锛?
 * 
 * v8.0.2011.0911   瀹屽杽妯″瀷鐨勬ā鍨嬬壒鎬э紝渚夸簬浠ｇ爜鐢熸垚鍣ㄤ腑鐨勬ā鍨嬬鐞?
 * 
 * v8.0.2011.0910   鏁版嵁灞備娇鐢ㄥ叏鏂扮殑鎺ュ彛IDataTable銆両DataColumn銆両DataIndex銆両DataRelation
 *                  灏濊瘯浣跨敤鏈嶅姟鎻愪緵鑰咃紝澶栭儴鍙浛浠ｅ唴閮ㄥ悇鎺ュ彛瀹炵幇
 *                  鏁版嵁灞?瀹炰綋灞傘€佹鍚?鍙嶅悜宸ョ▼ 澧炲姞绱㈠紩鏀寔锛屽湪閮ㄧ讲鍒扮敓鎴愮幆澧冩椂鍚屾鍒涘缓绱㈠紩锛屼繚璇佺郴缁熸渶浣虫€ц兘
 *                  涓板瘜瀹炰綋绫荤殑娣诲垹鏀规煡锛屽鍔犲绉嶅父瑙侀〉闈㈢敤娉?
 *                  閲嶇偣锛氭妸鏁版嵁搴?>瀹炰綋绫?椤甸潰鐨勭敤娉曪紝鏀逛负妯″瀷+妯＄増=>鏁版嵁搴?瀹炰綋绫?椤甸潰鐨勪娇鐢ㄦ柟寮忥紝鎵╁ぇ鏁版嵁鏋舵瀯鐨勮〃鐜拌兘鍔涳紝鍏ㄥ姏鏀寔榄旀柟骞冲彴
 * 
 * v7.16.2011.0803  淇MSSQL涓垱寤烘暟鎹簱鎸囧畾鏂囦欢浣嶇疆鏃跺嚭閿欑殑BUG
 *                  澧炲姞璁剧疆椤筍QLPath锛屽厑璁告妸SQL鏃ュ織鍐欏叆鍒板崟鐙殑SQL鏃ュ織涓?
 * 
 * v7.15.2011.0725  淇EntityFactory涓垱寤哄疄浣撴搷浣滆€呭彲鑳藉嚭鐜扮殑BUG锛岃В鍐抽潪娉涘瀷缁ф壙鐨勯棶棰橈紝濡侫dmin=>Administrator=>Administrator<Administrator>
 * 
 * v7.14.2011.0723  澧炲姞瀹炰綋缂撳瓨鎺ュ彛IEntityCache鍜屽崟瀵硅薄缂撳瓨鎺ュ彛ISingleEntityCache
 *                  IEntityOperate澧炲姞缂撳瓨绛夋搷浣滄敮鎸?
 * 
 * v7.13.2011.0622  浼樺寲SQLite锛屽鏋滃閮ㄤ笉鎸囧畾缂撳瓨澶у皬绛夊弬鏁帮紝鍒欒嚜鍔ㄤ娇鐢ㄦ渶楂樻€ц兘鐨勫弬鏁?
 * 
 * v7.12.2011.0614  SQLite澧炲姞瀵瑰唴瀛樻暟鎹簱鐨勬敮鎸侊紝鏁版嵁婧愯缃负:memory:鎴栬€呯┖锛屽嵆琛ㄧず浣跨敤鍐呭瓨鏁版嵁搴?
 * 
 * v7.11.2011.0613  淇v7.8.2011.0510涓慨鏀规椂閬楃暀涓嬫潵鐨勯棶棰橈紝涓€涓槸SQLite.DropColumnSQL涓妸涓や釜鍙傛暟鍐欏弽浜嗭紝涓€涓槸DatabaseSchema涓紝濡傛灉鍏堝鍔犲瓧娈靛悗鍒犻櫎瀛楁浼氬嚭閿?
 * 
 * v7.11.2011.0612  淇v7.10.2011.0608涓慨鏀规椂閬楃暀涓嬬殑闂锛屽畬鏁村疄鐜版渶澶ф渶灏忓€煎垎椤碉紝鍚屾椂鍙戠幇TopNotIn鍒嗛〉鍜孧axMin鍒嗛〉鏃犳硶瀹岀編鐨勬敮鎸丟roupBy鏌ヨ鍒嗛〉锛屽彧鑳芥煡鍒扮涓€椤?
 * 
 * v7.11.2011.0611  淇v7.10.2011.0608涓慨鏀规椂閬楃暀涓嬬殑闂锛岃幏鍙栧垪琛ㄦ椂榛樿浣跨敤鑷瀛楁闄嶅簭锛屾牴鎹富閿幏鍙栧崟璁板綍鐨勬柟娉曠粫杩囨澶勶紝鍏嶅彈褰卞搷
 *                  闈炲父閲嶈锛氫慨鏀笶ntityBase锛岀粰瀹炰綋绫绘暟鎹睘鎬ц祴鍊兼椂锛屽鏋滄柊鏃у€肩浉绛夛紝涓嶅奖鍝嶈剰鏁版嵁锛屽墣闇€瑕佸奖鍝嶈剰鏁版嵁锛岃浣跨敤SetItem
 * 
 * v7.11.2011.0610  淇敼DbBase锛屽浜庨渶瑕佸閮ㄦ彁渚涜€呯殑鏁版嵁搴撶被鍨嬶紝鍦ㄦ病鏈夋彁渚涜€呯▼搴忛泦鏃讹紝鑷姩浠庣綉缁滀笂涓嬭浇锛岀瓑寰?绉?
 * 
 * v7.10.2011.0608  Entity涓嚜澧炴垨鑰呬富閿煡璇紝璁板綍闆嗚偗瀹氭槸鍞竴鐨勶紝涓嶉渶瑕佹寚瀹氳褰曟暟鍜屾帓搴?
 * 
 * v7.9.2011.0603   瀹炰綋绫诲鍔犱笁涓牴鎹疄浣撶紦瀛樻煡鎵炬暟鎹殑鏂规硶锛屾柟渚縊bjectDataSource缁戝畾
 * 
 * v7.9.2011.0602   淇EntityTree涓殑鎺掑簭閿欒锛屽鍔犲崌闄嶆帓搴忔柟娉曪紝鏀寔鍚岀骇鍗囬檷鎺掑簭
 * 
 * v7.9.2011.0529   瀹炰綋绫绘坊鍒犳敼鎷嗗垎涓ら儴鍒嗭紝OnInsert/OnUpdate/Delete浣滀负鎿嶄綔鏁版嵁鐨勭湡瀹炴搷浣滐紝Insert/Update/Delete浣滀负璋冪敤鑰咃紝閰嶅悎浠ユ暟鎹獙璇佸拰浜嬪姟淇濇姢
 *                  澧炲姞鏁版嵁楠岃瘉Valid锛屽疄浣撶被鍙互閲嶈浇锛屼互瀹炵幇Insert/Update鍓嶉獙璇佹暟鎹紝灏嗘潵鍙兘鏍规嵁鏁版嵁瀛楁鐗规€ц繘琛岃嚜鍔ㄥ寲楠岃瘉銆?
 *                  澧炲姞鏁版嵁瀛樺湪鍒ゆ柇Exist锛屽紑鍙戣€呭彲鏍规嵁闇€瑕佽皟鐢紝寤鸿鐢ㄤ簬涓氬姟涓婚敭鐨勫瓨鍦ㄦ€у垽鏂€侰heckExist鍙互鍦ㄥ垽鏂悗鎶涘嚭寮傚父銆?
 * 
 * v7.9.2011.0526   閲嶆瀯XCode瀹炰綋灞傚厓鏁版嵁閮ㄥ垎锛屼娇鐢ㄥ叕寮€鐨凾ableItem鏇夸唬淇濇姢鐨刋CodeConfig锛岄厤鍚團ieldItem褰㈡垚瀹屾垚鐨勫疄浣撳厓鏁版嵁缁撴瀯
 *                  浣跨敤涓撶敤绫诲疄鐜癐EntityOperator鎺ュ彛锛岄伩鍏嶅師鏉ヨ噧鑲跨殑缁撴瀯
 * 
 * v7.8.2011.0512   鏇存柊SelectBuilder锛屾洿鏂癚ueryCount鐩稿叧浠ｇ爜锛屼繚璇佺敓鎴愭渶绮剧畝鐨凲ueryCount鏌ヨ璇彞锛屽浜嶮ySql鑰岃█锛岄伩寮€瀛愭煡璇紝鏈夊法澶х殑鎬ц兘浼樺娍
 * 
 * v7.8.2011.0510   澧炲己SQLite鐨勫弽鍚戝伐绋嬭兘鍔涳紝SQLite涓嶆敮鎸佷慨鏀瑰瓧娈靛拰鍒犻櫎瀛楁锛屼絾鏄彲浠ラ€氳繃鏂板缓琛ㄧ劧鍚庡鍒舵暟鎹殑鏂瑰紡鏇夸唬锛屽苟涓旇В鍐充簡鏂板涓嶅厑璁哥┖涓斿張娌℃湁榛樿鍊肩殑瀛楁鏃跺嚭閿欑殑闂
 * 
 * v7.7.2011.0429   淇Access鍒涘缓琛ㄦ椂涓嶅簲璇ュ悓鏃舵搷浣滈粯璁ゅ€肩殑閿欒
 * 
 * v7.6.2011.0420   淇XCode涓弽鍚戝伐绋嬫ā鍧楀垽鏂槸鍚︽櫘閫氬疄浣撶被鐨勯敊璇?
 * 
 * v7.6.2011.0409   閲嶆柊鍚敤瀹炰綋绫荤殑ToData锛屽厑璁稿疄浣撴暟鎹浆鍖栦负DataRow
 *                  EntityList澧炲姞ToDataTable鍜孴oDataSet绛夋柟娉曪紝鍏佽瀹炰綋闆嗗悎杞负鏁版嵁闆嗭紝骞堕€氳繃浜嬩欢鎶婃暟鎹泦鐨勬坊鍒犳敼鎿嶄綔濮旀墭鍒板疄浣撴搷浣?
 *                  涓€绾х紦瀛橀粯璁よ缃敼涓鸿姹傜骇缂撳瓨锛岄伩鍏嶅湪Web椤圭洰涓洜涓嶆褰撲娇鐢ㄦ煡璇㈣€屽甫鏉ョ殑鎬ц兘鎹熻€?
 * 
 * v7.5.2011.0403   淇XField涓璛ml搴忓垪鍖栫殑闂
 * 
 * v7.5.2011.0401   澧炲姞Json鏀寔
 * 
 * v7.4.2011.0331   瀹炰綋绫籌nsert鍚庢竻绌鸿剰鏁版嵁锛岄伩鍏嶈繛缁袱娆ave鍙樻垚涓€娆nsert鍜屼竴娆pdate
 *                  淇瀹炵幇缁勪欢妯″瀷鎺ュ彛涓殑涓€浜涢棶棰橈紝娴嬭瘯閫氳繃锛屽熀鏈笂婊¤冻WinForm寮€鍙戣姹?
 * 
 * v7.4.2011.0330   淇3鏈?3鍙锋洿鏂癝qlServer鏃跺甫鏉ョ殑鍙︿竴涓敊璇€斺€旀棤娉曞垱寤鸿嚜澧炲瓧娈碉紱鍚屾椂澧炲姞浜嗘妸鍘熷瓧娈佃缃负鑷瀛楁鐨勫姛鑳斤紝鍏堝垹鍚庡姞锛?
 * 
 * v7.4.2011.0329   淇鍔ㄦ€佺敓鎴愪唬鐮佹椂灞炴€у悕涓庣被鍨嬮噸鍚嶅鑷寸紪璇戝嚭閿欑殑闂
 *                  XTable鍜孹Field瀹炵幇鍏嬮殕鎺ュ彛
 *                  EntityBase瀹炵幇INotifyPropertyChanging, INotifyPropertyChanged, ICustomTypeDescriptor, IEditableObject鎺ュ彛
 *                  EntityList瀹炵幇ITypedList, IBindingList, IBindingListView, ICancelAddNew鎺ュ彛
 * 
 * v7.4.2011.0325   Entity鎵€鏈夊熀绫绘爣璇嗕负鍙簭鍒楀寲
 * 
 * v7.4.2011.0323   淇敼鍙嶅悜宸ョ▼锛屽綋澶氫釜瀹炰綋绫讳娇鐢ㄥ悓涓€鏁版嵁琛ㄦ椂锛屼紭鍏堜娇鐢ㄩ潪閫氱敤瀹炰綋绫?
 *                  淇敼SqlServer鎻愪緵鑰咃紝鏀寔淇敼瀛楁鐨勪富閿睘鎬?
 * 
 * v7.4.2011.0321   EntityList澧炲姞Join鏂规硶锛屼覆鑱旀寚瀹氭垚鍛橈紝鏂逛究鐢卞疄浣撻泦鍚堟瀯閫犵敤浜庢煡璇㈢殑瀛愬瓧绗︿覆
 *                  杩涜寮傛鏁版嵁鍒濆鍖栨椂锛屽鏋滃唴閮ㄩ亣鍒板叾瀹冩暟鎹垵濮嬪寲锛屽垯鍦ㄥ綋鍓嶇嚎绋嬭繘琛屽鐞嗭紝淇濊瘉鏁版嵁鍒濆鍖栫殑鍚屾杩涜锛屼繚璇佹煇浜涗笟鍔℃暟鎹殑鍒濆鍖栧畨瑁呴瀹氶『搴忚繘琛屻€?
 * 
 * v7.4.2011.0318   瀹炰綋缂撳瓨澧炲姞鏄惁鍏佽绌虹殑璁剧疆锛屽鏋滀笉鍏佽绌哄垯鍗充娇缂撳瓨鏈繃鏈熶篃杩涜鏁版嵁鍒锋柊
 *                  绋嶅井浼樺寲瀹炰綋缂撳瓨鍜屽崟瀵硅薄缂撳瓨锛屾彁鍗囨€ц兘
 *                  璁″垝鍔犲己鍚勪釜缂撳瓨锛岀壒鍒槸鍗曞璞＄紦瀛橈紝鍒╃敤缁存姢绾跨▼鍒犻櫎杩囨湡缂撳瓨椤癸紝涔熷彲鑳藉€熷姪System.Web.Caching.Cache
 * 
 * v7.3.2011.0314   淇瀹炰綋鍩虹被闈欐€佹瀯閫犲嚱鏁扮殑姝婚攣闂锛屾劅璋㈤偙楣忓彂鐜拌闂锛?
 * 
 * v7.3.2011.0313   鎵╁睍EntityTree锛屽鍔燙ontains銆丆hildKeys銆丆hildKeyString銆丄llChildKeys銆丄llChildKeyString
 *                  淇敼EntityBase锛孏etExtend鏂规硶澧炲姞鏄惁缂撳瓨榛樿鍊肩殑閫夐」锛屼娇鐢ㄨ€呭彲浠ラ€夋嫨鍦ㄥ彇涓嶅埌鏁版嵁鏃舵槸鍚︾紦瀛樹唬琛ㄧ┖鐨勯粯璁ゅ€?
 *                  淇敼EntityTree鐨凴oot灞炴€э紝涓嶇紦瀛樼┖鍊硷紝澶у鏁版儏鍐典笅锛屾爲褰㈢粨鏋勭殑鏁版嵁閮戒笉搴旇涓虹┖
 * 
 * v7.3.2011.0311   淇闈濵S鏁版嵁搴撶殑鍒嗛〉閿欒
 * 
 * v7.3.2011.0310   淇鍒ゆ柇淇濈暀瀛楁椂浣跨敤娉涘瀷List瀵艰嚧鎬ц兘浣庝笅鐨凚UG锛屾敼涓篋ictionary
 * 
 * v7.3.2011.0307   澧炲姞瀵笷irebird鍜孭ostgreSQL鐨勬敮鎸侊紝鏈畬鍏ㄦ祴璇曢€氳繃
 * 
 * v7.2.2011.0303   瀹炰綋鎿嶄綔鎺ュ彛澧炲姞InitData鏂规硶锛屽疄浣撶被鍙互閲嶈浇锛岀敤浜庡湪绗竴娆′娇鐢ㄦ暟鎹簱鏃跺垵濮嬪寲鏁版嵁
 * 
 * v7.1.2011.0228   MSSQL涓娇鐢ㄦ灦鏋勪俊鎭垽鏂暟鎹簱鍜屾暟鎹〃鏄惁瀛樺湪锛岄伩鍏嶆煇浜涙儏鍐典笅娌℃湁鏉冮檺浣跨敤绯荤粺瑙嗗浘鑰屽嚭閿?
 *                  IDatabase鎺ュ彛澧炲姞淇濈暀瀛楀拰FormatName鏂规硶锛屽彧鏈夊叧閿瓧鎵嶈繘琛屾牸寮忓寲
 * 
 * v7.1.2011.0224   璋冩暣鏂规硶InsertAndGetIdentity
 *                  SQLite涓幓鎺夎鍐欓攣锛屾敼涓哄啓鍏ユ椂鍒ゆ柇鏁版嵁搴撴槸鍚﹂攣瀹氾紝濡傛灉宸查攣瀹氬垯閲嶈瘯
 * 
 * v7.1.2011.0223   璋冩暣Oracle鐨勬暟鎹灦鏋勫姛鑳?
 *                  Oracle澧炲姞蹇€熸煡鎵捐〃璁板綍鏁版柟娉?
 *                  XField璋冩暣锛岃鑼冨寲闀垮害銆佸瓧鑺傛暟銆佺簿搴﹀拰浣嶆暟
 * 
 * v7.1.2011.0222   SQLite浣跨敤瀹屾暣璇诲啓閿侊紝閬垮厤璇诲彇鏃舵湁鍐欏叆鎿嶄綔鐒跺悗鎶ユ枃浠堕攣瀹?
 *                  SQLite鍐欏叆鎿嶄綔鍏佽閲嶈瘯涓ゆ锛屼互瑙ｅ喅楂樺苟鍙戞椂鏂囦欢閿佸畾鐨勫皬姒傜巼浜嬩欢
 *                  淇敼鏁版嵁搴撴灦鏋勶紝鍦ㄨ幏鍙栨暟鎹簱鏄惁瀛樺湪鍑虹幇寮傚父鏃讹紝榛樿鏁版嵁搴撳凡瀛樺湪锛屽洜涓轰竴鑸潵璇撮兘鏄病鏈夌鐞嗗憳鏉冮檺閫犳垚鐨勯敊璇紝骞朵笖澶у鏁版椂鍊欐暟鎹簱閮芥槸瀛樺湪鐨?
 *                  淇敼DAL鐨勬瀯閫犲嚱鏁帮紝妫€鏌ユ暟鎹簱鏋舵瀯鐨勫紓甯镐笉搴旇褰卞搷DAL鐨勬甯镐娇鐢?
 * 
 * v7.1.2011.0215   鐑績缃戝弸 Hannibal 鍦ㄥ鐞嗘棩鏂囩綉绔欐椂鍙戠幇鎻掑叆鐨勬棩鏂囦负涔辩爜锛圡SSQL锛夛紝杩欓噷鍔犱笂N鍓嶇紑锛屽悓鏃剁粰鏃堕棿鏃ユ湡鍔犱笂ts鍓嶇紑
 *                  SQLite鏁版嵁搴撳鐞嗗瓧鑺傛暟缁勬椂锛屽姞涓奨鍓嶇紑
 *                  鎶婂疄浣撶被涓殑SQL鏂规硶锛岃涓哄叡鏈夛紝渚夸簬澶栭儴鑾峰彇SQL璇彞
 * 
 * v7.1.2011.0212   澧炲姞缃戠粶鏁版嵁搴撴彁渚涜€匩etwork锛屾妸鍚勭鎿嶄綔鐩存帴璺敱缁欒繙绔?
 *                  澧炲姞鍒嗗竷寮忔暟鎹簱鎻愪緵鑰匘istributed锛屽悓鏃惰鍐欏涓暟鎹簱
 *                  璁捐鏂规鏈€浣冲疄璺碉細
 *                  1锛屼娇鐢∕ySql鑷韩鐨勯泦缇わ紝涓€涓诲浠庯紝XCode閰嶇疆浣跨敤鍒嗗竷寮忔彁渚涜€咃紝鏇存柊鍐欏叆涓诲簱锛屼粠鍚勪粠搴撹鍙栨暟鎹紝瀹炵幇璐熻浇鍧囪　
 *                  2锛屼娇鐢ㄧ綉缁滄暟鎹簱鎻愪緵鑰呭疄鐜拌矾鐢变腑杞紝瀹炵幇鏁呴殰杞Щ
 * 
 * v7.0.2011.0201   閲嶅啓鏁版嵁璁块棶灞傦紝渚夸簬鍔熻兘鎵╁睍
 *                  閲嶅啓鏁版嵁鏋舵瀯锛堝弽鍚戝伐绋嬶級锛屽畬鍠凷QLite鍜孧ySql鐨勫弽鍚戝伐绋嬫敮鎸?
 * 
 * v6.6.2010.1230   淇敼XCode绫诲瀷鏄犲皠妯″瀷锛岀粺涓€浣跨敤Schema淇℃伅锛屼笉鍐嶄汉涓烘寚瀹氱被鍨嬫槧灏勶紝鍏ㄩ儴浜ょ敱鏁版嵁搴撴彁渚涜€呭鐞?
 *                  鐢盋#绫诲瀷鍙嶅悜鍒版暟鎹被鍨嬬殑鏄犲皠灏氭湭瀹屾垚
 * 
 * v6.5.2010.1223   淇SQLite宸茬煡鐨勪竴浜涢棶棰橈紝鏌ユ壘dll鏂囦欢璺緞涓嶆纭紝鎵ц鎻掑叆璇彞涓嶆纭?
 *                  IEntity澧炲姞CopyFrom鏂规硶锛岀敤浜庝粠鎸囧畾瀹炰綋瀵硅薄澶嶅埗鎴愬憳鏁版嵁
 *                  澧炲姞瀵逛簩杩涘埗瀛楁鐨勬敮鎸侊紝琛ㄧ幇涓築yte[]
 * 
 * v6.4.2010.1217   淇Entity涓瑿heckColumn鏃犳硶姝ｇ‘璁＄畻閫夋嫨瀛楁鐨勯敊璇?
 *                  浼樺寲SelectBuilder锛屽厑璁竁here涓娇鐢℅roupBy瀛楀彞锛孴oString鏃惰嚜鍔ㄥ垎鍓插埌姝ｇ‘浣嶇疆
 *                  瀹炰綋绫诲鍔犻潤鎬佹柟娉旻indByKeyForEdit锛岀敤浜庢浛浠ｆā鐗堢敓鎴愪腑鐨凢indByKeyForEdit锛屼负灏嗚瀹炵幇鐨勮〃鍗曞熀绫伙紙鑷畾涔夎〃鍗曪級鍋氬噯澶?
 *                  ********************************
 *                  瀹炰綋鍩虹被缁ф壙鑷狟inaryAccessor锛孖Entity澧炲姞IIndexAccessor鎺ュ彛鍜孖BinaryAccessor鎺ュ彛锛屽鍔犲蹇€熺储寮曡闂拰浜岃繘鍒惰闂殑鏀寔
 *                  蹇€熺储寮曡闂細瀹炰綋绫诲彲浠ヤ笉蹇呯敓鎴愮储寮曞櫒浠ｇ爜锛孖IndexAccessor鐩存帴鎻愪緵鎸夊悕绉拌闂睘鎬?
 *                  浜岃繘鍒惰闂細鏀寔鎶婂疄浣撳璞″簭鍒楀寲鎴愪簩杩涘埗鎴栬€呭弽鍚戞搷浣?
 *                  杩欎袱涓姛鑳藉皻鏈粡杩囦弗鏍兼祴璇曪紝璇蜂笉瑕佺敤浜庢寮忕郴缁熶娇鐢紒
 * 
 * v6.3.2010.1209   淇瀹炰綋宸ュ巶EntityFactory缂撳瓨瀹炰綋瀵艰嚧鏃犳硶璇嗗埆鍚庡姞杞藉疄浣撶▼搴忛泦鐨勯敊璇?
 * 
 * v6.2.2010.1202   SQLite澧炲姞璇诲啓閿侊紝闄愬埗鍚屾椂鍙兘鎸囧畾涓€涓狤xcute鎿嶄綔
 *                  Entity鐨凱ageSplitSQL鏂规硶淇琛ㄥ悕娌℃湁杩涜鏍煎紡鍖栫殑BUG
 * 
 * v6.1.2010.1119   鍙栨秷渚濊禆XLog锛屽崌绾т负渚濊禆NewLife.Core锛岄儴鍒嗗叕鍏辩被搴撶Щ妞嶅埌NewLife.Core
 *                  淇EntityTree涓璅indChilds閿欒锛屽鍔犳帓搴忓瓧娈电殑鏀寔锛屽鏋滄寚瀹氭帓搴忓瓧娈碉紝鏌ヨ瀛愮骇鐨勬椂鍊欏皢鎸夋帓搴忓瓧娈甸檷搴忔帓搴?
 *                  鍙栨秷鎺堟潈闄愬埗锛屼絾浠嶇劧娣锋穯浠ｇ爜
 * 
 * v6.0.2010.1021   澧炲姞瀛楀吀缂撳瓨DictionaryCache
 *                  澧炲姞寮卞紩鐢ㄦ硾鍨媁eakReference<T>
 *                  鍗曞璞″疄浣撶紦瀛樻敼涓哄急寮曠敤锛屼娇寰楃紦瀛樺璞″湪娌℃湁寮曠敤鏃跺緱鍒板洖鏀?
 *                  鍗曞璞″疄浣撶紦瀛橀粯璁ゅ～鍏呮柟娉曟敼涓哄疄浣撳熀绫荤殑FindByKey锛堝墠闈㈡煇涓増鏈鍔狅紝鍙傛暟涓篛bject锛夛紝鎹Delegate.CreateDelegate鍑烘潵鐨勫鎵樹細寰堟參
 *                  瀹炰綋鍏冩暟鎹被Meta澧炲姞鍗曞璞″疄浣撶紦瀛楽ingleCache锛岀粰SingleCacheInt鍜孲ingleCacheStr鍔犱笂杩囨湡鏍囪瘑锛屽埌v7.0灏嗕笉鍐嶆敮鎸?
 *                  瀹炰綋鍏冩暟鎹被Meta澧炲姞OnDataChange鐨勬暟鎹敼鍙樹簨浠讹紝骞朵娇鐢ㄥ急寮曠敤锛屽綋璇ュ疄浣撴湁鏁版嵁鏀瑰彉鍚庯紝瑙﹀彂浜嬩欢锛屽彲鐢ㄤ簬鍦ㄥ閮ㄥ垹闄よ瀵硅薄鐨勭紦瀛?
 *                  锛堥噸瑕佹洿鏂帮級瀹炰綋鍩虹被澧炲姞瀛楀吀缂撳瓨Extends锛岀敤浜庡瓨鍌ㄦ墿灞曞睘鎬э紝骞跺鍔犱笓灞炵殑GetExtend鏂规硶鐢ㄤ簬鑾峰彇鎵╁睍灞炴€э紝鍚戜緷璧栧疄浣撶被娉ㄥ唽鏁版嵁鏇存敼浜嬩欢
 *                  锛堥噸瑕佹洿鏂帮級瀹炰綋鏍戠被鍗囩骇涓哄疄浣撴爲鍩虹被锛屾墍鏈夊叿鏈夋爲褰㈢粨鏋勬暟鎹殑瀹炰綋绫伙紝缁ф壙鑷绫伙紝浜彈鏍戝舰瀹炰綋鐨勫悇绉嶅姛鑳?
 *                  瀹炰綋鍩虹被澧炲姞铏氭嫙鐨凜reateXmlSerializer锛屽厑璁稿疄浣撶被閲嶈浇浠ユ敼鍙榅ml搴忓垪鍖栬涓猴紝榛樿搴忓垪鍖栬涓烘敼涓哄簭鍒楀寲涓虹壒鎬?
 *                  EntityList鏀瑰彉搴忓垪鍖栬涓猴紝榛樿搴忓垪鍖栦负鐗规€?
 *                  EntityList鍒ゆ柇鍏冪礌鏄惁瀛樺湪Contains鏂规硶鏀逛负Exists
 *                  EntityList澧炲姞澶氬瓧娈垫帓搴忔柟娉昐ort锛屽彲鐢ㄤ簬澶氫釜瀛楁鎺掑簭
 *                  淇蹇€熻闂柟娉曘€佸睘鎬у拰瀛楁鎵€瀛樺湪鐨勯棶棰橈紝鍦ㄥ疄浣撳熀绫荤储寮曞櫒浣跨敤
 * 
 * v5.9.2010.1020   淇Database涓璔ueryCountFast鐨勪弗閲嶉敊璇?
 * 
 * v5.8.2010.1018   澧炲姞瀹炰綋鏍戞帴鍙EntityTree锛岀敤浜庤В鍐冲疄浣撴爲鎿嶄綔鐨勪竴浜涘叡鎬ч棶棰橈紝閬垮厤姝诲惊鐜?
 * 
 * v5.7.2010.0930   XField涓鍔犱竴涓猅able灞炴€ф寚鍚戣嚜宸辩殑XTable锛屽垱寤篨Field鏃跺繀椤绘寚瀹氭墍灞瀀Table
 *                  澧炲姞鍙鍒楄〃锛屽悇閰嶇疆椤逛娇鐢ㄥ彧璇诲垪琛ㄨ繑鍥烇紝閰嶇疆椤硅嚜韬娴嬪垪琛ㄦ槸鍚﹁淇敼
 *                  瀹炰綋鎿嶄綔鎺ュ彛澧炲姞Fields鍜孎ieldNames灞炴€?
 * 
 * v5.6.2010.0909   淇敼DAL锛屾妸QueryTimes鍜孍xecuteTimes鏀逛负鏈嚎绋嬬殑鏌ヨ娆℃暟鍜屾墽琛屾鏁?
 *                  淇敼Entity锛孧eta.Count杩斿洖琛ㄧ殑鎬昏褰曟暟锛堝揩閫燂級锛孎indCount()浣跨敤鏅€氭柟娉曟煡璇㈢湡瀹炶褰曟暟
 * 
 * v5.5.2010.0903   瀹炰綋鎿嶄綔鎺ュ彛IEntityOperate杩斿洖鐨勫疄浣撻泦鍚堟敼涓篍ntityList<IEntity>锛屽洜涓轰娇鐢ㄦ搷浣滄帴鍙ｆ椂涓€鑸笉鐭ラ亾鍏蜂綋绫诲瀷锛屽鏋滅煡閬撳氨娌″繀瑕佷娇鐢ㄦ搷浣滄帴鍙?
 *                  澧炲姞鏁版嵁杩炴帴鍚嶆槧灏勭殑閰嶇疆锛屽厑璁搁€氳繃閰嶇疆淇敼鏌愪竴涓疄浣撴垨鑰呮煇涓€涓繛鎺ュ悕瀹為檯瀵瑰簲鐨勮繛鎺ュ悕
 *                  淇敼瀹炰綋缂撳瓨鍜屽崟瀵硅薄缂撳瓨锛屼娇寰楃紦瀛樼殑鏁版嵁鍥犺繛鎺ュ悕鎴栬〃鍚嶄笉鍚岃€屼笉鍚岋紝閬垮厤涓嶅悓杩炴帴鍚嶆垨琛ㄥ悕鏃剁紦瀛樹覆鍙风殑闂
 *                  淇敼瀹炰綋绫荤粨鏋勬ā鍨嬶紝姣斿Area:Area<Area>:Entity<Area>锛屼娇寰楀疄浣撶被鍙互閫氳繃缁ф壙瀹炵幇浜屾鎵╁睍
 * 
 * v5.4.2010.0830   鏁版嵁鏋舵瀯涓殑寮傛妫€鏌eginCheck褰撳惎鐢ㄦ鏌ユ椂鏀逛负鍚屾妫€鏌heck锛屼繚璇佹暟鎹簱鎿嶄綔鍓嶅厛瀹屾垚涓€娆℃暟鎹灦鏋勬鏌?
 *                  鍞竴閿负鑷涓斿弬鏁板皬浜庣瓑浜?鏃讹紝杩斿洖绌?
 *                  瀹炰綋鎿嶄綔鎺ュ彛IEntityOperate澧炲姞ToList鏂规硶锛屽疄鐜版妸ICollection杞负List<IEntity>
 *                  浼樺寲Entity鐨凢indAll鏂规硶锛屽鐞嗘捣閲忔暟鎹熬椤垫煡璇㈡椂浣跨敤浼樺寲绠楁硶
 * 
 * v5.3.2010.0826   DAL澧炲姞CreateOperate鏂规硶锛屼负鏁版嵁琛ㄥ姩鎬佸垱寤哄疄浣撶被鎿嶄綔鎺ュ彛锛屾敮鎸佸湪娌℃湁瀹炰綋绫荤殑鎯呭喌涓嬫搷浣滄暟鎹簱
 *                  璇ョ増鏈负涓嶇ǔ瀹氱増鏈?
 * 
 * v5.2.2010.0726   IEntity鎺ュ彛澧炲姞SetItem鏂规硶锛屾彁渚涘奖鍝嶈剰鏁版嵁鐨勫急绫诲瀷鏁版嵁璁剧疆
 *                  IEntityOperate鎺ュ彛澧炲姞Create鏂规硶锛屾彁渚涘垱寤鸿绫诲瀷瀹炰綋瀵硅薄鐨勫姛鑳?
 * 
 * v5.1.2010.0709   澧炲姞瀹炰綋鎺ュ彛銆佸疄浣撴搷浣滄帴鍙ｃ€佸疄浣撳熀绫荤殑鍩虹被锛屾彁渚涘急绫诲瀷鐨凮rm鏀寔
 * 
 * v5.0.2010.0625   DAL浼樺寲
 *                  閲嶆柊鍚敤鎺堟潈绠＄悊
 *                  EntityList澧炲姞鎺掑簭鏂规硶Sort
 * 
 * v4.9.2010.0430   浣跨敤SelectBuilder鏉ユ瀯閫燬QL璇彞锛岀敤浜庡悇灞備箣闂翠紶閫掞紝鍑嗗灏嗘墍鏈夋柟娉曞線SelectBuilder杩囧害銆傝鏇存柊鍙兘閫犳垚浣跨敤GroupBy鐨勫湴鏂硅绠楀嚭閿?
 * 
 * v4.8.2010.0325   淇敼Entity绱㈠紩鍣紝鏂扮殑蹇€熻皟鐢ㄦ柟娉曞湪set鐨勬椂鍊欐湁闂
 *                  澧炲姞甯哥敤鏌ヨ鏂规硶涓篧eb鏂规硶
 * 
 * v4.8.2010.0301   澧炲姞瀹炰綋绫诲琛ㄦ敮鎸佸拰澶氭暟鎹簱鏀寔
 *                  鏆撮湶鍑犱釜甯哥敤鐨勫疄浣撶被闈欐€佹柟娉曚緵WebService寮曠敤
 * 
 * v4.7.2010.0130   鏁版嵁鏋舵瀯涓瘑鍒〃鍚嶆椂涓嶅簲璇ュ尯鍒嗗ぇ灏忓啓
 *                  Entity涓鍔燤akeCondition鏂规硶锛屼互渚夸簬鏋勯€爓here璇彞
 * 
 * v4.6.2009.1226   鏀瑰杽鍒嗛〉绠楁硶锛屼骇鐢熸洿绠€鍗曠殑鍒嗛〉璇彞
 * 
 * v4.5.2009.1127   澧炲姞鍗曞疄浣撶紦瀛?
 * 
 * v4.4.2009.1125   淇敼浜岀骇缂撳瓨锛孍ntities鏀逛负EntityList绫诲瀷锛岄潪绌猴紝鏀寔FindAll鎿嶄綔
 * 
 * v4.3.2009.1121   淇Entity涓璖ave鏂规硶鍒ゆ柇鑷瀛楁涓嶅噯纭殑BUG
 * 
 * v4.2.2009.1114   浼樺寲SqlServer鍙栨灦鏋勪俊鎭殑鎬ц兘锛屼互鍙婅緭鍑虹殑SQL鐨勫彲璇绘€?
 *                  鏀寔Sql2008锛岄€氳繃Sql2005绫?
 *                  浼樺寲QueryCount鏂规硶锛屼骇鐢熸洿绠€鐭殑SQL
 * 
 * v4.1.2009.1028   澧炲姞蹇€熻幏鍙栧崟琛ㄦ€昏褰曟暟鏂规硶QueryCountFast锛屼慨鏀笶ntity锛屽湪璁板綍鏁板ぇ浜?000鏃惰嚜鍔ㄤ娇鐢ㄥ揩閫熷彇鎬昏褰曟暟
 * 
 * v4.0.2009.1011   澧炲姞瀹炰綋绫婚泦鍚圗ntityList锛孍ntity鐨勬墍鏈塅indAll杩斿洖EntityList
 *                  澧炲己鏁版嵁鏋舵瀯鍔熻兘锛屾敮鎸丄ccess銆丼QL2000銆丼QL2005
 * 
 * v3.7.2009.0907   淇DatabaseSchema涓殑涓€涓皬閿欒
 * 
 * v3.6.2009.0819   淇FindCount鏂规硶鐨勯敊璇?
 * 
 * v3.5.2009.0714   Config绫昏緭鍑虹殑FieldItem闆嗗悎鏀逛负鏁扮粍锛岄槻姝㈣澶栭儴淇敼銆?
 *                  鎵€鏈塖elect璇彞锛屼娇鐢?琛ㄧず鎵€鏈夊垪锛岃€屼笉鏄垪鍑烘墍鏈夊垪鍚嶃€?
 * 
 * v3.4.2009.0701   淇SqlServer 2000鍙栦富閿殑閿欒
 * 
 * v3.3.2009.0628   淇敼DAL锛屽睆钄絎eb璇锋眰绾х紦瀛楧B鐨勬柟娉曪紝浼间箮Web涓嬪绾跨▼寰堜笉绋冲畾锛屼粠鑰屽鑷翠簨鍔℃棤娉曟甯镐娇鐢ㄣ€?
 * 
 * v3.2.2009.0623   淇敼Oracle锛岄噸杞紾etTables鏂规硶锛屼慨姝ｆ棤娉曚粠Oracle鏁版嵁搴撳彇寰楁瀯鏋朵俊鎭殑閿欒
 * 
 * v3.1.2009.0611   淇敼SqlServer绫伙紝浣垮緱姣忔杩斿洖鏋勬灦淇℃伅鏃讹紝閮芥槸浠庢暟鎹簱鍙栧€笺€?
 * 
 * v3.0.2009.0608   鍏冩暟鎹被Meta澧炲姞涓€涓瓧娈靛悕鍒楄〃灞炴€ieldNames
 *                  璋冩暣DatabaseSchema绫伙紝鏂板瀛楁鏃讹紝鐩存帴璁剧疆榛樿鍊硷紝鍚﹀垯瀵逛簬闈炵┖瀛楁锛屽垱寤哄瓧娈靛皢浼氬け璐?
 *                  鏁版嵁鏋勬灦澧炲姞DatabaseSchema_Exclude閰嶇疆椤癸紝鐢ㄤ簬鎸囧畾瑕佹帓闄ゆ鏌ョ殑閾炬帴鍚嶃€?
 *                  Entity涓紝澧炲姞ToXml杈撳嚭鐨刋ml鐨勭紪鐮佷负UTF8锛屽鍔燜romXml鍙嶅簭鍒楀寲锛屽鍔燙lone鏂规硶鍜孋loneEntity鏂规硶
 *                  Database涓紝澧炲姞浜嬪姟璁℃暟瀛楁锛屾敮鎸佸绾т簨鍔°€?
 *                  Entity涓紝闆嗗悎杩愮畻杩斿洖鍊兼敼涓篖ist<T>锛岃€屼笉鏄疘List<T>锛屾洿鏂逛究璋冪敤
 *                  鍦―atabase鐨凲ueryCount鏂规硶澧炲姞鑷姩鍘婚櫎鎺掑簭瀛愬彞鐨勫姛鑳?
 *                  Entity涓紝澧炲姞ToString閲嶈浇锛岄粯璁ゆ樉绀篘ame灞炴€?
 *                  Entity涓紝Update鏃讹紝澧炲姞浜嗚剰鏁版嵁鐨勫垽鏂紝闈炶剰鏁版嵁鐨勫瓧娈典笉鏇存柊锛岀敱浜庤鍔熻兘鐨勫鍔犲皢瀵艰嚧浠ュ墠鎵€鏈夌殑瀹炰綋閮芥棤娉昒pdate鍒版暟鎹簱锛屾晠鐗堟湰鏀逛负3.0
 * 
 * v2.3.2009.0530   淇闈炶嚜澧炲瓧娈靛仛涓婚敭鏃朵篃璋冪敤InsertAndGetIdentity鐨勯敊璇€?
 * 
 * v2.2.2009.0527   鏁版嵁琛ㄧ粨鏋勪腑锛屽鍔營nt16鍜孖nt64涓ょ绫诲瀷
 * 
 * v2.1.2009.0408   淇DAL涓璤DBs绌哄紩鐢ㄧ殑闂锛屽彲鑳芥槸鍥犱负璇ユ垚鍛樻槸绾跨▼闈欐€侊紝骞舵病鏈夊湪姣忎竴涓嚎绋嬩笂new涓€涓璞°€?
 * 
 * v2.0.2009.0408   澧炲姞鏁版嵁鏋舵瀯鐨勫姛鑳姐€傛暟鎹灦鏋勫彲浠ュ疄鐜伴€氳繃瀹炰綋绫诲弽鍚戞洿鏂版暟鎹簱缁撴瀯锛屼笉鍚敤鏃讹紝浠呮妸鏇存柊SQL鍐欏叆鏃ュ織
 *                  淇Access绫讳娇鐢ㄥ綋鍓嶇洰褰曟椂鎷兼帴璺緞鐨勯敊璇€?
 *                  
 * v1.2.2008.01.01  浣跨敤娉涘瀷鍩虹被閲嶆瀯
 * 
 * v1.1.2007.03.08  澶ч噺鎵╁睍鍔熻兘锛屾敮鎸佽嚜瀹氫箟琛ㄥ崟銆佸箍涔夊崟鐐圭櫥褰曠瓑椤圭洰
 *                  瀹屽杽瀵筄racle鐨勬敮鎸侊紝鏀寔鐢靛姏鐢熶骇绠＄悊绯荤粺绛夐」鐩?
 *                  瀹屽杽瀵筍ybase鐨勬敮鎸侊紝鏀寔鐢靛姏SCADA鏁版嵁鍒嗘瀽绛夐」鐩?
 * 
 * v1.0.2005.10.01  鍒涘缓椤圭洰
 *                  鏀寔C++瀹㈡埛绔綉缁滈獙璇佺郴缁熺瓑椤圭洰
 *                  鏀寔鍥剧墖楠岃瘉鐮佽瘑鍒瓑椤圭洰
*/
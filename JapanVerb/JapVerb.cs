
using System;
using System.Collections;
using System.Collections.Generic;

namespace JapanVerb
{
    public class JapVerb
    {
        private String verbDictionaryName;
        private String verbTeform;
        String verbTaForm;
        String verbMasuForm;
        String verbNayiForm;
        String verbKanji;

        String verbVolitional;
        String verbPotential;
        String verbImperitive;
        String verbCausative;
        String verbConditional;
        String verbPasssive;
        String verbMeaning;


        public JapVerb(String name, string masuForm, string teForm, string nayiForm, string taForm, string kanji,
            string volitionalForm, string potentialForm, string ImperitiveForm, string causativeForm, string conditionalForm, string passiveForm, string meaning)
        {
            verbDictionaryName = name;
            verbMasuForm = masuForm;
            verbTeform = teForm;
            VerbNayiForm = nayiForm;
            verbTaForm = taForm;
            VerbKanji = kanji;
            verbVolitional = volitionalForm;
            verbPotential = potentialForm;
            verbImperitive = ImperitiveForm;
            verbCausative = causativeForm;
            verbConditional =  conditionalForm;
            verbPasssive = passiveForm;
            VerbMeaning = meaning;

        }


        public String VerbDictionaryName { get => verbDictionaryName; set => verbDictionaryName = value; }
        public String VerbTeform { get => verbTeform; set => verbTeform = value; }
        public String VerbTaForm { get => verbTaForm; set => verbTaForm = value; }
        public String VerbMasuForm { get => verbMasuForm; set => verbMasuForm = value; }
        public string VerbNayiForm { get => verbNayiForm; set => verbNayiForm = value; }
        public string VerbKanji { get => verbKanji; set => verbKanji = value; }
        public string VerbVolitional { get => verbVolitional; set => verbVolitional = value; }
        public string VerbPotential { get => verbPotential; set => verbPotential = value; }
        public string VerbImperitive { get => verbImperitive; set => verbImperitive = value; }
        public string VerbCausative { get => verbCausative; set => verbCausative = value; }
        public string VerbConditional { get => verbConditional; set => verbConditional = value; }
        public string VerbPasssive { get => verbPasssive; set => verbPasssive = value; }
        public string VerbMeaning { get => verbMeaning; set => verbMeaning = value; }
    }

    public class JapanVerbs
    {
        public List<JapVerb> verbList = new List<JapVerb>();

        int index = 0;

        public JapanVerbs()
        {
            addVerb();
        }

        public void addVerb()
        {
            ///////// Group I Verbs
            verbList.Add(new JapVerb("あう", "あいます","あって","あわない","あった", "会います", "","","", "", "","", "见面"));
            verbList.Add(new JapVerb("ある", "あります","あって","ー","あった", "あります", "", "", "", "", "", "", "有"));
            verbList.Add(new JapVerb("あらう","あらいます","あらって","あらわない","あらった", "洗います", "", "", "", "", "", "", "洗"));
            verbList.Add(new JapVerb("あるく","あるきます","あるいて","あらかない","あるいた",  "歩きます", "", "", "", "", "", "", "走"));
            verbList.Add(new JapVerb("いう","いいます","いって","いわない","いった",  "言います", "", "", "", "", "", "", "说"));
            verbList.Add(new JapVerb("いく","いきます","いって","いかない","いった",  "行きます", "", "", "", "", "", "", "去"));
            verbList.Add(new JapVerb("いそぐ","いそぎます","いそいで","いそがない","いそいだ",  "急ぎます", "", "", "", "", "", "", "急"));
            verbList.Add(new JapVerb("いる", "いります", "いって", "いらない","いった", "要ります", "", "", "", "", "", "", "要"));
            verbList.Add(new JapVerb("うごく", "うごきます", "うごいて", "うごかない", "うごいた",  "動きます", "", "", "", "", "", "", "转动"));
            verbList.Add(new JapVerb("うたう", "うたいます", "うたって", "うたわない", "うたった" , "歌います", "", "", "", "", "", "", "唱"));
            verbList.Add(new JapVerb("うる", "うります", "うって", "うらない", "うった", "売ります", "", "", "", "", "", "", "卖"));
            verbList.Add(new JapVerb("おく", "おきます", "おいて", "おかない", "おいた", "置きます", "", "", "", "", "", "", "放"));
            verbList.Add(new JapVerb("おくる", "おくります", "おくって", "おくらない", "おくった", "送ります", "", "", "", "", "", "", "寄，送，送人"));
            verbList.Add(new JapVerb("おす", "おします", "おして", "おさない", "おした", "押します", "", "", "", "", "", "", "按，押，推"));
            verbList.Add(new JapVerb("おもいだす", "おもいだします", "おもいだして", "おもいださない", "おもいだした", "思い出します", "", "", "", "", "", "", "想起"));
            verbList.Add(new JapVerb("おもう", "おもいます", "おもって", "おもわない", "おもった", "思います", "", "", "", "", "", "", "想，觉得"));
            verbList.Add(new JapVerb("およぐ", "およぎます", "およいで", "およがない", "およいだ", "泳ぎます", "", "", "", "", "", "", "游泳"));
            verbList.Add(new JapVerb("おろす", "おろします", "おろして", "おろさない", "おろした", "下ろします", "", "", "", "", "", "", "取款"));
            verbList.Add(new JapVerb("おわる", "おわります", "おわって", "おわらない", "おわった", "終わります", "", "", "", "", "", "", "结束"));
            verbList.Add(new JapVerb("かう", "かいます", "かって", "かわない", "かった", "買います", "", "", "", "", "", "", "买"));
            verbList.Add(new JapVerb("かえす", "かえします", "かえして", "かえさない", "返します", "", "", "", "", "", "", "", "归还，返回"));
            verbList.Add(new JapVerb("かえる", "かえります", "かえって", "かえらない", "かえった", "帰ります", "", "", "", "", "", "", "回"));
            verbList.Add(new JapVerb("かかる", "かかります", "かかって", "かからない", "かかった", "かかります", "", "", "", "", "", "", "花费"));
            verbList.Add(new JapVerb("かく", "かきます", "かいて", "かかない", "かいた", "書きます", "", "", "", "", "", "", "写， 画"));
            verbList.Add(new JapVerb("かす", "かします", "かして", "かさない", "かした", "貸します", "", "", "", "", "", "", "借给"));
            verbList.Add(new JapVerb("かつ", "かちます", "かって", "かたない", "かった", "勝ちます", "", "", "", "", "", "", "赢"));
            verbList.Add(new JapVerb("かぶる", "かぶります", "かぶって", "かぶらない", "かぶった", "かぶります",  "", "", "", "", "", "", "戴"));
            verbList.Add(new JapVerb("がんばる", "がんばります", "がんばって", "がんばらない", "がんばった", "頑張ります",  "", "", "", "", "", "", "加油，努力"));
            verbList.Add(new JapVerb("きく", "ききます", "きいて", "きかない", "きいた", "聞きます",  "", "", "", "", "", "", "听"));
            verbList.Add(new JapVerb("きる", "きります", "きって", "きらない", "きった", "切ります",  "", "", "", "", "", "", "切，剪"));
            verbList.Add(new JapVerb("けす", "けします", "けして", "けさない", "けした", "消します",  "", "", "", "", "", "", "关（空调，电灯"));
            verbList.Add(new JapVerb("さわる", "さわります", "さわって", "さわらない", "さわらった", "触ります", "", "", "", "", "", "", "摸，碰（到门）"));
            verbList.Add(new JapVerb("しる", "しります", "しって", "しらない", "しった", "知ります",  "", "", "", "", "", "", "知道"));
            verbList.Add(new JapVerb("すう", "すいます", "すって", "すわない", "すった", "吸います",  "", "", "", "", "", "", "吸，抽（烟)"));
            verbList.Add(new JapVerb("すむ", "すみます", "すんで", "すまない", "すんだ", "住みます", "", "", "", "", "", "", "住"));
            verbList.Add(new JapVerb("すわる", "すわります", "すわって", "すわらない", "すわった", "座ります",  "", "", "", "", "", "", "坐"));
            verbList.Add(new JapVerb("だす", "だします", "だして", "ださない", "だした", "出します", "", "", "", "", "", "", "拿出，取出， 提交，寄"));
            verbList.Add(new JapVerb("たつ", "たちます", "たって", "たたない", "たった", "立ちます", "", "", "", "", "", "", "站"));
            verbList.Add(new JapVerb("つかう", "つかいます", "つかって", "つかわない", "つかった", "使います", "", "", "", "", "", "", "使用"));
            verbList.Add(new JapVerb("つく", "つきます", "ついて", "つかない", "ついた", "着きます", "", "", "", "", "", "", "到，到达"));
            verbList.Add(new JapVerb("つくる", "つくります", "つくって", "つくらない", "つくった", "作ります", "", "", "", "", "", "", "做，制造"));
            verbList.Add(new JapVerb("つれていく", "つれていきます", "つれていって", "つれていかない", "つれていった", "連れていきます", "", "", "", "", "", "", "领着去"));
            verbList.Add(new JapVerb("てつだう", "てつだいます", "てつだって", "てつだわない", "てつだった", "手伝います", "", "", "", "", "", "", "帮忙"));
            verbList.Add(new JapVerb("とまる", "とまります", "とまって", "とまらない", "とまった", "泊まります", "", "", "", "", "", "", "住（饭店）"));
            verbList.Add(new JapVerb("とる", "とります", "とって", "とらない", "とった", "取ります／撮ります", "", "", "", "", "", "", "拍摄、上年纪"));
            verbList.Add(new JapVerb("なおす", "なおします", "なおして", "なおさない", "なおした", "直します", "", "", "", "", "", "", "修理，修改"));
            verbList.Add(new JapVerb("なくす", "なくします", "なくして", "なくさない", "なくした", "なくします", "", "", "", "", "", "", "丢失"));
            verbList.Add(new JapVerb("ならう", "ならいます", "ならって", "ならわない", "ならった", "習います", "", "", "", "", "", "", "学习"));
            verbList.Add(new JapVerb("なる", "なります", "なって", "ならないい", "なった", "なります", "", "", "", "", "", "", "变成"));
            verbList.Add(new JapVerb("ぬぐ", "ぬぎます", "ぬいで", "ぬがない", "ぬいだ", "脱ぎます", "", "", "", "", "", "", "脱(衣服，鞋子"));
            verbList.Add(new JapVerb("のぼる", "のぼります", "のぼって", "のぼらない", "のぼった", "上ります／登ります", "", "", "", "", "", "", "登上"));
            verbList.Add(new JapVerb("のむ", "のみます", "のんで", "のまない", "のんだ", "飲みます", "", "", "", "", "", "", "喝水，酒，吃药"));
            verbList.Add(new JapVerb("のる", "のります", "のって", "のらない", "のった", "乗ります", "", "", "", "", "", "", "坐，乘（电车）"));
            verbList.Add(new JapVerb("はいる", "はいります", "はいって", "はいらない", "はいった", "入ります", "", "", "", "", "", "", "进入（咖啡馆）、上大学、洗（澡）"));
            verbList.Add(new JapVerb("はく", "はきます", "はいて", "はかない", "はいた", "はきます", "", "", "", "", "", "", "穿（鞋子、裤子等"));
            verbList.Add(new JapVerb("はたらく", "はたらきます", "はたらいて", "はたらかない", "はたらいた", "働きます", "", "", "", "", "", "", "工作"));
            verbList.Add(new JapVerb("はなす", "はなします", "はなして", "はなさない", "はなした", "話します", "", "", "", "", "", "", "说话"));
            verbList.Add(new JapVerb("はらう", "はらいます", "はらって", "はらわない", "はなった", "払います", "", "", "", "", "", "", "付钱"));
            verbList.Add(new JapVerb("ひく", "ひくます", "ひいて", "ひかない", "ひいた", "引きます／弾きます", "", "", "", "", "", "", "弹奏、拉拽"));
            verbList.Add(new JapVerb("ふる", "ふります", "ふって", "ふらない", "ふった", "降ります", "", "", "", "", "", "", "下（雨）"));
            verbList.Add(new JapVerb("まがる", "まがります", "まがって", "まがらない", "まがった", "曲がります", "", "", "", "", "", "", "转外"));
            verbList.Add(new JapVerb("まつ", "まちます", "まって", "またない", "まった", "待ちます", "", "", "", "", "", "", "等"));
            verbList.Add(new JapVerb("まわす", "まわします", "まわして", "まわさない", "まわした", "回します", "", "", "", "", "", "", "传递、转"));
            verbList.Add(new JapVerb("もつ", "もちます", "もって", "もたない", "もった", "持ちます", "", "", "", "", "", "", "拿"));
            verbList.Add(new JapVerb("もっていく", "もっていきます", "もっていって", "もっていかない", "もっていった", "持っていきます", "", "", "", "", "", "", "带去，拿去"));
            verbList.Add(new JapVerb("もらう", "もらいます", "もらって", "もらわない", "もらった", "もらいます", "", "", "", "", "", "", "得到"));
            verbList.Add(new JapVerb("やくにたつ", "やくにたちます", "やくにたって", "やくにたたない", "やくにたった", "役に立ちます", "", "", "", "", "", "", "有用，起作用"));
            verbList.Add(new JapVerb("やすむ", "やすみます", "やすんで", "やすまない", "やすんだ", "休みます", "", "", "", "", "", "", "休息，请假"));
            verbList.Add(new JapVerb("よぶ", "よびます", "よんで", "よばない", "よんだ", "呼びます", "", "", "", "", "", "", "叫"));
            verbList.Add(new JapVerb("よむ", "よみます", "よんで", "よまない", "よんだ", "読みます", "", "", "", "", "", "", "读"));
            verbList.Add(new JapVerb("わかる", "わかります", "わかって", "わからない", "わかった", "わかります", "", "", "", "", "", "", "懂，明白"));
            verbList.Add(new JapVerb("わたる", "わたります", "わたって", "わたらない", "わたった", "渡ります", "", "", "", "", "", "", "渡过"));

            ///////// Group II Verbs
            verbList.Add(new JapVerb("あける", "あけます", "あけて", "あけない", "あけた", "開けます", "", "", "", "", "", "", "开（门、窗）"));
            verbList.Add(new JapVerb("あげる", "あげます", "あげて", "あげない", "あげた", "あげます", "", "", "", "", "", "", "给（你）"));
            verbList.Add(new JapVerb("あつめる", "あつめます", "あつめて", "あつめない", "あつめた", "集めます", "", "", "", "", "", "", "收集，收藏"));
            verbList.Add(new JapVerb("あびる", "あびます", "あびて", "あびない", "あびた", "浴びます", "", "", "", "", "", "", "浇，淋（浴）"));
            verbList.Add(new JapVerb("いる", "います", "いて", "いない", "いた", "います", "", "", "", "", "", "", "有"));
            verbList.Add(new JapVerb("いれる", "いれます", "いれて", "いれない", "いれた", "入れます",  "", "", "", "", "", "", "放入"));
            verbList.Add(new JapVerb("うまれる", "うまれます", "うまれて", "うまれない", "うまれた", "生まれます", "", "", "", "", "", "", "出生"));
            verbList.Add(new JapVerb("おきる", "おきます", "おきて", "おきない", "おきた", "起きます", "", "", "", "", "", "", "起床"));
            verbList.Add(new JapVerb("おしえる", "おしえます", "おしえて", "おしえない", "おしえた", "教えます", "", "", "", "", "", "", "教，告诉"));
            verbList.Add(new JapVerb("おぼえる", "おぼえます", "おぼえて", "おぼえない", "おぼえた", "覚えます", "", "", "", "", "", "", "记住"));
            verbList.Add(new JapVerb("おりる", "おります", "おりて", "おりない", "おりた", "降ります", "", "", "", "", "", "", "下（电车）"));
            verbList.Add(new JapVerb("かえる", "かえます", "かえて", "かえない", "かえた", "変えます／換えます", "", "", "", "", "", "", "换、改变"));
            verbList.Add(new JapVerb("かける", "かけます", "かけて", "かけない", "かけた", "かけます", "", "", "", "", "", "", "打（电话)"));
            verbList.Add(new JapVerb("かりる", "かります", "かりて", "かりない", "かりた", "借ります", "", "", "", "", "", "", "借入"));
            verbList.Add(new JapVerb("かんがえる", "かんがえます", "かんがえて", "かんがえない", "かんがえた", "", "", "", "", "", "", "", "考虑"));
            verbList.Add(new JapVerb("きる", "きます", "きて", "きない", "きた", "着ます", "", "", "", "", "", "", "穿"));
            verbList.Add(new JapVerb("きをつける", "きをつけます", "きをつけて", "きをつけない", "きをつけた", "気を付けます", "", "", "", "", "", "", "小心，注意"));
            verbList.Add(new JapVerb("くれる", "くれます", "くれて", "くれない", "くれた", "くれます", "", "", "", "", "", "", "给（我，我方）"));
            verbList.Add(new JapVerb("しめる", "しめます", "しめて", "しめない", "しめた", "閉めます", "", "", "", "", "", "", "关（窗，门）"));
            verbList.Add(new JapVerb("しらべる", "しらべます", "しらべて", "しらべない", "しらべた", "調べます", "", "", "", "", "", "", "查，调查"));
            verbList.Add(new JapVerb("すてる", "すてます", "すてて", "すてない", "すてた", "捨てます", "", "", "", "", "", "", "丢弃，扔"));
            verbList.Add(new JapVerb("たべる", "たべます", "たべて", "たべない", "たべた", "食べます", "", "", "", "", "", "", "吃"));
            verbList.Add(new JapVerb("たりる", "たります", "たりて", "たりない", "たりた", "足ります", "", "", "", "", "", "", "够"));
            verbList.Add(new JapVerb("つかれる", "つかれます", "つかれて", "つかれない", "つかれた", "疲れます", "", "", "", "", "", "", "累"));
            verbList.Add(new JapVerb("つける", "つけます", "つけて", "つけない", "つけた", "つけます", "", "", "", "", "", "", "开（空调，灯）"));
            verbList.Add(new JapVerb("でかける", "でかけます", "でかけて", "てかけない", "てかけた", "てかけます", "", "", "", "", "", "", "出门，外出"));
            verbList.Add(new JapVerb("できる", "できます", "できて", "できない", "できた", "できます", "", "", "", "", "", "", "能，会，可以"));
            verbList.Add(new JapVerb("でる", "でます", "でて", "でない", "でた", "出ます", "", "", "", "", "", "","找（零钱）、出， 毕业"));
            verbList.Add(new JapVerb("とめる", "とめます", "とめて", "とめない", "とめた", "止めます", "", "", "", "", "", "", "停止"));
            verbList.Add(new JapVerb("ねる", "ねます", "ねて", "ねない", "ねた", "寝ます", "", "", "", "", "", "", "睡觉"));
            verbList.Add(new JapVerb("のりかえる", "のりかえます", "のりかえて", "のりかえない", "のりかえた", "乗り換えます", "", "", "", "", "", "", "换乘"));
            verbList.Add(new JapVerb("はじめる", "はじめます", "はじめて", "はじめない", "はじめた", "始めます", "", "", "", "", "", "", "开始"));
            verbList.Add(new JapVerb("まける", "まけます", "まけて", "まけない", "まけた", "負けます", "", "", "", "", "", "", "输"));
            verbList.Add(new JapVerb("みせる", "みせます", "みせて", "みせない", "みせた", "見せます", "", "", "", "", "", "", "显示"));
            verbList.Add(new JapVerb("みる", "みます", "みて", "みない", "みた", "見ます", "", "", "", "", "", "", "看"));
            verbList.Add(new JapVerb("むかえる", "むかえます", "むかえて", "むかえない", "むかえた", "迎えます", "", "", "", "", "", "", "迎接"));
            verbList.Add(new JapVerb("やめる", "やめます", "やめて", "やめない", "やめた", "やめます", "", "", "", "", "", "", "辞职，退休"));
            verbList.Add(new JapVerb("わすれる", "わすれます", "わすれて", "わすれない", "わすれた", "忘れます", "", "", "", "", "", "", "忘记"));
        }

        public JapVerb getNext()
        {
            if (index == verbList.Count - 1) 
                index = 0;
            return verbList[++index];
        }

        public JapVerb getPrev()
        {
            if (index == 0)
                index = verbList.Count - 1;

            return verbList[--index];
        }

        public JapVerb currentVerb()
        {
            return verbList[index];
        }
    }
}
        

    


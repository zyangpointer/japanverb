
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


        public JapVerb(String name, string masuForm, string teForm, string nayiForm, string taForm, string kanji,
            string volitionalForm, string potentialForm, string ImperitiveForm, string causativeForm, string conditionalForm, string passiveForm)
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
            verbList.Add(new JapVerb("あう", "あいます","あって","あわない","あった", "会います", "","","", "", "",""));
            verbList.Add(new JapVerb("ある", "あります","あって","ー","あった", "あります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("あらう","あらいます","あらって","あらわない","あらった", "洗います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("あるく","あるきます","あるいて","あらかない","あるいた",  "歩きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("いう","いいます","いって","いわない","いった",  "言います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("いく","いきます","いって","いかない","いった",  "行きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("いそぐ","いそぎます","いそいで","いそがない","いそいた",  "急ぎます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("いる", "いります", "いって", "いらない","いった", "要ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("うごく", "うごきます", "うごいて", "うごかない", "うごいた",  "動きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("うたう", "うたいます", "うたって", "うたわない", "うたった" , "歌います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("うる", "うります", "うって", "うらない", "うった", "売ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おく", "おきます", "おいて", "おかない", "おいた", "置きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おくる", "おくります", "おくって", "おくらない", "おくった", "送ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おす", "おします", "おして", "おさない", "おした", "押します", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おもいだす", "おもいだします", "おもいだして", "おもいださない", "思い出す", "", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おもう", "おもいます", "おもって", "おもわない", "おもった", "思います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("およぐ", "およぎます", "およいで", "およがない", "およいだ", "泳ぎます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おろす", "おろします", "おろして", "おろさない", "おろした", "下ろします", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おわる", "おわります", "おわって", "おわらない", "おわった", "終わります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かう", "かいます", "かって", "かわない", "かった", "買います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かえす", "かえします", "かえして", "かえさない", "返します", "", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かえる", "かえります", "かえって", "かえらない", "かえった", "帰ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かかる", "かかります", "かかって", "かからない", "かかった", "かかります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かく", "かきます", "かいて", "かかない", "かいた", "書きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かす", "かします", "かして", "かさない", "かした", "貸します", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かつ", "かちます", "かって", "かたない", "かった", "勝ちます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かぶる", "かぶります", "かぶって", "かぶらない", "かぶった", "かぶります",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("がんばる", "がんばります", "がんばって", "がんばらない", "がんばった", "頑張ります",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("きく", "ききます", "きいて", "きかない", "きいた", "聞きます",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("きる", "きります", "きって", "きらない", "きった", "聞きます",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("けす", "けします", "けして", "けさない", "けした", "消します",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("さわる", "さわります", "さわって", "さわらない", "さわらった", "触ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("しる", "しります", "しって", "しらない", "しった", "知ります",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("すう", "すいます", "すって", "すわない", "すった", "吸います",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("すむ", "すみます", "すんで", "すまない", "すんだ", "住みます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("すわる", "すわります", "すわって", "すわらない", "すわった", "座ります",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("だす", "だします", "だして", "ださない", "だした", "出します", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("たつ", "たちます", "たって", "たたない", "たった", "立ちます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("つかう", "つかいます", "つかって", "つかわない", "つかった", "使います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("つく", "つきます", "ついて", "つかない", "ついた", "着きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("つくる", "つくります", "つくって", "つくらない", "つくった", "作ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("つれていく", "つれていきます", "つれていって", "つれていかない", "つれていった", "連れていきます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("てつだう", "てつだいます", "てつだって", "てつだわない", "てつだった", "手伝います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("とまる", "とまります", "とまって", "とまらない", "とまった", "泊まります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("とる", "とります", "とって", "とらない", "とった", "取ります／撮ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("なおす", "なおします", "なおして", "なおさない", "なおした", "直します", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("なくす", "なくします", "なくして", "なくさない", "なくした", "なくします", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("ならう", "ならいます", "ならって", "ならわない", "ならった", "習います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("なる", "なります", "なって", "ならないい", "なった", "なります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("ぬぐ", "ぬぎます", "ぬいで", "ぬがない", "ぬいだ", "脱ぎます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("のぼる", "のぼります", "のぼって", "のぼらない", "のぼった", "上ります／登ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("のむ", "のみます", "のんで", "のまない", "のんだ", "飲みます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("のる", "のります", "のって", "のらない", "のった", "乗ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("はいる", "はいります", "はいって", "はいらない", "はいった", "入ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("はく", "はきます", "はいて", "はかない", "はいた", "はきます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("はたらく", "はたらきます", "はたらいて", "はたらかない", "はたらいた", "働きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("はなす", "はなします", "はなして", "はなさない", "はなした", "話します", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("はらう", "はらいます", "はらって", "はらわない", "はなった", "払います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("ひく", "ひくます", "ひいて", "ひかない", "ひいた", "引きます／弾きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("ふる", "ふります", "ふって", "ふらない", "ふった", "降ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("まがる", "まがります", "まがって", "まがらない", "まがった", "曲がります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("まつ", "まちます", "まって", "またない", "まった", "待ちます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("まわす", "まわします", "まわして", "まわさない", "まわした", "回します", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("もつ", "もちます", "もって", "もたない", "もった", "持ちます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("もっていく", "もっていきます", "もっていって", "もっていかない", "もっていった", "持っていきます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("もらう", "もらいます", "もらって", "もらわない", "もらった", "もらいます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("やくにたつ", "やくにたちます", "やくにたって", "やくにたたない", "やくにたった", "役に立ちます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("やすむ", "やすみます", "やすんで", "やすまない", "やすんだ", "休みます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("よぶ", "よびます", "よんで", "よばない", "よんだ", "呼びます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("よむ", "よみます", "よんで", "よまない", "よんだ", "読みます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("わかる", "わかります", "わかって", "わからない", "わかった", "わかります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("わたる", "わたります", "わたって", "わたらない", "わたった", "渡ります", "", "", "", "", "", ""));

            ///////// Group II Verbs
            verbList.Add(new JapVerb("あける", "あけます", "あけて", "あけない", "あけた", "開けます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("あげる", "あげます", "あげて", "あげない", "あげた", "あげます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("あつめる", "あつめます", "あつめて", "あつめない", "あつめた", "集めます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("あびる", "あびます", "あびて", "あびない", "あびた", "浴びます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("いる", "います", "いて", "いない", "いた", "います", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("いれる", "いれます", "いれて", "いれない", "いれた", "入れます",  "", "", "", "", "", ""));
            verbList.Add(new JapVerb("うまれる", "うまれます", "うまれて", "うまれない", "うまれた", "生まれます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おきる", "おきます", "おきて", "おきない", "おきた", "起きます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おしえる", "おしえます", "おしえて", "おしえない", "おしえた", "教えます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おぼえる", "おぼえます", "おぼえて", "おぼえない", "おぼえた", "覚えます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("おりる", "おります", "おりて", "おりない", "おりた", "降ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かえる", "かえます", "かえて", "かえない", "かえた", "変えます／換えます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かける", "かけます", "かけて", "かけない", "かけた", "かけます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かりる", "かります", "かりて", "かりない", "かりた", "借ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("かんがえる", "かんがえます", "かんがえて", "かんがえない", "かんがえた", "", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("きる", "きます", "きて", "きない", "きた", "", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("きをつける", "きをつけます", "きをつけて", "きをつけない", "きをつけた", "気を付けます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("くれる", "くれます", "くれて", "くれない", "くれた", "くれます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("しめる", "しめます", "しめて", "しめない", "しめた", "閉めます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("しらべる", "しらべます", "しらべて", "しらべない", "しらべた", "調べます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("すてる", "すてます", "すてて", "すてない", "すてた", "捨てます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("たべる", "たべます", "たべて", "たべない", "たべた", "食べます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("たりる", "たります", "たりて", "たりない", "たりた", "足ります", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("つかれる", "つかれます", "つかれて", "つかれない", "つかれた", "疲れます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("つける", "つけます", "つけて", "つけない", "つけた", "つけます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("でかける", "でかけます", "でかけて", "てかけない", "てかけた", "てかけます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("できる", "できます", "できて", "できない", "できた", "できます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("でる", "でます", "でて", "でない", "でた", "出ます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("とめる", "とめます", "とめて", "とめない", "とめた", "止めます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("ねる", "ねます", "ねて", "ねない", "ねた", "寝ます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("のりかえる", "のりかえます", "のりかえて", "のりかえない", "のりかえた", "乗り換えます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("はじめる", "はじめます", "はじめて", "はじめない", "はじめた", "始めます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("まける", "まけます", "まけて", "まけない", "まけた", "負けます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("みせる", "みせます", "みせて", "みせない", "みせた", "見せます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("みる", "みます", "みて", "みない", "みた", "見ます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("むかえる", "むかえます", "むかえて", "むかえない", "むかえた", "迎えます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("やめる", "やめます", "やめて", "やめない", "やめた", "やめます", "", "", "", "", "", ""));
            verbList.Add(new JapVerb("わすれる", "わすれます", "わすれて", "わすれない", "わすれた", "忘れます", "", "", "", "", "", ""));
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
        

    


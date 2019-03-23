
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

        public JapVerb(String name, string masuForm, string teForm)
        {
            verbDictionaryName = name;
            verbMasuForm = masuForm;
            verbTeform = teForm;
        }


        public String VerbDictionaryName { get => verbDictionaryName; set => verbDictionaryName = value; }
        public String VerbTeform { get => verbTeform; set => verbTeform = value; }
        public String VerbTaForm { get => verbTaForm; set => verbTaForm = value; }
        public String VerbMasuForm { get => verbMasuForm; set => verbMasuForm = value; }
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
            verbList.Add(new JapVerb("あう", "あいます","あって"));
            verbList.Add(new JapVerb("ある", "あります","あって"));
            verbList.Add(new JapVerb("あらう","あらいます","あらって"));
            verbList.Add(new JapVerb("あるく","あるきます","あるいて"));
            verbList.Add(new JapVerb("いう","いいます","いって"));
            verbList.Add(new JapVerb("いく","いきます","いって"));
            verbList.Add(new JapVerb("いそぐ","いそびます","いそいて"));
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
        

    


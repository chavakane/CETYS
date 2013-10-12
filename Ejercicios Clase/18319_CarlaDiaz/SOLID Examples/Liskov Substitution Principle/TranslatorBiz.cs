using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// French person can't substitute Person, it only extends its behaviour
    /// </summary>
    public class TranslatorBiz
    {
        public Person HireTranslator(Language lang)
        {
            if (lang == Language.French)
            {
                return new FrenchPerson();
            }
            return new Person();
        }
    }

    public enum Language
    {
        English,
        French
    }
}

using System.Collections.Generic;

namespace Skovokh_Translator
{
    public static class Mappings
    {
        public static readonly Dictionary<string, string> LatinToSkovokhMappings = new()
        {
            { "o" , "o"    },
            { "h" , "hu"   },
            { "q" , "ku"   },
            { "C" , "gi"   },
            { "k" , "ke"   },
            { "K" , "ki"   },
            { "a" , "a"    },
            { "v" , "vih"  },
            { "l" , "lu"   },
            { "r" , "ru"   },
            { "g" , "g"    }, // a, e, i, o, and u.
            { "t" , "ta"   }, // Special rule || t if vowel is after
            { "d" , "di"   }, // Special rule || d if vowel is after
            { "p" , "po"   },
            { "T" , "te"   },
            { "c" , "si"   },
            { "x" , "ks"   },
            { "s" , "s"    },
            { "z" , "zet"  },
            { "Z" , "zuh"  },
            { "R" , "ro"   },
            { "S" , "shi"  },
            { "kH", "ka"   },
            { "KH", "khu"  },
            { "tH", "tu"   },
            { "TH", "kt"   },
            { "E" , "es"   },
            { "EE", "ee"   },
            { "y" , "ji"   },
            { "RH", "ko"   },
            { "EH", "ei"   }, // a, e, i, o, and u.
            { "rH", "re"   }, // Special rule || r if vowel is after
            { "u" , "uh"   },
            { "oe", "vhu"  },
            { "b" , "be"   },
            { "B" , "ba"   },
            { "bH", "bu"   },
            { "BH", "bo"   },
            { "L" , "la"   },
            { "zH", "zha"  },
            { "LH", "lo"   }, // a, e, i, o, and u.
            { "Le", "mu"   }, // Special rule || w if vowel is after
            { "va", "vha"  },
            { "ve", "ve"   }, // a, e, i, o, and u.
            { "V" , "wh"   }, // Special rule || w if vowel is after
            { "aH", "nu"   }, // a, e, i, o, and u.
            { "IH", "ih"   }, // Special rule || i if vowel is after
            { "uH", "ui"   },
            { " " , " "    },
            { "." , "."    },
            { "," , ","    },
            { "(" , " ("   },
            { ")" , ")"    },
            { "!" , "!"    },
            { "?" , "?"    },
            { "*" , "*"    },
            { ":" , ":"    },
            { "'" , "'"    },
            { "\"", "\""   },
        };

        public static readonly List<string> VowelRuleLetters = new()
        {
            "t", "d", "z", "rH", "u", "Le", "V", "aH", "IH"
        };

        public static readonly Dictionary<string, string> CutVowelRuleVersions = new()
        {
            { "t", "t"  },
            { "d", "d"  },
            { "z", "z"  },
            { "rH", "r" },
            { "Le", "m" },
            { "V", "w"  },
            { "aH", "n" },
            { "IH", "a" }
        };

        public static readonly List<string> VowelTriggers = new()
        {
            // a e i o u
            "o", "a", "EH", "u", "IH"
        };

        public static readonly Dictionary<string, string> LatinSkovokhPaths = new()
        {
            { "o" ,  @"\img\Step0\1.png"  },
            { "h" ,  @"\img\Step0\2.png"  },
            { "q" ,  @"\img\Step0\3.png"  },
            { "C" ,  @"\img\Step0\4.png"  },
            { "k" ,  @"\img\Step0\5.png"  },
            { "K" ,  @"\img\Step0\6.png"  },
            { "a" ,  @"\img\Step0\7.png"  },
            { "v" ,  @"\img\Step0\8.png"  },
            { "l" ,  @"\img\Step0\9.png"  },
            { "r" ,  @"\img\Step0\10.png" },
            { "g" ,  @"\img\Step0\11.png" },
            { "t" ,  @"\img\Step0\12.png" },
            { "d" ,  @"\img\Step0\13.png" },
            { "p" ,  @"\img\Step0\14.png" },
            { "T" ,  @"\img\Step0\15.png" },
            { "c" ,  @"\img\Step0\16.png" },
            { "x" ,  @"\img\Step0\17.png" },
            { "s" ,  @"\img\Step0\18.png" },
            { "z" ,  @"\img\Step0\19.png" },
            { "Z" ,  @"\img\Step0\20.png" },
            { "R" ,  @"\img\Step0\21.png" },
            { "S" ,  @"\img\Step0\22.png" },
            { "kH",  @"\img\Step0\23.png" },
            { "KH",  @"\img\Step0\24.png" },
            { "tH",  @"\img\Step0\25.png" },
            { "TH",  @"\img\Step0\26.png" },
            { "E" ,  @"\img\Step0\27.png" },
            { "EE",  @"\img\Step0\28.png" },
            { "y" ,  @"\img\Step0\29.png" },
            { "RH",  @"\img\Step0\30.png" },
            { "EH",  @"\img\Step0\31.png"  },
            { "rH",  @"\img\Step0\32.png"  },
            { "u" ,  @"\img\Step0\33.png"  },
            { "oe",  @"\img\Step0\34.png"  },
            { "b" ,  @"\img\Step0\35.png"  },
            { "B" ,  @"\img\Step0\36.png"  },
            { "bH",  @"\img\Step0\37.png"  },
            { "BH",  @"\img\Step0\38.png"  },
            { "L" ,  @"\img\Step0\39.png"  },
            { "zH",  @"\img\Step0\40.png"  },
            { "LH",  @"\img\Step0\41.png" },
            { "Le",  @"\img\Step0\42.png" },
            { "va",  @"\img\Step0\43.png" },
            { "ve",  @"\img\Step0\44.png" },
            { "V" ,  @"\img\Step0\45.png" },
            { "aH",  @"\img\Step0\46.png" },
            { "IH",  @"\img\Step0\47.png" },
            { "uH",  @"\img\Step0\48.png" },
            { " " ,  @"\img\Step0\space.png" },
            { "." ,  @"\img\Step0\49.png" },
            { "," ,  @"\img\Step0\50.png" },
            { "(" ,  @"\img\Step0\51.png" },
            { ")" ,  @"\img\Step0\52.png" },
            { "!" ,  @"\img\Step0\53.png" },
            { "?" ,  @"\img\Step0\54.png" },
            { "*" ,  @"\img\Step0\55.png" },
            { ":" ,  @"\img\Step0\56.png" },
            { "'" ,  @"\img\Step0\57.png" },
            { "\"",  @"\img\Step0\58.png" },
        };
    }
}
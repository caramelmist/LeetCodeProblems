using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem336 : Solution
    {
        public void Run()
        {
            IList<IList<int>> actual = PalindromePairs(new string[] { "abcd", "dcba", "lls", "s", "sssll" });
            List<List<int>> expected = new()
            {
                new List<int>() { 0, 1 },
                new List<int>() { 1, 0 },
                new List<int>() { 3, 2 },
                new List<int>() { 2, 4 }
            };

            Console.WriteLine("Outcome: {0} {1}", expected.Count, actual.Count);

            actual = PalindromePairs(new string[] { "hijajcd", "hjhgahbcegj", "fjbjfecjgfjdbbgdadcb", "did", "cgjhfafgea", "chdbicgcij", "jiebc", "aajaaed", "afddjhg", "hiabij", "hfgidgegedeafc", "ifedfcaahhbc", "fci", "jbadcfghehiecbgjcg", "gihedfiabhdjicaea", "ji", "hgacdbeadahceag", "hij", "fhheadbjb", "gieghcacfccfadijcdbg", "dbeabaafia", "je", "ebieia", "becjedbdadecfafi", "acbchfigbiaafechfeii", "fddfbb", "jefdihii", "cfcifihdfgcjadbeec", "jbcfgdhifjgdgcccggfe", "ibhj", "iihihigj", "jifbhdgffiaii", "gdcgdabdhbdh", "giaa", "fgaidgcbgbagjjgcja", "becgcgjbeegebb", "jadgeej", "h", "fddgcbgahhh", "gecajfjcheha", "gaeejd", "bc", "fd", "jh", "jddecghbjaedgeadieej", "ehi", "cfijccggfeijfc", "jbdaeaeigbedebaabdg", "hjiijifigbhae", "aeihbbfdgfhi", "bibhjdgdejjfgd", "b", "dgfhcbgfifchhihg", "faaefigafd", "fijbabeifgjcefeffdgc", "ahdaiejbhegaha", "difcfcbcfg", "abdffeifcb", "ggeaej", "hbcicchejbecidi", "ijedjfcjahhajc", "jfacgfijbdehg", "dfbhhbdafcfhjffbcij", "cddjdgefdjbhccgaeb", "c", "gajfibiaehichfhfh", "cheegj", "icjhhcigfeedg", "dggf", "ificjhaihgicbhagjjgc", "ifbjbadgcccacjcaea", "biaafggehahijagj", "dghehgccj", "ccigbcajbb", "fgafdfhagi", "jdifdcj", "haagafjfa", "cdjibbfgije", "jgbgdcgaabeicfadedjg", "iahehcjhjecbjdehd", "acahgc", "ejggbffeea", "ebacgded", "ci", "igggjhfgcjfeagaed", "jjifjgfefgjgafdc", "ddiefahhfeifggj", "jggjfacda", "dig", "bajbghfecjajdhfebi", "bfjcbiceefafhbc", "bi", "cdaj", "bfedf", "affdcjd", "ebjceefjji", "cgedidfdaj", "diagcdjgcidcaabdec", "biajbeajggcaadb", "gg", "af", "ddeibadahhhbcgbb", "fbgjaedfgah", "fhagi", "dbggfjbhefcg", "dfgdhjcecbhjffhhcc", "gcg", "ibejfeehbfhbcceagbf", "beefhdiiaajbbid", "fcbgeeaggcehjagfbec", "cehgbhhdjdabjhgbdf", "ibjchciabig", "fjfhbdhbdchacfi", "dgaiffdjjfhihheajda", "afbdfijbaacechfeehai", "bhccifjcigdge", "ghdibjdih", "fhjiaja", "fadfaea", "ghhdicafbdgbccahb", "fhf", "jhfg", "jehedbbcidgahjhefj", "jdigdea", "acfiiaebjfeea", "eibciijib", "fghhghdhb", "bf", "jgdbcciehebec", "cbef", "ccdcegbejhcdhbjgd", "dacefieigggddd", "icjfbhabjjaehgic", "dja", "egidaegjegceied", "eifggahef", "d", "gh", "aabhihfhbjjgaaaaaaf", "hhfjgcd", "efcejjcgbhdicghbcbda", "jeecggeaidcdfeae", "i", "ddibebgcibi", "gcffcijafghehgffijbj", "ieb", "hhbfcdgeicihcbcgje", "aegbdaeedadig", "jjhfgeijciji", "ecjijiahfcbcf", "hibddjjgifbf", "eccaajecechb", "deaaj", "ecgfaaigjce", "jhhejciejdhh", "cb", "f", "cjddcfdihddechegg", "cgdfdbficba", "jajh", "hcfadbghjbicbachah", "g", "fhchedhbcigeci", "ghbbcijcbgeccbebaa", "chgdgjiac", "adfgjbbhfbdbheebhgb", "gbbebiaijhagcjfgjda", "aadhgcfjhcjaa", "fhdbhccfccajfheiaaj", "ijgjfc", "dcdcfaebjhgafh", "egadegbjabjgjhdbhcfb", "hhaeabfcfcjc", "gfjcijhbbie", "icgihfcgd", "gfaihjbcb", "hae", "ciiaefdegffchagaccj", "dbadejehhgjjfd", "abfbfdaaebhgbadf", "gfeijf", "acidgfeccdaccc", "chhicfj", "aejjeejbjcebd", "bcchhd", "aajideccdfgfdee", "fdd", "idabig", "bfgigiacibhibfc", "ghjidfcjdbfagbgg", "jdgefifgfg", "figabdib", "ieegjbjaaaheieccfifj", "hhifigebihbec", "abfdca", "j", "dfecghggj", "fbdg", "aghigddeagaj", "hjghddg", "biededhjegi", "aed", "jcgbbhiacef", "hgbhaadhe", "bjffahgjibfjijjcah", "abjgacciihhigafe", "bhighdhjgb", "idjbedcbcghfhgdjgd", "fdcge", "jiefciajfacejcbhiijb", "gghchaac", "jdh", "ccdabajaihbigbfbi", "edcchgggdajibbafag", "fiihgiebhhb", "ggbhhfjfa", "gechicejjgbebe", "fdadccghiadhgeecfeb", "fh", "gbddbi", "acjcafggc", "chgbfjfdghjfgaje", "fgdcfffcabdbih", "ffggdfd", "eeibfggddgbb", "bcccgbihhhaa", "ecegdgdaieicfffebd", "heig", "aeafdijcgffhaagajbc", "cdfecjaabhajjcag", "jgacggaabdidjgg", "hfcdjddbchagfa", "bgh", "bbiefehhfc", "dfhic", "checjfabdceddfefa", "bbiebgigjg", "hdchejdjeecc", "cieafdi", "bjbebfjbb", "jeeghjiaagdf", "ibbjgh", "jgfje", "gddfb", "iadhbabgjjci", "faafifgeddfcaji", "ijejbiidaefibga", "gjhdgffcebfdbbhh", "hfbccbbbhebgjihfbhad", "jhjeffebgiaijecihcbh", "bdacgdeeiajehjhd", "cej", "fbbhabbdhbeigag", "dhb", "cbgahbcjjcb", "jfbgegddgbfij", "bjhcaabhgcfcieai", "dfbedgacb", "bh", "hbgjhchebdigfef", "becbjjgbdgfg", "jigbiecdcegcgdha", "ddacfbgaibdag", "afid", "gijejaagbghjha", "becaigcjdbeiba", "gd", "cbfffhbacc", "jjbafcijeffacaej", "ihihgcgjgefiehgdijb", "afifbbhfbd", "dhigif", "chcfjjahbjjgjjheie", "ggfaaeeca", "afjiccee", "dddeigfhbgjiiffgf", "edbcfcbiibhcdbihahd", "jfhf", "cgeeefjhj", "ehaaahjbf", "dbdbfeabhhdfhedc", "jagiegfhgeicd", "cg", "fjhbaj", "djfejdacebedjjh", "ejhdbjaagcih", "hhifahefah", "decabhgbhf", "hjgfhdcfjghiehfbaccb", "hc", "cicefggjjhahhihh", "ebghgcehfdbgjef", "ihjfejiaidccj", "feebgfadjjih", "efdjbhbcdgfabia", "ebjdhij", "ccbjjbfgjifgibibhdi", "ddhgfihdifiegfdcbg", "jjhccchci", "bjhffdchjgfdejbjcc", "ghfhfadhadggbf", "degiigae", "ffefbjgfacjghchab", "affcadjjedffagcija", "hfaahajcijjigihjdbh", "eccahdhacfaaechc", "gaidhegbhdbg", "gdacg", "ajiafgjbi", "dcecgfgjh", "e", "cj", "iijjbfbciidi", "hhabcihigiccc", "hdje", "ghgiagda", "gcgii", "jgccffabdd", "eafd", "jgajgdghgjihfj", "hf", "jfhhagebiaage", "jcbgf", "cehifbja", "egidejh", "jd", "hhfgdcedjbafijia", "jejiajdffhdg", "ebdificebhah", "djddifjeb", "ibgfadfebjefjehed", "fcbad", "gfajh", "eabhddjadabaadc", "jfjdaibedicjfd", "a", "ahfiihcjceefjghjhi", "hdbcfidadjaggacigg", "bbfjhiegacbicihgbd", "beddihjhhjhi", "ahgideccga", "eadhajdegaig", "bccbgahhh", "ihfieebjejfhfh", "jddigigfhfegf", "acdihgjab", "hgcbfheehjafij", "hagfebifdcah", "ecfbiefefcgha", "giifif", "cfiadgbb", "faiecgcbaidi", "ffhcfc", "dgcbabfchj", "gchhhdhjjjjgfbeeaig", "jiebceebjeeiadcjehia", "ajbbhbighd", "hgiidjeagfgeejb", "gdehaffbfjc", "dhfibjfdfedbe", "hbeeedddgaaa", "bj", "fgdhidihjfbedbbhb", "dcigfcd", "jjgccccjfhjgagjbccbd", "djggj", "fdfbcaj", "hhh", "ebgddabghbje", "ijaeaihjbjgeb", "bcgf", "geabfbf", "ajdf", "behefaeeb", "icjecdbeejbg", "dcfhcchjabbbe", "ficggejecefjahagfc", "cbjbaaig", "cgghddihbibdahajjjj", "febcdicdjhigigjf", "jccfhaafj", "hgagaghagejgdbhiaa", "gdibfadcfjdchdcda", "faice", "jddahggg", "ig", "ajihabc", "ifc", "ddbdie", "hgf", "iicihahjicfbce", "egfjiifaigfhafdcdi", "gahbbfgebhajgajgf", "gibegcbhhjhcgeg", "gahahjjjid", "beeghbgiaiffcbedhi", "hb", "dgfdhbajiej", "ehjieabbfgjfabegijii", "chdafjb", "giejchjbifieeeigccah", "dadgcgjddbc", "cdiiea", "icdjffie", "iehihifddj", "jfcgfbjghbgfd", "edebbjiieahada", "badbhciaf", "icdffehcddgacgjcfji", "fgiheieeeibdjhhjae", "accebdijaedhhajaj", "acdgcbaehgaiedfcddf", "jiagjghcaihbf", "ga", "ggghd", "gb", "ehcjcd", "aac", "cdfghgfagbcjjc", "cddadcdidegifbi", "ddhhch", "fe", "eaageabiccfcdd", "fbbbjfjffj", "icjfacdcbdajecda", "aegdcbbicebaffaifg", "hedichggfajdbagh", "fggjjg", "bdbigbjbjadiabjbhch", "cdddaajifjjjiigj", "bhb", "faa", "bdfgebjf", "hicgahicd", "hcfghggjcibb", "ieddefeccfeccajhcah", "ghc", "jdgcbjaeeijjgciae", "bdeaif", "ehfdc", "jjjddhjd", "jibaejfc", "gddibbagdjbefaga", "fhca", "iaggggg", "bgbhgei", "gigfa", "fbibghagehecbedidbf", "igbfedebhcjbbcegaa", "cdceiffdjech", "fbdjdhhfgaija", "jgjccccchjabdgejfcj", "aca", "jghb", "ffeejefecheefdjh", "aediabejhghedgdah", "edfcbijbihjafedcc", "jbeg", "gfdeccbdgdgidabe", "figbaajccj", "dh", "eeafbfcccbjidci", "adfgdc", "becaafdhg", "cjfhajagc", "fhfifchf", "djdihjjdiibhaegfehc", "cgecbjhdjh", "acbfbccbiehjhjahjbic", "hhgbjdcidhdhdcijfdg", "jdcjaichdbiaefe", "bbdgfafiehc", "acdaajjfjcaeahcddage", "edbbehfdiddc", "ghabih", "ba", "dhjhdbieifabebajf", "cccdhicdbdf", "jfgdddh", "chhjg", "fgheacjabhiiihefbji", "jhcfbgbbgfe", "jgffhddba", "jibffbeijfcif", "dcghgfddfhj", "gaggjcdcaaf", "igjiaajgcjhbeeebdf", "gejibddcbj", "jcaaebfebjh", "jeedhcejgbegide", "jebfehdfdibg", "hdefhaia", "eb", "fjchhceceijfi", "egabjjcdbegfeabc", "gbiagfgfg", "gfajge", "iii", "dccjjeajd", "aihegdchjef", "gdaiegffaih", "haacjdcfheheeejefg", "bcde", "agcbagagadfjfdghdbb", "ejjiageabfh", "gichcecbfd", "iacajf", "fdfeaajhccbhb", "aecc", "da", "ecgcbdggffjg", "biebjjhfidb", "dadfcigjif", "badafaheg", "gddadiifadaa", "echjgchihgadb", "bhgaghbihef", "cjihigiiibdc", "bdheddceciaib", "ggegccjahfbib", "jfabidhcjefcfd", "iiiadhfhaig", "geedcbchc", "bafhbicaeidjg", "hfgiefdcgjjieejii", "hgiiigfcididicgaijde", "ihdbeahaehgd", "difgjfagjfidcdbggce", "ajdfddjbbdjjb", "iccabdaahhgcdejf", "gichhgejcgddcgbij", "jjea", "gcigbjhbaadjhi", "jjeeefibachiddid", "hjbehbeic", "adibfgfdgfgghgbggaa", "biggeedhffd", "hffdaaeidhfjgj", "ige", "ichijijc", "bhjh", "bifeidf", "hcgd", "jfbdabjbcadjgahgjd", "fhghdhfahibcbieiab", "gcjijfbiigiegb", "ibgabbhbijadhgib", "djadidiihhdfhiabb", "badefeccfjgca", "edehccejiajcb", "adjf", "afcefdjajhjhddffbjb", "biejjg", "ffjfhieaebhbiag", "gaegidbb", "jaahhjfca", "egg", "jeeaaffch", "bjaaafccjiii", "gcghehg", "egdibghgbhicdfdcicif", "jidaafdbhggfea", "daceegcdfbbbehejdgej", "jdbjcaad", "aihf", "fhgahbafcd", "bgcdcdejeiefdggfhha", "ccafhij", "hdahgjieaacabfa", "hgjeajaacfce", "jhejhibcbdacgjbjhbe", "hajgigd", "aaid", "fbjhbd", "eaddhgedigbffgbhcc", "diiiabffdifheaaahe", "cifigegjbibihd", "ahhiffjfff", "eebhji", "cidjigijdaghhcjic" });
            expected = new()
            {
                new List<int>() { 0, 1 },
                new List<int>() { 1, 0 },
                new List<int>() { 3, 2 },
                new List<int>() { 2, 4 }
            };

            Console.WriteLine("Outcome: {0} {1}", expected.Count, actual.Count);
        }

        public IList<IList<int>> PalindromePairs(string[] words)
        {
            List<IList<int>> answer = new();
            for (int i = 0; i < words.Length; i++)
            {
                if(HasIndex(answer, i))
                {
                    continue;
                }

                for (int j = 0; j < words.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }

                    HasPair(answer, i, j);

                    if (IsPalindrome(words[i] + words[j]))
                    {
                        List<int> ints = new List<int>();
                        ints.Add(i);
                        ints.Add(j);
                        answer.Add(ints);

                        for (int k = i + 1; k < words.Length; k++)
                        {
                            if (words[i] == words[k])
                            {
                                List<int> other = new List<int>();
                                other.Add(k);
                                other.Add(j);
                                answer.Add(other);
                            }
                        }
                    }
                }
            }

            return answer;
        }

        private bool HasPair(List<IList<int>> values, int i, int j)
        {
            foreach (var item in values)
            {
                if (item[0] == i && item[1] == j)
                {
                    return true;
                }

                if (item[1] == i && item[0] == j)
                {
                    return true;
                }
            }
            return false;
        }

        private bool HasIndex(List<IList<int>> values, int index)
        {
            foreach (var item in values)
            {
                if (item[0] == index)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsPalindrome(string word)
        {
            for(int i = 0; i < word.Length; i++)
            {
                char f = word[i];
                char b = word[(word.Length-1-i)];

                if (f != b)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SavePrisonerTests
    {
        [TestMethod()]
        public void saveThePrisonerTest1()
        {
            Assert.AreEqual(2, SavePrisoner.saveThePrisoner(5, 2, 1));
        }

        [TestMethod()]
        public void saveThePrisonerTest2()
        {
            Assert.AreEqual(3, SavePrisoner.saveThePrisoner(5, 2, 2));
        }

        [TestMethod()]
        public void saveThePrisonerTest3()
        {
            Assert.AreEqual(6, SavePrisoner.saveThePrisoner(7, 19, 2));
        }

        [TestMethod()]
        public void saveThePrisonerTest4()
        {
            Assert.AreEqual(3, SavePrisoner.saveThePrisoner(3, 7, 3));
        }

        [TestMethod()]
        public void saveThePrisonerTest5()
        {
            Assert.AreEqual(72975907, SavePrisoner.saveThePrisoner(208526924, 756265725, 150817879));
        }

        [TestMethod()]
        public void saveThePrisonerTest6()
        {
            Assert.AreEqual(999999999, SavePrisoner.saveThePrisoner(999999999, 999999999, 1));
        }

        [TestMethod()]
        public void saveThePrisonerTest7()
        {
            Assert.AreEqual(40, SavePrisoner.saveThePrisoner(40, 277585960, 1));
        }

        [TestMethod()]
        public void saveThePrisonerTestAll1()
        {
            Assert.AreEqual(122129406, SavePrisoner.saveThePrisoner(352926151, 380324688, 94730870));
            Assert.AreEqual(23525398, SavePrisoner.saveThePrisoner(94431605, 679262176, 5284458));
            Assert.AreEqual(405956028, SavePrisoner.saveThePrisoner(962975336, 972576181, 396355184));
            Assert.AreEqual(265162707, SavePrisoner.saveThePrisoner(464237185, 937820284, 255816794));
            Assert.AreEqual(91803604, SavePrisoner.saveThePrisoner(649320641, 742902564, 647542323));
            Assert.AreEqual(82636723, SavePrisoner.saveThePrisoner(174512033, 711706897, 68977959));
            Assert.AreEqual(9258153, SavePrisoner.saveThePrisoner(107283902, 156676511, 67149447));
            Assert.AreEqual(81152217, SavePrisoner.saveThePrisoner(104513201, 298399273, 96292548));
            Assert.AreEqual(31978708, SavePrisoner.saveThePrisoner(113378824, 274011418, 98103763));
            Assert.AreEqual(269539705, SavePrisoner.saveThePrisoner(934815799, 991959468, 212396037));
            Assert.AreEqual(18445097, SavePrisoner.saveThePrisoner(88325121, 435452998, 24617705));
            Assert.AreEqual(115810626, SavePrisoner.saveThePrisoner(984873585, 997634055, 103050157));
            Assert.AreEqual(117586280, SavePrisoner.saveThePrisoner(344218387, 715364875, 90658180));
            Assert.AreEqual(216062299, SavePrisoner.saveThePrisoner(556065259, 615709967, 156417592));
            Assert.AreEqual(55859471, SavePrisoner.saveThePrisoner(57109959, 451440582, 4188603));
            Assert.AreEqual(110226121, SavePrisoner.saveThePrisoner(353972922, 573651462, 244520504));
            Assert.AreEqual(674567416, SavePrisoner.saveThePrisoner(946486979, 973168361, 647886035));
            Assert.AreEqual(49690850, SavePrisoner.saveThePrisoner(368127406, 680428368, 105517295));
            Assert.AreEqual(200235842, SavePrisoner.saveThePrisoner(884634320, 965112925, 119757238));
            Assert.AreEqual(350805362, SavePrisoner.saveThePrisoner(422557970, 744431033, 28932300));
            Assert.AreEqual(28872987, SavePrisoner.saveThePrisoner(634954007, 957414623, 341366379));
            Assert.AreEqual(59090728, SavePrisoner.saveThePrisoner(190265362, 445253893, 184632922));
            Assert.AreEqual(13206454, SavePrisoner.saveThePrisoner(293315518, 479153471, 120684020));
            Assert.AreEqual(8773474, SavePrisoner.saveThePrisoner(72410472, 80198999, 984948));
            Assert.AreEqual(425809870, SavePrisoner.saveThePrisoner(784893322, 849791807, 360911386));
            Assert.AreEqual(544652109, SavePrisoner.saveThePrisoner(846191883, 880790237, 510053756));
            Assert.AreEqual(119049822, SavePrisoner.saveThePrisoner(297201660, 812278057, 198376746));
            Assert.AreEqual(519193865, SavePrisoner.saveThePrisoner(945087694, 999220046, 465061514));
            Assert.AreEqual(422682546, SavePrisoner.saveThePrisoner(786859800, 831171414, 378370933));
            Assert.AreEqual(27074790, SavePrisoner.saveThePrisoner(528402029, 859318899, 224559950));
            Assert.AreEqual(262019564, SavePrisoner.saveThePrisoner(522640531, 755821672, 28838424));
            Assert.AreEqual(821934714, SavePrisoner.saveThePrisoner(864006909, 879474138, 806467486));
            Assert.AreEqual(588497214, SavePrisoner.saveThePrisoner(613544440, 943850900, 258190755));
            Assert.AreEqual(460522527, SavePrisoner.saveThePrisoner(734228459, 928771704, 265979283));
            Assert.AreEqual(385897437, SavePrisoner.saveThePrisoner(542812502, 597832172, 330877768));
            Assert.AreEqual(333906011, SavePrisoner.saveThePrisoner(541133561, 748691081, 126348492));
            Assert.AreEqual(14136713, SavePrisoner.saveThePrisoner(51187317, 524866691, 1143193));
            Assert.AreEqual(478754860, SavePrisoner.saveThePrisoner(885290374, 990676850, 373368385));
            Assert.AreEqual(145371959, SavePrisoner.saveThePrisoner(147955933, 450823700, 138416059));
            Assert.AreEqual(20243482, SavePrisoner.saveThePrisoner(100046465, 587967212, 32555061));
            Assert.AreEqual(93060069, SavePrisoner.saveThePrisoner(233926824, 996957988, 31809378));
            Assert.AreEqual(739548684, SavePrisoner.saveThePrisoner(785405778, 835771758, 689182705));
            Assert.AreEqual(54653973, SavePrisoner.saveThePrisoner(444389615, 870657324, 72775880));
            Assert.AreEqual(537798717, SavePrisoner.saveThePrisoner(702580369, 895325888, 345053199));
            Assert.AreEqual(332932745, SavePrisoner.saveThePrisoner(968559651, 974760313, 326732084));
            Assert.AreEqual(170016312, SavePrisoner.saveThePrisoner(299437419, 514618345, 254272806));
            Assert.AreEqual(755555371, SavePrisoner.saveThePrisoner(901702945, 930227426, 727030891));
            Assert.AreEqual(239799957, SavePrisoner.saveThePrisoner(721843209, 736359383, 225283784));
            Assert.AreEqual(24001866, SavePrisoner.saveThePrisoner(833018320, 883439261, 806599246));
            Assert.AreEqual(87501244, SavePrisoner.saveThePrisoner(267346244, 307857609, 46989880));
            Assert.AreEqual(202677879, SavePrisoner.saveThePrisoner(299901304, 892163356, 210218436));
            Assert.AreEqual(388484637, SavePrisoner.saveThePrisoner(565637506, 795821687, 158300457));
            Assert.AreEqual(85042925, SavePrisoner.saveThePrisoner(107336562, 781910357, 54488503));
            Assert.AreEqual(144704874, SavePrisoner.saveThePrisoner(513281286, 916998022, 254269425));
            Assert.AreEqual(387228584, SavePrisoner.saveThePrisoner(413431205, 611661371, 188998419));
            Assert.AreEqual(29703127, SavePrisoner.saveThePrisoner(740163288, 938647312, 571382392));
            Assert.AreEqual(27144750, SavePrisoner.saveThePrisoner(44702121, 296589002, 43470596));
            Assert.AreEqual(465233083, SavePrisoner.saveThePrisoner(771733011, 919327188, 317638907));
            Assert.AreEqual(592129096, SavePrisoner.saveThePrisoner(718860003, 815844769, 495144331));
            Assert.AreEqual(171623012, SavePrisoner.saveThePrisoner(377975600, 438513404, 111085209));
            Assert.AreEqual(99804791, SavePrisoner.saveThePrisoner(424965480, 928959619, 20776133));
            Assert.AreEqual(233162218, SavePrisoner.saveThePrisoner(234986523, 732169039, 205952749));
            Assert.AreEqual(69626951, SavePrisoner.saveThePrisoner(377078343, 981597420, 219264561));
            Assert.AreEqual(147046575, SavePrisoner.saveThePrisoner(612269027, 791414524, 580170106));
            Assert.AreEqual(467740, SavePrisoner.saveThePrisoner(232336090, 616084008, 81392003));
            Assert.AreEqual(27317429, SavePrisoner.saveThePrisoner(75059328, 274029861, 53524881));
            Assert.AreEqual(70841696, SavePrisoner.saveThePrisoner(239121359, 646856043, 141349731));
            Assert.AreEqual(226892541, SavePrisoner.saveThePrisoner(923193147, 943368157, 206717532));
            Assert.AreEqual(8113004, SavePrisoner.saveThePrisoner(12565064, 536852817, 11557940));
            Assert.AreEqual(174582190, SavePrisoner.saveThePrisoner(360225746, 970375527, 284883902));
            Assert.AreEqual(181675979, SavePrisoner.saveThePrisoner(213705306, 380885426, 14495860));
            Assert.AreEqual(113791493, SavePrisoner.saveThePrisoner(659446919, 699401237, 73837176));
            Assert.AreEqual(122228525, SavePrisoner.saveThePrisoner(335372713, 785363124, 7610828));
            Assert.AreEqual(431091984, SavePrisoner.saveThePrisoner(538388654, 859196325, 110284314));
            Assert.AreEqual(86082218, SavePrisoner.saveThePrisoner(118558760, 713483972, 83950807));
            Assert.AreEqual(73257991, SavePrisoner.saveThePrisoner(896959032, 961368580, 8848444));
            Assert.AreEqual(12731011, SavePrisoner.saveThePrisoner(25543240, 521123082, 2472730));
            Assert.AreEqual(96444034, SavePrisoner.saveThePrisoner(258530682, 935834352, 194732411));
            Assert.AreEqual(83666114, SavePrisoner.saveThePrisoner(465248213, 679599042, 334563499));
            Assert.AreEqual(52088792, SavePrisoner.saveThePrisoner(331230504, 637771661, 76778140));
            Assert.AreEqual(256275569, SavePrisoner.saveThePrisoner(976340152, 988657462, 243958260));
            Assert.AreEqual(356889192, SavePrisoner.saveThePrisoner(552994811, 922743535, 540135280));
            Assert.AreEqual(236671646, SavePrisoner.saveThePrisoner(626831986, 839281366, 24222267));
            Assert.AreEqual(155050214, SavePrisoner.saveThePrisoner(157704591, 253731033, 59023773));
            Assert.AreEqual(290894843, SavePrisoner.saveThePrisoner(806377559, 859228114, 238044289));
            Assert.AreEqual(426512254, SavePrisoner.saveThePrisoner(838798445, 996851254, 268459446));
            Assert.AreEqual(835545460, SavePrisoner.saveThePrisoner(847646888, 928001503, 755190846));
            Assert.AreEqual(118152992, SavePrisoner.saveThePrisoner(877625009, 999275937, 874127074));
            Assert.AreEqual(55891557, SavePrisoner.saveThePrisoner(847949466, 893343194, 10497830));
            Assert.AreEqual(22230414, SavePrisoner.saveThePrisoner(35029316, 784675240, 8200127));
            Assert.AreEqual(42655476, SavePrisoner.saveThePrisoner(111807455, 690309882, 23190325));
            Assert.AreEqual(154594318, SavePrisoner.saveThePrisoner(355765714, 554560093, 311565654));
            Assert.AreEqual(1153181, SavePrisoner.saveThePrisoner(1890615, 614626804, 976253));
            Assert.AreEqual(98497256, SavePrisoner.saveThePrisoner(132293206, 165429783, 65360680));
            Assert.AreEqual(376112207, SavePrisoner.saveThePrisoner(506726160, 934170235, 455394293));
            Assert.AreEqual(67920321, SavePrisoner.saveThePrisoner(210041918, 328800789, 159203369));
            Assert.AreEqual(499999999, SavePrisoner.saveThePrisoner(499999999, 999999997, 2));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(499999999, 999999998, 2));


        }

        [TestMethod()]
        public void saveThePrisonerTestAll2()
        {
            Assert.AreEqual(20809, SavePrisoner.saveThePrisoner(46934, 543563655, 46743));
            Assert.AreEqual(15, SavePrisoner.saveThePrisoner(530, 533048047, 529));
            Assert.AreEqual(436776010, SavePrisoner.saveThePrisoner(436776012, 436776012, 436776011));
            Assert.AreEqual(999983943, SavePrisoner.saveThePrisoner(999999999, 999999998, 999983945));
            Assert.AreEqual(30, SavePrisoner.saveThePrisoner(59, 78693934, 2));
            Assert.AreEqual(17, SavePrisoner.saveThePrisoner(49, 897910613, 48));
            Assert.AreEqual(2, SavePrisoner.saveThePrisoner(124, 738996353, 2));
            Assert.AreEqual(871077787, SavePrisoner.saveThePrisoner(999999999, 871077789, 999999998));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(2, 576581, 1));
            Assert.AreEqual(275329482, SavePrisoner.saveThePrisoner(526663404, 801992888, 526663403));
            Assert.AreEqual(999999998, SavePrisoner.saveThePrisoner(999999998, 999999998, 1));
            Assert.AreEqual(95, SavePrisoner.saveThePrisoner(126, 859530642, 126));
            Assert.AreEqual(999999998, SavePrisoner.saveThePrisoner(1000000000, 999999999, 1000000000));
            Assert.AreEqual(22, SavePrisoner.saveThePrisoner(107, 425601402, 2));
            Assert.AreEqual(378, SavePrisoner.saveThePrisoner(381, 695699141, 380));
            Assert.AreEqual(4, SavePrisoner.saveThePrisoner(11, 32020900, 6));
            Assert.AreEqual(468840391, SavePrisoner.saveThePrisoner(468840391, 468840391, 1));
            Assert.AreEqual(29010, SavePrisoner.saveThePrisoner(999999999, 29010, 1));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(31, 238250965, 2));
            Assert.AreEqual(5, SavePrisoner.saveThePrisoner(6, 923562791, 1));
            Assert.AreEqual(38, SavePrisoner.saveThePrisoner(39, 558119524, 38));
            Assert.AreEqual(120, SavePrisoner.saveThePrisoner(121, 652798629, 1));
            Assert.AreEqual(67, SavePrisoner.saveThePrisoner(94, 105224796, 94));
            Assert.AreEqual(3, SavePrisoner.saveThePrisoner(9, 903414482, 5));
            Assert.AreEqual(1717786, SavePrisoner.saveThePrisoner(1718761, 828441828, 1718761));
            Assert.AreEqual(69, SavePrisoner.saveThePrisoner(4970962, 984250547, 4970961));
            Assert.AreEqual(12, SavePrisoner.saveThePrisoner(19, 235344290, 2));
            Assert.AreEqual(514824323, SavePrisoner.saveThePrisoner(514824323, 514824324, 514824323));
            Assert.AreEqual(178, SavePrisoner.saveThePrisoner(181, 511813156, 180));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(66, 810757794, 2));
            Assert.AreEqual(152, SavePrisoner.saveThePrisoner(154, 935852917, 154));
            Assert.AreEqual(999974359, SavePrisoner.saveThePrisoner(1000000000, 999999999, 999974361));
            Assert.AreEqual(18, SavePrisoner.saveThePrisoner(21, 603073253, 20));
            Assert.AreEqual(5, SavePrisoner.saveThePrisoner(29, 834017184, 28));
            Assert.AreEqual(195446093, SavePrisoner.saveThePrisoner(195446094, 586338283, 195446093));
            Assert.AreEqual(54691, SavePrisoner.saveThePrisoner(93995, 173193482, 93995));
            Assert.AreEqual(100, SavePrisoner.saveThePrisoner(101, 143467773, 101));
            Assert.AreEqual(133, SavePrisoner.saveThePrisoner(134, 677010612, 134));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(99, 741806010, 2));
            Assert.AreEqual(2, SavePrisoner.saveThePrisoner(75, 129103876, 2));
            Assert.AreEqual(689370114, SavePrisoner.saveThePrisoner(689371544, 689371544, 689370115));
            Assert.AreEqual(22721112, SavePrisoner.saveThePrisoner(28410362, 340924345, 22721112));
            Assert.AreEqual(9, SavePrisoner.saveThePrisoner(170, 780653100, 170));
            Assert.AreEqual(180, SavePrisoner.saveThePrisoner(193, 945602138, 192));
            Assert.AreEqual(78, SavePrisoner.saveThePrisoner(96, 23494832, 95));
            Assert.AreEqual(20311, SavePrisoner.saveThePrisoner(944675683, 944675683, 20312));
            Assert.AreEqual(16, SavePrisoner.saveThePrisoner(27, 546238476, 26));
            Assert.AreEqual(70866971, SavePrisoner.saveThePrisoner(76195990, 223258463, 489));
            Assert.AreEqual(269208525, SavePrisoner.saveThePrisoner(999999999, 269208525, 1));
            Assert.AreEqual(107, SavePrisoner.saveThePrisoner(108, 280122192, 108));
            Assert.AreEqual(14, SavePrisoner.saveThePrisoner(16, 995404080, 15));
            Assert.AreEqual(50150967, SavePrisoner.saveThePrisoner(50158215, 451423257, 50151646));
            Assert.AreEqual(4, SavePrisoner.saveThePrisoner(4, 467711281, 4));
            Assert.AreEqual(144, SavePrisoner.saveThePrisoner(145, 71654651, 144));
            Assert.AreEqual(2985, SavePrisoner.saveThePrisoner(1000000000, 2985, 1));
            Assert.AreEqual(990271854, SavePrisoner.saveThePrisoner(990301380, 1, 990271854));
            Assert.AreEqual(27888, SavePrisoner.saveThePrisoner(999999999, 6413, 21476));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(2, 468939243, 1));
            Assert.AreEqual(396, SavePrisoner.saveThePrisoner(399, 592025825, 398));
            Assert.AreEqual(6, SavePrisoner.saveThePrisoner(8, 666688807, 8));
            Assert.AreEqual(5, SavePrisoner.saveThePrisoner(7, 633100633, 2));
            Assert.AreEqual(5, SavePrisoner.saveThePrisoner(12, 124444631, 7));
            Assert.AreEqual(4, SavePrisoner.saveThePrisoner(8, 347412080, 5));
            Assert.AreEqual(999999998, SavePrisoner.saveThePrisoner(999999999, 1, 999999998));
            Assert.AreEqual(38386279, SavePrisoner.saveThePrisoner(42774012, 765544482, 2));
            Assert.AreEqual(16, SavePrisoner.saveThePrisoner(18, 359622755, 18));
            Assert.AreEqual(198, SavePrisoner.saveThePrisoner(198, 964246139, 2));
            Assert.AreEqual(999999997, SavePrisoner.saveThePrisoner(999999999, 999999998, 999999999));
            Assert.AreEqual(9, SavePrisoner.saveThePrisoner(10, 143638249, 1));
            Assert.AreEqual(1946080, SavePrisoner.saveThePrisoner(1946080, 978878239, 2));
            Assert.AreEqual(999967088, SavePrisoner.saveThePrisoner(1000000000, 999976501, 999990588));
            Assert.AreEqual(6922, SavePrisoner.saveThePrisoner(999999999, 999978713, 28209));
            Assert.AreEqual(206648315, SavePrisoner.saveThePrisoner(433677591, 433663369, 206662538));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(999999999, 1, 1));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(2325, 562408200, 2));
            Assert.AreEqual(114, SavePrisoner.saveThePrisoner(172, 456632596, 171));
            Assert.AreEqual(11, SavePrisoner.saveThePrisoner(19, 563815520, 11));
            Assert.AreEqual(148, SavePrisoner.saveThePrisoner(34339, 656699084, 101));
            Assert.AreEqual(999997152, SavePrisoner.saveThePrisoner(1000000000, 999997154, 999999999));
            Assert.AreEqual(90143094, SavePrisoner.saveThePrisoner(1000000000, 1000000000, 90143095));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(2, 213164653, 1));
            Assert.AreEqual(123, SavePrisoner.saveThePrisoner(134, 644278309, 113));
            Assert.AreEqual(640282836, SavePrisoner.saveThePrisoner(1000000000, 640282835, 2));
            Assert.AreEqual(999999998, SavePrisoner.saveThePrisoner(1000000000, 1000000000, 999999999));
            Assert.AreEqual(999999998, SavePrisoner.saveThePrisoner(999999999, 999999999, 999999999));
            Assert.AreEqual(11130, SavePrisoner.saveThePrisoner(999999999, 11132, 999999998));
            Assert.AreEqual(11, SavePrisoner.saveThePrisoner(197, 190791557, 197));
            Assert.AreEqual(999999999, SavePrisoner.saveThePrisoner(1000000000, 1000000000, 1000000000));
            Assert.AreEqual(26, SavePrisoner.saveThePrisoner(46, 56740430, 45));

            Assert.AreEqual(54, SavePrisoner.saveThePrisoner(56, 306549319, 56));
            Assert.AreEqual(6, SavePrisoner.saveThePrisoner(62, 803079454, 43));
            Assert.AreEqual(183, SavePrisoner.saveThePrisoner(184, 834149464, 184));
            Assert.AreEqual(8, SavePrisoner.saveThePrisoner(9, 526219551, 9));
            Assert.AreEqual(583101930, SavePrisoner.saveThePrisoner(999999999, 999999999, 583101931));
            Assert.AreEqual(999999997, SavePrisoner.saveThePrisoner(1000000000, 999999999, 999999999));
            Assert.AreEqual(1, SavePrisoner.saveThePrisoner(176, 719643761, 1));
            Assert.AreEqual(328966241, SavePrisoner.saveThePrisoner(1000000000, 999999999, 328966243));
            Assert.AreEqual(36, SavePrisoner.saveThePrisoner(65, 980609890, 37));
        }
    }
}
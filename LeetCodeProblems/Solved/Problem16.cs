﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem16 : Solution
    {
        public void Run()
        {
            int actual = ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1);
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ThreeSumClosest(new int[] { 0, 0, 0 }, 1);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ThreeSumClosest(new int[] { -744, 572, 795, 845, -57, -225, 874, -600, -818, -725, -449, -140, -236, 602, -961, 11, 358, -97, -884, 1, -478, -736, 55, -55, -4, 667, -931, 582, -124, -101, -813, -957, -749, -363, -711, 25, 834, -906, -5, 84, 915, -197, 773, 570, -309, -240, 459, -431, -974, 949, 490, -912, -510, 43, -195, 473, -983, 20, 684, 975, 906, -793, 554, -517, 202, 196, 987, -207, -248, 128, 24, -281, 661, -979, -238, -210, 506, -208, -110, -303, -694, 366, -213, -451, 149, 861, 794, -189, -598, 618, 216, -534, 884, 933, -98, 288, -131, 296, 525, 573, 804, 451, -710, 603, 402, -848, -462, 58, 271, 843, 825, 23, -666, 442, -883, -767, 682, -601, -627, 411, 513, -411, -380, 260, -962, -464, 122, 89, 532, 741, -50, 174, 307, -955, 440, 567, -705, 416, -32, 726, -648, 600, 470, -216, 839, 693, -343, -325, 206, -12, 119, 980, 331, -278, 948, 193, -3, 991, 286, 169, -642, -104, -563, -828, -220, -692, 504, -81, 77, -152, -676, 512, 706, 210, -875, 910, 659, -479, 176, 383, 727, -608, 456, -408, -320, -387, 212, 976, 236, 47, 16, 94, 215, -773, -586, 201, 455, -139, -40, 998, 181, -806, -553, 395, -258, 892, -196, -190, -791, 391, -446, -333, 321, 351, 534, -660, -845, -861, 392, 350, -518, 853, 91, 319, 973, 542, 274, 116, -644, -537, 249, 625, -596, 475, -724, -180, 468, -26, 246, 893, -738, -442, -821, -324, -142, -782, 102, 92, 209, 484, 318, -522, -989, -970, 511, -445, -62, -434, -685, 374, 381, 229, 654, 21, 595, 399, -667, -421, 241, 335, -713, 650, 353, -580, 69, 566, 222, -223, 791, 40, 162, -176, -639, 961, 417, -816, 510, -930, 986, 652, -843, 651, -951, 259, -151, 294, 972, 329, -402, -447, -441, -846, 770, 328, -896, 400, -854, 611, 378, -976, -106, 379, 398, 519, -505, -718, 228, -722, -94, 571, -712, -53, -889, 995, -823, 535, 772, 389, -268, -351, 656, -269, 71, 315, -594, 290, 382, -60, 863, -454, -1000, -193, -226, -924, 828, 709, -920, -27, 529, 4, -504, 0, 911, -554, 689, -67, 779, 74, -338, 644, 859, -102, -547, 170, 938, 186, 927, 898, -945, -371, -669, 612, -809, -765, -798, -752, -546, -629, -815, -492, -194, 414, 759, 803, 908, -80, -127, -892, 524, -344, 913, -687, -591, 594, -264, 238, 526, 93, 408, 821, 984, 278, -916, 749, 129, -741, 254, 436, -509, 902, -719, 304, 360, -203, -858, -43, 146, -716, -292, -659, -520, -543, -409, 671, -899, -13, -966, 605, 868, -803, 546, 748, 49, 410, -315, -686, -882, -862, -881, 284, -17, -783, -175, 865, 53, 655, 599, 336, -654, 369, -132, -678, -376, -9, -469, -550, 311, -857, 540, -477, -450, 593, 308, -24, 596, -484, -890, -38, -327, 721, 614, 827, -993, -891, 28, -168, -533, -548, 974, -564, -406, 51, -116, 244, 864, -527, 742, -250, -453, 668, 752, -880, 476, 806, 493, 316, -785, 739, -20, -566, 207, -329, -72, 658, -986, 135, -587, -584, 214, 327, 698, 172, -233, 426, -583, -795, -289, -452, 738, -489, 99, -243, -994, -114, 781, 346, -530, 897, -155, -923, 301, 320, 256, -668, -633, 575, 989, -585, -936, -15, -425, -757, 639, 120, 32, -514, -117, -237, 725, -933, 57, -88, -302, -946, -698, 871, -964, -863, -398, -362, 681, 151, 730, 872, -96, 586, -146, -784, -762, -538, 616, -308, -215, -521, 452, 740, 629, -279, 627, -76, 555, -472, 269, 234, -794, 157, -691, 184, -819, 124, 734, 98, -905, -844, -202, -582, -620, -706, 113, -512, -879, 899, -922, -927, 718, 205, 109, -249, 977, -443, -495, -827, -365, 86, -332, 18, -311, -513, 27, 979, -525, 219, 764, -437, 405, -272, -273, -804, -171, -222, -285, -977, 925, 551, -777, -404, -829, 491, 805, 648, 131, 774, -339, 523, -364, -873, -16, -297, -358, -715, -836, -54, 793, -673, 886, 494, -385, -590, -111, -349, -265, -204, 607, 187, -856, 790, -910, 324, 717, 501, -991, -466, 387, 637, -576, -160, 638, 19, 371, 305, -473, 796, -357, 231, -377, -561, 199, -433, 744, 912, 293, 788, -498, -623, -568, 824, 251, 802, 692, 291, -944, 41, 153, 36, 900, 461, 448, -488, -145, 263, 935, -470, 550, 882, -486, -919, 847, 876, 245, 474, -35, -592, -760, 136, 798, 811, 756, -107, 344, 137, 52, 808, 916, 867, 670, 946, -457, 5, 303, 443, -414, -410, 401, 568, 361, 707, 403, -768, 849, -379, 854, 558, -672, 29, -397, -45, 253, -572, -282, -280, 79, -529, -2, -745, -253, -985, 941, 983, -56, -129, 232, -219, 243, -89, 217, 732, 103, 901, 242, -174, -810, 822, 188, 699, -841, 719, 394, 507, -143, -901, 714, 531, -200, 862, -428, 538, 521, -178, 418, -109, 967, -483, 959, -613, 337, -780, -937, 589, -761, -506, -296, 962, -894, 150, -378, -943, 14, -348, -375, 777, 503, 642, -319, -391, 143, 355, -77, -501, -834, -463, -683, 221, -293, 647, 643, -415, 449, 945, -192, -156, -49, 495, -150, 784, 909, 687, -383, 969, -959, -932, -205, 820, 623, -68, -456, 556, -44, 422, 339, -647, 479, -436, 992, -664, -407, -314, -552, -928, -71, 767, -872, 31, 306, -835, -334, 716, -939, 478, 487, 460, 785, -438, 786, -301, -342, 12, -632, -51, -797, -852, 85, 830, -766, -395, 310, -287, -640, -99, -886, -42, -185, -247, -735, -934, -212, -573, 713, -975, 694, 375, -651, -887, -170, 343, -251, 68, -162, 728, -575, 121, 813, -605, -560, 634, -427, -416, 943, 761, 787, -577, -779, 277, 59, -755, 160, -211, 447, 818, 505, 592, 580, 167, 994, -130, -468, 626 }, -6970);
            expected = -2987;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ThreeSumClosest(new int[] { 299, 739, 424, -197, 746, 446, 534, -19, -486, -797, 34, -978, 899, -683, -45, 231, 319, 330, 690, -950, -934, 873, 312, -702, -156, -961, -882, 246, -259, 478, 898, -732, 64, -460, -580, -910, 457, 404, -936, -705, -780, 170, -819, -319, 960, 859, 653, 436, -277, -913, -667, -314, 577, -66, 228, -354, 932, 651, -273, 384, -155, 102, 988, 882, -92, 907, -196, 451, -405, 928, 616, 268, 415, -986, 576, 139, 205, 464, -108, -115, -703, -284, -261, 671, -55, 539, 689, 484, -138, 682, 934, 88, 546, -203, -587, -867, 97, -191, 580, -757, -525, -335, 462, 886, -725, 722, 98, -400, -898, 441, 410, 624, 672, -528, 481, 343, 719, -428, 463, 239, 74, -285, 66, 984, -785, 487, 84, 614, 414, -302, 875, 974, -919, -642, -72, 162, 1, 22, 6, -855, 488, -219, 723, 717, 676, 876, -70, -424, 706, 686, -570, 371, -248, -763, 938, 949, -129, -13, -150, -195, -526, -912, -903, 943, -24, -945, 452, -590, 323, -995, -884, 871, -658, -839, 156, -634, 968, 354, -364, 856, -843, -806, -865, -211, 16, -415, 961, -718, 972, -272, -322, 177, 709, 249, -893, 650, -214, -113, -448, 702, 758, 730, 406, -965, -938, 342, -408, 994, 600, -132, -530, -482, 407, -222, -178, 615, -4, -977, 90, 332, -835, -141, -295, 545, 692, -972, -240, -464, 67, 792, 395, 302, 440, 693, 912, -742, 40, 374, 864, 604, 480, -729, 649, -688, 738, 950, 272, 435, -637, 568, -429, 120, 7, -656, 142, 358, -734, -149, -426, -812, 853, 165, -112, 602, 497, 83, -679, 956, 447, -519, -305, 180, 519, -991, -790, -659, -512, 587, 68, 909, -299, 294, 772, -994, -798, 811, -521, 344, -159, -989, -162, -266, -663, 525, 936, 714, 613, -924, -800, -304, 296, -333, 995, 845, 790, 844, 132, -709, -766, -987, -892, -614, -210, -841, 158, 379, 313, 92, -313, -308, 103, 518, -476, -846, -885, -163, -387, -459, 402, -441, -436, 733, -307, 416, 996, -810, -949, -14, -619, -348, -786, 359, 937, 794, 176, 193, 1000, 81, 306, -566, 465, 935, -453, 727, -41, 762, 145, -736, 529, 62, 178, 578, -879, -386, 589, 147, -379, -407, 396, 388, -860, -352, 838, -552, -137, 288, 185, 944, -796, -346, 528, -465, 267, 621, -511, 948, 449, 537, -537, -204, -360, 855, -505, -12, -296, 939, -752, -520, 230, -370, -502, -769, -60, 920, 612, -748, 684, 820, -447, -595, -109, -747, -242, -650, -361, -657, -461, -389, 126, -808, 971, 669, -276, -966, 515, 444, 542, -600, 221, 151, 227, 787, -231, -876, 921, 590, -152, -661, -432, -123, 789, 697, -959, -508, -315, 270, -192, 114, -710, -328, -993, -377, 625, 363, 361, 724, -75, -958, -338, 810, -562, 128, 967, -90, 680, -618, -331, -466, -953, -289, 473, -713, -62, -74, 245, 498, -440, 595, 472, -660, 611, -94, -350, -556, -765, -134, -990, 243, -576, 190, 169, -316, -139, -858, -544, 527, -697, -764, 619, -280, 212, 510, -844, -730, -737, 565, -171, 215, 946, 387, 501, 977, -776, 438, 769, 470, 986, -226, -340, -830, -376, 657, 399, 251, -434, -100, -694, -501, 293, 728, -437, -717, 917, 618, -118, -851, 670, -131, 975, 708, -755, 863, 346, -245, 52, -999, 116, 884, 253, 492, 262, -692, -485, -503, 265, -922, 109, -925, 634, -538, -574, 632, -962, 153, 981, -187, -563, -294, -681, -135, 289, -454, -357, -119, 157, -982, -880, -727, 985, 963, 869, 133, 813, -414, -985, 712, -180, -631, -124, 17, 247, 370, 573, 905, 958, -917, -146, 753, -421, 315, 540, 782, -362, 369, 868, 47, -539, -202, -213, -534, -579, 287, -247, -599, -929, 204, 929, -714, -507, -384, 179, 279, -89, -10, 721, 77, -458, -413, 50, 561, 930, -671, -700, 285, -814, 491, -8, -662, -832, 216, 817, -551, 531, -655, -229, -189, -901, 417, 118, 0, -581, 736, -467, -833, -980, 244, -419, 419, -199, -423, 766, -638, -128, -928, -378, -698, -381, -957, 803, -546, 486, 551, 667, -960, -160, -622, 53, 503, 729, 919, -218, -886, -933, 237, -244, -281, -877, 888, 233, -604, 575, 122, -18, -457, -140, 812, -852, 857, -29, -206, 337, 655, 947, 571, 584, -743, -68, 953, -778, -939, -905, 131, -427, 461, 314, -264, -468, -779, -883, -1000, 918, 33, 82, -873, 524, -158, -371, 837, 806, 592, -183, -243, 23, 291, -179, 94, -121, 553, -578, -685, 804, -651, 99, 952, -267, -236, -821, 336, 248, 549, 260, 321, 390, -342, -606, 476, 42, 385, -674, 365, -394, 588, -190, 284, 931, -914, -7, 627, -774, -895, 263, -120, -309, 552, 309, -815, -172, 100, 737, 86, -811, -553, -942, 63, -337, 925, -355, 678, 885, -374, -363, -327, -699, -554, 847, 143, 883, 514, 826, -868, 115, 548, 386, 830, 668, -444, 683, -543, 426, 560, 489, 9, -733, 341, 520, 21, -560, 236, -63, -514, 756, 225, -225, -48, 874, 966, 750, 696, -723, 71, -602, 324, 405, -646, 665, -64, -721, 175, 376, -209, -686, 594, 597, 183, -575, -215, 777, 897, -288, -804, -44, 445, 224, 685, 317, 705, 46, 732, 211, 535, -450, 271, 840, -420, -353, -613, 137, 829, 691, -500, -416, 554, -433, -169, -443, 191, 652, -654, 823, -593, 202, 496, 940, 412, -909, -269, 241, 14, 850, 880, 375, -666, 677, 355, 305, 494, 743, 924, 194, -67, 922, -153, -847, 257, -57, -375, -791, 765, -116, -969, -777, -827, -130, 482, -891, 201, -822, 784, -759, 567, -615, -640, -611, 235, 150, 333, -559, 517, -931, -907, 544, -897, 731, -527, -221, 127, -805, 628, -11, 278, 596, -212, -716, -49, 521, 164, -826, 43, 718, 893, -921, -268, 688, 643, 240, -164, -625, -71, 617, 891, 508, -301, -404, -568, -298, 828, 310, 851 }, 3676);
            expected = 2991;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums.Length == 3)
            {
                return nums[0] + nums[1] + nums[2];
            }

            Array.Sort(nums);

            int closest = int.MaxValue;
            int ret = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int value = nums[i] + nums[j] + nums[nums.Length - 1];

                        if (value < target)
                        {
                            k = nums.Length;
                        }
                        else
                        {
                            value = nums[i] + nums[j] + nums[k];
                        }

                        int diff = Math.Abs(value - target);
                        if (diff < closest)
                        {
                            closest = diff;
                            ret = value;
                        }

                        if (ret == target)
                        {
                            return target;
                        }

                        if (value > target)
                        {
                            break;
                        }
                    }
                }
            }
            return ret;
        }
    }
}
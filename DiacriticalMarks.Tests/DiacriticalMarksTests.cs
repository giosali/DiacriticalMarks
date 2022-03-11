﻿using NUnit.Framework;

namespace DiacriticalMarks.Tests
{
    [TestFixture]
    public class DiacriticalMarksTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase('a', Accent.Circumflex, 'â')]
        [TestCase('a', Accent.Grave, 'à')]
        [TestCase('a', Accent.Tilde, 'ã')]
        [TestCase('a', Accent.Diaeresis, 'ä')]
        [TestCase('a', Accent.Macron, 'ā')]
        [TestCase('a', Accent.Acute, 'á')]
        [TestCase('A', Accent.Circumflex, 'Â')]
        [TestCase('A', Accent.Grave, 'À')]
        [TestCase('A', Accent.Tilde, 'Ã')]
        [TestCase('A', Accent.Diaeresis, 'Ä')]
        [TestCase('A', Accent.Macron, 'Ā')]
        [TestCase('A', Accent.Acute, 'Á')]
        [TestCase('c', Accent.Acute, 'ć')]
        [TestCase('c', Accent.Cedilla, 'ç')]
        [TestCase('C', Accent.Acute, 'Ć')]
        [TestCase('C', Accent.Cedilla, 'Ç')]
        [TestCase('e', Accent.Grave, 'è')]
        [TestCase('e', Accent.Acute, 'é')]
        [TestCase('e', Accent.Circumflex, 'ê')]
        [TestCase('e', Accent.Diaeresis, 'ë')]
        [TestCase('e', Accent.Macron, 'ē')]
        [TestCase('E', Accent.Acute, 'É')]
        [TestCase('E', Accent.Grave, 'È')]
        [TestCase('E', Accent.Circumflex, 'Ê')]
        [TestCase('E', Accent.Diaeresis, 'Ë')]
        [TestCase('E', Accent.Macron, 'Ē')]
        [TestCase('i', Accent.Circumflex, 'î')]
        [TestCase('i', Accent.Diaeresis, 'ï')]
        [TestCase('i', Accent.Acute, 'í')]
        [TestCase('i', Accent.Macron, 'ī')]
        [TestCase('i', Accent.Grave, 'ì')]
        [TestCase('I', Accent.Circumflex, 'Î')]
        [TestCase('I', Accent.Diaeresis, 'Ï')]
        [TestCase('I', Accent.Acute, 'Í')]
        [TestCase('I', Accent.Macron, 'Ī')]
        [TestCase('I', Accent.Grave, 'Ì')]
        [TestCase('n', Accent.Tilde, 'ñ')]
        [TestCase('n', Accent.Acute, 'ń')]
        [TestCase('N', Accent.Tilde, 'Ñ')]
        [TestCase('N', Accent.Acute, 'Ń')]
        [TestCase('o', Accent.Circumflex, 'ô')]
        [TestCase('o', Accent.Diaeresis, 'ö')]
        [TestCase('o', Accent.Grave, 'ò')]
        [TestCase('o', Accent.Acute, 'ó')]
        [TestCase('o', Accent.Macron, 'ō')]
        [TestCase('o', Accent.Tilde, 'õ')]
        [TestCase('O', Accent.Circumflex, 'Ô')]
        [TestCase('O', Accent.Diaeresis, 'Ö')]
        [TestCase('O', Accent.Grave, 'Ò')]
        [TestCase('O', Accent.Acute, 'Ó')]
        [TestCase('O', Accent.Macron, 'Ō')]
        [TestCase('O', Accent.Tilde, 'Õ')]
        [TestCase('s', Accent.Acute, 'ś')]
        [TestCase('S', Accent.Acute, 'Ś')]
        [TestCase('u', Accent.Circumflex, 'û')]
        [TestCase('u', Accent.Diaeresis, 'ü')]
        [TestCase('u', Accent.Grave, 'ù')]
        [TestCase('u', Accent.Acute, 'ú')]
        [TestCase('u', Accent.Macron, 'ū')]
        [TestCase('U', Accent.Circumflex, 'Û')]
        [TestCase('U', Accent.Diaeresis, 'Ü')]
        [TestCase('U', Accent.Grave, 'Ù')]
        [TestCase('U', Accent.Acute, 'Ú')]
        [TestCase('U', Accent.Macron, 'Ū')]
        [TestCase('y', Accent.Diaeresis, 'ÿ')]
        [TestCase('Y', Accent.Diaeresis, 'Ÿ')]
        [TestCase('z', Accent.Acute, 'ź')]
        [TestCase('Z', Accent.Acute, 'Ź')]
        public void AttachAccent_ShouldReturnCorrectDiacriticalLetter(char baseCharacter, Accent accent, char expected)
        {
            char actual = char.Parse(DiacriticalMarks.AttachAccent(baseCharacter, accent));
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase('a', CombiningDiacriticalMark.CombiningGraveAccent, 'à')]
        [TestCase('a', CombiningDiacriticalMark.CombiningAcuteAccent, 'á')]
        [TestCase('a', CombiningDiacriticalMark.CombiningCircumflexAccent, 'â')]
        [TestCase('a', CombiningDiacriticalMark.CombiningDiaeresis, 'ä')]
        [TestCase('a', CombiningDiacriticalMark.CombiningTilde, 'ã')]
        [TestCase('a', CombiningDiacriticalMark.CombiningRingAbove, 'å')]
        [TestCase('a', CombiningDiacriticalMark.CombiningMacron, 'ā')]
        [TestCase('A', CombiningDiacriticalMark.CombiningGraveAccent, 'À')]
        [TestCase('A', CombiningDiacriticalMark.CombiningAcuteAccent, 'Á')]
        [TestCase('A', CombiningDiacriticalMark.CombiningCircumflexAccent, 'Â')]
        [TestCase('A', CombiningDiacriticalMark.CombiningDiaeresis, 'Ä')]
        [TestCase('A', CombiningDiacriticalMark.CombiningTilde, 'Ã')]
        [TestCase('A', CombiningDiacriticalMark.CombiningRingAbove, 'Å')]
        [TestCase('A', CombiningDiacriticalMark.CombiningMacron, 'Ā')]
        [TestCase('c', CombiningDiacriticalMark.CombiningCedilla, 'ç')]
        [TestCase('c', CombiningDiacriticalMark.CombiningAcuteAccent, 'ć')]
        [TestCase('c', CombiningDiacriticalMark.CombiningCaron, 'č')]
        [TestCase('C', CombiningDiacriticalMark.CombiningCedilla, 'Ç')]
        [TestCase('C', CombiningDiacriticalMark.CombiningAcuteAccent, 'Ć')]
        [TestCase('C', CombiningDiacriticalMark.CombiningCaron, 'Č')]
        [TestCase('e', CombiningDiacriticalMark.CombiningGraveAccent, 'è')]
        [TestCase('e', CombiningDiacriticalMark.CombiningAcuteAccent, 'é')]
        [TestCase('e', CombiningDiacriticalMark.CombiningCircumflexAccent, 'ê')]
        [TestCase('e', CombiningDiacriticalMark.CombiningDiaeresis, 'ë')]
        [TestCase('e', CombiningDiacriticalMark.CombiningMacron, 'ē')]
        [TestCase('e', CombiningDiacriticalMark.CombiningDotAbove, 'ė')]
        [TestCase('e', CombiningDiacriticalMark.CombiningOgonek, 'ę')]
        [TestCase('E', CombiningDiacriticalMark.CombiningAcuteAccent, 'É')]
        [TestCase('E', CombiningDiacriticalMark.CombiningGraveAccent, 'È')]
        [TestCase('E', CombiningDiacriticalMark.CombiningCircumflexAccent, 'Ê')]
        [TestCase('E', CombiningDiacriticalMark.CombiningDiaeresis, 'Ë')]
        [TestCase('E', CombiningDiacriticalMark.CombiningMacron, 'Ē')]
        [TestCase('E', CombiningDiacriticalMark.CombiningDotAbove, 'Ė')]
        [TestCase('E', CombiningDiacriticalMark.CombiningOgonek, 'Ę')]
        [TestCase('i', CombiningDiacriticalMark.CombiningCircumflexAccent, 'î')]
        [TestCase('i', CombiningDiacriticalMark.CombiningDiaeresis, 'ï')]
        [TestCase('i', CombiningDiacriticalMark.CombiningAcuteAccent, 'í')]
        [TestCase('i', CombiningDiacriticalMark.CombiningMacron, 'ī')]
        [TestCase('i', CombiningDiacriticalMark.CombiningOgonek, 'į')]
        [TestCase('i', CombiningDiacriticalMark.CombiningGraveAccent, 'ì')]
        [TestCase('I', CombiningDiacriticalMark.CombiningCircumflexAccent, 'Î')]
        [TestCase('I', CombiningDiacriticalMark.CombiningDiaeresis, 'Ï')]
        [TestCase('I', CombiningDiacriticalMark.CombiningAcuteAccent, 'Í')]
        [TestCase('I', CombiningDiacriticalMark.CombiningMacron, 'Ī')]
        [TestCase('I', CombiningDiacriticalMark.CombiningOgonek, 'Į')]
        [TestCase('I', CombiningDiacriticalMark.CombiningGraveAccent, 'Ì')]
        [TestCase('n', CombiningDiacriticalMark.CombiningTilde, 'ñ')]
        [TestCase('n', CombiningDiacriticalMark.CombiningAcuteAccent, 'ń')]
        [TestCase('N', CombiningDiacriticalMark.CombiningTilde, 'Ñ')]
        [TestCase('N', CombiningDiacriticalMark.CombiningAcuteAccent, 'Ń')]
        [TestCase('o', CombiningDiacriticalMark.CombiningCircumflexAccent, 'ô')]
        [TestCase('o', CombiningDiacriticalMark.CombiningDiaeresis, 'ö')]
        [TestCase('o', CombiningDiacriticalMark.CombiningGraveAccent, 'ò')]
        [TestCase('o', CombiningDiacriticalMark.CombiningAcuteAccent, 'ó')]
        [TestCase('o', CombiningDiacriticalMark.CombiningMacron, 'ō')]
        [TestCase('o', CombiningDiacriticalMark.CombiningTilde, 'õ')]
        [TestCase('O', CombiningDiacriticalMark.CombiningCircumflexAccent, 'Ô')]
        [TestCase('O', CombiningDiacriticalMark.CombiningDiaeresis, 'Ö')]
        [TestCase('O', CombiningDiacriticalMark.CombiningGraveAccent, 'Ò')]
        [TestCase('O', CombiningDiacriticalMark.CombiningAcuteAccent, 'Ó')]
        [TestCase('O', CombiningDiacriticalMark.CombiningMacron, 'Ō')]
        [TestCase('O', CombiningDiacriticalMark.CombiningTilde, 'Õ')]
        [TestCase('s', CombiningDiacriticalMark.CombiningAcuteAccent, 'ś')]
        [TestCase('s', CombiningDiacriticalMark.CombiningCaron, 'š')]
        [TestCase('S', CombiningDiacriticalMark.CombiningAcuteAccent, 'Ś')]
        [TestCase('S', CombiningDiacriticalMark.CombiningCaron, 'Š')]
        [TestCase('u', CombiningDiacriticalMark.CombiningCircumflexAccent, 'û')]
        [TestCase('u', CombiningDiacriticalMark.CombiningDiaeresis, 'ü')]
        [TestCase('u', CombiningDiacriticalMark.CombiningGraveAccent, 'ù')]
        [TestCase('u', CombiningDiacriticalMark.CombiningAcuteAccent, 'ú')]
        [TestCase('u', CombiningDiacriticalMark.CombiningMacron, 'ū')]
        [TestCase('U', CombiningDiacriticalMark.CombiningCircumflexAccent, 'Û')]
        [TestCase('U', CombiningDiacriticalMark.CombiningDiaeresis, 'Ü')]
        [TestCase('U', CombiningDiacriticalMark.CombiningGraveAccent, 'Ù')]
        [TestCase('U', CombiningDiacriticalMark.CombiningAcuteAccent, 'Ú')]
        [TestCase('U', CombiningDiacriticalMark.CombiningMacron, 'Ū')]
        [TestCase('y', CombiningDiacriticalMark.CombiningDiaeresis, 'ÿ')]
        [TestCase('Y', CombiningDiacriticalMark.CombiningDiaeresis, 'Ÿ')]
        [TestCase('z', CombiningDiacriticalMark.CombiningCaron, 'ž')]
        [TestCase('z', CombiningDiacriticalMark.CombiningAcuteAccent, 'ź')]
        [TestCase('z', CombiningDiacriticalMark.CombiningDotAbove, 'ż')]
        [TestCase('Z', CombiningDiacriticalMark.CombiningCaron, 'Ž')]
        [TestCase('Z', CombiningDiacriticalMark.CombiningAcuteAccent, 'Ź')]
        [TestCase('Z', CombiningDiacriticalMark.CombiningDotAbove, 'Ż')]
        public void AttachDiacritic_ShouldReturnStringWithLength1(char baseCharacter, CombiningDiacriticalMark mark, char expected)
        {
            string result = DiacriticalMarks.AttachDiacritic(baseCharacter, mark);
            char actual = char.Parse(result);
            Assert.Multiple(() =>
            {
                Assert.IsTrue(result.Length == 1);
                Assert.AreEqual(expected, actual);
            });
        }

        [Test]
        [TestCase('C', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCedilla, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ḉ')]
        [TestCase('c', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCedilla, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ḉ')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningGraveAccent }, 'Ḕ')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningGraveAccent }, 'ḕ')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ḗ')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ḗ')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCedilla, CombiningDiacriticalMark.CombiningBreve }, 'ḝ')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCedilla, CombiningDiacriticalMark.CombiningBreve }, 'Ḝ')]
        [TestCase('I', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDiaeresis, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ḯ')]
        [TestCase('i', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDiaeresis, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ḯ')]
        [TestCase('L', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningMacron }, 'Ḹ')]
        [TestCase('l', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningMacron }, 'ḹ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ṍ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ṍ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningDiaeresis }, 'Ṏ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningDiaeresis }, 'ṏ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningGraveAccent }, 'Ṑ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningGraveAccent }, 'ṑ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ṓ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ṓ')]
        [TestCase('R', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningMacron }, 'Ṝ')]
        [TestCase('r', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningMacron }, 'ṝ')]
        [TestCase('S', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningDotAbove }, 'Ṥ')]
        [TestCase('s', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningDotAbove }, 'ṥ')]
        [TestCase('S', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCaron, CombiningDiacriticalMark.CombiningDotAbove }, 'Ṧ')]
        [TestCase('s', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCaron, CombiningDiacriticalMark.CombiningDotAbove }, 'ṧ')]
        [TestCase('S', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningDotAbove }, 'Ṩ')]
        [TestCase('s', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningDotAbove }, 'ṩ')]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ṹ')]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ṹ')]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningDiaeresis }, 'Ṻ')]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningDiaeresis }, 'ṻ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ấ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ấ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningGraveAccent }, 'Ầ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningGraveAccent }, 'ầ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningHookAbove }, 'Ẩ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningHookAbove }, 'ẩ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningTilde }, 'Ẫ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningTilde }, 'ẫ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningDotBelow }, 'Ậ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningDotBelow }, 'ậ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ắ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ắ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningGraveAccent }, 'Ằ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningGraveAccent }, 'ằ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningHookAbove }, 'Ẳ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningHookAbove }, 'ẳ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningTilde }, 'Ẵ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningTilde }, 'ẵ')]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningDotBelow }, 'Ặ')]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningDotBelow }, 'ặ')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ế')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ế')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningGraveAccent }, 'Ề')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningGraveAccent }, 'ề')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningHookAbove }, 'Ể')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningHookAbove }, 'ể')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningTilde }, 'Ễ')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningTilde }, 'ễ')]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningDotBelow }, 'Ệ')]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningDotBelow }, 'ệ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningAcuteAccent }, 'Ố')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningAcuteAccent }, 'ố')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningGraveAccent }, 'Ồ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningGraveAccent }, 'ồ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningHookAbove}, 'Ổ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningHookAbove}, 'ổ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningTilde}, 'Ỗ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningTilde}, 'ỗ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningDotBelow}, 'Ộ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningCircumflexAccent, CombiningDiacriticalMark.CombiningDotBelow}, 'ộ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningAcuteAccent}, 'Ớ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningAcuteAccent}, 'ớ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningGraveAccent}, 'Ờ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningGraveAccent}, 'ờ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningHookAbove}, 'Ở')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningHookAbove}, 'ở')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningTilde}, 'Ỡ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningTilde}, 'ỡ')]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningDotBelow}, 'Ợ')]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningDotBelow}, 'ợ')]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningAcuteAccent}, 'Ứ')]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningAcuteAccent}, 'ứ')]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningGraveAccent}, 'Ừ')]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningGraveAccent}, 'ừ')]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningHookAbove}, 'Ử')]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningHookAbove}, 'ử')]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningTilde}, 'Ữ')]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningTilde}, 'ữ')]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningDotBelow}, 'Ự')]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHorn, CombiningDiacriticalMark.CombiningDotBelow}, 'ự')]
        public void AttachDiacritics_WhenGivenCorrectOrder_ShouldReturnStringWithLength1(char baseCharacter, CombiningDiacriticalMark[] marks, char expected)
        {
            string result = DiacriticalMarks.AttachDiacritics(baseCharacter, marks);
            char actual = char.Parse(result);
            Assert.Multiple(() =>
            {
                Assert.IsTrue(result.Length == 1);
                Assert.AreEqual(expected, actual);
            });
        }

        [Test]
        [TestCase('C', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCedilla })]
        [TestCase('c', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCedilla })]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningMacron })]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningMacron })]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningMacron })]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningMacron })]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningCedilla })]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningCedilla })]
        [TestCase('I', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningDiaeresis })]
        [TestCase('i', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningDiaeresis })]
        [TestCase('L', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningDotBelow })]
        [TestCase('l', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningDotBelow })]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningTilde })]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningTilde })]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDiaeresis, CombiningDiacriticalMark.CombiningTilde })]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDiaeresis, CombiningDiacriticalMark.CombiningTilde })]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningMacron })]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningMacron })]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningMacron})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningMacron})]
        [TestCase('R', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningDotBelow})]
        [TestCase('r', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningMacron, CombiningDiacriticalMark.CombiningDotBelow})]
        [TestCase('S', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotAbove, CombiningDiacriticalMark.CombiningAcuteAccent})]
        [TestCase('s', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotAbove, CombiningDiacriticalMark.CombiningAcuteAccent})]
        [TestCase('S', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotAbove, CombiningDiacriticalMark.CombiningCaron})]
        [TestCase('s', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotAbove, CombiningDiacriticalMark.CombiningCaron})]
        [TestCase('S', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotAbove, CombiningDiacriticalMark.CombiningDotBelow})]
        [TestCase('s', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotAbove, CombiningDiacriticalMark.CombiningDotBelow})]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningTilde})]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningTilde })]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDiaeresis, CombiningDiacriticalMark.CombiningMacron})]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDiaeresis, CombiningDiacriticalMark.CombiningMacron})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningCircumflexAccent })]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningCircumflexAccent })]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('A', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('a', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningBreve})]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('E', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('e', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningCircumflexAccent})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('O', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('o', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningAcuteAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningGraveAccent, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningHookAbove, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningTilde, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('U', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningHorn})]
        [TestCase('u', new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningHorn})]
        public void AttachDiacritics_WhenGivenWrongOrderAndNormalizeIsFalse_ShouldReturnStringWithLengthGreaterThan1(char baseCharacter, CombiningDiacriticalMark[] marks)
        {
            string actual = DiacriticalMarks.AttachDiacritics(baseCharacter, marks, false);
            Assert.IsTrue(actual.Length > 1);
        }
    }
}
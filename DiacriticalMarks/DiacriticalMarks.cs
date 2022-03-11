namespace DiacriticalMarks
{
    public static class DiacriticalMarks
    {
        /// <summary>
        /// Returns a string consisting of a single character created from an alphabetical <see langword="char"/> and an <see cref="Accent"/>.
        /// </summary>
        /// <param name="baseCharacter">The alphabetical base character.</param>
        /// <param name="accent">The accent mark.</param>
        /// <returns>A string consisting of a single character created from combining <paramref name="baseCharacter"/> and <paramref name="accent"/>.</returns>
        public static string AttachAccent(char baseCharacter, Accent accent)
        {
            CombiningDiacriticalMark? mark = null;
            switch (accent)
            {
                case Accent.Circumflex:
                    mark = CombiningDiacriticalMark.CombiningCircumflexAccent;
                    break;

                case Accent.Grave:
                    mark = CombiningDiacriticalMark.CombiningGraveAccent;
                    break;

                case Accent.Tilde:
                    mark = CombiningDiacriticalMark.CombiningTilde;
                    break;

                case Accent.Diaeresis:
                    mark = CombiningDiacriticalMark.CombiningDiaeresis;
                    break;

                case Accent.Macron:
                    mark = CombiningDiacriticalMark.CombiningMacron;
                    break;

                case Accent.Acute:
                    mark = CombiningDiacriticalMark.CombiningAcuteAccent;
                    break;

                case Accent.Cedilla:
                    mark = CombiningDiacriticalMark.CombiningCedilla;
                    break;
            }

            return $"{baseCharacter}{(char)mark}".Normalize();
        }

        /// <summary>
        /// Returns a string consisting of a single character created from an alphabetical <see langword="char"/> and a <see cref="CombiningDiacriticalMark"/>.
        /// </summary>
        /// <param name="baseCharacter">The alphabetical base character.</param>
        /// <param name="combiningDiacriticalMark">The <see href="https://en.wikipedia.org/wiki/Combining_Diacritical_Marks">combining diacritical mark</see>.</param>
        /// <returns>A string consisting of a single character created from combining <paramref name="baseCharacter"/> and <paramref name="combiningDiacriticalMark"/>.</returns>
        public static string AttachDiacritic(char baseCharacter, CombiningDiacriticalMark combiningDiacriticalMark)
        {
            return $"{baseCharacter}{(char)combiningDiacriticalMark}".Normalize();
        }

        /// <summary>
        /// Returns a string consisting of one or more characters created from an alphabetical <see langword="char"/> and an array of <see cref="CombiningDiacriticalMark"/>.
        /// </summary>
        /// <param name="baseCharacter">The alphabetical base character.</param>
        /// <param name="combiningDiacriticalMarks">The array of <see href="https://en.wikipedia.org/wiki/Combining_Diacritical_Marks">combining diacritical marks</see>.</param>
        /// <param name="normalize">The bool indicating whether the returned string's binary representation is in Unicode normalization form C.</param>
        /// <returns>A string consisting of one or more characters created from combining <paramref name="baseCharacter"/> and <paramref name="combiningDiacriticalMarks"/>.</returns>
        public static string AttachDiacritics(char baseCharacter, CombiningDiacriticalMark[] combiningDiacriticalMarks, bool normalize = true)
        {
            char[] diacriticalChars = new char[combiningDiacriticalMarks.Length];
            for (int i = 0; i < combiningDiacriticalMarks.Length; i++)
            {
                diacriticalChars[i] = (char)combiningDiacriticalMarks[i];
            }

            return normalize
                 ? $"{baseCharacter}{string.Join(string.Empty, diacriticalChars)}".Normalize()
                 : $"{baseCharacter}{string.Join(string.Empty, diacriticalChars)}";
        }
    }
}

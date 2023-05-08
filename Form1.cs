using GreyCrammedContainer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static Skovokh_Translator.TranslationTools;

namespace Skovokh_Translator
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;

        public TranslationMode Mode;
        public LayerMode ImageType = LayerMode.TwentyLettersALayer;

        public Dictionary<string, string> EnglishToLatinSkov = new();
        public List<(string, string)> EnglishToSkovokh = new();
        public Dictionary<string, string> LatinToSkovokh = new();
        public List<(string, string)> LatinToEnglish = new();

        public Form1 ()
        {
            InitializeComponent();

            Instance = this;
            Instance.Name = "Skovokh Translator";
            Instance.AccessibleName = "Skovokh Translator";

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Skovokh Translator";

            EnglishToLatinSkov = GccConverter.Deserialize<Dictionary<string, string>>( AppDomain.CurrentDomain.BaseDirectory + @$"\Lang\EngLatinSkovokh.gcc" );
            LatinToSkovokh = GccConverter.Deserialize<Dictionary<string, string>>( AppDomain.CurrentDomain.BaseDirectory + @$"\Lang\LatinSkovokhToSkovokh.gcc" );

            foreach (var pair in EnglishToLatinSkov)
                LatinToEnglish.Add( (pair.Value, pair.Key) );

            foreach (var englat in EnglishToLatinSkov)
            {
                foreach (var latskov in LatinToSkovokh)
                {
                    if (englat.Value == latskov.Key)
                    {
                        EnglishToSkovokh.Add( (englat.Key, latskov.Value) );
                        break;
                    }
                }
            }
        }

        public void RegenerateTupleLists ()
        {
            LatinToEnglish.Clear();
            EnglishToSkovokh.Clear();

            foreach (var pair in EnglishToLatinSkov)
                LatinToEnglish.Add( (pair.Value, pair.Key) );

            foreach (var englat in EnglishToLatinSkov)
            {
                foreach (var latskov in LatinToSkovokh)
                {
                    if (englat.Value == latskov.Key)
                    {
                        EnglishToSkovokh.Add( (englat.Key, latskov.Value) );
                        break;
                    }
                }
            }
        }

        private void Input_TextChanged ( object sender, EventArgs e )
        {
            StringBuilder result = new();
            switch (Mode)
            {
                case TranslationMode.EnglishToLatin:
                    #region EngLat
                    // gets words between each space.
                    foreach (var word in Input.Text.Split( ' ' ))
                    {
                        // remove punctuation and other non letter characters from the word
                        // this is so the word can be found in the dictionary.
                        var onlyLetters = LettersOnly( word );
                        // checks if the dictionary contains the word.
                        if (EnglishToLatinSkov.ContainsKey( onlyLetters ))
                        {
                            // appends first the word without any non letter characters, then the puntuation marks.
                            // finally appends a space so words are not glued together.
                            result.Append( EnglishToLatinSkov[onlyLetters] ).Append( NonLettersOnly( word ) ).Append( ' ' );
                        }
                    }
                    Output.Text = result.ToString();
                    #endregion
                    break;
                case TranslationMode.EnglishToSkovokh:
                    #region EnglishToSkov
                    // gets words between each space.
                    foreach (var word in Input.Text.Split( ' ' ))
                    {
                        // remove punctuation and other non letter characters from the word
                        // this is so the word can be found in the dictionary
                        var onlyLetters = LettersOnly( word );
                        // check if the english to latin skovokh dictionary contains the letter only version of the word
                        if (EnglishToLatinSkov.ContainsKey( onlyLetters ))
                        {
                            // check if the latin skovokh to skovokh dictionary has a key of the eng->latin dictionary key.
                            if (LatinToSkovokh.ContainsKey( EnglishToLatinSkov[onlyLetters] ))
                            {
                                // appends the skovokh version of the letter only version of the english word. Appends the punctuation marks
                                // finally appends a space at the end.
                                result.Append( LatinToSkovokh[EnglishToLatinSkov[onlyLetters]] ).Append( NonLettersOnly( word ) ).Append( ' ' );
                            }
                        }
                    }
                    Output.Text = result.ToString();
                    #endregion
                    break;
                case TranslationMode.LatinToEnglish:
                    #region LatinToEnglish
                    // gets words between each space.
                    foreach (var word in Input.Text.Split( ' ' ))
                    {
                        // iterates through all the tuple pairs in the generated LatinToEnglish(string,string) list
                        foreach (var key in LatinToEnglish)
                        {
                            // checks if letters only word is the same as the key ( latin skovokh ).
                            if (string.Equals( key.Item1, LettersOnly( word ), StringComparison.InvariantCulture ))
                            {
                                // appends letters only english translation of the key, then the non letters version of the word
                                // for punctuation and whatnot.
                                // finally appends a space so words are not glued together.
                                result.Append( LettersOnly( key.Item2 ) ).Append( NonLettersOnly( word ) ).Append( ' ' );
                                break;
                            }
                        }
                    }
                    Output.Text = result.ToString();
                    #endregion
                    break;
                case TranslationMode.LatinToSkovokh:
                    #region LatSkov
                    // same as English to latin Skovokh.
                    foreach (var word in Input.Text.Split( ' ' ))
                    {
                        // remove punctuation and other non letter characters from the word
                        // this is so the word can be found in the dictionary.
                        var onlyLetters = LettersOnly( word );
                        if (LatinToSkovokh.ContainsKey( onlyLetters ))
                        {
                            // appends first the word without any non letter characters, then the puntuation marks.
                            // finally appends a space so words are not glued together.
                            result.Append( LatinToSkovokh[onlyLetters] ).Append( NonLettersOnly( word ) ).Append( ' ' );
                        }
                    }
                    Output.Text = result.ToString();
                    #endregion
                    break;
                case TranslationMode.SkovokhToLatin:
                    #region SkovokhToLatin
                    foreach (var word in Input.Text.Split( ' ' ))
                    {
                        // remove punctuation and other non letter characters from the word
                        // this is so the word can be found in the dictionary.
                        var onlyLetters = LettersOnly( word );
                        // iterates through the latin skovokh to skovokh dictionary
                        foreach (var pair in LatinToSkovokh)
                        {
                            // checks if the pair's value aka the latin skovakh word is translated to the current skovokh word
                            if (string.Equals( pair.Value, onlyLetters, StringComparison.InvariantCulture))
                            {
                                // writes the found translation.
                                result.Append( pair.Key ).Append( NonLettersOnly( word ) ).Append( ' ' );
                                break;
                            }
                        }
                    }
                    Output.Text = result.ToString();
                    #endregion
                    break;
                case TranslationMode.SkovokhToEnglish:
                    #region SkovokhToEnglish
                    foreach (var word in Input.Text.Split( ' ' ))
                    {
                        // remove punctuation and other non letter characters from the word
                        // this is so the word can be found in the dictionary.
                        var onlyLetters = LettersOnly( word );
                        // iterates through the generated english to skovokh tuple list
                        foreach (var pair in Instance.EnglishToSkovokh)
                        {
                            // checks if the skovokh word of the tuple is equal to the input word.
                            if (pair.Item2 == onlyLetters)
                            {
                                // appends the tuple's english word.
                                result.Append( pair.Item1 ).Append(' ');
                                break;
                            }
                        }
                    }
                    Output.Text = result.ToString();
                    #endregion
                    break;
            }
        }

        private void UpdateMode ( TranslationMode mode )
        {
            Mode = mode;
            TransMode.Text = Mode.ToString();
            Input_TextChanged( new object(), new EventArgs() );
        }

        private void ChangeImageMode_Click ( object sender, EventArgs e )
        {
            switch (ImageType)
            {
                case LayerMode.TenlettersALayer:
                    ImageType = LayerMode.TwentyLettersALayer;
                    ChangeImageMode.Text = "20 Chars Per Layer";
                    break;
                case LayerMode.TwentyLettersALayer:
                    ImageType = LayerMode.ThirtyLettersALayer;
                    ChangeImageMode.Text = "30 Chars Per Layer";
                    break;
                case LayerMode.ThirtyLettersALayer:
                    ImageType = LayerMode.TenlettersALayer;
                    ChangeImageMode.Text = "10 Chars Per Layer";
                    break;
            }
        }

        private void GenerateImage_Click ( object sender, EventArgs e )
        {
            if (ImageSkovokhText.Text.Length < 1)
                return;
            if (ImageSkovokhText.Text == "Input text for image generation here")
                return;

            StringBuilder result = new();
            foreach (var word in ImageSkovokhText.Text.Split( ' ' ))
            {
                // remove punctuation and other non letter characters from the word
                // this is so the word can be found in the dictionary.
                var onlyLetters = LettersOnly( word );
                // iterates through the latin skovokh to skovokh dictionary
                bool found = false;
                foreach (var pair in LatinToSkovokh)
                {
                    // checks if the pair's value aka the latin skovakh word is translated to the current skovokh word
                    if (string.Equals( pair.Value, onlyLetters, StringComparison.InvariantCulture ))
                    {
                        // writes the found translation.
                        result.Append( pair.Key ).Append( NonLetterSkovokhOnly( word ) ).Append( ' ' );
                        found = true;
                        break;
                    }
                }
                // if the word wasnt found in the dictionary it is possibly a symbol like "("
                if (!found && word.Length == 1)
                {
                    // checks if the skovokh symbols contain the character
                    if (char.IsPunctuation( char.Parse( word ) ))
                    {
                        result.Append( word ).Append( ' ' );
                    }
                }
                found = false;
            }

            // splits the sliced latin skovokh characters to later generate an image from them.
            var letters = LatinSkovokhSlicer( result.ToString()).Split( '_' );

            if (letters.Length - 1 < 1)
                return;

            List<string> paths = new();

            // outputs sliced latin characters at the output text window for debug purposes.
            // Output.Text = final.ToString();

            for (int i = 0; i < letters.Length; i++)
            {
                // checks if a slight oopsie happened during latin skovokh letter slicing
                // such as "....dEHR!" and sentences alike sometimes produce smth like "..._R!".
                // R does not belong with "!". That will throw an error.
                // Checks if the current sliced letter(s) are of such imperfection.
                // f.e "R!". Seperates skovokh letters from skovokh symbols.
                // when generating image first appends letter image, then symbol image.
                if (ImperfectLatinSkovokh( letters[i] ))
                {
                    paths.Add( Directory.GetCurrentDirectory() + Mappings.LatinSkovokhPaths[LettersOnly( letters[i] )] );
                    paths.Add( Directory.GetCurrentDirectory() + Mappings.LatinSkovokhPaths[NonLetterSkovokhOnly( letters[i] )] );
                }
                else if (letters[i] != "")
                {
                    // No imperfections here.
                    // appends letter image to queue.
                    paths.Add( Directory.GetCurrentDirectory() + Mappings.LatinSkovokhPaths[letters[i]] );
                }
            }

            // Generates images from the queue with given layer mode.
            ImageGeneration.CombineImages( paths.ToArray() );
        }

        private void DictionaryEditor_Click ( object sender, EventArgs e ) => new Form2().Show();

        private void EngToLatin_Click  ( object sender, EventArgs e ) => UpdateMode( TranslationMode.EnglishToLatin   );
        private void EngToSkov_Click   ( object sender, EventArgs e ) => UpdateMode( TranslationMode.EnglishToSkovokh );
        private void LatinToEng_Click  ( object sender, EventArgs e ) => UpdateMode( TranslationMode.LatinToEnglish   );
        private void LatinToSkov_Click ( object sender, EventArgs e ) => UpdateMode( TranslationMode.LatinToSkovokh   );
        private void SkovToEng_Click   ( object sender, EventArgs e ) => UpdateMode( TranslationMode.SkovokhToEnglish );
        private void SkovToLatin_Click ( object sender, EventArgs e ) => UpdateMode( TranslationMode.SkovokhToLatin   );
    }
}
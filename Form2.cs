using GreyCrammedContainer;
using System;
using System.Text;
using System.Windows.Forms;
using static Skovokh_Translator.TranslationTools;

namespace Skovokh_Translator
{
    public partial class Form2 : Form
    {
        public Form2 ()
        {
            InitializeComponent();

            this.Name = "Skovokh Translator";
            this.AccessibleName = "Skovokh Translator";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Text = "Dictionary Editor";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private StringBuilder TranslationCheck ()
        {
            // splits the sliced latin skovokh characters to later generate an image from them.
            var letters = LatinSkovokhSlicer( LatinText.Text + " "  ).Split( '_' );

            bool[] useCutVowel = new bool[letters.Length];

            StringBuilder str = new();
            VowelRuleSolver( letters, ref useCutVowel );

            // debug
            // Events.Text = "";

            int i = 0;
            var maps = Mappings.LatinToSkovokhMappings;
            foreach (var item in letters)
            {
                if (useCutVowel[i])
                {
                    if (ImperfectLatinSkovokh( item ))
                    {
                        // debug
                        // Events.Text += "_" + item + "_";
                        str.Append( Mappings.CutVowelRuleVersions[LettersOnly( item )] );
                        str.Append( Mappings.CutVowelRuleVersions[NonLetterSkovokhOnly( item )] );
                    }
                    else if (item != "")
                    {
                        // debug
                        // Events.Text += "_" + item + "_";
                        str.Append( Mappings.CutVowelRuleVersions[item] );
                    }
                }
                else
                {
                    if (ImperfectLatinSkovokh( item ))
                    {
                        // Events.Text += "_" + item + "_";
                        str.Append( maps[LettersOnly( item )] );
                        str.Append( maps[NonLetterSkovokhOnly( item )] );
                    }
                    else if (item != "")
                    {
                        // debug
                        // Events.Text += "_" + item + "_";
                        str.Append( maps[item] );
                    }
                }
                Events.Text += useCutVowel[i];
                i++;
            }

            return str;
        }

        private void LatinText_TextChanged ( object sender, EventArgs e )
        {
            try
            {
                var str = TranslationCheck();
                SkovokhText.Text = str.ToString();
                Events.Text = "";
            }
            catch (Exception)
            {
                Events.Text = "Incorrect Latin Skovokh input!";
                Events.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void SaveWord_Click ( object sender, EventArgs e )
        {
            StringBuilder str = new();
            try
            {
                str = TranslationCheck();
            }
            catch (Exception)
            {
                Events.Text = "Incorrect Latin Skovokh input!";
                Events.ForeColor = System.Drawing.Color.Red;
                return;
            }

            var holder = Form1.Instance;

            if (holder.EnglishToLatinSkov.ContainsKey( EnglishText.Text ))
            {
                Events.Text = "English To Latin Dictionary Already Contains Your Key!";
                Events.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (holder.LatinToSkovokh.ContainsKey( LatinText.Text ))
            {
                Events.Text = "Latin To Skovokh Dictionary Already Contains Your Key!";
                Events.ForeColor = System.Drawing.Color.Red;
                return;
            }

            holder.EnglishToLatinSkov.Add( EnglishText.Text.Trim(), LatinText.Text.Trim() );
            holder.LatinToSkovokh.Add( LatinText.Text.Trim(), SkovokhText.Text.Trim() );

            GccConverter.Serialize( AppDomain.CurrentDomain.BaseDirectory + @$"\Lang\EngLatinSkovokh.gcc", holder.EnglishToLatinSkov );
            GccConverter.Serialize( AppDomain.CurrentDomain.BaseDirectory + @$"\Lang\LatinSkovokhToSkovokh.gcc", holder.LatinToSkovokh );

            holder.RegenerateTupleLists();

            Events.Text = "Successfully Added The Translations!";
            Events.ForeColor = System.Drawing.Color.LimeGreen;
        }
    }
}
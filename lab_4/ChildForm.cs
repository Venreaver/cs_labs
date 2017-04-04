using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_4
{
    public enum showForm {ADD_WORD, DELETE_WORD, DELETE_TRANSLATE};

    // child-frame, singleton
    public partial class ChildForm : Form
    {
        private static ChildForm instance;

        Point mainPointLocation = new Point(25, 343);
        Size mainFrameSize = new Size(494, 383);
        Size mainMaxMinFrameSize = new Size(510, 422);

        Point secondLocation = new Point(25, 175);
        Size secondFrameSize = new Size(332, 210);
        Size secondMaxMinFrameSize = new Size(348, 249);

        partOfSpeech pos;
        showForm form;

        bool flag;

        protected ChildForm()
        {
            InitializeComponent();
        }

        public static ChildForm Instance
        {
            get
            {
                return instance ?? (instance = new ChildForm());
            }
        }

        // set view, depends on showForm
        public void setView(showForm form)
        {
            this.form = form;
            if (form == showForm.ADD_WORD)
            {
                ClientSize = mainFrameSize;
                MaximumSize = mainMaxMinFrameSize;
                MinimumSize = mainMaxMinFrameSize;
                Text = "Добавление карточки/перевода";
                label1.Text = "Слово";
                label1.Visible = true;
                label2.Visible = true;
                richTextBox1.Visible = true;
                richTextBox2.Visible = true;
                group_Box1.Visible = true;
                okButton.Location = mainPointLocation;
                okButton.Visible = true;
                okButton.Enabled = false;
                group_Box1.Enabled = false;
            }
            else if (form == showForm.DELETE_WORD)
            {
                ClientSize = secondFrameSize;
                MaximumSize = secondMaxMinFrameSize;
                MinimumSize = secondMaxMinFrameSize;
                Text = "Удаление слова";
                label1.Text = "Слово";
                label1.Visible = true;
                label2.Visible = false;
                richTextBox1.Visible = true;
                richTextBox2.Visible = false;
                group_Box1.Visible = false;
                okButton.Location = secondLocation;
                okButton.Visible = true;
                okButton.Enabled = true;
            }
            else if (form == showForm.DELETE_TRANSLATE)
            {
                ClientSize = mainFrameSize;
                MaximumSize = mainMaxMinFrameSize;
                MinimumSize = mainMaxMinFrameSize;
                Text = "Добавление карточки/перевода";
                label1.Text = "Перевод";
                label1.Visible = true;
                label2.Visible = false;
                richTextBox1.Visible = true;
                richTextBox2.Visible = false;
                group_Box1.Visible = true;
                okButton.Location = mainPointLocation;
                okButton.Visible = true;
                okButton.Enabled = true;
                flag = false;
                group_Box1.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (form == showForm.ADD_WORD)
            {
                if ((richTextBox1.Text.Length > 0) && (richTextBox2.Text.Length > 0))
                {
                    ((MainForm)Owner).Controller.addCard(richTextBox1.Text, richTextBox2.Text, pos);
                }
            }
            else if (form == showForm.DELETE_WORD)
            {
                if (richTextBox1.Text.Length > 0)
                {
                    ((MainForm)Owner).Controller.removeCard(richTextBox1.Text);
                }
            }
            else if (form == showForm.DELETE_TRANSLATE)
            {
                if (richTextBox1.Text.Length > 0)
                {
                    if (flag)
                    {
                        ((MainForm)Owner).Controller.removeTranslation(((MainForm)Owner).Controller[((MainForm)Owner).Index].Word, richTextBox1.Text, pos);
                    }
                    else
                    {
                        ((MainForm)Owner).Controller.removeTranslation(((MainForm)Owner).Controller[((MainForm)Owner).Index].Word, richTextBox1.Text);
                    }
                }
            }
            Close();
        }

        private void R_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == noun_RButton)
            {
                pos = partOfSpeech.NOUN;
            }
            else if (sender == pronoun_RButton)
            {
                pos = partOfSpeech.PRONOUN;
            }
            else if (sender == adjective_RButton)
            {
                pos = partOfSpeech.ADJECTIVE;
            }
            else if (sender == verb_RButton)
            {
                pos = partOfSpeech.VERB;
            }
            else if (sender == adverb_RButton)
            {
                pos = partOfSpeech.ADVERB;
            }
            else if (sender == preposition_RButton)
            {
                pos = partOfSpeech.PREPOSITION;
            }
            else if (sender == conjunction_RButton)
            {
                pos = partOfSpeech.CONJUNCTION;
            }
            else if (sender == interjection_RButton)
            {
                pos = partOfSpeech.INTERJECTION;
            }
            else if (sender == article_RButton)
            {
                pos = partOfSpeech.ARTICLE;
            }
            else if (sender == phrase_RButton)
            {
                pos = partOfSpeech.PHRASE;
            }
            okButton.Enabled = true;
            flag = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            group_Box1.Enabled = true;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (form == showForm.DELETE_TRANSLATE)
            {
                if ((e.KeyChar.ToString().ToLower().ToCharArray()[0] < 'а'
                    || e.KeyChar.ToString().ToLower().ToCharArray()[0] > 'я')
                    && e.KeyChar.ToString().ToLower().ToCharArray()[0] != ' ')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((e.KeyChar.ToString().ToLower().ToCharArray()[0] < 'a'
                    || e.KeyChar.ToString().ToLower().ToCharArray()[0] > 'z')
                    && e.KeyChar.ToString().ToLower().ToCharArray()[0] != ' ')
                {
                    e.Handled = true;
                }
            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.ToString().ToLower().ToCharArray()[0] < 'а'
                || e.KeyChar.ToString().ToLower().ToCharArray()[0] > 'я')
                && e.KeyChar.ToString().ToLower().ToCharArray()[0] != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
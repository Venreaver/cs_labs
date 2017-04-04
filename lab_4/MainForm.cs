using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab_4
{
    public partial class MainForm : Form
    {
        DictController controller;                                                  // vocab controller
        int currentIdx = -1;                                                        // index of current card (card-mode)
        SaveFileDialog saveFileDialog = new SaveFileDialog();  
        OpenFileDialog openFileDialog = new OpenFileDialog();

        int wordsToTest = 1;                                                        // count of words to test
        Random rnd = new Random();
        Dictionary<Card, int> statTest = new SerializableDictionary<Card, int>();   // dictionary for testing and showing test statistics
        int outerIdx;                                                               // index of current cards in statTest
        int innerIdx;                                                               // index of curent PoS in statTest
        string testTransl;                                                          // translation from user in test-mode

        public MainForm()
        {
            InitializeComponent();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
        }

        public DictController Controller
        {
            get
            {
                return controller;
            }
        }

        public int Index
        {
            get
            {
                return currentIdx;
            }
        }

        private void newVocabButton_Click(object sender, EventArgs e)
        {
            closeVocabButton.PerformClick();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            controller = new DictController();
            controller.Path = saveFileDialog.FileName;
            secondPanel.Enabled = true;
            tabControl1.Enabled = true;
        }

        private void loadVocabButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            closeVocabButton.PerformClick();
            controller = new DictController();
            controller.load(openFileDialog.FileName);
            secondPanel.Enabled = true;
            tabControl1.Enabled = true;
            tabVocabPage.Enabled = true;
            tabTestPage.Enabled = true;
        }

        private void saveVocabButton_Click(object sender, EventArgs e)
        {
            controller.save();
        }

        private void saveVocabAsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            controller.saveAs(saveFileDialog.FileName);
        }

        private void closeVocabButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            posLabel.Text = "";
            richTextBox2.Text = "";
            RButton_CheckedChanged(sender, e);
            if (!splitContainer3.Panel1.Enabled)
            {
                showTestStat();
                wordLabel.Text = "Внимание!";
                richTextBox3.Text = "Досрочное завершение теста";
            }
            secondPanel.Enabled = false;
            tabControl1.Enabled = false;
            controller = null;
        }

        private void showCardsButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            RButton_CheckedChanged(sender, e);
            if (controller.Count > 0)
            {
                currentIdx = 0;
                showCard();
            }
        }

        private void showCard()
        {
            label1.Text = controller[currentIdx].Word;
            splitContainer2.Panel2.Enabled = true;
            adjectiveRButton.Enabled = controller[currentIdx].isAdjective ? true : false;
            adverbRButton.Enabled = controller[currentIdx].isAdverb ? true : false;
            articleRButton.Enabled = controller[currentIdx].isArticle ? true : false;
            conjunctionRButton.Enabled = controller[currentIdx].isConjunction ? true : false;
            interjectionRButton.Enabled = controller[currentIdx].isInterjection ? true : false;
            nounRButton.Enabled = controller[currentIdx].isNoun ? true : false;
            phraseRButton.Enabled = controller[currentIdx].isPhrase ? true : false;
            prepositionRButton.Enabled = controller[currentIdx].isPreposition ? true : false;
            pronounRButton.Enabled = controller[currentIdx].isPronoun ? true : false;
            verbRButton.Enabled = controller[currentIdx].isVerb ? true : false;
            previousButton.Enabled = (currentIdx > 0) ? true : false;
            nextButton.Enabled = (currentIdx < controller.Count - 1) ? true : false;
            if (nounRButton.Enabled)
            {
                nounRButton.PerformClick();
            }
            else if (verbRButton.Enabled)
            {
                verbRButton.PerformClick();
            }
            else if (adjectiveRButton.Enabled)
            {
                adjectiveRButton.PerformClick();
            }
            else if (adverbRButton.Enabled)
            {
                adverbRButton.PerformClick();
            }
            else if (phraseRButton.Enabled)
            {
                phraseRButton.PerformClick();
            }
            else if (pronounRButton.Enabled)
            {
                pronounRButton.PerformClick();
            }
            else if (conjunctionRButton.Enabled)
            {
                conjunctionRButton.PerformClick();
            }
            else if (prepositionRButton.Enabled)
            {
                prepositionRButton.PerformClick();
            }
            else if (interjectionRButton.Enabled)
            {
                interjectionRButton.PerformClick();
            }
            else if (articleRButton.Enabled)
            {
                articleRButton.PerformClick();
            }
        }

        private void RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == nounRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.NOUN]);
            }
            else if (sender == pronounRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.PRONOUN]);
            }
            else if (sender == adjectiveRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.ADJECTIVE]);
            }
            else if (sender == verbRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.VERB]);
            }
            else if (sender == adverbRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.ADVERB]);
            }
            else if (sender == prepositionRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.PREPOSITION]);
            }
            else if (sender == conjunctionRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.CONJUNCTION]);
            }
            else if (sender == interjectionRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.INTERJECTION]);
            }
            else if (sender == articleRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.ARTICLE]);
            }
            else if (sender == phraseRButton)
            {
                richTextBox1.Text = string.Join("\n", controller[currentIdx].Translation[partOfSpeech.PHRASE]);
            }
            else
            {
                nounRButton.Checked = false;
                pronounRButton.Checked = false;
                adjectiveRButton.Checked = false;
                verbRButton.Checked = false;
                adverbRButton.Checked = false;
                prepositionRButton.Checked = false;
                conjunctionRButton.Checked = false;
                interjectionRButton.Checked = false;
                articleRButton.Checked = false;
                phraseRButton.Checked = false;
                richTextBox1.Text = "";
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentIdx > 0)
            {
                RButton_CheckedChanged(sender, e);
                --currentIdx;
                showCard();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIdx < controller.Count - 1)
            {
                RButton_CheckedChanged(sender, e);
                ++currentIdx;
                showCard();
            }
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = false;
            label1.Text = "";
            RButton_CheckedChanged(sender, e);
            if (!ChildForm.Instance.Visible)
            {
                ChildForm.Instance.setView(showForm.ADD_WORD);
                ChildForm.Instance.Show(this);
            }
        }

        private void deleteCardButton_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = false;
            label1.Text = "";
            RButton_CheckedChanged(sender, e);
            if (!ChildForm.Instance.Visible)
            {
                ChildForm.Instance.setView(showForm.DELETE_WORD);
                ChildForm.Instance.Show(this);
            }
        }

        private void deleteTranslButton_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = false;
            label1.Text = "";
            RButton_CheckedChanged(sender, e);
            if (!ChildForm.Instance.Visible)
            {
                ChildForm.Instance.setView(showForm.DELETE_TRANSLATE);
                ChildForm.Instance.Show(this);
            }
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = true;
            label1.Text = "Статистика";
            richTextBox1.Text = "Количество существительных: " + controller.Nouns + '\n'
                + "Количество местоимений: " + controller.Pronouns + '\n'
                + "Количество прилагательных: " + controller.Adjectives + '\n'
                + "Количество глаголов: " + controller.Verbs + '\n'
                + "Количество наречий: " + controller.Adverbs + '\n'
                + "Количество предлогов: " + controller.Prepositions + '\n'
                + "Количество союзов: " + controller.Conjunctions + '\n'
                + "Количество междометий: " + controller.Interjections + '\n'
                + "Количество артиклей: " + controller.Articles + '\n'
                + "Количество фраз: " + controller.Phrases + '\n'
                + "Всего слов: " + controller.Count + '\n'
                + "Средняя длина слова в словаре: " + controller.AvgWordLength + '\n'
                + "Максимальная длина слова в словаре: " + controller.MaxWordLength + '\n'
                + "Максимальное количество переводов слова: " + controller.MaxTranslLength + '\n';
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > controller.Count)
            {
                wordsToTest = controller.Count;
            }
            else
            {
                wordsToTest = (int)numericUpDown1.Value;
            }
            numericUpDown1.Value = wordsToTest;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            RButton_CheckedChanged(sender, e);
            int[] array = new int[wordsToTest];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = controller.Count;
            }
            for (int i = 0; i < array.Length; i++)
            {
                int num = rnd.Next(0, controller.Count);
                while (array.Any(ar => ar == num))
                {
                    num = rnd.Next(0, controller.Count);
                }
                array[i] = num;
            }
            for (int i = 0; i < array.Length; i++)
            {
                statTest.Add(controller[array[i]], 0);
            }
            outerIdx = 0;
            innerIdx = 0;
            splitContainer3.Panel1.Enabled = false;
            tabVocabPage.Enabled = false;
            nextButton2.Text = "Вперед                    >>";
            richTextBox3.Visible = false;
            richTextBox2.Visible = true;
            showTestCard();
            nextButton2.Enabled = true;
        }

        private void showTestCard()
        {
            richTextBox2.Text = "";
            if (outerIdx == (statTest.Count - 1))
            {
                nextButton2.Text = "Завершить тестирование";
            }
            wordLabel.Text = statTest.ElementAt(outerIdx).Key.Word;
            posLabel.Text = pos(statTest.ElementAt(outerIdx).Key.Translation.ElementAt(innerIdx).Key);
        }

        private string pos(partOfSpeech pos)
        {
            if (pos == partOfSpeech.NOUN)
            {
                return "существительное";
            }
            else if (pos == partOfSpeech.PRONOUN)
            {
                return "местоимение";
            }
            else if(pos == partOfSpeech.ADJECTIVE)
            {
                return "прилагательное";
            }
            else if (pos == partOfSpeech.VERB)
            {
                return "глагол";
            }
            else if (pos == partOfSpeech.ADVERB)
            {
                return "наречие";
            }
            else if (pos == partOfSpeech.PREPOSITION)
            {
                return "предлог";
            }
            else if (pos == partOfSpeech.CONJUNCTION)
            {
                return "союз";
            }
            else if (pos == partOfSpeech.INTERJECTION)
            {
                return "междометие";
            }
            else if (pos == partOfSpeech.ARTICLE)
            {
                return "артикль";
            }
            else if (pos == partOfSpeech.PHRASE)
            {
                return "фраза";
            }
            else
            {
                return "";
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

        private void nextButton2_Click(object sender, EventArgs e)
        {
            testTransl = Regex.Replace(richTextBox2.Text.ToLower().Trim(), "\\s+", " ");
            if (!statTest.ElementAt(outerIdx).Key.Translation.ElementAt(innerIdx).Value.Any(str => str == testTransl))
            {
                statTest[statTest.ElementAt(outerIdx).Key] += 1;
            }
            if (innerIdx == (statTest.ElementAt(outerIdx).Key.Translation.Count - 1))
            {
                innerIdx = 0;
                ++outerIdx;
            }
            else
            {
                ++innerIdx;
            }
            if (outerIdx == statTest.Count)
            {
                showTestStat();
                return;
            }
            else
            {
                showTestCard();
            }
        }

        private void showTestStat()
        {
            richTextBox2.Visible = false;
            richTextBox3.Visible = true;
            nextButton2.Enabled = false;
            wordLabel.Text = "Статистика";
            posLabel.Text = "";
            richTextBox3.Text = "Всего ошибок: " + statTest.Values.Sum() + " из " + statTest.Select(s => s.Key.Translation.Count).Sum() + "\n"
                + string.Join("\n", statTest.Select(s => "Cлово -- " + s.Key.Word + " -- ошибок: " + s.Value + " из " + s.Key.Translation.Count));
            statTest.Clear();
            splitContainer3.Panel1.Enabled = true;
            tabVocabPage.Enabled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                    if (nextButton.Enabled)
                    {
                        nextButton.PerformClick();
                    }
                    return true;
                case Keys.Left:
                    if (previousButton.Enabled)
                    {
                        previousButton.PerformClick();
                    }
                    return true;
                case Keys.Enter:
                    if (nextButton2.Enabled)
                    {
                        nextButton2.PerformClick();
                        return true;
                    }
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
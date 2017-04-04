namespace lab_4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.closeVocabButton = new System.Windows.Forms.Button();
            this.saveVocabButton = new System.Windows.Forms.Button();
            this.saveVocabAsButton = new System.Windows.Forms.Button();
            this.loadVocabButton = new System.Windows.Forms.Button();
            this.newVocabButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVocabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statButton = new System.Windows.Forms.Button();
            this.deleteCardButton = new System.Windows.Forms.Button();
            this.addCardButton = new System.Windows.Forms.Button();
            this.showCardsButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phraseRButton = new System.Windows.Forms.RadioButton();
            this.articleRButton = new System.Windows.Forms.RadioButton();
            this.interjectionRButton = new System.Windows.Forms.RadioButton();
            this.conjunctionRButton = new System.Windows.Forms.RadioButton();
            this.adjectiveRButton = new System.Windows.Forms.RadioButton();
            this.prepositionRButton = new System.Windows.Forms.RadioButton();
            this.adverbRButton = new System.Windows.Forms.RadioButton();
            this.pronounRButton = new System.Windows.Forms.RadioButton();
            this.nounRButton = new System.Windows.Forms.RadioButton();
            this.verbRButton = new System.Windows.Forms.RadioButton();
            this.deleteTranslButton = new System.Windows.Forms.Button();
            this.tabTestPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.posLabel = new System.Windows.Forms.Label();
            this.nextButton2 = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabVocabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTestPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.secondPanel);
            this.splitContainer1.Panel1.Controls.Add(this.loadVocabButton);
            this.splitContainer1.Panel1.Controls.Add(this.newVocabButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(964, 638);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 0;
            // 
            // secondPanel
            // 
            this.secondPanel.Controls.Add(this.closeVocabButton);
            this.secondPanel.Controls.Add(this.saveVocabButton);
            this.secondPanel.Controls.Add(this.saveVocabAsButton);
            this.secondPanel.Enabled = false;
            this.secondPanel.Location = new System.Drawing.Point(25, 240);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(210, 272);
            this.secondPanel.TabIndex = 2;
            // 
            // closeVocabButton
            // 
            this.closeVocabButton.Location = new System.Drawing.Point(0, 200);
            this.closeVocabButton.Name = "closeVocabButton";
            this.closeVocabButton.Size = new System.Drawing.Size(210, 60);
            this.closeVocabButton.TabIndex = 4;
            this.closeVocabButton.Text = "Закрыть текущий словарь";
            this.closeVocabButton.UseVisualStyleBackColor = true;
            this.closeVocabButton.Click += new System.EventHandler(this.closeVocabButton_Click);
            // 
            // saveVocabButton
            // 
            this.saveVocabButton.Location = new System.Drawing.Point(0, 0);
            this.saveVocabButton.Name = "saveVocabButton";
            this.saveVocabButton.Size = new System.Drawing.Size(210, 60);
            this.saveVocabButton.TabIndex = 6;
            this.saveVocabButton.Text = "Сохранить словарь";
            this.saveVocabButton.UseVisualStyleBackColor = true;
            this.saveVocabButton.Click += new System.EventHandler(this.saveVocabButton_Click);
            // 
            // saveVocabAsButton
            // 
            this.saveVocabAsButton.Location = new System.Drawing.Point(0, 100);
            this.saveVocabAsButton.Name = "saveVocabAsButton";
            this.saveVocabAsButton.Size = new System.Drawing.Size(210, 60);
            this.saveVocabAsButton.TabIndex = 3;
            this.saveVocabAsButton.Text = "Сохранить словарь как";
            this.saveVocabAsButton.UseVisualStyleBackColor = true;
            this.saveVocabAsButton.Click += new System.EventHandler(this.saveVocabAsButton_Click);
            // 
            // loadVocabButton
            // 
            this.loadVocabButton.Location = new System.Drawing.Point(25, 140);
            this.loadVocabButton.Name = "loadVocabButton";
            this.loadVocabButton.Size = new System.Drawing.Size(210, 60);
            this.loadVocabButton.TabIndex = 1;
            this.loadVocabButton.Text = "Загрузить словарь";
            this.loadVocabButton.UseVisualStyleBackColor = true;
            this.loadVocabButton.Click += new System.EventHandler(this.loadVocabButton_Click);
            // 
            // newVocabButton
            // 
            this.newVocabButton.Location = new System.Drawing.Point(25, 40);
            this.newVocabButton.Name = "newVocabButton";
            this.newVocabButton.Size = new System.Drawing.Size(210, 60);
            this.newVocabButton.TabIndex = 0;
            this.newVocabButton.Text = "Новый словарь";
            this.newVocabButton.UseVisualStyleBackColor = true;
            this.newVocabButton.Click += new System.EventHandler(this.newVocabButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVocabPage);
            this.tabControl1.Controls.Add(this.tabTestPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 638);
            this.tabControl1.TabIndex = 5;
            // 
            // tabVocabPage
            // 
            this.tabVocabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabVocabPage.Controls.Add(this.splitContainer2);
            this.tabVocabPage.Location = new System.Drawing.Point(4, 22);
            this.tabVocabPage.Name = "tabVocabPage";
            this.tabVocabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabVocabPage.Size = new System.Drawing.Size(703, 612);
            this.tabVocabPage.TabIndex = 0;
            this.tabVocabPage.Text = "Словарь";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.statButton);
            this.splitContainer2.Panel1.Controls.Add(this.deleteCardButton);
            this.splitContainer2.Panel1.Controls.Add(this.addCardButton);
            this.splitContainer2.Panel1.Controls.Add(this.showCardsButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Panel2.Controls.Add(this.previousButton);
            this.splitContainer2.Panel2.Controls.Add(this.nextButton);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.deleteTranslButton);
            this.splitContainer2.Panel2.Enabled = false;
            this.splitContainer2.Size = new System.Drawing.Size(697, 606);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.TabIndex = 0;
            // 
            // statButton
            // 
            this.statButton.Location = new System.Drawing.Point(530, 23);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(150, 65);
            this.statButton.TabIndex = 3;
            this.statButton.Text = "Статистика";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // deleteCardButton
            // 
            this.deleteCardButton.Location = new System.Drawing.Point(355, 23);
            this.deleteCardButton.Name = "deleteCardButton";
            this.deleteCardButton.Size = new System.Drawing.Size(150, 65);
            this.deleteCardButton.TabIndex = 2;
            this.deleteCardButton.Text = "Удаление слова";
            this.deleteCardButton.UseVisualStyleBackColor = true;
            this.deleteCardButton.Click += new System.EventHandler(this.deleteCardButton_Click);
            // 
            // addCardButton
            // 
            this.addCardButton.Location = new System.Drawing.Point(185, 23);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(150, 65);
            this.addCardButton.TabIndex = 1;
            this.addCardButton.Text = "Добавление карточки/перевода";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // showCardsButton
            // 
            this.showCardsButton.Location = new System.Drawing.Point(15, 23);
            this.showCardsButton.Name = "showCardsButton";
            this.showCardsButton.Size = new System.Drawing.Size(150, 65);
            this.showCardsButton.TabIndex = 0;
            this.showCardsButton.Text = "Просмотр карточек";
            this.showCardsButton.UseVisualStyleBackColor = true;
            this.showCardsButton.Click += new System.EventHandler(this.showCardsButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(37, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(419, 329);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(15, 417);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(189, 52);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "<<                    Назад";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(491, 417);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(189, 52);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Вперед                    >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phraseRButton);
            this.groupBox1.Controls.Add(this.articleRButton);
            this.groupBox1.Controls.Add(this.interjectionRButton);
            this.groupBox1.Controls.Add(this.conjunctionRButton);
            this.groupBox1.Controls.Add(this.adjectiveRButton);
            this.groupBox1.Controls.Add(this.prepositionRButton);
            this.groupBox1.Controls.Add(this.adverbRButton);
            this.groupBox1.Controls.Add(this.pronounRButton);
            this.groupBox1.Controls.Add(this.nounRButton);
            this.groupBox1.Controls.Add(this.verbRButton);
            this.groupBox1.Location = new System.Drawing.Point(491, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Часть речи";
            // 
            // phraseRButton
            // 
            this.phraseRButton.AutoSize = true;
            this.phraseRButton.Location = new System.Drawing.Point(20, 320);
            this.phraseRButton.Name = "phraseRButton";
            this.phraseRButton.Size = new System.Drawing.Size(57, 17);
            this.phraseRButton.TabIndex = 11;
            this.phraseRButton.TabStop = true;
            this.phraseRButton.Text = "фраза";
            this.phraseRButton.UseVisualStyleBackColor = true;
            this.phraseRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // articleRButton
            // 
            this.articleRButton.AutoSize = true;
            this.articleRButton.Location = new System.Drawing.Point(20, 288);
            this.articleRButton.Name = "articleRButton";
            this.articleRButton.Size = new System.Drawing.Size(66, 17);
            this.articleRButton.TabIndex = 10;
            this.articleRButton.TabStop = true;
            this.articleRButton.Text = "артикль";
            this.articleRButton.UseVisualStyleBackColor = true;
            this.articleRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // interjectionRButton
            // 
            this.interjectionRButton.AutoSize = true;
            this.interjectionRButton.Location = new System.Drawing.Point(20, 256);
            this.interjectionRButton.Name = "interjectionRButton";
            this.interjectionRButton.Size = new System.Drawing.Size(90, 17);
            this.interjectionRButton.TabIndex = 9;
            this.interjectionRButton.TabStop = true;
            this.interjectionRButton.Text = "междометие";
            this.interjectionRButton.UseVisualStyleBackColor = true;
            this.interjectionRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // conjunctionRButton
            // 
            this.conjunctionRButton.AutoSize = true;
            this.conjunctionRButton.Location = new System.Drawing.Point(20, 224);
            this.conjunctionRButton.Name = "conjunctionRButton";
            this.conjunctionRButton.Size = new System.Drawing.Size(51, 17);
            this.conjunctionRButton.TabIndex = 8;
            this.conjunctionRButton.TabStop = true;
            this.conjunctionRButton.Text = "союз";
            this.conjunctionRButton.UseVisualStyleBackColor = true;
            this.conjunctionRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // adjectiveRButton
            // 
            this.adjectiveRButton.AutoSize = true;
            this.adjectiveRButton.Location = new System.Drawing.Point(20, 96);
            this.adjectiveRButton.Name = "adjectiveRButton";
            this.adjectiveRButton.Size = new System.Drawing.Size(107, 17);
            this.adjectiveRButton.TabIndex = 4;
            this.adjectiveRButton.TabStop = true;
            this.adjectiveRButton.Text = "прилагательное";
            this.adjectiveRButton.UseVisualStyleBackColor = true;
            this.adjectiveRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // prepositionRButton
            // 
            this.prepositionRButton.AutoSize = true;
            this.prepositionRButton.Location = new System.Drawing.Point(20, 192);
            this.prepositionRButton.Name = "prepositionRButton";
            this.prepositionRButton.Size = new System.Drawing.Size(66, 17);
            this.prepositionRButton.TabIndex = 7;
            this.prepositionRButton.TabStop = true;
            this.prepositionRButton.Text = "предлог";
            this.prepositionRButton.UseVisualStyleBackColor = true;
            this.prepositionRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // adverbRButton
            // 
            this.adverbRButton.AutoSize = true;
            this.adverbRButton.Location = new System.Drawing.Point(20, 160);
            this.adverbRButton.Name = "adverbRButton";
            this.adverbRButton.Size = new System.Drawing.Size(66, 17);
            this.adverbRButton.TabIndex = 6;
            this.adverbRButton.TabStop = true;
            this.adverbRButton.Text = "наречие";
            this.adverbRButton.UseVisualStyleBackColor = true;
            this.adverbRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // pronounRButton
            // 
            this.pronounRButton.AutoSize = true;
            this.pronounRButton.Location = new System.Drawing.Point(20, 64);
            this.pronounRButton.Name = "pronounRButton";
            this.pronounRButton.Size = new System.Drawing.Size(94, 17);
            this.pronounRButton.TabIndex = 3;
            this.pronounRButton.TabStop = true;
            this.pronounRButton.Text = "местоимениe";
            this.pronounRButton.UseVisualStyleBackColor = true;
            this.pronounRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // nounRButton
            // 
            this.nounRButton.AutoSize = true;
            this.nounRButton.Location = new System.Drawing.Point(20, 32);
            this.nounRButton.Name = "nounRButton";
            this.nounRButton.Size = new System.Drawing.Size(115, 17);
            this.nounRButton.TabIndex = 2;
            this.nounRButton.TabStop = true;
            this.nounRButton.Text = "существительное";
            this.nounRButton.UseVisualStyleBackColor = true;
            this.nounRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // verbRButton
            // 
            this.verbRButton.AutoSize = true;
            this.verbRButton.Location = new System.Drawing.Point(20, 128);
            this.verbRButton.Name = "verbRButton";
            this.verbRButton.Size = new System.Drawing.Size(59, 17);
            this.verbRButton.TabIndex = 5;
            this.verbRButton.TabStop = true;
            this.verbRButton.Text = "глагол";
            this.verbRButton.UseVisualStyleBackColor = true;
            this.verbRButton.CheckedChanged += new System.EventHandler(this.RButton_CheckedChanged);
            // 
            // deleteTranslButton
            // 
            this.deleteTranslButton.Location = new System.Drawing.Point(491, 22);
            this.deleteTranslButton.Name = "deleteTranslButton";
            this.deleteTranslButton.Size = new System.Drawing.Size(189, 34);
            this.deleteTranslButton.TabIndex = 0;
            this.deleteTranslButton.Text = "Удалить перевод из карточки";
            this.deleteTranslButton.UseVisualStyleBackColor = true;
            this.deleteTranslButton.Click += new System.EventHandler(this.deleteTranslButton_Click);
            // 
            // tabTestPage
            // 
            this.tabTestPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabTestPage.Controls.Add(this.splitContainer3);
            this.tabTestPage.Location = new System.Drawing.Point(4, 22);
            this.tabTestPage.Name = "tabTestPage";
            this.tabTestPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTestPage.Size = new System.Drawing.Size(703, 612);
            this.tabTestPage.TabIndex = 1;
            this.tabTestPage.Text = "Тестирование";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.testButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer3.Panel2.Controls.Add(this.richTextBox3);
            this.splitContainer3.Panel2.Controls.Add(this.posLabel);
            this.splitContainer3.Panel2.Controls.Add(this.nextButton2);
            this.splitContainer3.Panel2.Controls.Add(this.wordLabel);
            this.splitContainer3.Size = new System.Drawing.Size(697, 606);
            this.splitContainer3.SplitterDistance = 110;
            this.splitContainer3.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(364, 39);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 35);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество случайных слов";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(428, 14);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(241, 80);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Начать тестирование";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(22, 63);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(647, 366);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.posLabel.Location = new System.Drawing.Point(466, 21);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(0, 25);
            this.posLabel.TabIndex = 5;
            // 
            // nextButton2
            // 
            this.nextButton2.Enabled = false;
            this.nextButton2.Location = new System.Drawing.Point(22, 435);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(647, 42);
            this.nextButton2.TabIndex = 2;
            this.nextButton2.Text = "Вперед                    >>";
            this.nextButton2.UseVisualStyleBackColor = true;
            this.nextButton2.Click += new System.EventHandler(this.nextButton2_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordLabel.Location = new System.Drawing.Point(15, 7);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(0, 39);
            this.wordLabel.TabIndex = 0;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(22, 84);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(647, 30);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox2_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 638);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(980, 677);
            this.MinimumSize = new System.Drawing.Size(980, 677);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Англо-русский словарь";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.secondPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabVocabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTestPage.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button closeVocabButton;
        private System.Windows.Forms.Button saveVocabAsButton;
        private System.Windows.Forms.Button loadVocabButton;
        private System.Windows.Forms.Button newVocabButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVocabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.Button deleteCardButton;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Button showCardsButton;
        private System.Windows.Forms.TabPage tabTestPage;
        private System.Windows.Forms.Button deleteTranslButton;
        private System.Windows.Forms.Button saveVocabButton;
        private System.Windows.Forms.Panel secondPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton phraseRButton;
        private System.Windows.Forms.RadioButton articleRButton;
        private System.Windows.Forms.RadioButton interjectionRButton;
        private System.Windows.Forms.RadioButton conjunctionRButton;
        private System.Windows.Forms.RadioButton adjectiveRButton;
        private System.Windows.Forms.RadioButton prepositionRButton;
        private System.Windows.Forms.RadioButton adverbRButton;
        private System.Windows.Forms.RadioButton pronounRButton;
        private System.Windows.Forms.RadioButton nounRButton;
        private System.Windows.Forms.RadioButton verbRButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Button nextButton2;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}
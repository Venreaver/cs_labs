namespace lab_4
{
    partial class ChildForm
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
            instance = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group_Box1 = new System.Windows.Forms.GroupBox();
            this.phrase_RButton = new System.Windows.Forms.RadioButton();
            this.article_RButton = new System.Windows.Forms.RadioButton();
            this.interjection_RButton = new System.Windows.Forms.RadioButton();
            this.conjunction_RButton = new System.Windows.Forms.RadioButton();
            this.adjective_RButton = new System.Windows.Forms.RadioButton();
            this.preposition_RButton = new System.Windows.Forms.RadioButton();
            this.adverb_RButton = new System.Windows.Forms.RadioButton();
            this.pronoun_RButton = new System.Windows.Forms.RadioButton();
            this.noun_RButton = new System.Windows.Forms.RadioButton();
            this.verb_RButton = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.group_Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перевод";
            // 
            // group_Box1
            // 
            this.group_Box1.Controls.Add(this.phrase_RButton);
            this.group_Box1.Controls.Add(this.article_RButton);
            this.group_Box1.Controls.Add(this.interjection_RButton);
            this.group_Box1.Controls.Add(this.conjunction_RButton);
            this.group_Box1.Controls.Add(this.adjective_RButton);
            this.group_Box1.Controls.Add(this.preposition_RButton);
            this.group_Box1.Controls.Add(this.adverb_RButton);
            this.group_Box1.Controls.Add(this.pronoun_RButton);
            this.group_Box1.Controls.Add(this.noun_RButton);
            this.group_Box1.Controls.Add(this.verb_RButton);
            this.group_Box1.Location = new System.Drawing.Point(334, 23);
            this.group_Box1.Name = "group_Box1";
            this.group_Box1.Size = new System.Drawing.Size(145, 349);
            this.group_Box1.TabIndex = 2;
            this.group_Box1.TabStop = false;
            this.group_Box1.Text = "Часть речи";
            // 
            // phrase_RButton
            // 
            this.phrase_RButton.AutoSize = true;
            this.phrase_RButton.Location = new System.Drawing.Point(20, 320);
            this.phrase_RButton.Name = "phrase_RButton";
            this.phrase_RButton.Size = new System.Drawing.Size(57, 17);
            this.phrase_RButton.TabIndex = 11;
            this.phrase_RButton.TabStop = true;
            this.phrase_RButton.Text = "фраза";
            this.phrase_RButton.UseVisualStyleBackColor = true;
            this.phrase_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // article_RButton
            // 
            this.article_RButton.AutoSize = true;
            this.article_RButton.Location = new System.Drawing.Point(20, 288);
            this.article_RButton.Name = "article_RButton";
            this.article_RButton.Size = new System.Drawing.Size(66, 17);
            this.article_RButton.TabIndex = 10;
            this.article_RButton.TabStop = true;
            this.article_RButton.Text = "артикль";
            this.article_RButton.UseVisualStyleBackColor = true;
            this.article_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // interjection_RButton
            // 
            this.interjection_RButton.AutoSize = true;
            this.interjection_RButton.Location = new System.Drawing.Point(20, 256);
            this.interjection_RButton.Name = "interjection_RButton";
            this.interjection_RButton.Size = new System.Drawing.Size(90, 17);
            this.interjection_RButton.TabIndex = 9;
            this.interjection_RButton.TabStop = true;
            this.interjection_RButton.Text = "междометие";
            this.interjection_RButton.UseVisualStyleBackColor = true;
            this.interjection_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // conjunction_RButton
            // 
            this.conjunction_RButton.AutoSize = true;
            this.conjunction_RButton.Location = new System.Drawing.Point(20, 224);
            this.conjunction_RButton.Name = "conjunction_RButton";
            this.conjunction_RButton.Size = new System.Drawing.Size(51, 17);
            this.conjunction_RButton.TabIndex = 8;
            this.conjunction_RButton.TabStop = true;
            this.conjunction_RButton.Text = "союз";
            this.conjunction_RButton.UseVisualStyleBackColor = true;
            this.conjunction_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // adjective_RButton
            // 
            this.adjective_RButton.AutoSize = true;
            this.adjective_RButton.Location = new System.Drawing.Point(20, 96);
            this.adjective_RButton.Name = "adjective_RButton";
            this.adjective_RButton.Size = new System.Drawing.Size(107, 17);
            this.adjective_RButton.TabIndex = 4;
            this.adjective_RButton.TabStop = true;
            this.adjective_RButton.Text = "прилагательное";
            this.adjective_RButton.UseVisualStyleBackColor = true;
            this.adjective_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // preposition_RButton
            // 
            this.preposition_RButton.AutoSize = true;
            this.preposition_RButton.Location = new System.Drawing.Point(20, 192);
            this.preposition_RButton.Name = "preposition_RButton";
            this.preposition_RButton.Size = new System.Drawing.Size(66, 17);
            this.preposition_RButton.TabIndex = 7;
            this.preposition_RButton.TabStop = true;
            this.preposition_RButton.Text = "предлог";
            this.preposition_RButton.UseVisualStyleBackColor = true;
            this.preposition_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // adverb_RButton
            // 
            this.adverb_RButton.AutoSize = true;
            this.adverb_RButton.Location = new System.Drawing.Point(20, 160);
            this.adverb_RButton.Name = "adverb_RButton";
            this.adverb_RButton.Size = new System.Drawing.Size(66, 17);
            this.adverb_RButton.TabIndex = 6;
            this.adverb_RButton.TabStop = true;
            this.adverb_RButton.Text = "наречие";
            this.adverb_RButton.UseVisualStyleBackColor = true;
            this.adverb_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // pronoun_RButton
            // 
            this.pronoun_RButton.AutoSize = true;
            this.pronoun_RButton.Location = new System.Drawing.Point(20, 64);
            this.pronoun_RButton.Name = "pronoun_RButton";
            this.pronoun_RButton.Size = new System.Drawing.Size(94, 17);
            this.pronoun_RButton.TabIndex = 3;
            this.pronoun_RButton.TabStop = true;
            this.pronoun_RButton.Text = "местоимениe";
            this.pronoun_RButton.UseVisualStyleBackColor = true;
            this.pronoun_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // noun_RButton
            // 
            this.noun_RButton.AutoSize = true;
            this.noun_RButton.Location = new System.Drawing.Point(20, 32);
            this.noun_RButton.Name = "noun_RButton";
            this.noun_RButton.Size = new System.Drawing.Size(115, 17);
            this.noun_RButton.TabIndex = 2;
            this.noun_RButton.TabStop = true;
            this.noun_RButton.Text = "существительное";
            this.noun_RButton.UseVisualStyleBackColor = true;
            this.noun_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // verb_RButton
            // 
            this.verb_RButton.AutoSize = true;
            this.verb_RButton.Location = new System.Drawing.Point(20, 128);
            this.verb_RButton.Name = "verb_RButton";
            this.verb_RButton.Size = new System.Drawing.Size(59, 17);
            this.verb_RButton.TabIndex = 5;
            this.verb_RButton.TabStop = true;
            this.verb_RButton.Text = "глагол";
            this.verb_RButton.UseVisualStyleBackColor = true;
            this.verb_RButton.CheckedChanged += new System.EventHandler(this.R_Button_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 114);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(25, 215);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(282, 114);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            this.richTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox2_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(25, 343);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(282, 28);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 383);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.group_Box1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChildForm";
            this.group_Box1.ResumeLayout(false);
            this.group_Box1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_Box1;
        private System.Windows.Forms.RadioButton phrase_RButton;
        private System.Windows.Forms.RadioButton article_RButton;
        private System.Windows.Forms.RadioButton interjection_RButton;
        private System.Windows.Forms.RadioButton conjunction_RButton;
        private System.Windows.Forms.RadioButton adjective_RButton;
        private System.Windows.Forms.RadioButton preposition_RButton;
        private System.Windows.Forms.RadioButton adverb_RButton;
        private System.Windows.Forms.RadioButton pronoun_RButton;
        private System.Windows.Forms.RadioButton noun_RButton;
        private System.Windows.Forms.RadioButton verb_RButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button okButton;
    }
}
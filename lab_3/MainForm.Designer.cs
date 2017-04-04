namespace lab_3
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
            this.pointButton = new System.Windows.Forms.Button();
            this.paramButton = new System.Windows.Forms.Button();
            this.closedCurveButton = new System.Windows.Forms.Button();
            this.polygoneButton = new System.Windows.Forms.Button();
            this.beizersButton = new System.Windows.Forms.Button();
            this.fillCurveButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pointDrButton = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointButton
            // 
            this.pointButton.Location = new System.Drawing.Point(13, 13);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(134, 41);
            this.pointButton.TabIndex = 0;
            this.pointButton.Text = "Точки";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.button_Click);
            // 
            // paramButton
            // 
            this.paramButton.Location = new System.Drawing.Point(13, 60);
            this.paramButton.Name = "paramButton";
            this.paramButton.Size = new System.Drawing.Size(134, 41);
            this.paramButton.TabIndex = 1;
            this.paramButton.Text = "Параметры";
            this.paramButton.UseVisualStyleBackColor = true;
            this.paramButton.Click += new System.EventHandler(this.button_Click);
            // 
            // closedCurveButton
            // 
            this.closedCurveButton.Location = new System.Drawing.Point(13, 107);
            this.closedCurveButton.Name = "closedCurveButton";
            this.closedCurveButton.Size = new System.Drawing.Size(134, 41);
            this.closedCurveButton.TabIndex = 2;
            this.closedCurveButton.Text = "Кривая";
            this.closedCurveButton.UseVisualStyleBackColor = true;
            this.closedCurveButton.Click += new System.EventHandler(this.button_Click);
            // 
            // polygoneButton
            // 
            this.polygoneButton.Location = new System.Drawing.Point(13, 154);
            this.polygoneButton.Name = "polygoneButton";
            this.polygoneButton.Size = new System.Drawing.Size(134, 41);
            this.polygoneButton.TabIndex = 3;
            this.polygoneButton.Text = "Ломанная";
            this.polygoneButton.UseVisualStyleBackColor = true;
            this.polygoneButton.Click += new System.EventHandler(this.button_Click);
            // 
            // beizersButton
            // 
            this.beizersButton.Location = new System.Drawing.Point(13, 201);
            this.beizersButton.Name = "beizersButton";
            this.beizersButton.Size = new System.Drawing.Size(134, 41);
            this.beizersButton.TabIndex = 4;
            this.beizersButton.Text = "Безье";
            this.beizersButton.UseVisualStyleBackColor = true;
            this.beizersButton.Click += new System.EventHandler(this.button_Click);
            // 
            // fillCurveButton
            // 
            this.fillCurveButton.Location = new System.Drawing.Point(13, 248);
            this.fillCurveButton.Name = "fillCurveButton";
            this.fillCurveButton.Size = new System.Drawing.Size(134, 41);
            this.fillCurveButton.TabIndex = 5;
            this.fillCurveButton.Text = "Заполненная";
            this.fillCurveButton.UseVisualStyleBackColor = true;
            this.fillCurveButton.Click += new System.EventHandler(this.button_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(13, 342);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(134, 41);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "Движение";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.button_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(13, 389);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(134, 41);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.pointButton);
            this.buttonPanel.Controls.Add(this.paramButton);
            this.buttonPanel.Controls.Add(this.closedCurveButton);
            this.buttonPanel.Controls.Add(this.polygoneButton);
            this.buttonPanel.Controls.Add(this.beizersButton);
            this.buttonPanel.Controls.Add(this.fillCurveButton);
            this.buttonPanel.Controls.Add(this.pointDrButton);
            this.buttonPanel.Controls.Add(this.moveButton);
            this.buttonPanel.Controls.Add(this.clearButton);
            this.buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonPanel.Location = new System.Drawing.Point(12, 12);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(10);
            this.buttonPanel.Size = new System.Drawing.Size(163, 444);
            this.buttonPanel.TabIndex = 8;
            // 
            // pointDrButton
            // 
            this.pointDrButton.Location = new System.Drawing.Point(13, 295);
            this.pointDrButton.Name = "pointDrButton";
            this.pointDrButton.Size = new System.Drawing.Size(134, 41);
            this.pointDrButton.TabIndex = 9;
            this.pointDrButton.Text = "Точки без соединения";
            this.pointDrButton.UseVisualStyleBackColor = true;
            this.pointDrButton.Click += new System.EventHandler(this.button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.buttonPanel);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(584, 511);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ФОРМА";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button paramButton;
        private System.Windows.Forms.Button closedCurveButton;
        private System.Windows.Forms.Button polygoneButton;
        private System.Windows.Forms.Button beizersButton;
        private System.Windows.Forms.Button fillCurveButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button pointDrButton;
    }
}


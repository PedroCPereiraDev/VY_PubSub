namespace FormsApp
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NewPubButton = new Button();
            NewSubButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 0;
            label1.Text = "INVOICE ENGINE";
            // 
            // NewPubButton
            // 
            NewPubButton.Location = new Point(12, 54);
            NewPubButton.Name = "NewPubButton";
            NewPubButton.Size = new Size(237, 57);
            NewPubButton.TabIndex = 1;
            NewPubButton.Text = "NEW INVOICE REPORTER";
            NewPubButton.UseVisualStyleBackColor = true;
            NewPubButton.Click += NewPubButton_Click;
            // 
            // NewSubButton
            // 
            NewSubButton.Location = new Point(12, 117);
            NewSubButton.Name = "NewSubButton";
            NewSubButton.Size = new Size(237, 57);
            NewSubButton.TabIndex = 2;
            NewSubButton.Text = "NEW INVOICE VIEWER";
            NewSubButton.UseVisualStyleBackColor = true;
            NewSubButton.Click += NewSubButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 188);
            Controls.Add(NewSubButton);
            Controls.Add(NewPubButton);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "StartForm";
            Text = "Invoice Engine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button NewPubButton;
        private Button NewSubButton;
    }
}

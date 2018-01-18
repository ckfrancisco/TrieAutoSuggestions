namespace TrieAutoSuggestions
{
    partial class Form1
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
            this.PrefixInputContainer = new System.Windows.Forms.GroupBox();
            this.PrefixInput = new System.Windows.Forms.TextBox();
            this.ResultsContainer = new System.Windows.Forms.GroupBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.PrefixInputContainer.SuspendLayout();
            this.ResultsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrefixInputContainer
            // 
            this.PrefixInputContainer.Controls.Add(this.PrefixInput);
            this.PrefixInputContainer.Location = new System.Drawing.Point(12, 12);
            this.PrefixInputContainer.Name = "PrefixInputContainer";
            this.PrefixInputContainer.Size = new System.Drawing.Size(676, 49);
            this.PrefixInputContainer.TabIndex = 0;
            this.PrefixInputContainer.TabStop = false;
            this.PrefixInputContainer.Text = "Prefix Input";
            // 
            // PrefixInput
            // 
            this.PrefixInput.Location = new System.Drawing.Point(6, 21);
            this.PrefixInput.Name = "PrefixInput";
            this.PrefixInput.Size = new System.Drawing.Size(664, 22);
            this.PrefixInput.TabIndex = 1;
            this.PrefixInput.TextChanged += new System.EventHandler(this.PrefixInput_TextChanged);
            // 
            // ResultsContainer
            // 
            this.ResultsContainer.Controls.Add(this.Results);
            this.ResultsContainer.Location = new System.Drawing.Point(12, 67);
            this.ResultsContainer.Name = "ResultsContainer";
            this.ResultsContainer.Size = new System.Drawing.Size(676, 759);
            this.ResultsContainer.TabIndex = 1;
            this.ResultsContainer.TabStop = false;
            this.ResultsContainer.Text = "Results";
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(6, 21);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(664, 732);
            this.Results.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 838);
            this.Controls.Add(this.ResultsContainer);
            this.Controls.Add(this.PrefixInputContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PrefixInputContainer.ResumeLayout(false);
            this.PrefixInputContainer.PerformLayout();
            this.ResultsContainer.ResumeLayout(false);
            this.ResultsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PrefixInputContainer;
        private System.Windows.Forms.TextBox PrefixInput;
        private System.Windows.Forms.GroupBox ResultsContainer;
        private System.Windows.Forms.TextBox Results;
    }
}


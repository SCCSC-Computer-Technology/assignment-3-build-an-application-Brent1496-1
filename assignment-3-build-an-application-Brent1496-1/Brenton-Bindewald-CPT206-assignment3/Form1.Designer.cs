namespace Brenton_Bindewald_Assignment3CPT_206_A01S_2024SP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ExitButton = new Button();
            StateComboBox = new ComboBox();
            label1 = new Label();
            RunButton = new Button();
            StateInformationOverviewLabel = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(384, 228);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(53, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StateComboBox
            // 
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Location = new Point(325, 199);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(121, 23);
            StateComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 181);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Select State";
            // 
            // RunButton
            // 
            RunButton.Location = new Point(325, 228);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(53, 29);
            RunButton.TabIndex = 4;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // StateInformationOverviewLabel
            // 
            StateInformationOverviewLabel.AutoSize = true;
            StateInformationOverviewLabel.Font = new Font("Segoe UI", 15F);
            StateInformationOverviewLabel.Location = new Point(260, 91);
            StateInformationOverviewLabel.Name = "StateInformationOverviewLabel";
            StateInformationOverviewLabel.Size = new Size(250, 28);
            StateInformationOverviewLabel.TabIndex = 5;
            StateInformationOverviewLabel.Text = "State Information Overview";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(StateInformationOverviewLabel);
            Controls.Add(RunButton);
            Controls.Add(label1);
            Controls.Add(StateComboBox);
            Controls.Add(ExitButton);
            Name = "Form1";
            Text = "UnitedStatesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RunButton;
        private Button ExitButton;
        private ComboBox StateComboBox;
        private Label label1;
        private Label StateInformationOverviewLabel;
    }
}

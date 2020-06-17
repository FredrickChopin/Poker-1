namespace Poker_1
{
    partial class SettingsForm
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
            this.lblChoose = new System.Windows.Forms.Label();
            this.moneyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblStakes = new System.Windows.Forms.Label();
            this.stakesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moneyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stakesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChoose.Image = global::Poker_1.Properties.Resources.Background;
            this.lblChoose.Location = new System.Drawing.Point(12, 76);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(475, 29);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choose the amount of money for each side:";
            // 
            // moneyNumericUpDown
            // 
            this.moneyNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyNumericUpDown.Location = new System.Drawing.Point(493, 74);
            this.moneyNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.moneyNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moneyNumericUpDown.Name = "moneyNumericUpDown";
            this.moneyNumericUpDown.Size = new System.Drawing.Size(120, 35);
            this.moneyNumericUpDown.TabIndex = 1;
            this.moneyNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblStakes
            // 
            this.lblStakes.AutoSize = true;
            this.lblStakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStakes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStakes.Image = global::Poker_1.Properties.Resources.Background;
            this.lblStakes.Location = new System.Drawing.Point(12, 162);
            this.lblStakes.Name = "lblStakes";
            this.lblStakes.Size = new System.Drawing.Size(268, 29);
            this.lblStakes.TabIndex = 0;
            this.lblStakes.Text = "Choose the small stake:";
            // 
            // stakesNumericUpDown
            // 
            this.stakesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stakesNumericUpDown.Location = new System.Drawing.Point(493, 156);
            this.stakesNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.stakesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stakesNumericUpDown.Name = "stakesNumericUpDown";
            this.stakesNumericUpDown.Size = new System.Drawing.Size(120, 35);
            this.stakesNumericUpDown.TabIndex = 1;
            this.stakesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(294, 264);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(149, 81);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poker_1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.stakesNumericUpDown);
            this.Controls.Add(this.moneyNumericUpDown);
            this.Controls.Add(this.lblStakes);
            this.Controls.Add(this.lblChoose);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings Form";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moneyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stakesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.NumericUpDown moneyNumericUpDown;
        private System.Windows.Forms.Label lblStakes;
        private System.Windows.Forms.NumericUpDown stakesNumericUpDown;
        private System.Windows.Forms.Button confirm;
    }
}
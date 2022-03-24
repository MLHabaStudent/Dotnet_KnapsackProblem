namespace KnapsackForm
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
            this.txtKnapsack = new System.Windows.Forms.TextBox();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.chckSort = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtKnapsack
            // 
            this.txtKnapsack.BackColor = System.Drawing.SystemColors.Window;
            this.txtKnapsack.Location = new System.Drawing.Point(12, 242);
            this.txtKnapsack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKnapsack.Multiline = true;
            this.txtKnapsack.Name = "txtKnapsack";
            this.txtKnapsack.ReadOnly = true;
            this.txtKnapsack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKnapsack.Size = new System.Drawing.Size(296, 294);
            this.txtKnapsack.TabIndex = 1;
            // 
            // txtItems
            // 
            this.txtItems.BackColor = System.Drawing.SystemColors.Window;
            this.txtItems.Location = new System.Drawing.Point(335, 28);
            this.txtItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItems.Multiline = true;
            this.txtItems.Name = "txtItems";
            this.txtItems.ReadOnly = true;
            this.txtItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItems.Size = new System.Drawing.Size(296, 509);
            this.txtItems.TabIndex = 2;
            this.txtItems.Text = "Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item count";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 28);
            this.txtCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(293, 22);
            this.txtCount.TabIndex = 4;
            this.txtCount.Text = "10";
            this.txtCount.TextChanged += new System.EventHandler(this.txtVerifyColor);
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(12, 74);
            this.txtCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(293, 22);
            this.txtCap.TabIndex = 6;
            this.txtCap.Text = "50";
            this.txtCap.TextChanged += new System.EventHandler(this.txtVerifyColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Knapsack size";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(12, 119);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(293, 22);
            this.txtSeed.TabIndex = 8;
            this.txtSeed.Text = "1";
            this.txtSeed.TextChanged += new System.EventHandler(this.txtVerifyColor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Knapsack";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(16, 544);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(82, 16);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.Text = "Total weight:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(331, 544);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(77, 16);
            this.lblValue.TabIndex = 12;
            this.lblValue.Text = "Total value:";
            // 
            // chckSort
            // 
            this.chckSort.AutoSize = true;
            this.chckSort.Location = new System.Drawing.Point(12, 154);
            this.chckSort.Margin = new System.Windows.Forms.Padding(4);
            this.chckSort.Name = "chckSort";
            this.chckSort.Size = new System.Drawing.Size(91, 20);
            this.chckSort.TabIndex = 14;
            this.chckSort.Text = "Solve Sort";
            this.chckSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 571);
            this.Controls.Add(this.chckSort);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.txtKnapsack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Knapsack Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKnapsack;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.CheckBox chckSort;
    }
}


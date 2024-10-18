namespace tic_tac_toe
{
    partial class Form1
    {
        private int countMoves;
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
            this.button11 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(12, 114);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(131, 133);
            this.button11.TabIndex = 1;
            this.button11.UseCompatibleTextRendering = true;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ClickCell);
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button32.Location = new System.Drawing.Point(149, 392);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(131, 133);
            this.button32.TabIndex = 2;
            this.button32.UseCompatibleTextRendering = true;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.ClickCell);
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button31.Location = new System.Drawing.Point(12, 392);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(131, 133);
            this.button31.TabIndex = 3;
            this.button31.UseCompatibleTextRendering = true;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.ClickCell);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(287, 253);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(131, 133);
            this.button23.TabIndex = 4;
            this.button23.UseCompatibleTextRendering = true;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ClickCell);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(149, 253);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(131, 133);
            this.button22.TabIndex = 5;
            this.button22.UseCompatibleTextRendering = true;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.ClickCell);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(12, 253);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(131, 133);
            this.button21.TabIndex = 6;
            this.button21.UseCompatibleTextRendering = true;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.ClickCell);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(287, 114);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(131, 133);
            this.button13.TabIndex = 7;
            this.button13.UseCompatibleTextRendering = true;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.ClickCell);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(149, 114);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(131, 133);
            this.button12.TabIndex = 8;
            this.button12.UseCompatibleTextRendering = true;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ClickCell);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button33.Location = new System.Drawing.Point(287, 392);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(131, 133);
            this.button33.TabIndex = 9;
            this.button33.UseCompatibleTextRendering = true;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.ClickCell);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 69);
            this.label1.TabIndex = 10;
            this.label1.Text = "КРЕСТИКИ-НОЛИКИ";
            // 
            // restartButton
            // 
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.Location = new System.Drawing.Point(473, 470);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(358, 55);
            this.restartButton.TabIndex = 11;
            this.restartButton.Text = "Играть заново";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.playerLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.playerLabel.Location = new System.Drawing.Point(424, 114);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(432, 272);
            this.playerLabel.TabIndex = 12;
            this.playerLabel.Text = "Игрок 1";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 582);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button11);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label playerLabel;

    }
}


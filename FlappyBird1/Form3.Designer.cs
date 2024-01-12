
namespace FlappyBird1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.playAgainBT = new System.Windows.Forms.Button();
            this.newPlayerBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(127, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score :";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.White;
            this.scoreText.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(316, 252);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(66, 25);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.BackColor = System.Drawing.Color.White;
            this.nameText.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameText.Location = new System.Drawing.Point(285, 169);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(132, 25);
            this.nameText.TabIndex = 5;
            this.nameText.Text = "Player Name";
            // 
            // playAgainBT
            // 
            this.playAgainBT.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainBT.Location = new System.Drawing.Point(594, 102);
            this.playAgainBT.Name = "playAgainBT";
            this.playAgainBT.Size = new System.Drawing.Size(139, 69);
            this.playAgainBT.TabIndex = 6;
            this.playAgainBT.Text = "PLAY AGAIN";
            this.playAgainBT.UseVisualStyleBackColor = true;
            this.playAgainBT.Click += new System.EventHandler(this.playAgainBT_Click);
            // 
            // newPlayerBT
            // 
            this.newPlayerBT.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerBT.Location = new System.Drawing.Point(539, 228);
            this.newPlayerBT.Name = "newPlayerBT";
            this.newPlayerBT.Size = new System.Drawing.Size(139, 69);
            this.newPlayerBT.TabIndex = 7;
            this.newPlayerBT.Text = "NEW PLAYER";
            this.newPlayerBT.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newPlayerBT);
            this.Controls.Add(this.playAgainBT);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Button playAgainBT;
        private System.Windows.Forms.Button newPlayerBT;
    }
}
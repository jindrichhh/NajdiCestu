﻿namespace NajdiCestu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_gamePanel = new System.Windows.Forms.Panel();
            this.panel_gameControl = new System.Windows.Forms.Panel();
            this.button_DOWN = new System.Windows.Forms.Button();
            this.button_RIGHT = new System.Windows.Forms.Button();
            this.button_LEFT = new System.Windows.Forms.Button();
            this.button_UP = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_NewGame = new System.Windows.Forms.Button();
            this.panel_gameControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_gamePanel
            // 
            this.panel_gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gamePanel.Location = new System.Drawing.Point(22, 26);
            this.panel_gamePanel.Margin = new System.Windows.Forms.Padding(6);
            this.panel_gamePanel.Name = "panel_gamePanel";
            this.panel_gamePanel.Size = new System.Drawing.Size(927, 1064);
            this.panel_gamePanel.TabIndex = 0;
            // 
            // panel_gameControl
            // 
            this.panel_gameControl.Controls.Add(this.button_DOWN);
            this.panel_gameControl.Controls.Add(this.button_RIGHT);
            this.panel_gameControl.Controls.Add(this.button_LEFT);
            this.panel_gameControl.Controls.Add(this.button_UP);
            this.panel_gameControl.Controls.Add(this.button_play);
            this.panel_gameControl.Controls.Add(this.richTextBox1);
            this.panel_gameControl.Controls.Add(this.button_NewGame);
            this.panel_gameControl.Location = new System.Drawing.Point(999, 26);
            this.panel_gameControl.Margin = new System.Windows.Forms.Padding(6);
            this.panel_gameControl.Name = "panel_gameControl";
            this.panel_gameControl.Size = new System.Drawing.Size(498, 1161);
            this.panel_gameControl.TabIndex = 1;
            // 
            // button_DOWN
            // 
            this.button_DOWN.Location = new System.Drawing.Point(191, 875);
            this.button_DOWN.Margin = new System.Windows.Forms.Padding(6);
            this.button_DOWN.Name = "button_DOWN";
            this.button_DOWN.Size = new System.Drawing.Size(139, 49);
            this.button_DOWN.TabIndex = 6;
            this.button_DOWN.Text = "DOWN";
            this.button_DOWN.UseVisualStyleBackColor = true;
            this.button_DOWN.Click += new System.EventHandler(this.button_DOWN_Click);
            // 
            // button_RIGHT
            // 
            this.button_RIGHT.Location = new System.Drawing.Point(310, 813);
            this.button_RIGHT.Margin = new System.Windows.Forms.Padding(6);
            this.button_RIGHT.Name = "button_RIGHT";
            this.button_RIGHT.Size = new System.Drawing.Size(139, 49);
            this.button_RIGHT.TabIndex = 5;
            this.button_RIGHT.Text = "RIGHT";
            this.button_RIGHT.UseVisualStyleBackColor = true;
            this.button_RIGHT.Click += new System.EventHandler(this.button_RIGHT_Click);
            // 
            // button_LEFT
            // 
            this.button_LEFT.Location = new System.Drawing.Point(69, 813);
            this.button_LEFT.Margin = new System.Windows.Forms.Padding(6);
            this.button_LEFT.Name = "button_LEFT";
            this.button_LEFT.Size = new System.Drawing.Size(139, 49);
            this.button_LEFT.TabIndex = 4;
            this.button_LEFT.Text = "LEFT";
            this.button_LEFT.UseVisualStyleBackColor = true;
            this.button_LEFT.Click += new System.EventHandler(this.button_LEFT_Click);
            // 
            // button_UP
            // 
            this.button_UP.Location = new System.Drawing.Point(191, 751);
            this.button_UP.Margin = new System.Windows.Forms.Padding(6);
            this.button_UP.Name = "button_UP";
            this.button_UP.Size = new System.Drawing.Size(139, 49);
            this.button_UP.TabIndex = 3;
            this.button_UP.Text = "UP";
            this.button_UP.UseVisualStyleBackColor = true;
            this.button_UP.Click += new System.EventHandler(this.button_UP_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(22, 1084);
            this.button_play.Margin = new System.Windows.Forms.Padding(6);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(448, 49);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 94);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(444, 471);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button_NewGame
            // 
            this.button_NewGame.Location = new System.Drawing.Point(22, 32);
            this.button_NewGame.Margin = new System.Windows.Forms.Padding(6);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(448, 49);
            this.button_NewGame.TabIndex = 0;
            this.button_NewGame.Text = "New Game";
            this.button_NewGame.UseVisualStyleBackColor = true;
            this.button_NewGame.Click += new System.EventHandler(this.button_NewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 1212);
            this.Controls.Add(this.panel_gameControl);
            this.Controls.Add(this.panel_gamePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_gameControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Panel panel_gamePanel;
        private Panel panel_gameControl;
        private Button button_DOWN;
        private Button button_RIGHT;
        private Button button_LEFT;
        private Button button_UP;
        private Button button_play;
        private RichTextBox richTextBox1;
        private Button button_NewGame;
    }
}
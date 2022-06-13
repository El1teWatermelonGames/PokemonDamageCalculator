
namespace Pokemon_Damage_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.runButton = new System.Windows.Forms.Button();
            this.critMax = new System.Windows.Forms.TextBox();
            this.critMin = new System.Windows.Forms.TextBox();
            this.NormMin = new System.Windows.Forms.TextBox();
            this.NormMax = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pkmnLevel = new System.Windows.Forms.NumericUpDown();
            this.movePower = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.defense = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.attack = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.targetEffectiveness = new System.Windows.Forms.ComboBox();
            this.wiki = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.howToUse = new System.Windows.Forms.Button();
            this.stab = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.moveEffectiveness = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkmnLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            resources.ApplyResources(this.runButton, "runButton");
            this.runButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.runButton.Name = "runButton";
            this.runButton.Tag = "run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.run_Click);
            // 
            // critMax
            // 
            resources.ApplyResources(this.critMax, "critMax");
            this.critMax.Name = "critMax";
            this.critMax.ReadOnly = true;
            this.critMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // critMin
            // 
            resources.ApplyResources(this.critMin, "critMin");
            this.critMin.Name = "critMin";
            this.critMin.ReadOnly = true;
            // 
            // NormMin
            // 
            resources.ApplyResources(this.NormMin, "NormMin");
            this.NormMin.Name = "NormMin";
            this.NormMin.ReadOnly = true;
            this.NormMin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // NormMax
            // 
            resources.ApplyResources(this.NormMax, "NormMax");
            this.NormMax.Name = "NormMax";
            this.NormMax.ReadOnly = true;
            this.NormMax.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NormMax);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.runButton);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.critMax);
            this.groupBox1.Controls.Add(this.critMin);
            this.groupBox1.Controls.Add(this.NormMin);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TabStop = false;
            // 
            // pkmnLevel
            // 
            resources.ApplyResources(this.pkmnLevel, "pkmnLevel");
            this.pkmnLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pkmnLevel.Name = "pkmnLevel";
            this.pkmnLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // movePower
            // 
            resources.ApplyResources(this.movePower, "movePower");
            this.movePower.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.movePower.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.movePower.Name = "movePower";
            this.movePower.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.movePower.ValueChanged += new System.EventHandler(this.movePower_ValueChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.TabStop = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // defense
            // 
            resources.ApplyResources(this.defense, "defense");
            this.defense.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.defense.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.defense.Name = "defense";
            this.defense.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.TabStop = false;
            // 
            // attack
            // 
            resources.ApplyResources(this.attack, "attack");
            this.attack.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.attack.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.attack.Name = "attack";
            this.attack.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.attack.ValueChanged += new System.EventHandler(this.attack_ValueChanged);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.TabStop = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.TabStop = false;
            // 
            // targetEffectiveness
            // 
            this.targetEffectiveness.FormattingEnabled = true;
            this.targetEffectiveness.Items.AddRange(new object[] {
            resources.GetString("targetEffectiveness.Items"),
            resources.GetString("targetEffectiveness.Items1"),
            resources.GetString("targetEffectiveness.Items2")});
            resources.ApplyResources(this.targetEffectiveness, "targetEffectiveness");
            this.targetEffectiveness.Name = "targetEffectiveness";
            // 
            // wiki
            // 
            resources.ApplyResources(this.wiki, "wiki");
            this.wiki.Name = "wiki";
            this.wiki.UseVisualStyleBackColor = true;
            this.wiki.Click += new System.EventHandler(this.wiki_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2")});
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.TabStop = false;
            // 
            // howToUse
            // 
            resources.ApplyResources(this.howToUse, "howToUse");
            this.howToUse.Name = "howToUse";
            this.howToUse.UseVisualStyleBackColor = true;
            // 
            // stab
            // 
            this.stab.FormattingEnabled = true;
            this.stab.Items.AddRange(new object[] {
            resources.GetString("stab.Items"),
            resources.GetString("stab.Items1"),
            resources.GetString("stab.Items2")});
            resources.ApplyResources(this.stab, "stab");
            this.stab.Name = "stab";
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.TabStop = false;
            // 
            // moveEffectiveness
            // 
            this.moveEffectiveness.FormattingEnabled = true;
            this.moveEffectiveness.Items.AddRange(new object[] {
            resources.GetString("moveEffectiveness.Items"),
            resources.GetString("moveEffectiveness.Items1"),
            resources.GetString("moveEffectiveness.Items2"),
            resources.GetString("moveEffectiveness.Items3"),
            resources.GetString("moveEffectiveness.Items4")});
            resources.ApplyResources(this.moveEffectiveness, "moveEffectiveness");
            this.moveEffectiveness.Name = "moveEffectiveness";
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.TabStop = false;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            resources.GetString("status.Items"),
            resources.GetString("status.Items1"),
            resources.GetString("status.Items2"),
            resources.GetString("status.Items3"),
            resources.GetString("status.Items4")});
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            this.status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.status);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.moveEffectiveness);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.stab);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.howToUse);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.wiki);
            this.Controls.Add(this.targetEffectiveness);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.defense);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.movePower);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pkmnLevel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkmnLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.Button runButton;
        public System.Windows.Forms.TextBox critMax;
        public System.Windows.Forms.TextBox critMin;
        public System.Windows.Forms.TextBox NormMin;
        public System.Windows.Forms.TextBox NormMax;
        public System.Windows.Forms.NumericUpDown pkmnLevel;
        public System.Windows.Forms.NumericUpDown movePower;
        public System.Windows.Forms.NumericUpDown defense;
        public System.Windows.Forms.NumericUpDown attack;
        private System.Windows.Forms.ComboBox targetEffectiveness;
        private System.Windows.Forms.Button wiki;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button howToUse;
        private System.Windows.Forms.ComboBox stab;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox moveEffectiveness;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox textBox11;
    }
}


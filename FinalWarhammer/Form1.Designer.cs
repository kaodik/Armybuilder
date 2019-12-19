namespace FinalWarhammer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label attackLabel;
            System.Windows.Forms.Label defenceLabel;
            System.Windows.Forms.Label healthLabel;
            System.Windows.Forms.Label picNameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label recuitNameLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label recuitIDLabel;
            this.attackTextBox = new System.Windows.Forms.TextBox();
            this.defenceTextBox = new System.Windows.Forms.TextBox();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.picNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.recuitNameTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddtoArmy = new System.Windows.Forms.Button();
            this.BtnViewArmy = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.recuitIDTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.recruteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            attackLabel = new System.Windows.Forms.Label();
            defenceLabel = new System.Windows.Forms.Label();
            healthLabel = new System.Windows.Forms.Label();
            picNameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            recuitNameLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            recuitIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attackLabel
            // 
            attackLabel.AutoSize = true;
            attackLabel.Location = new System.Drawing.Point(36, 100);
            attackLabel.Name = "attackLabel";
            attackLabel.Size = new System.Drawing.Size(41, 13);
            attackLabel.TabIndex = 1;
            attackLabel.Text = "Attack:";
            // 
            // defenceLabel
            // 
            defenceLabel.AutoSize = true;
            defenceLabel.Location = new System.Drawing.Point(36, 126);
            defenceLabel.Name = "defenceLabel";
            defenceLabel.Size = new System.Drawing.Size(51, 13);
            defenceLabel.TabIndex = 3;
            defenceLabel.Text = "Defence:";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new System.Drawing.Point(36, 152);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new System.Drawing.Size(41, 13);
            healthLabel.TabIndex = 5;
            healthLabel.Text = "Health:";
            // 
            // picNameLabel
            // 
            picNameLabel.AutoSize = true;
            picNameLabel.Location = new System.Drawing.Point(36, 236);
            picNameLabel.Name = "picNameLabel";
            picNameLabel.Size = new System.Drawing.Size(56, 13);
            picNameLabel.TabIndex = 7;
            picNameLabel.Text = "Pic Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(36, 74);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price:";
            // 
            // recuitNameLabel
            // 
            recuitNameLabel.AutoSize = true;
            recuitNameLabel.Location = new System.Drawing.Point(36, 46);
            recuitNameLabel.Name = "recuitNameLabel";
            recuitNameLabel.Size = new System.Drawing.Size(72, 13);
            recuitNameLabel.TabIndex = 13;
            recuitNameLabel.Text = "Recuit Name:";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new System.Drawing.Point(36, 179);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(41, 13);
            speedLabel.TabIndex = 15;
            speedLabel.Text = "Speed:";
            // 
            // recuitIDLabel
            // 
            recuitIDLabel.AutoSize = true;
            recuitIDLabel.Location = new System.Drawing.Point(36, 206);
            recuitIDLabel.Name = "recuitIDLabel";
            recuitIDLabel.Size = new System.Drawing.Size(55, 13);
            recuitIDLabel.TabIndex = 28;
            recuitIDLabel.Text = "Recuit ID:";
            // 
            // attackTextBox
            // 
            this.attackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "Attack", true));
            this.attackTextBox.Location = new System.Drawing.Point(114, 97);
            this.attackTextBox.Name = "attackTextBox";
            this.attackTextBox.Size = new System.Drawing.Size(100, 20);
            this.attackTextBox.TabIndex = 2;
            // 
            // defenceTextBox
            // 
            this.defenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "Defence", true));
            this.defenceTextBox.Location = new System.Drawing.Point(114, 123);
            this.defenceTextBox.Name = "defenceTextBox";
            this.defenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.defenceTextBox.TabIndex = 4;
            // 
            // healthTextBox
            // 
            this.healthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "Health", true));
            this.healthTextBox.Location = new System.Drawing.Point(114, 149);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(100, 20);
            this.healthTextBox.TabIndex = 6;
            // 
            // picNameTextBox
            // 
            this.picNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "PicName", true));
            this.picNameTextBox.Location = new System.Drawing.Point(114, 233);
            this.picNameTextBox.Name = "picNameTextBox";
            this.picNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.picNameTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(114, 71);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 10;
            // 
            // recuitNameTextBox
            // 
            this.recuitNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "RecuitName", true));
            this.recuitNameTextBox.Location = new System.Drawing.Point(114, 43);
            this.recuitNameTextBox.Name = "recuitNameTextBox";
            this.recuitNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.recuitNameTextBox.TabIndex = 14;
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "Speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(114, 176);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 16;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(145, 311);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(84, 37);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(248, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 37);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(338, 311);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 37);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(441, 311);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(84, 37);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(455, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 44);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(455, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 44);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(455, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 53);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(577, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 53);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddtoArmy
            // 
            this.btnAddtoArmy.Location = new System.Drawing.Point(455, 216);
            this.btnAddtoArmy.Name = "btnAddtoArmy";
            this.btnAddtoArmy.Size = new System.Drawing.Size(104, 37);
            this.btnAddtoArmy.TabIndex = 25;
            this.btnAddtoArmy.Text = "Add To Army";
            this.btnAddtoArmy.UseVisualStyleBackColor = true;
            this.btnAddtoArmy.Click += new System.EventHandler(this.btnAddtoArmy_Click);
            // 
            // BtnViewArmy
            // 
            this.BtnViewArmy.Location = new System.Drawing.Point(577, 216);
            this.BtnViewArmy.Name = "BtnViewArmy";
            this.BtnViewArmy.Size = new System.Drawing.Size(103, 37);
            this.BtnViewArmy.TabIndex = 26;
            this.BtnViewArmy.Text = "View Army";
            this.BtnViewArmy.UseVisualStyleBackColor = true;
            this.BtnViewArmy.Click += new System.EventHandler(this.BtnViewArmy_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(264, 30);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(155, 223);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 27;
            this.picBox.TabStop = false;
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(264, 259);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(155, 36);
            this.btnAddPic.TabIndex = 28;
            this.btnAddPic.Text = "Add Picture";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // recuitIDTextBox
            // 
            this.recuitIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recruteBindingSource, "RecuitID", true));
            this.recuitIDTextBox.Location = new System.Drawing.Point(114, 203);
            this.recuitIDTextBox.Name = "recuitIDTextBox";
            this.recuitIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.recuitIDTextBox.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // recruteBindingSource
            // 
            this.recruteBindingSource.DataSource = typeof(FinalWarhammer.Recrute);
            this.recruteBindingSource.CurrentChanged += new System.EventHandler(this.recruteBindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 368);
            this.Controls.Add(recuitIDLabel);
            this.Controls.Add(this.recuitIDTextBox);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.BtnViewArmy);
            this.Controls.Add(this.btnAddtoArmy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(attackLabel);
            this.Controls.Add(this.attackTextBox);
            this.Controls.Add(defenceLabel);
            this.Controls.Add(this.defenceTextBox);
            this.Controls.Add(healthLabel);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(picNameLabel);
            this.Controls.Add(this.picNameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(recuitNameLabel);
            this.Controls.Add(this.recuitNameTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Name = "Form1";
            this.Text = "Welcome To Warhammer Army Builder!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource recruteBindingSource;
        private System.Windows.Forms.TextBox attackTextBox;
        private System.Windows.Forms.TextBox defenceTextBox;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.TextBox picNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox recuitNameTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddtoArmy;
        private System.Windows.Forms.Button BtnViewArmy;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.TextBox recuitIDTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


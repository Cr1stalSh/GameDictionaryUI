namespace pitpo_kurs_UI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSectionsEnemies = new System.Windows.Forms.Button();
            this.btnSectionsArtifacts = new System.Windows.Forms.Button();
            this.btnSectionsCharacters = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMinViews = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 82);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добро пожаловать в энциклопедию \r\nпо игре Shadows of the Soul";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(715, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 29);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(36, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(673, 27);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSectionsEnemies
            // 
            this.btnSectionsEnemies.Location = new System.Drawing.Point(36, 357);
            this.btnSectionsEnemies.Name = "btnSectionsEnemies";
            this.btnSectionsEnemies.Size = new System.Drawing.Size(116, 79);
            this.btnSectionsEnemies.TabIndex = 9;
            this.btnSectionsEnemies.Text = "Враги";
            this.btnSectionsEnemies.UseVisualStyleBackColor = true;
            // 
            // btnSectionsArtifacts
            // 
            this.btnSectionsArtifacts.Location = new System.Drawing.Point(36, 277);
            this.btnSectionsArtifacts.Name = "btnSectionsArtifacts";
            this.btnSectionsArtifacts.Size = new System.Drawing.Size(116, 74);
            this.btnSectionsArtifacts.TabIndex = 8;
            this.btnSectionsArtifacts.Text = "Артефакты";
            this.btnSectionsArtifacts.UseVisualStyleBackColor = true;
            // 
            // btnSectionsCharacters
            // 
            this.btnSectionsCharacters.Location = new System.Drawing.Point(36, 197);
            this.btnSectionsCharacters.Name = "btnSectionsCharacters";
            this.btnSectionsCharacters.Size = new System.Drawing.Size(116, 74);
            this.btnSectionsCharacters.TabIndex = 7;
            this.btnSectionsCharacters.Text = "Персонажи";
            this.btnSectionsCharacters.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(219, 197);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(344, 104);
            this.lstResults.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(569, 206);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 272);
            this.txtDescription.TabIndex = 15;
            // 
            // txtMinViews
            // 
            this.txtMinViews.Location = new System.Drawing.Point(36, 102);
            this.txtMinViews.Name = "txtMinViews";
            this.txtMinViews.Size = new System.Drawing.Size(125, 27);
            this.txtMinViews.TabIndex = 16;
            this.txtMinViews.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Количество просмотров";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinViews);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSectionsEnemies);
            this.Controls.Add(this.btnSectionsArtifacts);
            this.Controls.Add(this.btnSectionsCharacters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSectionsEnemies;
        private System.Windows.Forms.Button btnSectionsArtifacts;
        private System.Windows.Forms.Button btnSectionsCharacters;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtMinViews;
        private System.Windows.Forms.Label label2;
    }
}

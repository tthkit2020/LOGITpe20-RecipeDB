namespace RecipeDB
{
    partial class CookBook
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
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listIngredient = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe";
            // 
            // listRecipe
            // 
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.Location = new System.Drawing.Point(50, 63);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(116, 134);
            this.listRecipe.TabIndex = 1;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listRecipe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingredients";
            // 
            // listIngredient
            // 
            this.listIngredient.FormattingEnabled = true;
            this.listIngredient.Location = new System.Drawing.Point(234, 63);
            this.listIngredient.Name = "listIngredient";
            this.listIngredient.Size = new System.Drawing.Size(120, 134);
            this.listIngredient.TabIndex = 3;
            // 
            // CookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listIngredient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRecipe);
            this.Controls.Add(this.label1);
            this.Name = "CookBook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CookBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRecipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listIngredient;
    }
}


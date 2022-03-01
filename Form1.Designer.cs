
namespace IG_explore_downloader
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.postCountNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hashtagDownloadBtn = new System.Windows.Forms.Button();
            this.profileDownloadBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.hashtagTxtBox = new System.Windows.Forms.TextBox();
            this.profileTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.downloadPost = new System.Windows.Forms.Button();
            this.videoRadioBtn = new System.Windows.Forms.RadioButton();
            this.imageRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.urlDownloadTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.postCountNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(259, 156);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 72);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Explore Download";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(6, 25);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(235, 26);
            this.usernameTxtBox.TabIndex = 1;
            this.usernameTxtBox.Text = "username";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(6, 57);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = 'x';
            this.passwordTxtBox.Size = new System.Drawing.Size(235, 26);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.Text = "password";
            // 
            // postCountNum
            // 
            this.postCountNum.Location = new System.Drawing.Point(121, 89);
            this.postCountNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.postCountNum.Name = "postCountNum";
            this.postCountNum.Size = new System.Drawing.Size(120, 26);
            this.postCountNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Post Count";
            // 
            // console
            // 
            this.console.FormattingEnabled = true;
            this.console.ItemHeight = 20;
            this.console.Location = new System.Drawing.Point(18, 234);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(593, 444);
            this.console.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernameTxtBox);
            this.groupBox1.Controls.Add(this.passwordTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.postCountNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Property";
            // 
            // hashtagDownloadBtn
            // 
            this.hashtagDownloadBtn.Location = new System.Drawing.Point(18, 187);
            this.hashtagDownloadBtn.Name = "hashtagDownloadBtn";
            this.hashtagDownloadBtn.Size = new System.Drawing.Size(235, 41);
            this.hashtagDownloadBtn.TabIndex = 9;
            this.hashtagDownloadBtn.Text = "Hashtag Download";
            this.hashtagDownloadBtn.UseVisualStyleBackColor = true;
            this.hashtagDownloadBtn.Click += new System.EventHandler(this.hashtagDownloadBtn_Click);
            // 
            // profileDownloadBtn
            // 
            this.profileDownloadBtn.Location = new System.Drawing.Point(365, 187);
            this.profileDownloadBtn.Name = "profileDownloadBtn";
            this.profileDownloadBtn.Size = new System.Drawing.Size(235, 41);
            this.profileDownloadBtn.TabIndex = 10;
            this.profileDownloadBtn.Text = "Profile Download";
            this.profileDownloadBtn.UseVisualStyleBackColor = true;
            this.profileDownloadBtn.Click += new System.EventHandler(this.profileDownloadBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 684);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(593, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // hashtagTxtBox
            // 
            this.hashtagTxtBox.Location = new System.Drawing.Point(18, 155);
            this.hashtagTxtBox.Name = "hashtagTxtBox";
            this.hashtagTxtBox.Size = new System.Drawing.Size(235, 26);
            this.hashtagTxtBox.TabIndex = 12;
            this.hashtagTxtBox.Text = "Hashtag";
            // 
            // profileTxtBox
            // 
            this.profileTxtBox.Location = new System.Drawing.Point(365, 155);
            this.profileTxtBox.Name = "profileTxtBox";
            this.profileTxtBox.Size = new System.Drawing.Size(235, 26);
            this.profileTxtBox.TabIndex = 13;
            this.profileTxtBox.Text = "Profile Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.downloadPost);
            this.groupBox2.Controls.Add(this.videoRadioBtn);
            this.groupBox2.Controls.Add(this.imageRadioBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.urlDownloadTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(270, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 137);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post Download";
            // 
            // downloadPost
            // 
            this.downloadPost.Location = new System.Drawing.Point(97, 57);
            this.downloadPost.Name = "downloadPost";
            this.downloadPost.Size = new System.Drawing.Size(228, 54);
            this.downloadPost.TabIndex = 4;
            this.downloadPost.Text = "Download";
            this.downloadPost.UseVisualStyleBackColor = true;
            this.downloadPost.Click += new System.EventHandler(this.downloadPost_Click);
            // 
            // videoRadioBtn
            // 
            this.videoRadioBtn.AutoSize = true;
            this.videoRadioBtn.Location = new System.Drawing.Point(12, 87);
            this.videoRadioBtn.Name = "videoRadioBtn";
            this.videoRadioBtn.Size = new System.Drawing.Size(75, 24);
            this.videoRadioBtn.TabIndex = 3;
            this.videoRadioBtn.TabStop = true;
            this.videoRadioBtn.Text = "Video";
            this.videoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // imageRadioBtn
            // 
            this.imageRadioBtn.AutoSize = true;
            this.imageRadioBtn.Location = new System.Drawing.Point(12, 57);
            this.imageRadioBtn.Name = "imageRadioBtn";
            this.imageRadioBtn.Size = new System.Drawing.Size(79, 24);
            this.imageRadioBtn.TabIndex = 2;
            this.imageRadioBtn.TabStop = true;
            this.imageRadioBtn.Text = "Image";
            this.imageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            // 
            // urlDownloadTxtBox
            // 
            this.urlDownloadTxtBox.Location = new System.Drawing.Point(65, 25);
            this.urlDownloadTxtBox.Name = "urlDownloadTxtBox";
            this.urlDownloadTxtBox.Size = new System.Drawing.Size(270, 26);
            this.urlDownloadTxtBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.profileTxtBox);
            this.Controls.Add(this.hashtagTxtBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.profileDownloadBtn);
            this.Controls.Add(this.hashtagDownloadBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Post Scrapper By redlfie21";
            ((System.ComponentModel.ISupportInitialize)(this.postCountNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.NumericUpDown postCountNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox console;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hashtagDownloadBtn;
        private System.Windows.Forms.Button profileDownloadBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox hashtagTxtBox;
        private System.Windows.Forms.TextBox profileTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urlDownloadTxtBox;
        private System.Windows.Forms.Button downloadPost;
        private System.Windows.Forms.RadioButton videoRadioBtn;
        private System.Windows.Forms.RadioButton imageRadioBtn;
        private System.Windows.Forms.Label label2;
    }
}


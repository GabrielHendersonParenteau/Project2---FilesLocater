namespace Project2___FilesLocater
{
    partial class MainForm
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
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.selectedDirectoryLabel = new System.Windows.Forms.Label();
            this.numberOfFilesInDirectory = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.dateModificationLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.dateModificationCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.sizeCheckBox = new System.Windows.Forms.CheckBox();
            this.nameAndExtensionLabel = new System.Windows.Forms.Label();
            this.creationDateAndTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modificationsDateAndTimeLabel = new System.Windows.Forms.Label();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.imageVResolutionTextBox = new System.Windows.Forms.TextBox();
            this.audioBitRateTextBox = new System.Windows.Forms.TextBox();
            this.audioArtistTextBox = new System.Windows.Forms.TextBox();
            this.videoProducerTextBox = new System.Windows.Forms.TextBox();
            this.videoDirectorTextBox = new System.Windows.Forms.TextBox();
            this.mediaRatingTextBox = new System.Windows.Forms.TextBox();
            this.mediaLengthTextBox = new System.Windows.Forms.TextBox();
            this.mediaTitleTextBox = new System.Windows.Forms.TextBox();
            this.documentSubjectTextBox = new System.Windows.Forms.TextBox();
            this.documentWordsTextBox = new System.Windows.Forms.TextBox();
            this.documentPagesTextBox = new System.Windows.Forms.TextBox();
            this.bitRateLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.vResolutionLabel = new System.Windows.Forms.Label();
            this.hResolutionLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.docSubjectLabel = new System.Windows.Forms.Label();
            this.numberOfWordsLabel = new System.Windows.Forms.Label();
            this.numberOfPagesLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.propertiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // directoryListBox
            // 
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.ItemHeight = 16;
            this.directoryListBox.Location = new System.Drawing.Point(12, 48);
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.ScrollAlwaysVisible = true;
            this.directoryListBox.Size = new System.Drawing.Size(133, 452);
            this.directoryListBox.TabIndex = 0;
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 16;
            this.filesListBox.Location = new System.Drawing.Point(151, 77);
            this.filesListBox.MultiColumn = true;
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(717, 276);
            this.filesListBox.TabIndex = 1;
            // 
            // selectedDirectoryLabel
            // 
            this.selectedDirectoryLabel.Location = new System.Drawing.Point(12, 9);
            this.selectedDirectoryLabel.Name = "selectedDirectoryLabel";
            this.selectedDirectoryLabel.Size = new System.Drawing.Size(133, 26);
            this.selectedDirectoryLabel.TabIndex = 3;
            this.selectedDirectoryLabel.Text = "*DirectoryName*";
            this.selectedDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfFilesInDirectory
            // 
            this.numberOfFilesInDirectory.Location = new System.Drawing.Point(9, 503);
            this.numberOfFilesInDirectory.Name = "numberOfFilesInDirectory";
            this.numberOfFilesInDirectory.Size = new System.Drawing.Size(133, 31);
            this.numberOfFilesInDirectory.TabIndex = 4;
            this.numberOfFilesInDirectory.Text = "*#FilesInDirectory*";
            this.numberOfFilesInDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(151, 57);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(45, 17);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "Name";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(604, 57);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(40, 17);
            this.fileTypeLabel.TabIndex = 6;
            this.fileTypeLabel.Text = "Type";
            // 
            // dateModificationLabel
            // 
            this.dateModificationLabel.AutoSize = true;
            this.dateModificationLabel.Location = new System.Drawing.Point(370, 57);
            this.dateModificationLabel.Name = "dateModificationLabel";
            this.dateModificationLabel.Size = new System.Drawing.Size(117, 17);
            this.dateModificationLabel.TabIndex = 7;
            this.dateModificationLabel.Text = "Date Modification";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(774, 57);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(35, 17);
            this.sizeLabel.TabIndex = 8;
            this.sizeLabel.Text = "Size";
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(202, 58);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(18, 17);
            this.nameCheckBox.TabIndex = 9;
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateModificationCheckBox
            // 
            this.dateModificationCheckBox.AutoSize = true;
            this.dateModificationCheckBox.Location = new System.Drawing.Point(493, 58);
            this.dateModificationCheckBox.Name = "dateModificationCheckBox";
            this.dateModificationCheckBox.Size = new System.Drawing.Size(18, 17);
            this.dateModificationCheckBox.TabIndex = 10;
            this.dateModificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Location = new System.Drawing.Point(650, 58);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(18, 17);
            this.typeCheckBox.TabIndex = 11;
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // sizeCheckBox
            // 
            this.sizeCheckBox.AutoSize = true;
            this.sizeCheckBox.Location = new System.Drawing.Point(815, 58);
            this.sizeCheckBox.Name = "sizeCheckBox";
            this.sizeCheckBox.Size = new System.Drawing.Size(18, 17);
            this.sizeCheckBox.TabIndex = 12;
            this.sizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameAndExtensionLabel
            // 
            this.nameAndExtensionLabel.AutoSize = true;
            this.nameAndExtensionLabel.Location = new System.Drawing.Point(17, 32);
            this.nameAndExtensionLabel.Name = "nameAndExtensionLabel";
            this.nameAndExtensionLabel.Size = new System.Drawing.Size(141, 17);
            this.nameAndExtensionLabel.TabIndex = 13;
            this.nameAndExtensionLabel.Text = "Name with extension:";
            // 
            // creationDateAndTimeLabel
            // 
            this.creationDateAndTimeLabel.AutoSize = true;
            this.creationDateAndTimeLabel.Location = new System.Drawing.Point(17, 107);
            this.creationDateAndTimeLabel.Name = "creationDateAndTimeLabel";
            this.creationDateAndTimeLabel.Size = new System.Drawing.Size(134, 17);
            this.creationDateAndTimeLabel.TabIndex = 14;
            this.creationDateAndTimeLabel.Text = "Creation Date/Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "File Size:";
            // 
            // modificationsDateAndTimeLabel
            // 
            this.modificationsDateAndTimeLabel.AutoSize = true;
            this.modificationsDateAndTimeLabel.Location = new System.Drawing.Point(17, 146);
            this.modificationsDateAndTimeLabel.Name = "modificationsDateAndTimeLabel";
            this.modificationsDateAndTimeLabel.Size = new System.Drawing.Size(163, 17);
            this.modificationsDateAndTimeLabel.TabIndex = 16;
            this.modificationsDateAndTimeLabel.Text = "Modifications Date/Time:";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Controls.Add(this.imageVResolutionTextBox);
            this.propertiesGroupBox.Controls.Add(this.audioBitRateTextBox);
            this.propertiesGroupBox.Controls.Add(this.audioArtistTextBox);
            this.propertiesGroupBox.Controls.Add(this.videoProducerTextBox);
            this.propertiesGroupBox.Controls.Add(this.videoDirectorTextBox);
            this.propertiesGroupBox.Controls.Add(this.mediaRatingTextBox);
            this.propertiesGroupBox.Controls.Add(this.mediaLengthTextBox);
            this.propertiesGroupBox.Controls.Add(this.mediaTitleTextBox);
            this.propertiesGroupBox.Controls.Add(this.documentSubjectTextBox);
            this.propertiesGroupBox.Controls.Add(this.documentWordsTextBox);
            this.propertiesGroupBox.Controls.Add(this.documentPagesTextBox);
            this.propertiesGroupBox.Controls.Add(this.bitRateLabel);
            this.propertiesGroupBox.Controls.Add(this.artistLabel);
            this.propertiesGroupBox.Controls.Add(this.producerLabel);
            this.propertiesGroupBox.Controls.Add(this.directorLabel);
            this.propertiesGroupBox.Controls.Add(this.ratingLabel);
            this.propertiesGroupBox.Controls.Add(this.lengthLabel);
            this.propertiesGroupBox.Controls.Add(this.titleLabel);
            this.propertiesGroupBox.Controls.Add(this.vResolutionLabel);
            this.propertiesGroupBox.Controls.Add(this.hResolutionLabel);
            this.propertiesGroupBox.Controls.Add(this.HeightLabel);
            this.propertiesGroupBox.Controls.Add(this.widthLabel);
            this.propertiesGroupBox.Controls.Add(this.docSubjectLabel);
            this.propertiesGroupBox.Controls.Add(this.numberOfWordsLabel);
            this.propertiesGroupBox.Controls.Add(this.numberOfPagesLabel);
            this.propertiesGroupBox.Controls.Add(this.commentsTextBox);
            this.propertiesGroupBox.Controls.Add(this.commentsLabel);
            this.propertiesGroupBox.Controls.Add(this.nameAndExtensionLabel);
            this.propertiesGroupBox.Controls.Add(this.modificationsDateAndTimeLabel);
            this.propertiesGroupBox.Controls.Add(this.creationDateAndTimeLabel);
            this.propertiesGroupBox.Controls.Add(this.label1);
            this.propertiesGroupBox.Location = new System.Drawing.Point(154, 359);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(714, 244);
            this.propertiesGroupBox.TabIndex = 17;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // imageVResolutionTextBox
            // 
            this.imageVResolutionTextBox.Location = new System.Drawing.Point(477, 139);
            this.imageVResolutionTextBox.Name = "imageVResolutionTextBox";
            this.imageVResolutionTextBox.ReadOnly = true;
            this.imageVResolutionTextBox.Size = new System.Drawing.Size(214, 22);
            this.imageVResolutionTextBox.TabIndex = 36;
            // 
            // audioBitRateTextBox
            // 
            this.audioBitRateTextBox.Location = new System.Drawing.Point(502, 70);
            this.audioBitRateTextBox.Name = "audioBitRateTextBox";
            this.audioBitRateTextBox.ReadOnly = true;
            this.audioBitRateTextBox.Size = new System.Drawing.Size(190, 22);
            this.audioBitRateTextBox.TabIndex = 35;
            // 
            // audioArtistTextBox
            // 
            this.audioArtistTextBox.Location = new System.Drawing.Point(501, 32);
            this.audioArtistTextBox.Name = "audioArtistTextBox";
            this.audioArtistTextBox.ReadOnly = true;
            this.audioArtistTextBox.Size = new System.Drawing.Size(190, 22);
            this.audioArtistTextBox.TabIndex = 34;
            // 
            // videoProducerTextBox
            // 
            this.videoProducerTextBox.Location = new System.Drawing.Point(502, 70);
            this.videoProducerTextBox.Name = "videoProducerTextBox";
            this.videoProducerTextBox.ReadOnly = true;
            this.videoProducerTextBox.Size = new System.Drawing.Size(190, 22);
            this.videoProducerTextBox.TabIndex = 33;
            // 
            // videoDirectorTextBox
            // 
            this.videoDirectorTextBox.Location = new System.Drawing.Point(501, 32);
            this.videoDirectorTextBox.Name = "videoDirectorTextBox";
            this.videoDirectorTextBox.ReadOnly = true;
            this.videoDirectorTextBox.Size = new System.Drawing.Size(190, 22);
            this.videoDirectorTextBox.TabIndex = 32;
            // 
            // mediaRatingTextBox
            // 
            this.mediaRatingTextBox.Location = new System.Drawing.Point(477, 107);
            this.mediaRatingTextBox.Name = "mediaRatingTextBox";
            this.mediaRatingTextBox.ReadOnly = true;
            this.mediaRatingTextBox.Size = new System.Drawing.Size(214, 22);
            this.mediaRatingTextBox.TabIndex = 31;
            // 
            // mediaLengthTextBox
            // 
            this.mediaLengthTextBox.Location = new System.Drawing.Point(502, 70);
            this.mediaLengthTextBox.Name = "mediaLengthTextBox";
            this.mediaLengthTextBox.ReadOnly = true;
            this.mediaLengthTextBox.Size = new System.Drawing.Size(190, 22);
            this.mediaLengthTextBox.TabIndex = 29;
            // 
            // mediaTitleTextBox
            // 
            this.mediaTitleTextBox.Location = new System.Drawing.Point(501, 32);
            this.mediaTitleTextBox.Name = "mediaTitleTextBox";
            this.mediaTitleTextBox.ReadOnly = true;
            this.mediaTitleTextBox.Size = new System.Drawing.Size(190, 22);
            this.mediaTitleTextBox.TabIndex = 30;
            // 
            // documentSubjectTextBox
            // 
            this.documentSubjectTextBox.Location = new System.Drawing.Point(477, 107);
            this.documentSubjectTextBox.Name = "documentSubjectTextBox";
            this.documentSubjectTextBox.ReadOnly = true;
            this.documentSubjectTextBox.Size = new System.Drawing.Size(214, 22);
            this.documentSubjectTextBox.TabIndex = 29;
            // 
            // documentWordsTextBox
            // 
            this.documentWordsTextBox.Location = new System.Drawing.Point(502, 70);
            this.documentWordsTextBox.Name = "documentWordsTextBox";
            this.documentWordsTextBox.ReadOnly = true;
            this.documentWordsTextBox.Size = new System.Drawing.Size(190, 22);
            this.documentWordsTextBox.TabIndex = 28;
            // 
            // documentPagesTextBox
            // 
            this.documentPagesTextBox.Location = new System.Drawing.Point(501, 32);
            this.documentPagesTextBox.Name = "documentPagesTextBox";
            this.documentPagesTextBox.ReadOnly = true;
            this.documentPagesTextBox.Size = new System.Drawing.Size(190, 22);
            this.documentPagesTextBox.TabIndex = 27;
            // 
            // bitRateLabel
            // 
            this.bitRateLabel.AutoSize = true;
            this.bitRateLabel.Location = new System.Drawing.Point(374, 70);
            this.bitRateLabel.Name = "bitRateLabel";
            this.bitRateLabel.Size = new System.Drawing.Size(58, 17);
            this.bitRateLabel.TabIndex = 23;
            this.bitRateLabel.Text = "BitRate:";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(374, 32);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(44, 17);
            this.artistLabel.TabIndex = 23;
            this.artistLabel.Text = "Artist:";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Location = new System.Drawing.Point(373, 70);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(70, 17);
            this.producerLabel.TabIndex = 23;
            this.producerLabel.Text = "Producer:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(373, 32);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(62, 17);
            this.directorLabel.TabIndex = 23;
            this.directorLabel.Text = "Director:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(374, 107);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingLabel.TabIndex = 23;
            this.ratingLabel.Text = "Rating:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(373, 70);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 23;
            this.lengthLabel.Text = "Length:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(374, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 26;
            this.titleLabel.Text = "Title:";
            // 
            // vResolutionLabel
            // 
            this.vResolutionLabel.AutoSize = true;
            this.vResolutionLabel.Location = new System.Drawing.Point(374, 144);
            this.vResolutionLabel.Name = "vResolutionLabel";
            this.vResolutionLabel.Size = new System.Drawing.Size(96, 17);
            this.vResolutionLabel.TabIndex = 25;
            this.vResolutionLabel.Text = "V. Resolution:";
            // 
            // hResolutionLabel
            // 
            this.hResolutionLabel.AutoSize = true;
            this.hResolutionLabel.Location = new System.Drawing.Point(374, 107);
            this.hResolutionLabel.Name = "hResolutionLabel";
            this.hResolutionLabel.Size = new System.Drawing.Size(97, 17);
            this.hResolutionLabel.TabIndex = 24;
            this.hResolutionLabel.Text = "H. Resolution:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(373, 70);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(53, 17);
            this.HeightLabel.TabIndex = 23;
            this.HeightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(374, 32);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 22;
            this.widthLabel.Text = "Width:";
            // 
            // docSubjectLabel
            // 
            this.docSubjectLabel.AutoSize = true;
            this.docSubjectLabel.Location = new System.Drawing.Point(373, 107);
            this.docSubjectLabel.Name = "docSubjectLabel";
            this.docSubjectLabel.Size = new System.Drawing.Size(88, 17);
            this.docSubjectLabel.TabIndex = 21;
            this.docSubjectLabel.Text = "Doc Subject:";
            // 
            // numberOfWordsLabel
            // 
            this.numberOfWordsLabel.AutoSize = true;
            this.numberOfWordsLabel.Location = new System.Drawing.Point(373, 70);
            this.numberOfWordsLabel.Name = "numberOfWordsLabel";
            this.numberOfWordsLabel.Size = new System.Drawing.Size(123, 17);
            this.numberOfWordsLabel.TabIndex = 20;
            this.numberOfWordsLabel.Text = "Number of Words:";
            // 
            // numberOfPagesLabel
            // 
            this.numberOfPagesLabel.AutoSize = true;
            this.numberOfPagesLabel.Location = new System.Drawing.Point(373, 32);
            this.numberOfPagesLabel.Name = "numberOfPagesLabel";
            this.numberOfPagesLabel.Size = new System.Drawing.Size(122, 17);
            this.numberOfPagesLabel.TabIndex = 19;
            this.numberOfPagesLabel.Text = "Number of Pages:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(20, 200);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.Size = new System.Drawing.Size(304, 22);
            this.commentsTextBox.TabIndex = 18;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(17, 180);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(78, 17);
            this.commentsLabel.TabIndex = 17;
            this.commentsLabel.Text = "Comments:";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(396, 609);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(138, 34);
            this.modifyButton.TabIndex = 18;
            this.modifyButton.Text = "Modify Properties";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.propertiesGroupBox);
            this.Controls.Add(this.sizeCheckBox);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(this.dateModificationCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.dateModificationLabel);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.numberOfFilesInDirectory);
            this.Controls.Add(this.selectedDirectoryLabel);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.directoryListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox directoryListBox;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label selectedDirectoryLabel;
        private System.Windows.Forms.Label numberOfFilesInDirectory;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.Label dateModificationLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.CheckBox dateModificationCheckBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox sizeCheckBox;
        private System.Windows.Forms.Label nameAndExtensionLabel;
        private System.Windows.Forms.Label creationDateAndTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modificationsDateAndTimeLabel;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label docSubjectLabel;
        private System.Windows.Forms.Label numberOfWordsLabel;
        private System.Windows.Forms.Label numberOfPagesLabel;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hResolutionLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox imageVResolutionTextBox;
        private System.Windows.Forms.TextBox audioBitRateTextBox;
        private System.Windows.Forms.TextBox audioArtistTextBox;
        private System.Windows.Forms.TextBox videoProducerTextBox;
        private System.Windows.Forms.TextBox videoDirectorTextBox;
        private System.Windows.Forms.TextBox mediaRatingTextBox;
        private System.Windows.Forms.TextBox mediaLengthTextBox;
        private System.Windows.Forms.TextBox mediaTitleTextBox;
        private System.Windows.Forms.TextBox documentSubjectTextBox;
        private System.Windows.Forms.TextBox documentWordsTextBox;
        private System.Windows.Forms.TextBox documentPagesTextBox;
        private System.Windows.Forms.Label bitRateLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label vResolutionLabel;
    }
}


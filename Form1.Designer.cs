namespace BS_Notatnik
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
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikNowy = new System.Windows.Forms.ToolStripMenuItem();
            this.plikNoweOkno = new System.Windows.Forms.ToolStripMenuItem();
            this.plikOtworz = new System.Windows.Forms.ToolStripMenuItem();
            this.plikZapisz = new System.Windows.Forms.ToolStripMenuItem();
            this.plikZapiszJako = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.plikUstawieniaStrony = new System.Windows.Forms.ToolStripMenuItem();
            this.plikDrukuj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.plikZakoncz = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaCofnij = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.edycjaWytnij = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaKopiuj = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaWklej = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaUsun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.edycjaWyszukaj = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaZnajdz = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaZnajdzNastepny = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaZnajdzPoprzednie = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaZamien = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaPrzejdzDo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.edycjaZaznaczWszystko = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaGodzinaData = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatZawijanieWierszy = new System.Windows.Forms.ToolStripMenuItem();
            this.formatCzcionka = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokPowiekszenie = new System.Windows.Forms.ToolStripMenuItem();
            this.widokPowiekszeniePowieksz = new System.Windows.Forms.ToolStripMenuItem();
            this.widokPowiekszeniePomniejsz = new System.Windows.Forms.ToolStripMenuItem();
            this.widokPowiekszeniePrzywroc = new System.Windows.Forms.ToolStripMenuItem();
            this.widokPasekStanu = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opmocWyswietlPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocWyslijOpinie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.pomocInformacje = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openedFile = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikNowy,
            this.plikNoweOkno,
            this.plikOtworz,
            this.plikZapisz,
            this.plikZapiszJako,
            this.toolStripMenuItem1,
            this.plikUstawieniaStrony,
            this.plikDrukuj,
            this.toolStripMenuItem2,
            this.plikZakoncz});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // plikNowy
            // 
            this.plikNowy.Name = "plikNowy";
            this.plikNowy.Size = new System.Drawing.Size(215, 22);
            this.plikNowy.Text = "Nowy   Ctrl+N";
            this.plikNowy.Click += new System.EventHandler(this.plikNowy_Click);
            // 
            // plikNoweOkno
            // 
            this.plikNoweOkno.Name = "plikNoweOkno";
            this.plikNoweOkno.Size = new System.Drawing.Size(215, 22);
            this.plikNoweOkno.Text = "Nowe okno   Ctrl+Shift+N";
            this.plikNoweOkno.Click += new System.EventHandler(this.plikNoweOkno_Click);
            // 
            // plikOtworz
            // 
            this.plikOtworz.Name = "plikOtworz";
            this.plikOtworz.Size = new System.Drawing.Size(215, 22);
            this.plikOtworz.Text = "Otwórz...   Ctrl+O";
            this.plikOtworz.Click += new System.EventHandler(this.plikOtworz_Click);
            // 
            // plikZapisz
            // 
            this.plikZapisz.Name = "plikZapisz";
            this.plikZapisz.Size = new System.Drawing.Size(215, 22);
            this.plikZapisz.Text = "Zapisz   Ctrl+S";
            this.plikZapisz.Click += new System.EventHandler(this.plikZapisz_Click);
            // 
            // plikZapiszJako
            // 
            this.plikZapiszJako.Name = "plikZapiszJako";
            this.plikZapiszJako.Size = new System.Drawing.Size(215, 22);
            this.plikZapiszJako.Text = "Zapisz jako...   Ctrl+Shift+S";
            this.plikZapiszJako.Click += new System.EventHandler(this.plikZapiszJako_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // plikUstawieniaStrony
            // 
            this.plikUstawieniaStrony.BackColor = System.Drawing.Color.Red;
            this.plikUstawieniaStrony.Name = "plikUstawieniaStrony";
            this.plikUstawieniaStrony.Size = new System.Drawing.Size(215, 22);
            this.plikUstawieniaStrony.Text = "Ustawienia strony...";
            // 
            // plikDrukuj
            // 
            this.plikDrukuj.BackColor = System.Drawing.Color.Red;
            this.plikDrukuj.Name = "plikDrukuj";
            this.plikDrukuj.Size = new System.Drawing.Size(215, 22);
            this.plikDrukuj.Text = "Drukuj...   Ctrl+P";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 6);
            // 
            // plikZakoncz
            // 
            this.plikZakoncz.Name = "plikZakoncz";
            this.plikZakoncz.Size = new System.Drawing.Size(215, 22);
            this.plikZakoncz.Text = "Zakończ";
            this.plikZakoncz.Click += new System.EventHandler(this.plikZakoncz_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edycjaCofnij,
            this.toolStripMenuItem3,
            this.edycjaWytnij,
            this.edycjaKopiuj,
            this.edycjaWklej,
            this.edycjaUsun,
            this.toolStripMenuItem4,
            this.edycjaWyszukaj,
            this.edycjaZnajdz,
            this.edycjaZnajdzNastepny,
            this.edycjaZnajdzPoprzednie,
            this.edycjaZamien,
            this.edycjaPrzejdzDo,
            this.toolStripMenuItem5,
            this.edycjaZaznaczWszystko,
            this.edycjaGodzinaData});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // edycjaCofnij
            // 
            this.edycjaCofnij.BackColor = System.Drawing.Color.Red;
            this.edycjaCofnij.Name = "edycjaCofnij";
            this.edycjaCofnij.Size = new System.Drawing.Size(297, 22);
            this.edycjaCofnij.Text = "Cofnij   Ctrl+Z";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(294, 6);
            // 
            // edycjaWytnij
            // 
            this.edycjaWytnij.BackColor = System.Drawing.SystemColors.Control;
            this.edycjaWytnij.Name = "edycjaWytnij";
            this.edycjaWytnij.Size = new System.Drawing.Size(297, 22);
            this.edycjaWytnij.Text = "Wytnij   Ctrl+X";
            this.edycjaWytnij.Click += new System.EventHandler(this.edycjaWytnij_Click);
            // 
            // edycjaKopiuj
            // 
            this.edycjaKopiuj.BackColor = System.Drawing.SystemColors.Control;
            this.edycjaKopiuj.Name = "edycjaKopiuj";
            this.edycjaKopiuj.Size = new System.Drawing.Size(297, 22);
            this.edycjaKopiuj.Text = "Kopiuj   Ctrl+C";
            this.edycjaKopiuj.Click += new System.EventHandler(this.edycjaKopiuj_Click);
            // 
            // edycjaWklej
            // 
            this.edycjaWklej.BackColor = System.Drawing.SystemColors.Control;
            this.edycjaWklej.Name = "edycjaWklej";
            this.edycjaWklej.Size = new System.Drawing.Size(297, 22);
            this.edycjaWklej.Text = "Wklej   Ctrl+V";
            this.edycjaWklej.Click += new System.EventHandler(this.edycjaWklej_Click);
            // 
            // edycjaUsun
            // 
            this.edycjaUsun.BackColor = System.Drawing.SystemColors.Control;
            this.edycjaUsun.Name = "edycjaUsun";
            this.edycjaUsun.Size = new System.Drawing.Size(297, 22);
            this.edycjaUsun.Text = "Usuń   Del";
            this.edycjaUsun.Click += new System.EventHandler(this.edycjaUsun_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(294, 6);
            // 
            // edycjaWyszukaj
            // 
            this.edycjaWyszukaj.BackColor = System.Drawing.Color.Red;
            this.edycjaWyszukaj.Name = "edycjaWyszukaj";
            this.edycjaWyszukaj.Size = new System.Drawing.Size(297, 22);
            this.edycjaWyszukaj.Text = "Wyszukaj za pomocą usługi Bing...   Ctrl+E";
            // 
            // edycjaZnajdz
            // 
            this.edycjaZnajdz.BackColor = System.Drawing.Color.Red;
            this.edycjaZnajdz.Name = "edycjaZnajdz";
            this.edycjaZnajdz.Size = new System.Drawing.Size(297, 22);
            this.edycjaZnajdz.Text = "Znajdź...   Ctrl+F";
            // 
            // edycjaZnajdzNastepny
            // 
            this.edycjaZnajdzNastepny.BackColor = System.Drawing.Color.Red;
            this.edycjaZnajdzNastepny.Name = "edycjaZnajdzNastepny";
            this.edycjaZnajdzNastepny.Size = new System.Drawing.Size(297, 22);
            this.edycjaZnajdzNastepny.Text = "Znajdź następny   F3";
            // 
            // edycjaZnajdzPoprzednie
            // 
            this.edycjaZnajdzPoprzednie.BackColor = System.Drawing.Color.Red;
            this.edycjaZnajdzPoprzednie.Name = "edycjaZnajdzPoprzednie";
            this.edycjaZnajdzPoprzednie.Size = new System.Drawing.Size(297, 22);
            this.edycjaZnajdzPoprzednie.Text = "Znajdź poprzednie   Shift+F3";
            // 
            // edycjaZamien
            // 
            this.edycjaZamien.BackColor = System.Drawing.Color.Red;
            this.edycjaZamien.Name = "edycjaZamien";
            this.edycjaZamien.Size = new System.Drawing.Size(297, 22);
            this.edycjaZamien.Text = "Zamień...   Ctrl+H";
            // 
            // edycjaPrzejdzDo
            // 
            this.edycjaPrzejdzDo.BackColor = System.Drawing.Color.Red;
            this.edycjaPrzejdzDo.Name = "edycjaPrzejdzDo";
            this.edycjaPrzejdzDo.Size = new System.Drawing.Size(297, 22);
            this.edycjaPrzejdzDo.Text = "Przejdź do...   Ctrl+G";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(294, 6);
            // 
            // edycjaZaznaczWszystko
            // 
            this.edycjaZaznaczWszystko.BackColor = System.Drawing.SystemColors.Control;
            this.edycjaZaznaczWszystko.Name = "edycjaZaznaczWszystko";
            this.edycjaZaznaczWszystko.Size = new System.Drawing.Size(297, 22);
            this.edycjaZaznaczWszystko.Text = "Zaznacz wszystko   Ctrl+A";
            this.edycjaZaznaczWszystko.Click += new System.EventHandler(this.edycjaZaznaczWszystko_Click);
            // 
            // edycjaGodzinaData
            // 
            this.edycjaGodzinaData.BackColor = System.Drawing.Color.Red;
            this.edycjaGodzinaData.Name = "edycjaGodzinaData";
            this.edycjaGodzinaData.Size = new System.Drawing.Size(297, 22);
            this.edycjaGodzinaData.Text = "Godzina/data   F5";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatZawijanieWierszy,
            this.formatCzcionka});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // formatZawijanieWierszy
            // 
            this.formatZawijanieWierszy.BackColor = System.Drawing.Color.Red;
            this.formatZawijanieWierszy.Name = "formatZawijanieWierszy";
            this.formatZawijanieWierszy.Size = new System.Drawing.Size(165, 22);
            this.formatZawijanieWierszy.Text = "Zawijanie wierszy";
            // 
            // formatCzcionka
            // 
            this.formatCzcionka.BackColor = System.Drawing.Color.Red;
            this.formatCzcionka.Name = "formatCzcionka";
            this.formatCzcionka.Size = new System.Drawing.Size(165, 22);
            this.formatCzcionka.Text = "Czcionka...";
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widokPowiekszenie,
            this.widokPasekStanu});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // widokPowiekszenie
            // 
            this.widokPowiekszenie.BackColor = System.Drawing.Color.Red;
            this.widokPowiekszenie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widokPowiekszeniePowieksz,
            this.widokPowiekszeniePomniejsz,
            this.widokPowiekszeniePrzywroc});
            this.widokPowiekszenie.Name = "widokPowiekszenie";
            this.widokPowiekszenie.Size = new System.Drawing.Size(144, 22);
            this.widokPowiekszenie.Text = "Powiększenie";
            // 
            // widokPowiekszeniePowieksz
            // 
            this.widokPowiekszeniePowieksz.BackColor = System.Drawing.Color.Red;
            this.widokPowiekszeniePowieksz.Name = "widokPowiekszeniePowieksz";
            this.widokPowiekszeniePowieksz.Size = new System.Drawing.Size(292, 22);
            this.widokPowiekszeniePowieksz.Text = "Powiększ   Ctrl+Plus";
            // 
            // widokPowiekszeniePomniejsz
            // 
            this.widokPowiekszeniePomniejsz.BackColor = System.Drawing.Color.Red;
            this.widokPowiekszeniePomniejsz.Name = "widokPowiekszeniePomniejsz";
            this.widokPowiekszeniePomniejsz.Size = new System.Drawing.Size(292, 22);
            this.widokPowiekszeniePomniejsz.Text = "Pomniejsz   Ctrl+Minus";
            // 
            // widokPowiekszeniePrzywroc
            // 
            this.widokPowiekszeniePrzywroc.BackColor = System.Drawing.Color.Red;
            this.widokPowiekszeniePrzywroc.Name = "widokPowiekszeniePrzywroc";
            this.widokPowiekszeniePrzywroc.Size = new System.Drawing.Size(292, 22);
            this.widokPowiekszeniePrzywroc.Text = "Przywróć powiększenie domyślne   Ctrl+0";
            // 
            // widokPasekStanu
            // 
            this.widokPasekStanu.BackColor = System.Drawing.Color.Red;
            this.widokPasekStanu.Name = "widokPasekStanu";
            this.widokPasekStanu.Size = new System.Drawing.Size(144, 22);
            this.widokPasekStanu.Text = "Pasek stanu";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opmocWyswietlPomoc,
            this.pomocWyslijOpinie,
            this.toolStripMenuItem6,
            this.pomocInformacje});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // opmocWyswietlPomoc
            // 
            this.opmocWyswietlPomoc.BackColor = System.Drawing.Color.Red;
            this.opmocWyswietlPomoc.Name = "opmocWyswietlPomoc";
            this.opmocWyswietlPomoc.Size = new System.Drawing.Size(262, 22);
            this.opmocWyswietlPomoc.Text = "Wyświetl Pomoc";
            // 
            // pomocWyslijOpinie
            // 
            this.pomocWyslijOpinie.BackColor = System.Drawing.Color.Red;
            this.pomocWyslijOpinie.Name = "pomocWyslijOpinie";
            this.pomocWyslijOpinie.Size = new System.Drawing.Size(262, 22);
            this.pomocWyslijOpinie.Text = "Wyślij opinię";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(259, 6);
            // 
            // pomocInformacje
            // 
            this.pomocInformacje.BackColor = System.Drawing.Color.Red;
            this.pomocInformacje.Name = "pomocInformacje";
            this.pomocInformacje.Size = new System.Drawing.Size(262, 22);
            this.pomocInformacje.Text = "Blade Studios Notatnik - informacje";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openedFile
            // 
            this.openedFile.Location = new System.Drawing.Point(0, 25);
            this.openedFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.openedFile.Name = "openedFile";
            this.openedFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.openedFile.Size = new System.Drawing.Size(785, 585);
            this.openedFile.TabIndex = 1;
            this.openedFile.Text = "";
            this.openedFile.TextChanged += new System.EventHandler(this.openedFile_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.openedFile);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blade Studios Notatnik";
            this.Resize += new System.EventHandler(this.formResize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikNowy;
        private System.Windows.Forms.ToolStripMenuItem plikNoweOkno;
        private System.Windows.Forms.ToolStripMenuItem plikOtworz;
        private System.Windows.Forms.ToolStripMenuItem plikZapisz;
        private System.Windows.Forms.ToolStripMenuItem plikZapiszJako;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plikUstawieniaStrony;
        private System.Windows.Forms.ToolStripMenuItem plikDrukuj;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem plikZakoncz;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox openedFile;
        private System.Windows.Forms.ToolStripMenuItem edycjaCofnij;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem edycjaWytnij;
        private System.Windows.Forms.ToolStripMenuItem edycjaKopiuj;
        private System.Windows.Forms.ToolStripMenuItem edycjaWklej;
        private System.Windows.Forms.ToolStripMenuItem edycjaUsun;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem edycjaWyszukaj;
        private System.Windows.Forms.ToolStripMenuItem edycjaZnajdz;
        private System.Windows.Forms.ToolStripMenuItem edycjaZnajdzNastepny;
        private System.Windows.Forms.ToolStripMenuItem edycjaZnajdzPoprzednie;
        private System.Windows.Forms.ToolStripMenuItem edycjaZamien;
        private System.Windows.Forms.ToolStripMenuItem edycjaPrzejdzDo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem edycjaZaznaczWszystko;
        private System.Windows.Forms.ToolStripMenuItem edycjaGodzinaData;
        private System.Windows.Forms.ToolStripMenuItem formatZawijanieWierszy;
        private System.Windows.Forms.ToolStripMenuItem formatCzcionka;
        private System.Windows.Forms.ToolStripMenuItem widokPowiekszenie;
        private System.Windows.Forms.ToolStripMenuItem widokPowiekszeniePowieksz;
        private System.Windows.Forms.ToolStripMenuItem widokPowiekszeniePomniejsz;
        private System.Windows.Forms.ToolStripMenuItem widokPowiekszeniePrzywroc;
        private System.Windows.Forms.ToolStripMenuItem widokPasekStanu;
        private System.Windows.Forms.ToolStripMenuItem opmocWyswietlPomoc;
        private System.Windows.Forms.ToolStripMenuItem pomocWyslijOpinie;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem pomocInformacje;
    }
}


GEREKSİNİMLER

Visual Studio kurulu olmalı.
SQLite veri Veritabanı kurulu olmalı

Proje dosyasını klonlayım.
  git clone https://github.com/CelilA1/Gorsel-Programlama.git

NuGet paket yükleyici ile
  1-Microsoft.EntityFrameworkCore
  2-Microsoft.EntityFrameworkCore.Sqlite
  3-Microsoft.EntityFrameworkCore.Tools
paketlerini yükleyin.

Oluşturulan migrate dosyasını Update-Database komutu ile yükleyin.

Veri tabanı dosyalarda mevcut projeye gömülü halde gönderildi.Ancak farklı bir konumdaysa 
  optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\Burc.db");
satırını düzenleyerek kendi veri tabanı dosya yolunuzu ayarlayın.

PROJE AMACI
Bu proje kullanıcıdan verileri alarak bunlarla bazı işlemleri yapabilen.
Bu verilerin veri tabanında tutularak istenildiğinde tekrar erişimine olanak sağlayan.
Yeni bir veri girileceğinde temizle butonu ile kullanıcıya basitlik sağlayan mini uygulama.

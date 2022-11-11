using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace catalog.WebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Assembly", Description="Assembly Videoları"},
                new Category(){Name="Lisp", Description="Lisp Videoları"},
                new Category(){Name="Fortran", Description="Fortran Videoları"},
                new Category(){Name="Haskell", Description="Haskell Videoları"},
                new Category(){Name="Java", Description="Java Videoları"},
            };

            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);

            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){ Name = "Assembly Başlangıç", Description = "Assembly diline giriş yapar.Dilde orta seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 1,IsHome=true},
                new Product(){ Name = "Assembly Orta", Description = "Assembly dilinde orta seviyedeki konuları içerir.Dilde ileri seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 1},
                new Product(){ Name = "Assembly İleri", Description = "Assembly dilinde ileri seviyedeki konuları içerir.Dilde üst düzey seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true , CategoryId = 1,IsHome=true},
                new Product(){ Name = "Assembly Üst Düzey", Description = "Üst düzey konular ve örnekler içerir.Projelerle edinilen bilgileri destekler." , Price = 200 , Stock = 200 , IsAprovved = true , CategoryId = 1},
                new Product(){ Name = "Lisp Başlangıç", Description = "Lisp diline giriş yapar.Dilde orta seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true , CategoryId = 2},
                new Product(){ Name = "Lisp Orta", Description = "Lisp dilinde orta seviyedeki konuları içerir.Dilde ileri seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true , CategoryId = 2,IsHome=true},
                new Product(){ Name = "Lisp İleri", Description = "Lisp dilinde ileri seviyedeki konuları içerir.Dilde üst düzey seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true, CategoryId = 2},
                new Product(){ Name = "Lisp Üst Düzey", Description = "Üst düzey konular ve örnekler içerir.Projelerle edinilen bilgileri destekler." , Price = 200 , Stock = 200 , IsAprovved = true, CategoryId = 2},
                new Product(){ Name = "Fortran Başlangıç", Description = "Fortran diline giriş yapar.Dilde orta seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 3},
                new Product(){ Name = "Fortran Orta", Description = "Fortran dilinde orta seviyedeki konuları içerir.Dilde ileri seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 3},
                new Product(){ Name = "Fortran İleri", Description = "Fortran dilinde ileri seviyedeki konuları içerir.Dilde üst düzey seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 3},
                new Product(){ Name = "Fortan Üst Düzey", Description = "Üst düzey konular ve örnekler içerir.Projelerle edinilen bilgileri destekler." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 3},
                new Product(){ Name = "Haskell Başlangıç", Description = "Haskell diline giriş yapar.Dilde orta seviyeye gelinmesine yardımcı olur.", Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 4},
                new Product(){ Name = "Haskell Orta", Description = "Haskell dilinde orta seviyedeki konuları içerir.Dilde ileri seviyeye gelinmesine yardımcı olur.", Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 4,IsHome=true},
                new Product(){ Name = "Haskell İleri", Description = "Haskell dilinde ileri seviyedeki konuları içerir.Dilde üst düzey seviyeye gelinmesine yardımcı olur.", Price = 200 , Stock = 200 , IsAprovved = true,CategoryId = 4},
                new Product(){ Name = "Haskell Üst Düzey", Description = "Üst düzey konular ve örnekler içerir.Projelerle edinilen bilgileri destekler." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 4},
                new Product(){ Name = "Java Başlangıç", Description = "Java diline giriş yapar.Dilde orta seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 5},
                new Product(){ Name = "Java Orta", Description = "Java dilinde orta seviyedeki konuları içerir.Dilde ileri seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 5},
                new Product(){ Name = "Java İleri", Description = "Java dilinde ileri seviyedeki konuları içerir.Dilde üst düzey seviyeye gelinmesine yardımcı olur." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 5},
                new Product(){ Name = "Java Üst Düzey", Description = "Üst düzey konular ve örnekler içerir.Projelerle edinilen bilgileri destekler." , Price = 200 , Stock = 200 , IsAprovved = true ,CategoryId = 5},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
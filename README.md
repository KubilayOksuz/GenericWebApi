1) Entity Framework kütüphanesi ve Generic Repository design pattern async yapı ile kullanıldı. Proje henüz temel aşamasında ve geliştirilmeye açık olabilmesi açısından başlangıcı Generic bir yapı ile oluşturmak gerekiyordu o yüzden Generic Repository ve BaseApiController şeklinde oluşturdum. Async yapı ile performanslı bir ORM olduğundan dolayı Entity Framework kullandım.


2) Aktif olarak .NET Framework yazıyorum (ASP.NET MVC, Winform, 3 ay gibi kısa bir süre de Xamarin yazmıştım). ADO.NET çok katmanlı mimari kullanıyorum. SQL olarak MsSQL kullanıyorum. Entity Framework ile Müşteri Yönetimi adına bir proje yazılıyordu ve arkadaşlar Web alanında çok bilgi sahibi olmadıkları için ben yardımcı olmuştum. O süreçte Entity Framework kullandım fakat proje repository kullanılmadan yazılmıştı. 2 sene kadar bir süre geçti güncel olarak kullanmadığım için çok hatırlamıyorum bunun dışında bir tecrübem olmadı ama zorluk yaşayacağımı düşünmüyorum. .NET Core ile ilgili bir deneyimim yok.


3) Eğer vaktim olsaydı, projeye Unit Of Work pattern aracılığı ile transaction yapısı eklemek. Unit Of Work eklerken IDispose, GarbageCollector kullanıp, kullanılan belleği minimuma indirgemek. Yapılan işlemleri ve alınan hataları ayrı şekilde loglamayı eklerdim.


4) Versiyon yönetimi olarak yaklaşık 3 senedir Team Foundation Server(TFS) kullanıyorum ve proje yönetimi olarak 5 ay Jira kullandım.

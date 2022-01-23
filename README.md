# Proje Hakkında


* Kullanılan Yapılar
  *  Fluent Validation
  *  AutoMapper
  *  Mediatr 
  *  CQRS (Command and Query)
  *  Dependency Injection
  *  Entity Framework Core (Code First)
  *  Docker Compose ,Docker
  *  Rabbit Mq
  *  Clean Architecture
  *  Domain Driven Dizayn
  *  Generic Repository
  *  Web api Core
  *  Application  Exception
  * Serilog-->yarıda kaldı
  

* Proje Çalıştırılması
  *  Container ayağa kaldırılması ve ve silinmesi komutları
     *   docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
     *   docker-compose -f docker-compose.yml -f docker-compose.override.yml down
     *   ![image](https://user-images.githubusercontent.com/80510214/150670172-610f0233-7da3-4cac-9cf4-4eedf2398a11.png)
 
  *  Proje ayağa kalktığı zaman otomatik olarak 5 ürün ekledim .Id:1,2,3,4,5 
  *  Order oluşturulduğu zaman ilgili producttan eğer stok varsa düşürülmektedir
  *  Order Create,Update ve delete işlemlerini yaptım
  *  Order oluştuğu zaman Orderı Publsher yardımıyla  kuyruğe ekledim.
  
 


  
 

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
     *   GetPreconfiguredOrders() metodunda proje  ayağa kalktığı zaman 5 tane ürün ekledim Id:1,2,3,4,5 
     *   Order Create edilirken ProductId:1,2,3,4 veya 5 olmalıdır.Quantity alanı zorunludur. Geri kalan alanlar zorunlu değildir
     *   Order oluşturulduğu zaman ilgili producttan eğer stok varsa düşürülmektedir
     *   Order oluştuğu zaman Orderı Publsher yardımıyla  kuyruğe ekledim.
     *   Order Create,Update ve delete işlemlerini yaptım
     *  ![image](https://user-images.githubusercontent.com/80510214/150674043-a091a6c7-1af8-4dd5-a5d0-b1c58814b15a.png)
     *  ![image](https://user-images.githubusercontent.com/80510214/150674184-2b10706d-6b14-44bf-802e-2bf4c8f0dc54.png)
     *  ![image](https://user-images.githubusercontent.com/80510214/150674208-4f39498e-b35c-4f9c-bb60-6784c89b22c3.png)
     *  ![image](https://user-images.githubusercontent.com/80510214/150674317-4e6620f9-6d7b-4ceb-abc9-6a714360eedc.png)
 
 

  
 


  
 

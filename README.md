# Project
## Liskov Substitution Principle
Bu prinsipda asosan loyihani superclass o'rniga subclass orqali kengaytirish nazarda tutilgan.
Keling bu prinsipni tushunish uchun 2 loyiha misol keltiramiz.
### 1-loyiha
![image](https://github.com/AlijonovAzamjon2303/Liskov/assets/112892881/58dc704f-ab7f-4b45-a3d1-25b1204e132f)
Bu loyihamizni kengaytirish uchun ReadOnly document qo'shmoqchi edik, Save() methodida exception kelib chiqdi. 
Shu sabali loyihamizni kengaytirishda muammoga duch keldik. Open/Closed principiga ham qarshi bo'lib qoldi, chunki 
kamida superclass'imizga qaytib methodni virtual deb e'lon qilishimiz yoki boshqa yechim topishimiz kerak bo'ladi.
### 2-loyiha
![image](https://github.com/AlijonovAzamjon2303/Liskov/assets/112892881/5290b7d8-eb86-4bce-9cf3-61a998e835e6)   
  Biz yechimni topdik. Save() methodini barcha subclasslar implementatsiya qila olmagani sababli biz uni avval boshdan 
superclassga qo'shmaymiz. Bu bilan Open/Closed pricipini ham ta'minlagan bo'lamiz. Writable documentimizga Save() 
methodini qo'shib qo'yishimiz mumkin. 
  Superclass o'rniga subclass qabul qilinishiga kelsak, bu xususiyatni allaqachon C# qo'llab quvvatlaydi.

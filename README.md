# FinalProjectNatnicha
## ความเป็นมา
ความเป็นมา : ต้องการทำระบบยืม-คืนหนังสือให้ใช้งานง่ายขึ้น

## วัตถุประสงค์
วัตถุประสงค์ : เพื่อนำไปใช้กรอกข้อมูลการยืน-คืน ให้เจ้าหน้าที่ในห้องสมุดได้นำไปใช้งาน

## classDiagram
```mermaid
classDiagram
Form1 --|> Information
<<Interface>> Form1
Information --|> Form1
Information <-- Student
note for Information "Borrow Book"
class Student{
        +String Name
        +String ID
        +String Major
        +String Year
Form1 : DataGridView1()
Form1 : Borrow Book()
Form1 : Return Book()
form1 : save()
Form1 : load()
```

## ผู้พัฒนาโปรแกรม
ชื่อ-สกุล : ณัฐณิชา พรมปิก
รหัสนักศึกษา : 653450284-3
อีเมล์ : natnicha.pro@kkumail.com

# FinalProjectNatnicha
## ความเป็นมา
ความเป็นมา : ต้องการทำระบบยืม-คืนหนังสือให้ใช้งานง่ายขึ้น

## วัตถุประสงค์
วัตถุประสงค์ : เพื่อนำไปใช้กรอกข้อมูลการยืน-คืน ให้เจ้าหน้าที่ในห้องสมุดได้นำไปใช้งาน

## classDiagram
```mermaid
classDiagram
    Form1 <|-- Information
    Form1 : DataGridView1()
    Form1 : Borrow Book()
    Form1 : Return Book()
    Form1 : save()
    Form1 : load()
    Information <|-- Student
    Information <|-- Book
    Information <|-- BorrowList
    Information : DataGridView1()
    Information : Borrow Book()
    Information: Return Book()
    Information: save()
    Information: load()
    BorrowReturn --|> Form1
    BorrowReturn <|-- BorrowList
    class Student{
        +String Name
        +String ID
        +String Major
        +String Year
    }
    class Book{
        +String BookName
        +String BookID
        +String Bookshelf
        +String Borrow
        +String Return
    }
    class BorrowList{
        +string studentname
        +string studentid
        +string major
        +string year
        +string bookname
        +string bookid
        +string bookshelf
        +string borrowdate
        +string returndate
    }
```

## ผู้พัฒนาโปรแกรม
ชื่อ-สกุล : ณัฐณิชา พรมปิก
รหัสนักศึกษา : 653450284-3
อีเมล์ : natnicha.pro@kkumail.com

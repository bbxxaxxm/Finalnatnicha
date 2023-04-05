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
note for Information "Borrow Book"
classStudent --|> Information
classStudent : str Name
classStudent : str ID
classStudent : str Major
classStudent : str Year
classStudent --|> Form1
classBook --|> Information
classBook : str BookName
classBook : str BookID
classBook : str BookShel
classBook : str Borrow
classBook : str Return
classBook --|> Form1
classBorrowList --|> Information
classBorrowList : str studentname
classBorrowList : str studentid
classBorrowList : str major
classBorrowList : str year
classBorrowList : str bookname
classBorrowList : str bookid
classBorrowList : str bookshelf
classBorrowList : str borrowdate
classBorrowList : str returndate
classBorrowList --|> Form1
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
